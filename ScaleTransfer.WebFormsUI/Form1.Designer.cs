
namespace ScaleTransfer.WebFormsUI
{
    partial class Form1
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
            this.btnGetDatabasePath = new System.Windows.Forms.Button();
            this.cbxMaasAciklama = new System.Windows.Forms.ComboBox();
            this.btnExcelPath = new System.Windows.Forms.Button();
            this.tbxExcelPath = new System.Windows.Forms.TextBox();
            this.dgwScale = new System.Windows.Forms.DataGridView();
            this.btnStartTransfer = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwScale)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetDatabasePath
            // 
            this.btnGetDatabasePath.Location = new System.Drawing.Point(12, 12);
            this.btnGetDatabasePath.Name = "btnGetDatabasePath";
            this.btnGetDatabasePath.Size = new System.Drawing.Size(163, 39);
            this.btnGetDatabasePath.TabIndex = 0;
            this.btnGetDatabasePath.Text = "Veritabanı Seç";
            this.btnGetDatabasePath.UseVisualStyleBackColor = true;
            this.btnGetDatabasePath.Click += new System.EventHandler(this.btnGetDatabasePath_Click);
            // 
            // cbxMaasAciklama
            // 
            this.cbxMaasAciklama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMaasAciklama.FormattingEnabled = true;
            this.cbxMaasAciklama.Location = new System.Drawing.Point(181, 18);
            this.cbxMaasAciklama.Name = "cbxMaasAciklama";
            this.cbxMaasAciklama.Size = new System.Drawing.Size(423, 29);
            this.cbxMaasAciklama.TabIndex = 1;
            // 
            // btnExcelPath
            // 
            this.btnExcelPath.Enabled = false;
            this.btnExcelPath.Location = new System.Drawing.Point(12, 66);
            this.btnExcelPath.Name = "btnExcelPath";
            this.btnExcelPath.Size = new System.Drawing.Size(163, 39);
            this.btnExcelPath.TabIndex = 2;
            this.btnExcelPath.Text = "Excel Dosyasını Seç";
            this.btnExcelPath.UseVisualStyleBackColor = true;
            this.btnExcelPath.Click += new System.EventHandler(this.btnExcelPath_Click);
            // 
            // tbxExcelPath
            // 
            this.tbxExcelPath.Enabled = false;
            this.tbxExcelPath.Location = new System.Drawing.Point(181, 72);
            this.tbxExcelPath.Name = "tbxExcelPath";
            this.tbxExcelPath.Size = new System.Drawing.Size(423, 29);
            this.tbxExcelPath.TabIndex = 3;
            // 
            // dgwScale
            // 
            this.dgwScale.AllowUserToAddRows = false;
            this.dgwScale.AllowUserToDeleteRows = false;
            this.dgwScale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwScale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwScale.Location = new System.Drawing.Point(12, 120);
            this.dgwScale.Name = "dgwScale";
            this.dgwScale.ReadOnly = true;
            this.dgwScale.Size = new System.Drawing.Size(901, 525);
            this.dgwScale.TabIndex = 4;
            // 
            // btnStartTransfer
            // 
            this.btnStartTransfer.Enabled = false;
            this.btnStartTransfer.Location = new System.Drawing.Point(750, 655);
            this.btnStartTransfer.Name = "btnStartTransfer";
            this.btnStartTransfer.Size = new System.Drawing.Size(163, 39);
            this.btnStartTransfer.TabIndex = 5;
            this.btnStartTransfer.Text = "BAŞLAT";
            this.btnStartTransfer.UseVisualStyleBackColor = true;
            this.btnStartTransfer.Click += new System.EventHandler(this.btnStartTransfer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 702);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(926, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(47, 21);
            this.lblStatus.Text = "Hazır";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 728);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnStartTransfer);
            this.Controls.Add(this.dgwScale);
            this.Controls.Add(this.tbxExcelPath);
            this.Controls.Add(this.btnExcelPath);
            this.Controls.Add(this.cbxMaasAciklama);
            this.Controls.Add(this.btnGetDatabasePath);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skala Aktar";
            ((System.ComponentModel.ISupportInitialize)(this.dgwScale)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetDatabasePath;
        private System.Windows.Forms.ComboBox cbxMaasAciklama;
        private System.Windows.Forms.Button btnExcelPath;
        private System.Windows.Forms.TextBox tbxExcelPath;
        private System.Windows.Forms.DataGridView dgwScale;
        private System.Windows.Forms.Button btnStartTransfer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

