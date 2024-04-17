using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketMatic_V2
{
    public partial class Register : Form
    {
        public static string userName;
        private static string connectionString = "Data Source=..\\..\\Data\\TicketMaticDb.db;Version=3;";

        public Register()
        {
            InitializeComponent();
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            tb_userName.Text = "";
            tb_password.Text = "";
            tb_confirmPassword.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            new Login().Show();
            this.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            userName = tb_userName.Text;
            string password = tb_password.Text;
            string confirmPassword = tb_confirmPassword.Text;

            if (!string.IsNullOrWhiteSpace(userName) && !string.IsNullOrWhiteSpace(password) && !string.IsNullOrWhiteSpace(confirmPassword))
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Users WHERE userName = @UserName;";
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@UserName", userName);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("This username already taken!.");
                                return;
                            }
                        }
                    }
                    if (password == confirmPassword)
                    {
                        query = "INSERT INTO Users (userName, password) VALUES (@UserName, @Password);";
                        using (var command = new SQLiteCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@UserName", userName);
                            command.Parameters.AddWithValue("@Password", password);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("successfully registered");
                                new TicketMatic().Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("error!");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler eşleşmiyor. Lütfen doğru bir şekilde onaylayın.");
                    }
                }
            }
            else
            {
                MessageBox.Show("username and password/confirm password field cannot be blank!");
            }
        }
    }
}
