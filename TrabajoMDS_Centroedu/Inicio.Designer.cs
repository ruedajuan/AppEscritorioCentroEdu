namespace TrabajoMDS_Centroedu
{
    partial class Inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblRol = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menupago = new FontAwesome.Sharp.IconMenuItem();
            this.menuAlumnos = new FontAwesome.Sharp.IconMenuItem();
            this.submenuListaAlumnos = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuNotas = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosPorDocenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosConCuotasImpagasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClases = new FontAwesome.Sharp.IconMenuItem();
            this.menuboletin = new FontAwesome.Sharp.IconMenuItem();
            this.menuIngreso = new FontAwesome.Sharp.IconMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.contenedor = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(127, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sistema Educar Para Transformar";
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.AutoSize = true;
            this.lblRol.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblRol.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRol.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblRol.Location = new System.Drawing.Point(709, 49);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(27, 15);
            this.lblRol.TabIndex = 8;
            this.lblRol.Text = "Rol";
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblBienvenida.Location = new System.Drawing.Point(709, 12);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(53, 15);
            this.lblBienvenida.TabIndex = 7;
            this.lblBienvenida.Text = "Nombre";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menupago,
            this.menuAlumnos,
            this.menuClases,
            this.menuboletin,
            this.menuIngreso});
            this.menuStrip1.Location = new System.Drawing.Point(0, 76);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 84);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menupago
            // 
            this.menupago.IconChar = FontAwesome.Sharp.IconChar.CreditCardAlt;
            this.menupago.IconColor = System.Drawing.Color.Black;
            this.menupago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menupago.IconSize = 40;
            this.menupago.Name = "menupago";
            this.menupago.Size = new System.Drawing.Size(113, 80);
            this.menupago.Text = "Pago de Cuota";
            this.menupago.Click += new System.EventHandler(this.menupago_Click_1);
            // 
            // menuAlumnos
            // 
            this.menuAlumnos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuListaAlumnos,
            this.submenuNotas,
            this.alumnosPorDocenteToolStripMenuItem,
            this.alumnosConCuotasImpagasToolStripMenuItem});
            this.menuAlumnos.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.menuAlumnos.IconColor = System.Drawing.Color.Black;
            this.menuAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuAlumnos.Name = "menuAlumnos";
            this.menuAlumnos.Size = new System.Drawing.Size(83, 80);
            this.menuAlumnos.Text = "Alumnos";
            // 
            // submenuListaAlumnos
            // 
            this.submenuListaAlumnos.Name = "submenuListaAlumnos";
            this.submenuListaAlumnos.Size = new System.Drawing.Size(231, 22);
            this.submenuListaAlumnos.Text = "Lista de alumnos";
            this.submenuListaAlumnos.Click += new System.EventHandler(this.submenuListaAlumnos_Click_1);
            // 
            // submenuNotas
            // 
            this.submenuNotas.Name = "submenuNotas";
            this.submenuNotas.Size = new System.Drawing.Size(231, 22);
            this.submenuNotas.Text = "Cargar notas";
            this.submenuNotas.Click += new System.EventHandler(this.submenuNotas_Click_1);
            // 
            // alumnosPorDocenteToolStripMenuItem
            // 
            this.alumnosPorDocenteToolStripMenuItem.Name = "alumnosPorDocenteToolStripMenuItem";
            this.alumnosPorDocenteToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.alumnosPorDocenteToolStripMenuItem.Text = "Alumnos por docente";
            this.alumnosPorDocenteToolStripMenuItem.Click += new System.EventHandler(this.alumnosPorDocenteToolStripMenuItem_Click);
            // 
            // alumnosConCuotasImpagasToolStripMenuItem
            // 
            this.alumnosConCuotasImpagasToolStripMenuItem.Name = "alumnosConCuotasImpagasToolStripMenuItem";
            this.alumnosConCuotasImpagasToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.alumnosConCuotasImpagasToolStripMenuItem.Text = "Alumnos con cuotas impagas";
            this.alumnosConCuotasImpagasToolStripMenuItem.Click += new System.EventHandler(this.alumnosConCuotasImpagasToolStripMenuItem_Click);
            // 
            // menuClases
            // 
            this.menuClases.IconChar = FontAwesome.Sharp.IconChar.PersonChalkboard;
            this.menuClases.IconColor = System.Drawing.Color.Black;
            this.menuClases.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuClases.Name = "menuClases";
            this.menuClases.Size = new System.Drawing.Size(68, 80);
            this.menuClases.Text = "Clases";
            this.menuClases.Click += new System.EventHandler(this.iconMenuItem1_Click_1);
            // 
            // menuboletin
            // 
            this.menuboletin.IconChar = FontAwesome.Sharp.IconChar.EnvelopeOpenText;
            this.menuboletin.IconColor = System.Drawing.Color.Black;
            this.menuboletin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuboletin.Name = "menuboletin";
            this.menuboletin.Size = new System.Drawing.Size(72, 80);
            this.menuboletin.Text = "Boletin";
            this.menuboletin.Click += new System.EventHandler(this.menuboletin_Click_1);
            // 
            // menuIngreso
            // 
            this.menuIngreso.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.menuIngreso.IconColor = System.Drawing.Color.Black;
            this.menuIngreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.menuIngreso.Name = "menuIngreso";
            this.menuIngreso.Size = new System.Drawing.Size(79, 80);
            this.menuIngreso.Text = "Ingresos";
            this.menuIngreso.Click += new System.EventHandler(this.iconMenuItem2_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.BackColor = System.Drawing.Color.MidnightBlue;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 76);
            this.menuStrip2.TabIndex = 13;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // contenedor
            // 
            this.contenedor.Controls.Add(this.button1);
            this.contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedor.Location = new System.Drawing.Point(0, 160);
            this.contenedor.Name = "contenedor";
            this.contenedor.Size = new System.Drawing.Size(800, 290);
            this.contenedor.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(612, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar Sesion";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajoMDS_Centroedu.Properties.Resources.Logo1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.contenedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRol;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private FontAwesome.Sharp.IconMenuItem menupago;
        private FontAwesome.Sharp.IconMenuItem menuAlumnos;
        private System.Windows.Forms.ToolStripMenuItem submenuListaAlumnos;
        private System.Windows.Forms.ToolStripMenuItem submenuNotas;
        private System.Windows.Forms.ToolStripMenuItem alumnosPorDocenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosConCuotasImpagasToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem menuClases;
        private FontAwesome.Sharp.IconMenuItem menuboletin;
        private FontAwesome.Sharp.IconMenuItem menuIngreso;
        private System.Windows.Forms.Panel contenedor;
        private System.Windows.Forms.Button button1;
    }
}