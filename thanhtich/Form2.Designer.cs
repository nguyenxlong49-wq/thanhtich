namespace thanhtich
{
    partial class frmThanhTich
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvXepHang = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepHang)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvXepHang
            // 
            this.dgvXepHang.AllowUserToAddRows = false;
            this.dgvXepHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXepHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXepHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXepHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvXepHang.EnableHeadersVisualStyles = false;
            this.dgvXepHang.Location = new System.Drawing.Point(0, 0);
            this.dgvXepHang.Name = "dgvXepHang";
            this.dgvXepHang.ReadOnly = true;
            this.dgvXepHang.RowHeadersVisible = false;
            this.dgvXepHang.RowHeadersWidth = 51;
            this.dgvXepHang.RowTemplate.Height = 24;
            this.dgvXepHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXepHang.Size = new System.Drawing.Size(800, 450);
            this.dgvXepHang.TabIndex = 0;
            this.dgvXepHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXepHang_CellContentClick);
            // 
            // frmThanhTich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvXepHang);
            this.Name = "frmThanhTich";
            this.Text = "Bảng xếp hạng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvXepHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvXepHang;
    }
}