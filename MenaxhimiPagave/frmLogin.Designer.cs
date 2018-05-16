namespace Punetori
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnKycu = new System.Windows.Forms.Button();
            this.btnMbyll = new System.Windows.Forms.Button();
            this.lblPerdoruesi = new System.Windows.Forms.Label();
            this.lblFjalekalimi = new System.Windows.Forms.Label();
            this.txtPerdoruesi = new System.Windows.Forms.TextBox();
            this.txtfjalekalimi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnKycu
            // 
            this.btnKycu.BackColor = System.Drawing.Color.Transparent;
            this.btnKycu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKycu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnKycu.Location = new System.Drawing.Point(208, 97);
            this.btnKycu.Name = "btnKycu";
            this.btnKycu.Size = new System.Drawing.Size(79, 35);
            this.btnKycu.TabIndex = 0;
            this.btnKycu.Text = "Kycu";
            this.btnKycu.UseVisualStyleBackColor = false;
            this.btnKycu.Click += new System.EventHandler(this.btnKycu_Click);
            // 
            // btnMbyll
            // 
            this.btnMbyll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnMbyll.Location = new System.Drawing.Point(305, 97);
            this.btnMbyll.Name = "btnMbyll";
            this.btnMbyll.Size = new System.Drawing.Size(79, 35);
            this.btnMbyll.TabIndex = 1;
            this.btnMbyll.Text = "Mbyll";
            this.btnMbyll.UseVisualStyleBackColor = true;
            this.btnMbyll.Click += new System.EventHandler(this.btnMbyll_Click);
            // 
            // lblPerdoruesi
            // 
            this.lblPerdoruesi.AutoSize = true;
            this.lblPerdoruesi.BackColor = System.Drawing.Color.Transparent;
            this.lblPerdoruesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerdoruesi.Location = new System.Drawing.Point(173, 27);
            this.lblPerdoruesi.Name = "lblPerdoruesi";
            this.lblPerdoruesi.Size = new System.Drawing.Size(90, 18);
            this.lblPerdoruesi.TabIndex = 2;
            this.lblPerdoruesi.Text = "Perdoruesi";
            // 
            // lblFjalekalimi
            // 
            this.lblFjalekalimi.AutoSize = true;
            this.lblFjalekalimi.BackColor = System.Drawing.Color.Transparent;
            this.lblFjalekalimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblFjalekalimi.Location = new System.Drawing.Point(175, 63);
            this.lblFjalekalimi.Name = "lblFjalekalimi";
            this.lblFjalekalimi.Size = new System.Drawing.Size(88, 18);
            this.lblFjalekalimi.TabIndex = 3;
            this.lblFjalekalimi.Text = "Fjalekalimi";
            // 
            // txtPerdoruesi
            // 
            this.txtPerdoruesi.Location = new System.Drawing.Point(276, 26);
            this.txtPerdoruesi.Name = "txtPerdoruesi";
            this.txtPerdoruesi.Size = new System.Drawing.Size(100, 20);
            this.txtPerdoruesi.TabIndex = 4;
            // 
            // txtfjalekalimi
            // 
            this.txtfjalekalimi.Location = new System.Drawing.Point(276, 63);
            this.txtfjalekalimi.Name = "txtfjalekalimi";
            this.txtfjalekalimi.PasswordChar = '*';
            this.txtfjalekalimi.Size = new System.Drawing.Size(100, 20);
            this.txtfjalekalimi.TabIndex = 5;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(403, 146);
            this.ControlBox = false;
            this.Controls.Add(this.txtfjalekalimi);
            this.Controls.Add(this.txtPerdoruesi);
            this.Controls.Add(this.lblFjalekalimi);
            this.Controls.Add(this.lblPerdoruesi);
            this.Controls.Add(this.btnMbyll);
            this.Controls.Add(this.btnKycu);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKycu;
        private System.Windows.Forms.Button btnMbyll;
        private System.Windows.Forms.Label lblPerdoruesi;
        private System.Windows.Forms.Label lblFjalekalimi;
        private System.Windows.Forms.TextBox txtPerdoruesi;
        private System.Windows.Forms.TextBox txtfjalekalimi;
    }
}

