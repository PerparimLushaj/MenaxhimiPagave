namespace KNKProjekti
{
    partial class Form2
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
            this.txtfjalekalimi = new System.Windows.Forms.TextBox();
            this.txtPerdoruesi = new System.Windows.Forms.TextBox();
            this.lblFjalekalimi = new System.Windows.Forms.Label();
            this.lblPerdoruesi = new System.Windows.Forms.Label();
            this.btnMbyll = new System.Windows.Forms.Button();
            this.btnKycu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtfjalekalimi
            // 
            this.txtfjalekalimi.Location = new System.Drawing.Point(282, 56);
            this.txtfjalekalimi.Name = "txtfjalekalimi";
            this.txtfjalekalimi.PasswordChar = '*';
            this.txtfjalekalimi.Size = new System.Drawing.Size(100, 20);
            this.txtfjalekalimi.TabIndex = 1;
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.Location = new System.Drawing.Point(282, 19);
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.Size = new System.Drawing.Size(100, 20);
            this.txtPerdoruesi.TabIndex = 0;
            // 
            // lblFjalekalimi
            // 
            this.lblFjalekalimi.AutoSize = true;
            this.lblFjalekalimi.BackColor = System.Drawing.Color.Transparent;
            this.lblFjalekalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFjalekalimi.Location = new System.Drawing.Point(181, 56);
            this.lblFjalekalimi.Name = "lblFjalekalimi";
            this.lblFjalekalimi.Size = new System.Drawing.Size(88, 18);
            this.lblFjalekalimi.TabIndex = 9;
            this.lblFjalekalimi.Text = "Fjalekalimi";
            // 
            // lblPerdoruesi
            // 
            this.lblPerdoruesi.AutoSize = true;
            this.lblPerdoruesi.BackColor = System.Drawing.Color.Transparent;
            this.lblPerdoruesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdoruesi.Location = new System.Drawing.Point(179, 20);
            this.lblPerdoruesi.Name = "lblPerdoruesi";
            this.lblPerdoruesi.Size = new System.Drawing.Size(90, 18);
            this.lblPerdoruesi.TabIndex = 8;
            this.lblPerdoruesi.Text = "Perdoruesi";
            // 
            // btnMbyll
            // 
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMbyll.Location = new System.Drawing.Point(311, 90);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(79, 35);
            this.btnMbyll.TabIndex = 3;
            this.btnMbyll.Text = "Mbyll";
            this.btnMbyll.UseVisualStyleBackColor = true;
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // btnKycu
            // 
            this.btnKycu.BackColor = System.Drawing.Color.Transparent;
            this.btnKycu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKycu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKycu.Location = new System.Drawing.Point(214, 90);
            this.btnKycu.Name = "btnKycu";
            this.btnKycu.Size = new System.Drawing.Size(79, 35);
            this.btnKycu.TabIndex = 2;
            this.btnKycu.Text = "Kycu";
            this.btnKycu.UseVisualStyleBackColor = false;
            this.btnKycu.Click += new System.EventHandler(this.btnKycu_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 140);
            this.ControlBox = false;
            this.Controls.Add(this.txtfjalekalimi);
            this.Controls.Add(this.txtPerdoruesi);
            this.Controls.Add(this.lblFjalekalimi);
            this.Controls.Add(this.lblPerdoruesi);
            this.Controls.Add(this.btnMbyll);
            this.Controls.Add(this.btnKycu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtfjalekalimi;
        private System.Windows.Forms.TextBox txtPerdoruesi;
        private System.Windows.Forms.Label lblFjalekalimi;
        private System.Windows.Forms.Label lblPerdoruesi;
        private System.Windows.Forms.Button btnMbyll;
        private System.Windows.Forms.Button btnKycu;
    }
}