namespace BD1
{
    partial class Banco
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEXECUTE = new System.Windows.Forms.Button();
            this.textSERVIDOR = new System.Windows.Forms.Label();
            this.textBoxSERVIDOR = new System.Windows.Forms.TextBox();
            this.textBoxUSUARIO = new System.Windows.Forms.TextBox();
            this.textUSUARIO = new System.Windows.Forms.Label();
            this.textBoxSENHA = new System.Windows.Forms.TextBox();
            this.textSENHA = new System.Windows.Forms.Label();
            this.textBANCO = new System.Windows.Forms.Label();
            this.textBoxBANCO = new System.Windows.Forms.TextBox();
            this.textSQL = new System.Windows.Forms.Label();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEXECUTE
            // 
            this.btnEXECUTE.AllowDrop = true;
            this.btnEXECUTE.AutoEllipsis = true;
            this.btnEXECUTE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEXECUTE.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEXECUTE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEXECUTE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEXECUTE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEXECUTE.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEXECUTE.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEXECUTE.Location = new System.Drawing.Point(319, 160);
            this.btnEXECUTE.MaximumSize = new System.Drawing.Size(200, 110);
            this.btnEXECUTE.MinimumSize = new System.Drawing.Size(160, 50);
            this.btnEXECUTE.Name = "btnEXECUTE";
            this.btnEXECUTE.Size = new System.Drawing.Size(160, 50);
            this.btnEXECUTE.TabIndex = 0;
            this.btnEXECUTE.Text = "Executar!";
            this.btnEXECUTE.UseVisualStyleBackColor = false;
            this.btnEXECUTE.Click += new System.EventHandler(this.button1_Click);
            // 
            // textSERVIDOR
            // 
            this.textSERVIDOR.BackColor = System.Drawing.Color.Transparent;
            this.textSERVIDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSERVIDOR.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSERVIDOR.Location = new System.Drawing.Point(60, 9);
            this.textSERVIDOR.Name = "textSERVIDOR";
            this.textSERVIDOR.Size = new System.Drawing.Size(89, 20);
            this.textSERVIDOR.TabIndex = 1;
            this.textSERVIDOR.Text = "Servidor";
            // 
            // textBoxSERVIDOR
            // 
            this.textBoxSERVIDOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSERVIDOR.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSERVIDOR.Location = new System.Drawing.Point(12, 32);
            this.textBoxSERVIDOR.MaximumSize = new System.Drawing.Size(300, 300);
            this.textBoxSERVIDOR.MinimumSize = new System.Drawing.Size(100, 30);
            this.textBoxSERVIDOR.Name = "textBoxSERVIDOR";
            this.textBoxSERVIDOR.Size = new System.Drawing.Size(189, 30);
            this.textBoxSERVIDOR.TabIndex = 2;
            // 
            // textBoxUSUARIO
            // 
            this.textBoxUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUSUARIO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxUSUARIO.Location = new System.Drawing.Point(12, 88);
            this.textBoxUSUARIO.MaximumSize = new System.Drawing.Size(300, 300);
            this.textBoxUSUARIO.MinimumSize = new System.Drawing.Size(100, 30);
            this.textBoxUSUARIO.Name = "textBoxUSUARIO";
            this.textBoxUSUARIO.Size = new System.Drawing.Size(189, 30);
            this.textBoxUSUARIO.TabIndex = 3;
            // 
            // textUSUARIO
            // 
            this.textUSUARIO.AutoSize = true;
            this.textUSUARIO.BackColor = System.Drawing.Color.Transparent;
            this.textUSUARIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUSUARIO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textUSUARIO.Location = new System.Drawing.Point(60, 65);
            this.textUSUARIO.Name = "textUSUARIO";
            this.textUSUARIO.Size = new System.Drawing.Size(64, 20);
            this.textUSUARIO.TabIndex = 4;
            this.textUSUARIO.Text = "Usuário";
            // 
            // textBoxSENHA
            // 
            this.textBoxSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSENHA.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSENHA.Location = new System.Drawing.Point(12, 146);
            this.textBoxSENHA.MaximumSize = new System.Drawing.Size(300, 300);
            this.textBoxSENHA.MinimumSize = new System.Drawing.Size(100, 30);
            this.textBoxSENHA.Name = "textBoxSENHA";
            this.textBoxSENHA.Size = new System.Drawing.Size(189, 30);
            this.textBoxSENHA.TabIndex = 5;
            // 
            // textSENHA
            // 
            this.textSENHA.AutoSize = true;
            this.textSENHA.BackColor = System.Drawing.Color.Transparent;
            this.textSENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSENHA.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSENHA.Location = new System.Drawing.Point(60, 127);
            this.textSENHA.Name = "textSENHA";
            this.textSENHA.Size = new System.Drawing.Size(56, 20);
            this.textSENHA.TabIndex = 6;
            this.textSENHA.Text = "Senha";
            // 
            // textBANCO
            // 
            this.textBANCO.AutoSize = true;
            this.textBANCO.BackColor = System.Drawing.Color.Transparent;
            this.textBANCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBANCO.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBANCO.Location = new System.Drawing.Point(60, 176);
            this.textBANCO.Name = "textBANCO";
            this.textBANCO.Size = new System.Drawing.Size(55, 20);
            this.textBANCO.TabIndex = 7;
            this.textBANCO.Text = "Banco";
            // 
            // textBoxBANCO
            // 
            this.textBoxBANCO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBANCO.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxBANCO.Location = new System.Drawing.Point(12, 198);
            this.textBoxBANCO.MaximumSize = new System.Drawing.Size(300, 300);
            this.textBoxBANCO.MinimumSize = new System.Drawing.Size(100, 30);
            this.textBoxBANCO.Name = "textBoxBANCO";
            this.textBoxBANCO.Size = new System.Drawing.Size(189, 30);
            this.textBoxBANCO.TabIndex = 8;
            // 
            // textSQL
            // 
            this.textSQL.AutoSize = true;
            this.textSQL.BackColor = System.Drawing.Color.Transparent;
            this.textSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSQL.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textSQL.Location = new System.Drawing.Point(371, 32);
            this.textSQL.Name = "textSQL";
            this.textSQL.Size = new System.Drawing.Size(41, 20);
            this.textSQL.TabIndex = 9;
            this.textSQL.Text = "SQL";
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSQL.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.textBoxSQL.Location = new System.Drawing.Point(240, 62);
            this.textBoxSQL.MaximumSize = new System.Drawing.Size(600, 300);
            this.textBoxSQL.MinimumSize = new System.Drawing.Size(100, 90);
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.Size = new System.Drawing.Size(343, 90);
            this.textBoxSQL.TabIndex = 10;
            // 
            // Banco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 274);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.textSQL);
            this.Controls.Add(this.textBoxBANCO);
            this.Controls.Add(this.textBANCO);
            this.Controls.Add(this.textSENHA);
            this.Controls.Add(this.textBoxSENHA);
            this.Controls.Add(this.textUSUARIO);
            this.Controls.Add(this.textBoxUSUARIO);
            this.Controls.Add(this.textBoxSERVIDOR);
            this.Controls.Add(this.textSERVIDOR);
            this.Controls.Add(this.btnEXECUTE);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForeColor = System.Drawing.Color.Transparent;
            this.HelpButton = true;
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Banco";
            this.Text = "Window Title";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEXECUTE;
        private System.Windows.Forms.Label textSERVIDOR;
        private System.Windows.Forms.TextBox textBoxSERVIDOR;
        private System.Windows.Forms.TextBox textBoxUSUARIO;
        private System.Windows.Forms.Label textUSUARIO;
        private System.Windows.Forms.TextBox textBoxSENHA;
        private System.Windows.Forms.Label textSENHA;
        private System.Windows.Forms.Label textBANCO;
        private System.Windows.Forms.TextBox textBoxBANCO;
        private System.Windows.Forms.Label textSQL;
        private System.Windows.Forms.TextBox textBoxSQL;
    }
}

