namespace TicketMatic_V2.UserControls
{
    partial class UC_Session
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
            this.lb_selectedMovie = new System.Windows.Forms.Label();
            this.dgv_session = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theaterId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.select = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_session)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_selectedMovie
            // 
            this.lb_selectedMovie.AutoSize = true;
            this.lb_selectedMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_selectedMovie.Location = new System.Drawing.Point(312, 18);
            this.lb_selectedMovie.Name = "lb_selectedMovie";
            this.lb_selectedMovie.Size = new System.Drawing.Size(160, 25);
            this.lb_selectedMovie.TabIndex = 1;
            this.lb_selectedMovie.Text = "Selected Movie";
            // 
            // dgv_session
            // 
            this.dgv_session.AllowUserToAddRows = false;
            this.dgv_session.AllowUserToDeleteRows = false;
            this.dgv_session.AllowUserToResizeColumns = false;
            this.dgv_session.AllowUserToResizeRows = false;
            this.dgv_session.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_session.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_session.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.time,
            this.subtitle,
            this.theaterId,
            this.select});
            this.dgv_session.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_session.Location = new System.Drawing.Point(0, 63);
            this.dgv_session.MultiSelect = false;
            this.dgv_session.Name = "dgv_session";
            this.dgv_session.ReadOnly = true;
            this.dgv_session.RowHeadersWidth = 50;
            this.dgv_session.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_session.Size = new System.Drawing.Size(784, 400);
            this.dgv_session.TabIndex = 2;
            this.dgv_session.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_session_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // date
            // 
            this.date.HeaderText = "date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            this.date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // time
            // 
            this.time.HeaderText = "time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // subtitle
            // 
            this.subtitle.HeaderText = "subtitle";
            this.subtitle.Name = "subtitle";
            this.subtitle.ReadOnly = true;
            this.subtitle.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.subtitle.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // theaterId
            // 
            this.theaterId.HeaderText = "theater";
            this.theaterId.Name = "theaterId";
            this.theaterId.ReadOnly = true;
            this.theaterId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.theaterId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // select
            // 
            this.select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.select.HeaderText = "select";
            this.select.Name = "select";
            this.select.ReadOnly = true;
            this.select.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // UC_Session
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_session);
            this.Controls.Add(this.lb_selectedMovie);
            this.Name = "UC_Session";
            this.Size = new System.Drawing.Size(784, 463);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_session)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_selectedMovie;
        private System.Windows.Forms.DataGridView dgv_session;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn theaterId;
        private System.Windows.Forms.DataGridViewButtonColumn select;
    }
}
