namespace U2_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxPapel = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txtR = new System.Windows.Forms.TextBox();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRGB = new System.Windows.Forms.Button();
            this.CboxCuadrado = new System.Windows.Forms.CheckBox();
            this.btnGuardarImage = new System.Windows.Forms.Button();
            this.CboxCuadradoUnico = new System.Windows.Forms.CheckBox();
            this.CboxRectangulo = new System.Windows.Forms.CheckBox();
            this.CboxOvalo = new System.Windows.Forms.CheckBox();
            this.CboxOvaloRelleno = new System.Windows.Forms.CheckBox();
            this.CboxRandom = new System.Windows.Forms.CheckBox();
            this.btnGenerarFiguras = new System.Windows.Forms.Button();
            this.CboxLinea = new System.Windows.Forms.CheckBox();
            this.CboxCirculo = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPapel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPapel
            // 
            this.pictureBoxPapel.BackColor = System.Drawing.Color.White;
            this.pictureBoxPapel.Location = new System.Drawing.Point(330, 20);
            this.pictureBoxPapel.Name = "pictureBoxPapel";
            this.pictureBoxPapel.Size = new System.Drawing.Size(568, 418);
            this.pictureBoxPapel.TabIndex = 0;
            this.pictureBoxPapel.TabStop = false;
            this.pictureBoxPapel.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBoxPapel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBoxPapel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBoxPapel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(32, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 27);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.Info;
            this.pictureBox3.Location = new System.Drawing.Point(105, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(27, 27);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(138, 12);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 147);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll_1);
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(32, 45);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(100, 23);
            this.txtR.TabIndex = 4;
            this.txtR.Text = "0";
            // 
            // txtG
            // 
            this.txtG.Location = new System.Drawing.Point(32, 74);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(100, 23);
            this.txtG.TabIndex = 5;
            this.txtG.Text = "0";
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(32, 103);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 23);
            this.txtB.TabIndex = 6;
            this.txtB.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "B";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 401);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(98, 37);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRGB
            // 
            this.btnRGB.Location = new System.Drawing.Point(32, 132);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(100, 27);
            this.btnRGB.TabIndex = 11;
            this.btnRGB.Text = "Aplicar Color";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // CboxCuadrado
            // 
            this.CboxCuadrado.AutoSize = true;
            this.CboxCuadrado.Location = new System.Drawing.Point(172, 20);
            this.CboxCuadrado.Name = "CboxCuadrado";
            this.CboxCuadrado.Size = new System.Drawing.Size(152, 19);
            this.CboxCuadrado.TabIndex = 13;
            this.CboxCuadrado.Text = "Seleccion de Cuadrados";
            this.CboxCuadrado.UseVisualStyleBackColor = true;
            this.CboxCuadrado.CheckedChanged += new System.EventHandler(this.CboxCuadrado_CheckedChanged);
            // 
            // btnGuardarImage
            // 
            this.btnGuardarImage.Location = new System.Drawing.Point(155, 401);
            this.btnGuardarImage.Name = "btnGuardarImage";
            this.btnGuardarImage.Size = new System.Drawing.Size(98, 37);
            this.btnGuardarImage.TabIndex = 14;
            this.btnGuardarImage.Text = "Guardar";
            this.btnGuardarImage.UseVisualStyleBackColor = true;
            this.btnGuardarImage.Click += new System.EventHandler(this.btnGuardarImage_Click);
            // 
            // CboxCuadradoUnico
            // 
            this.CboxCuadradoUnico.AutoSize = true;
            this.CboxCuadradoUnico.Location = new System.Drawing.Point(12, 187);
            this.CboxCuadradoUnico.Name = "CboxCuadradoUnico";
            this.CboxCuadradoUnico.Size = new System.Drawing.Size(78, 19);
            this.CboxCuadradoUnico.TabIndex = 15;
            this.CboxCuadradoUnico.Text = "Cuadrado";
            this.CboxCuadradoUnico.UseVisualStyleBackColor = true;
            // 
            // CboxRectangulo
            // 
            this.CboxRectangulo.AutoSize = true;
            this.CboxRectangulo.Location = new System.Drawing.Point(85, 187);
            this.CboxRectangulo.Name = "CboxRectangulo";
            this.CboxRectangulo.Size = new System.Drawing.Size(86, 19);
            this.CboxRectangulo.TabIndex = 16;
            this.CboxRectangulo.Text = "Rectangulo";
            this.CboxRectangulo.UseVisualStyleBackColor = true;
            // 
            // CboxOvalo
            // 
            this.CboxOvalo.AutoSize = true;
            this.CboxOvalo.Location = new System.Drawing.Point(12, 212);
            this.CboxOvalo.Name = "CboxOvalo";
            this.CboxOvalo.Size = new System.Drawing.Size(57, 19);
            this.CboxOvalo.TabIndex = 17;
            this.CboxOvalo.Text = "Ovalo";
            this.CboxOvalo.UseVisualStyleBackColor = true;
            // 
            // CboxOvaloRelleno
            // 
            this.CboxOvaloRelleno.AutoSize = true;
            this.CboxOvaloRelleno.Location = new System.Drawing.Point(84, 212);
            this.CboxOvaloRelleno.Name = "CboxOvaloRelleno";
            this.CboxOvaloRelleno.Size = new System.Drawing.Size(99, 19);
            this.CboxOvaloRelleno.TabIndex = 18;
            this.CboxOvaloRelleno.Text = "Ovalo Relleno";
            this.CboxOvaloRelleno.UseVisualStyleBackColor = true;
            // 
            // CboxRandom
            // 
            this.CboxRandom.AutoSize = true;
            this.CboxRandom.Location = new System.Drawing.Point(84, 237);
            this.CboxRandom.Name = "CboxRandom";
            this.CboxRandom.Size = new System.Drawing.Size(71, 19);
            this.CboxRandom.TabIndex = 19;
            this.CboxRandom.Text = "Random";
            this.CboxRandom.UseVisualStyleBackColor = true;
            // 
            // btnGenerarFiguras
            // 
            this.btnGenerarFiguras.Location = new System.Drawing.Point(32, 262);
            this.btnGenerarFiguras.Name = "btnGenerarFiguras";
            this.btnGenerarFiguras.Size = new System.Drawing.Size(98, 26);
            this.btnGenerarFiguras.TabIndex = 20;
            this.btnGenerarFiguras.Text = "Generar";
            this.btnGenerarFiguras.UseVisualStyleBackColor = true;
            this.btnGenerarFiguras.Click += new System.EventHandler(this.btnGenerarFiguras_Click);
            // 
            // CboxLinea
            // 
            this.CboxLinea.AutoSize = true;
            this.CboxLinea.Location = new System.Drawing.Point(12, 237);
            this.CboxLinea.Name = "CboxLinea";
            this.CboxLinea.Size = new System.Drawing.Size(54, 19);
            this.CboxLinea.TabIndex = 21;
            this.CboxLinea.Text = "Linea";
            this.CboxLinea.UseVisualStyleBackColor = true;
            // 
            // CboxCirculo
            // 
            this.CboxCirculo.AutoSize = true;
            this.CboxCirculo.Location = new System.Drawing.Point(172, 44);
            this.CboxCirculo.Name = "CboxCirculo";
            this.CboxCirculo.Size = new System.Drawing.Size(138, 19);
            this.CboxCirculo.TabIndex = 22;
            this.CboxCirculo.Text = "Seleccion de Circulos";
            this.CboxCirculo.UseVisualStyleBackColor = true;
            this.CboxCirculo.CheckedChanged += new System.EventHandler(this.CboxCirculo_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(172, 69);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(128, 19);
            this.checkBox1.TabIndex = 23;
            this.checkBox1.Text = "Seleccion de Lineas";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(7, 358);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(97, 37);
            this.btnBorrar.TabIndex = 24;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 453);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.CboxCirculo);
            this.Controls.Add(this.CboxLinea);
            this.Controls.Add(this.btnGenerarFiguras);
            this.Controls.Add(this.CboxRandom);
            this.Controls.Add(this.CboxOvaloRelleno);
            this.Controls.Add(this.CboxOvalo);
            this.Controls.Add(this.CboxRectangulo);
            this.Controls.Add(this.CboxCuadradoUnico);
            this.Controls.Add(this.btnGuardarImage);
            this.Controls.Add(this.CboxCuadrado);
            this.Controls.Add(this.btnRGB);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxPapel);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPapel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxPapel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TrackBar trackBar1;
        private TextBox txtR;
        private TextBox txtG;
        private TextBox txtB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnClear;
        private Button btnRGB;
        private CheckBox CboxCuadrado;
        private Button btnGuardarImage;
        private CheckBox CboxCuadradoUnico;
        private CheckBox CboxRectangulo;
        private CheckBox CboxOvalo;
        private CheckBox CboxOvaloRelleno;
        private CheckBox CboxRandom;
        private Button btnGenerarFiguras;
        private CheckBox CboxLinea;
        private CheckBox CboxCirculo;
        private CheckBox checkBox1;
        private Button btnBorrar;
    }
}