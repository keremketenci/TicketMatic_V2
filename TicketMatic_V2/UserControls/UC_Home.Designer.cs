namespace TicketMatic_V2.UserControls
{
    partial class UC_Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_buyTicket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 47.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(755, 231);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome \r\nTo \r\nTicketMatic_V2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_buyTicket
            // 
            this.btn_buyTicket.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_buyTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buyTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buyTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_buyTicket.Location = new System.Drawing.Point(28, 328);
            this.btn_buyTicket.Name = "btn_buyTicket";
            this.btn_buyTicket.Size = new System.Drawing.Size(742, 95);
            this.btn_buyTicket.TabIndex = 1;
            this.btn_buyTicket.Text = "buy ticket";
            this.btn_buyTicket.UseVisualStyleBackColor = false;
            this.btn_buyTicket.Click += new System.EventHandler(this.btn_buyTicket_Click);
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_buyTicket);
            this.Controls.Add(this.label1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(784, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_buyTicket;
    }
}
