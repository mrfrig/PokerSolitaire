namespace PokerSolitaire
{
    partial class MenuDeInicioView
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
            this.nuevoJuego = new System.Windows.Forms.Button();
            this.cargarArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nuevoJuego
            // 
            this.nuevoJuego.AutoSize = true;
            this.nuevoJuego.Location = new System.Drawing.Point(217, 111);
            this.nuevoJuego.Name = "nuevoJuego";
            this.nuevoJuego.Size = new System.Drawing.Size(183, 88);
            this.nuevoJuego.TabIndex = 0;
            this.nuevoJuego.Text = "Nuevo Juego";
            this.nuevoJuego.UseVisualStyleBackColor = true;
            this.nuevoJuego.Click += new System.EventHandler(this.NuevoJuego_Click);
            // 
            // cargarArchivo
            // 
            this.cargarArchivo.AutoSize = true;
            this.cargarArchivo.Location = new System.Drawing.Point(217, 239);
            this.cargarArchivo.Name = "cargarArchivo";
            this.cargarArchivo.Size = new System.Drawing.Size(183, 83);
            this.cargarArchivo.TabIndex = 1;
            this.cargarArchivo.Text = "Cargar Archivo";
            this.cargarArchivo.UseVisualStyleBackColor = true;
            this.cargarArchivo.Click += new System.EventHandler(this.CargarArchivo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(108, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido a Poker Solitaire";
            // 
            // MenuDeInicioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PokerSolitaire.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cargarArchivo);
            this.Controls.Add(this.nuevoJuego);
            this.MaximizeBox = false;
            this.Name = "MenuDeInicioView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker Solitaire";
            this.Load += new System.EventHandler(this.MenuDeInicioView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nuevoJuego;
        private System.Windows.Forms.Button cargarArchivo;
        private System.Windows.Forms.Label label1;
    }
}

