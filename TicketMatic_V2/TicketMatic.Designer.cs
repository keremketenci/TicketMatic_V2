namespace TicketMatic_V2
{
    partial class TicketMatic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TicketMatic));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.lb_userName = new System.Windows.Forms.Label();
            this.lb_TicketMatic = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_navbar = new System.Windows.Forms.Panel();
            this.tab_reservation = new System.Windows.Forms.Button();
            this.tab_theater = new System.Windows.Forms.Button();
            this.tab_session = new System.Windows.Forms.Button();
            this.tab_movie = new System.Windows.Forms.Button();
            this.tab_home = new System.Windows.Forms.Button();
            this.pnl_container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_navbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.lb_userName);
            this.panel1.Controls.Add(this.lb_TicketMatic);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 50);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.Location = new System.Drawing.Point(733, 0);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(51, 50);
            this.btn_logout.TabIndex = 0;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // lb_userName
            // 
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lb_userName.Location = new System.Drawing.Point(259, 9);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(468, 29);
            this.lb_userName.TabIndex = 2;
            this.lb_userName.Text = "User Name";
            this.lb_userName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_TicketMatic
            // 
            this.lb_TicketMatic.AutoSize = true;
            this.lb_TicketMatic.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold);
            this.lb_TicketMatic.Location = new System.Drawing.Point(54, 9);
            this.lb_TicketMatic.Name = "lb_TicketMatic";
            this.lb_TicketMatic.Size = new System.Drawing.Size(199, 29);
            this.lb_TicketMatic.TabIndex = 1;
            this.lb_TicketMatic.Text = "TicketMatic-V2";
            this.lb_TicketMatic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_navbar
            // 
            this.pnl_navbar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pnl_navbar.Controls.Add(this.tab_reservation);
            this.pnl_navbar.Controls.Add(this.tab_theater);
            this.pnl_navbar.Controls.Add(this.tab_session);
            this.pnl_navbar.Controls.Add(this.tab_movie);
            this.pnl_navbar.Controls.Add(this.tab_home);
            this.pnl_navbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_navbar.Location = new System.Drawing.Point(0, 50);
            this.pnl_navbar.Name = "pnl_navbar";
            this.pnl_navbar.Size = new System.Drawing.Size(784, 50);
            this.pnl_navbar.TabIndex = 2;
            // 
            // tab_reservation
            // 
            this.tab_reservation.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_reservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_reservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_reservation.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_reservation.Location = new System.Drawing.Point(632, 0);
            this.tab_reservation.Name = "tab_reservation";
            this.tab_reservation.Size = new System.Drawing.Size(152, 50);
            this.tab_reservation.TabIndex = 99;
            this.tab_reservation.Text = "Reservation";
            this.tab_reservation.UseVisualStyleBackColor = false;
            this.tab_reservation.Click += new System.EventHandler(this.tab_Reservation_Click);
            // 
            // tab_theater
            // 
            this.tab_theater.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_theater.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_theater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_theater.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_theater.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_theater.Location = new System.Drawing.Point(474, 0);
            this.tab_theater.Name = "tab_theater";
            this.tab_theater.Size = new System.Drawing.Size(152, 50);
            this.tab_theater.TabIndex = 98;
            this.tab_theater.Text = "Theater";
            this.tab_theater.UseVisualStyleBackColor = false;
            this.tab_theater.Click += new System.EventHandler(this.tab_Theater_Click);
            // 
            // tab_session
            // 
            this.tab_session.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_session.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_session.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_session.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_session.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_session.Location = new System.Drawing.Point(316, 0);
            this.tab_session.Name = "tab_session";
            this.tab_session.Size = new System.Drawing.Size(152, 50);
            this.tab_session.TabIndex = 97;
            this.tab_session.Text = "Session";
            this.tab_session.UseVisualStyleBackColor = false;
            this.tab_session.Click += new System.EventHandler(this.tab_Session_Click);
            // 
            // tab_movie
            // 
            this.tab_movie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_movie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_movie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_movie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_movie.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tab_movie.Location = new System.Drawing.Point(158, 0);
            this.tab_movie.Name = "tab_movie";
            this.tab_movie.Size = new System.Drawing.Size(152, 50);
            this.tab_movie.TabIndex = 96;
            this.tab_movie.Text = "Movie";
            this.tab_movie.UseVisualStyleBackColor = false;
            this.tab_movie.Click += new System.EventHandler(this.tab_Movie_Click);
            // 
            // tab_home
            // 
            this.tab_home.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tab_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tab_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tab_home.Location = new System.Drawing.Point(0, 0);
            this.tab_home.Name = "tab_home";
            this.tab_home.Size = new System.Drawing.Size(152, 50);
            this.tab_home.TabIndex = 95;
            this.tab_home.Text = "Home";
            this.tab_home.UseVisualStyleBackColor = false;
            this.tab_home.Click += new System.EventHandler(this.tab_Home_Click);
            // 
            // pnl_container
            // 
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_container.Location = new System.Drawing.Point(0, 100);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.Size = new System.Drawing.Size(784, 463);
            this.pnl_container.TabIndex = 3;
            // 
            // TicketMatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnl_container);
            this.Controls.Add(this.pnl_navbar);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "TicketMatic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Reservation_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_navbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_TicketMatic;
        private System.Windows.Forms.Panel pnl_navbar;
        private System.Windows.Forms.Button tab_home;
        private System.Windows.Forms.Button tab_movie;
        private System.Windows.Forms.Panel pnl_container;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.Button tab_session;
        private System.Windows.Forms.Button tab_theater;
        private System.Windows.Forms.Button tab_reservation;
    }
}

