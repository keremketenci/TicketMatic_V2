namespace TicketMatic_V2.UserControls
{
    partial class UC_Theater
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Theater));
            this.lb_sessionDate = new System.Windows.Forms.Label();
            this.lb_sessionMovie = new System.Windows.Forms.Label();
            this.lb_sessionId = new System.Windows.Forms.Label();
            this.lb_selectedSeats = new System.Windows.Forms.Label();
            this.pb_confirm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_confirm)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_sessionDate
            // 
            this.lb_sessionDate.AutoSize = true;
            this.lb_sessionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sessionDate.Location = new System.Drawing.Point(3, 25);
            this.lb_sessionDate.Name = "lb_sessionDate";
            this.lb_sessionDate.Size = new System.Drawing.Size(131, 25);
            this.lb_sessionDate.TabIndex = 0;
            this.lb_sessionDate.Text = "sessionDate";
            // 
            // lb_sessionMovie
            // 
            this.lb_sessionMovie.AutoSize = true;
            this.lb_sessionMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sessionMovie.Location = new System.Drawing.Point(3, 50);
            this.lb_sessionMovie.Name = "lb_sessionMovie";
            this.lb_sessionMovie.Size = new System.Drawing.Size(144, 25);
            this.lb_sessionMovie.TabIndex = 2;
            this.lb_sessionMovie.Text = "sessionMovie";
            // 
            // lb_sessionId
            // 
            this.lb_sessionId.AutoSize = true;
            this.lb_sessionId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_sessionId.Location = new System.Drawing.Point(3, 0);
            this.lb_sessionId.Name = "lb_sessionId";
            this.lb_sessionId.Size = new System.Drawing.Size(103, 25);
            this.lb_sessionId.TabIndex = 3;
            this.lb_sessionId.Text = "sessionId";
            // 
            // lb_selectedSeats
            // 
            this.lb_selectedSeats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedSeats.Location = new System.Drawing.Point(0, 392);
            this.lb_selectedSeats.Name = "lb_selectedSeats";
            this.lb_selectedSeats.Size = new System.Drawing.Size(710, 71);
            this.lb_selectedSeats.TabIndex = 4;
            this.lb_selectedSeats.Text = "Selected Seat(s):";
            // 
            // pb_confirm
            // 
            this.pb_confirm.BackColor = System.Drawing.Color.Transparent;
            this.pb_confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_confirm.Image = ((System.Drawing.Image)(resources.GetObject("pb_confirm.Image")));
            this.pb_confirm.Location = new System.Drawing.Point(716, 392);
            this.pb_confirm.Name = "pb_confirm";
            this.pb_confirm.Size = new System.Drawing.Size(68, 71);
            this.pb_confirm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_confirm.TabIndex = 6;
            this.pb_confirm.TabStop = false;
            this.pb_confirm.Click += new System.EventHandler(this.pb_confirm_Click);
            // 
            // UC_Theater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_confirm);
            this.Controls.Add(this.lb_selectedSeats);
            this.Controls.Add(this.lb_sessionId);
            this.Controls.Add(this.lb_sessionMovie);
            this.Controls.Add(this.lb_sessionDate);
            this.Name = "UC_Theater";
            this.Size = new System.Drawing.Size(784, 463);
            ((System.ComponentModel.ISupportInitialize)(this.pb_confirm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_sessionDate;
        private System.Windows.Forms.Label lb_sessionMovie;
        private System.Windows.Forms.Label lb_sessionId;
        private System.Windows.Forms.Label lb_selectedSeats;
        private System.Windows.Forms.PictureBox pb_confirm;
    }
}
