namespace Quan_Ly_Ban_Hang
{
    partial class fXemDanhMuc
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
            this.dtgvDM = new System.Windows.Forms.DataGridView();
            this.btn_Xemdanhmuc_Back = new System.Windows.Forms.Button();
            this.lbDanhMuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDM)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvDM
            // 
            this.dtgvDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDM.Location = new System.Drawing.Point(3, 40);
            this.dtgvDM.Name = "dtgvDM";
            this.dtgvDM.Size = new System.Drawing.Size(413, 169);
            this.dtgvDM.TabIndex = 1;
            // 
            // btn_Xemdanhmuc_Back
            // 
            this.btn_Xemdanhmuc_Back.Location = new System.Drawing.Point(180, 216);
            this.btn_Xemdanhmuc_Back.Name = "btn_Xemdanhmuc_Back";
            this.btn_Xemdanhmuc_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Xemdanhmuc_Back.TabIndex = 2;
            this.btn_Xemdanhmuc_Back.Text = "Trở Về";
            this.btn_Xemdanhmuc_Back.UseVisualStyleBackColor = true;
            // 
            // lbDanhMuc
            // 
            this.lbDanhMuc.AutoSize = true;
            this.lbDanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhMuc.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbDanhMuc.Location = new System.Drawing.Point(119, 13);
            this.lbDanhMuc.Name = "lbDanhMuc";
            this.lbDanhMuc.Size = new System.Drawing.Size(66, 24);
            this.lbDanhMuc.TabIndex = 3;
            this.lbDanhMuc.Text = "label1";
            this.lbDanhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fXemDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.lbDanhMuc);
            this.Controls.Add(this.btn_Xemdanhmuc_Back);
            this.Controls.Add(this.dtgvDM);
            this.Name = "fXemDanhMuc";
            this.Text = "fXemDanhMuc";
            this.Load += new System.EventHandler(this.fXemDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgvDM;
        private System.Windows.Forms.Button btn_Xemdanhmuc_Back;
        private System.Windows.Forms.Label lbDanhMuc;
    }
}