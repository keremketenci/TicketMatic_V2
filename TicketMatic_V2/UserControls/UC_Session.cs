using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketMatic_V2.Models;
using TicketMatic_V2.Services;
using static System.Collections.Specialized.BitVector32;

namespace TicketMatic_V2.UserControls
{
    public partial class UC_Session : UserControl
    {
        DbService _dbService = new DbService();
        private static UC_Session _instance;
        public static UC_Session Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UC_Session();
                }
                return _instance;
            }
        }
        public UC_Session()
        {
            InitializeComponent();
        }

        public void ListSessions(string movieName)
        {
            if (movieName == null)
            {
                lb_selectedMovie.Text = "Selected Movie";
                dgv_session.Rows.Clear();
                return;
            }

            lb_selectedMovie.Text = movieName;
            var sessions = _dbService.GetSessionsBasedOnMovie(movieName);
            dgv_session.Rows.Clear();
            foreach (var session in sessions)
            {
                dgv_session.Rows.Add(session.id, session.date, session.time, session.subtitle, session.theaterId);
            }
        }

        private void dgv_session_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idColumnIndex = 0;
            int ClickedRowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgv_session.Rows[ClickedRowIndex];

            if (selectedRow.Cells[idColumnIndex].Value != null)
            {
                int selected_session = Convert.ToInt32(selectedRow.Cells[idColumnIndex].Value);
                UC_Theater.Instance.GetTheater(selected_session);
                UC_Reservation.Instance.GetSessionId(selected_session);
                ((TicketMatic)this.ParentForm).tab_Theater_Click(null, null);
            }
        }
    }
}
