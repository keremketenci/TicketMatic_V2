using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMatic_V2.Models;
using TicketMatic_V2.Services;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace TicketMatic_V2.UserControls
{
    public partial class UC_Reservation : UserControl
    {
        DbService _dbService = new DbService();

        private static string connectionString = "Data Source=..\\..\\Data\\TicketMaticDb.db;Version=3;";
        private List<string> selected_seats;
        private int user_id;
        private int session_id;

        public void GetSelectedSeats(List<string> selectedSeats)
        {
            selected_seats = selectedSeats;
        }
        public void GetUserId(int userId)
        {
            user_id = userId;
        }
        public void GetSessionId(int sessionId)
        {
            session_id = sessionId;
        }
        private static UC_Reservation _instance;
        public static UC_Reservation Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Reservation();
                }
                return _instance;
            }
        }
        
        public UC_Reservation()
        {
            InitializeComponent();
        }

        private void ClearReservationLabels()
        {
            lb_sessionId.Text = "Session Id: ";
            lb_sessionDate.Text = "Session Date: ";
            lb_sessionTime.Text = "Session Time: ";
            lb_sessionMovieName.Text = "Movie Name: ";
            lb_sessionMovieGenre.Text = "Movie Genre: ";
            lb_sessionMovieSubtitle.Text = "Subtitle: ";
            lb_sessionTheaterId.Text = "Theater No: ";
            lb_selectedSeatNo.Text = "Seat No(s): ";
            lb_totalPayment.Text = "Total Payment: 00 $";
        }


        public void ReservationDetails(int selectedSession, List<string> selectedSeats)
        {
            if (selectedSession == 0 && selectedSeats == null)
            {
                ClearReservationLabels();
                return;
            }
            ClearReservationLabels();
            var selectedSessionDetails = _dbService.GetSessionDetailsBasedOnsessionId(selectedSession);
            var selectedMovieDetails = _dbService.GetMovieDetailsBasedOnmovieId(selectedSessionDetails.movieId);

            lb_sessionId.Text += $"{selectedSessionDetails.id.ToString(CultureInfo.InvariantCulture)}";
            lb_sessionDate.Text += $"{selectedSessionDetails.date}";
            lb_sessionTime.Text += $"{selectedSessionDetails.time}";
            lb_sessionMovieName.Text += $"{selectedMovieDetails.movieName}";
            lb_sessionMovieGenre.Text += $"{selectedMovieDetails.movieGenre}";
            lb_sessionMovieSubtitle.Text += $"{selectedSessionDetails.subtitle.ToString()}";
            lb_sessionTheaterId.Text += $"{selectedSessionDetails.theaterId.ToString()}";

            selectedSeats.Sort();
            foreach (string selectedSeat in selectedSeats)
            {
                lb_selectedSeatNo.Text += $"{selectedSeat}, ";
            }
            lb_totalPayment.Text = "Total Payment: ";
            lb_totalPayment.Text += $"{(Convert.ToInt32(selectedSeats.Count()) * 10.00).ToString()}";
            lb_totalPayment.Text += " $";
        }

        private void btn_buy_Click(object sender, EventArgs e)
        {
            if (session_id == 0 && selected_seats == null)
            {
                MessageBox.Show("Before purchasing a ticket, please select a movie session.");
                return;
            }
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                Reservation reservation = _dbService.GetSeatsNoBasedOnsessionId(session_id);

                
                foreach (var seat in selected_seats)
                {
                    string insertReservationQuery = $@"
                    INSERT INTO Reservations (seatNo, sessionId, userId) VALUES ('{seat}', {session_id}, {user_id});";

                    using (var command = new SQLiteCommand(insertReservationQuery, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }

            MessageBox.Show("Thank you for your purchase! Enjoy the show!");
            GetSessionId(0);
            GetSelectedSeats(null);
            ReservationDetails(0, null);
            UC_Session.Instance.ListSessions(null);
            UC_Theater.Instance.GetTheater(0);
            ((TicketMatic)this.ParentForm).tab_Home_Click(null, null);
        }
    }
}
