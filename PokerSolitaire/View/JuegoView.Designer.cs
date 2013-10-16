namespace PokerSolitaire
{
    partial class JuegoView
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
            this.carta1 = new System.Windows.Forms.PictureBox();
            this.carta2 = new System.Windows.Forms.PictureBox();
            this.carta4 = new System.Windows.Forms.PictureBox();
            this.carta3 = new System.Windows.Forms.PictureBox();
            this.mazo = new System.Windows.Forms.PictureBox();
            this.atras = new System.Windows.Forms.PictureBox();
            this.adelante = new System.Windows.Forms.PictureBox();
            this.turno = new System.Windows.Forms.Label();
            this.turnoLabel = new System.Windows.Forms.Label();
            this.nombreCombinacion = new System.Windows.Forms.Label();
            this.valorCombinacion = new System.Windows.Forms.Label();
            this.puntuacionAcumulada = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adelante)).BeginInit();
            this.SuspendLayout();
            // 
            // carta1
            // 
            this.carta1.BackColor = System.Drawing.Color.Transparent;
            this.carta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta1.InitialImage = null;
            this.carta1.Location = new System.Drawing.Point(39, 33);
            this.carta1.Name = "carta1";
            this.carta1.Size = new System.Drawing.Size(98, 162);
            this.carta1.TabIndex = 0;
            this.carta1.TabStop = false;
            // 
            // carta2
            // 
            this.carta2.BackColor = System.Drawing.Color.Transparent;
            this.carta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta2.InitialImage = null;
            this.carta2.Location = new System.Drawing.Point(177, 33);
            this.carta2.Name = "carta2";
            this.carta2.Size = new System.Drawing.Size(98, 162);
            this.carta2.TabIndex = 1;
            this.carta2.TabStop = false;
            // 
            // carta4
            // 
            this.carta4.BackColor = System.Drawing.Color.Transparent;
            this.carta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta4.InitialImage = null;
            this.carta4.Location = new System.Drawing.Point(466, 33);
            this.carta4.Name = "carta4";
            this.carta4.Size = new System.Drawing.Size(98, 162);
            this.carta4.TabIndex = 2;
            this.carta4.TabStop = false;
            // 
            // carta3
            // 
            this.carta3.BackColor = System.Drawing.Color.Transparent;
            this.carta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.carta3.InitialImage = null;
            this.carta3.Location = new System.Drawing.Point(316, 33);
            this.carta3.Name = "carta3";
            this.carta3.Size = new System.Drawing.Size(98, 162);
            this.carta3.TabIndex = 3;
            this.carta3.TabStop = false;
            // 
            // mazo
            // 
            this.mazo.BackColor = System.Drawing.Color.Transparent;
            this.mazo.BackgroundImage = global::PokerSolitaire.Properties.Resources.CardBack;
            this.mazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mazo.InitialImage = null;
            this.mazo.Location = new System.Drawing.Point(359, 242);
            this.mazo.Name = "mazo";
            this.mazo.Size = new System.Drawing.Size(98, 162);
            this.mazo.TabIndex = 4;
            this.mazo.TabStop = false;
            this.mazo.Click += new System.EventHandler(this.mazo_Click);
            // 
            // atras
            // 
            this.atras.BackColor = System.Drawing.Color.Transparent;
            this.atras.BackgroundImage = global::PokerSolitaire.Properties.Resources.AtrasDesactivado;
            this.atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.atras.Enabled = false;
            this.atras.Location = new System.Drawing.Point(478, 354);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(51, 50);
            this.atras.TabIndex = 5;
            this.atras.TabStop = false;
            this.atras.Click += new System.EventHandler(this.atras_Click);
            // 
            // adelante
            // 
            this.adelante.BackColor = System.Drawing.Color.Transparent;
            this.adelante.BackgroundImage = global::PokerSolitaire.Properties.Resources.SiguienteDesactivado;
            this.adelante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adelante.Enabled = false;
            this.adelante.Location = new System.Drawing.Point(550, 354);
            this.adelante.Name = "adelante";
            this.adelante.Size = new System.Drawing.Size(51, 50);
            this.adelante.TabIndex = 6;
            this.adelante.TabStop = false;
            this.adelante.Click += new System.EventHandler(this.adelante_Click);
            // 
            // turno
            // 
            this.turno.AutoSize = true;
            this.turno.BackColor = System.Drawing.Color.Transparent;
            this.turno.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turno.Location = new System.Drawing.Point(507, 264);
            this.turno.Name = "turno";
            this.turno.Size = new System.Drawing.Size(72, 86);
            this.turno.TabIndex = 7;
            this.turno.Text = "0";
            this.turno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // turnoLabel
            // 
            this.turnoLabel.AutoSize = true;
            this.turnoLabel.BackColor = System.Drawing.Color.Transparent;
            this.turnoLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnoLabel.Location = new System.Drawing.Point(501, 242);
            this.turnoLabel.Name = "turnoLabel";
            this.turnoLabel.Size = new System.Drawing.Size(78, 32);
            this.turnoLabel.TabIndex = 8;
            this.turnoLabel.Text = "Turno";
            // 
            // nombreCombinacion
            // 
            this.nombreCombinacion.AutoSize = true;
            this.nombreCombinacion.BackColor = System.Drawing.Color.Transparent;
            this.nombreCombinacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreCombinacion.Location = new System.Drawing.Point(35, 264);
            this.nombreCombinacion.Name = "nombreCombinacion";
            this.nombreCombinacion.Size = new System.Drawing.Size(170, 21);
            this.nombreCombinacion.TabIndex = 9;
            this.nombreCombinacion.Text = "Combinación obtenida:";
            // 
            // valorCombinacion
            // 
            this.valorCombinacion.AutoSize = true;
            this.valorCombinacion.BackColor = System.Drawing.Color.Transparent;
            this.valorCombinacion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorCombinacion.Location = new System.Drawing.Point(35, 320);
            this.valorCombinacion.Name = "valorCombinacion";
            this.valorCombinacion.Size = new System.Drawing.Size(164, 21);
            this.valorCombinacion.TabIndex = 10;
            this.valorCombinacion.Text = "Valor de combinación:";
            // 
            // puntuacionAcumulada
            // 
            this.puntuacionAcumulada.AutoSize = true;
            this.puntuacionAcumulada.BackColor = System.Drawing.Color.Transparent;
            this.puntuacionAcumulada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntuacionAcumulada.Location = new System.Drawing.Point(35, 383);
            this.puntuacionAcumulada.Name = "puntuacionAcumulada";
            this.puntuacionAcumulada.Size = new System.Drawing.Size(171, 21);
            this.puntuacionAcumulada.TabIndex = 11;
            this.puntuacionAcumulada.Text = "Puntuación acumulada:";
            // 
            // JuegoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PokerSolitaire.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.puntuacionAcumulada);
            this.Controls.Add(this.valorCombinacion);
            this.Controls.Add(this.nombreCombinacion);
            this.Controls.Add(this.turnoLabel);
            this.Controls.Add(this.turno);
            this.Controls.Add(this.adelante);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.mazo);
            this.Controls.Add(this.carta3);
            this.Controls.Add(this.carta4);
            this.Controls.Add(this.carta2);
            this.Controls.Add(this.carta1);
            this.Name = "JuegoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JuegoView";
            this.Load += new System.EventHandler(this.JuegoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.carta1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adelante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox carta1;
        private System.Windows.Forms.PictureBox carta2;
        private System.Windows.Forms.PictureBox carta4;
        private System.Windows.Forms.PictureBox carta3;
        private System.Windows.Forms.PictureBox mazo;
        private System.Windows.Forms.PictureBox atras;
        private System.Windows.Forms.PictureBox adelante;
        private System.Windows.Forms.Label turno;
        private System.Windows.Forms.Label turnoLabel;
        private System.Windows.Forms.Label nombreCombinacion;
        private System.Windows.Forms.Label valorCombinacion;
        private System.Windows.Forms.Label puntuacionAcumulada;
    }
}