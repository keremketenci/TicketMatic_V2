using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMatic_V2.Services;

namespace TicketMatic_V2.UserControls
{
    public partial class UC_Theater : UserControl
    {
        DbService _dbService = new DbService();

        private int selectedSessionId;
        public void SetSelectedSessionId(int id)
        {
            selectedSessionId = id;
        }
        List<string> selectedSeats = new List<string>();
        List<string> occupiedSeats = new List<string>();

        private static UC_Theater _instance;
        public static UC_Theater Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Theater();
                }
                return _instance;
            }
        }
        public UC_Theater()
        {
            InitializeComponent();
        }
        private void ClearTheaterSeats()
        {
            foreach (Control control in Controls.OfType<Button>().ToList())
            {
                Controls.Remove(control);
                control.Dispose();
            }
        }
        public void ClearSelectedSeatsLabel()
        {
            lb_selectedSeats.Text = "Selected Seat(s):";
        }
        public void CheckSelectedSeats(int sessionId, List<string> selectedSeats)
        {
            var PurchasedSeats = _dbService.ReturnSeatsNoBasedOnSessionId(sessionId);
            ClearTheaterSeats();
            CreateTheaterSeats(5, 10, PurchasedSeats);
            selectedSeats.Clear();
        }
        public void GetTheater(int selectedSession)
        {
            if (selectedSession == 0)
            {
                lb_sessionId.Text = "sessionId";
                lb_sessionDate.Text = "sessionDate";
                lb_sessionMovie.Text = "sessionMovie";
                lb_selectedSeats.Text = "Selected Seat(s):";

                ClearTheaterSeats();
                selectedSeats.Clear();
                return;
            }
            ClearTheaterSeats();
            selectedSeats.Clear();
            var selectedSessionDetails = _dbService.GetSessionDetailsBasedOnsessionId(selectedSession);
            var selectedMovieDetails = _dbService.GetMovieDetailsBasedOnmovieId(selectedSessionDetails.movieId);

            lb_sessionId.Text = $"Session Id: {selectedSessionDetails.id}";
            lb_sessionDate.Text = $"{selectedSessionDetails.date} - {selectedSessionDetails.time }";
            lb_sessionMovie.Text = $"{selectedMovieDetails.movieName} - {selectedMovieDetails.movieGenre}";

            occupiedSeats = _dbService.GetSeatNoBasedOnSessionId(selectedSession);
            CreateTheaterSeats(5, 10, occupiedSeats);
            Instance.SetSelectedSessionId(selectedSession);
        }
        private void CreateTheaterSeats(int rowCount, int columnCount, List<string> occupiedSeats)
        {
            const int seatGap = 5;
            const int seatWidth = 50;
            const int seatHeight = 50;

            char[] letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            int totalWidth = columnCount * (seatWidth + seatGap);
            int totalHeight = rowCount * (seatHeight + seatGap);
            int startX = (ClientSize.Width - totalWidth) / 2;
            int startY = (ClientSize.Height - totalHeight) / 2;
            for (int row = 0; row < rowCount; row++)
            {
                for (int col = 0; col < columnCount; col++)
                {
                    Button btnSeat = new Button();
                    btnSeat.Cursor = Cursors.Hand;
                    btnSeat.Name = $"btnSeat_{letters[row]}{col + 1}";
                    btnSeat.Text = $"{letters[row]}{col + 1}";
                    if (occupiedSeats.Contains(btnSeat.Text))
                    {
                        btnSeat.BackColor = Color.Red;
                        btnSeat.ForeColor = Color.Black;
                    }
                    if (selectedSeats.Contains(btnSeat.Text))
                    {
                        if (!occupiedSeats.Contains(btnSeat.Text))
                        {
                            btnSeat.BackColor = Color.Green;
                            btnSeat.ForeColor = Color.Black;
                        }
                    }

                    btnSeat.Width = seatWidth;
                    btnSeat.Height = seatHeight;
                    btnSeat.Left = startX + col * (seatWidth + seatGap);
                    btnSeat.Top = startY + row * (seatHeight + seatGap);

                    btnSeat.Click += BtnSeat_Click;
                    Controls.Add(btnSeat);
                }
            }
        }
        private void BtnSeat_Click(object sender, EventArgs e)
        {
            string seatName = ((Button)sender).Name;
            string seatNumber = seatName.Substring(seatName.IndexOf('_') + 1);

            if (selectedSeats.Contains(seatNumber))
            {
                selectedSeats.Remove(seatNumber);
            }
            else if (occupiedSeats.Contains(seatNumber))
            {
                MessageBox.Show("This seat already taken!");
                return;
            }
            else
            {
                selectedSeats.Add(seatNumber);
            }

            if (selectedSeats.Contains(seatNumber))
            {
                ((Button)sender).BackColor = Color.Green;
            }
            else
            {
                ((Button)sender).BackColor = Color.White;
            }

            selectedSeats.Sort();

            lb_selectedSeats.Text = "Selected Seats: ";

            foreach (string selectedSeat in selectedSeats)
            {
                lb_selectedSeats.Text += selectedSeat + ", ";
            }
        }
        private void pb_confirm_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Select a seat first!");
                return;
            }

            UC_Reservation.Instance.ReservationDetails(selectedSessionId, selectedSeats);
            UC_Reservation.Instance.GetSelectedSeats(selectedSeats);
            ((TicketMatic)this.ParentForm).tab_Reservation_Click(null, null);
        }
    }
}
