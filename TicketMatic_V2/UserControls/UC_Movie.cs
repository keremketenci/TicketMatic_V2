using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMatic_V2.Data;
using TicketMatic_V2.Services;
using static System.Net.Mime.MediaTypeNames;

namespace TicketMatic_V2.UserControls
{
    public partial class UC_Movie : UserControl
    {
        DbService _dbService = new DbService();
        private static UC_Movie _instance;
        public static UC_Movie Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new UC_Movie();
                }
                return _instance;
            }
        }
        public UC_Movie()
        {
            InitializeComponent();
            GetFilms();
        }

        private void GetFilms()
        {
            var movies = _dbService.GetMovieNames();

            const int pictureboxWidth = 300;
            const int pictureboxHeight = 300;
            int padding_x = 61;
            int padding_y = 10;

            foreach (var movieName in movies)
            {
                var picturebox = new PictureBox();
                //picturebox.Text = movieName;
                string resourceName = "..\\..\\img\\" + movieName + ".jpg";
                picturebox.ImageLocation = resourceName;
                picturebox.Width = pictureboxWidth;
                picturebox.Height = pictureboxHeight;
                picturebox.SizeMode = PictureBoxSizeMode.Zoom;
                picturebox.BorderStyle = BorderStyle.FixedSingle;
                picturebox.Cursor = Cursors.Hand;
                picturebox.Location = new Point(padding_x, padding_y);
                picturebox.Click += (sender, e) =>
                {
                    MessageBox.Show($"You clicked on {movieName}");
                    UC_Session.Instance.ListSessions(movieName);
                    //UC_Theater.Instance.GetTheater(0);
                    //UC_Session.Instance.ListSessions(null);
                    ((TicketMatic)this.ParentForm).tab_Session_Click(null, null);
                };

                Controls.Add(picturebox);

                padding_x += pictureboxWidth + padding_x;
                if (padding_x + pictureboxWidth > Width)
                {
                    padding_y += pictureboxHeight + padding_y;
                }
            }
        }
    }
}