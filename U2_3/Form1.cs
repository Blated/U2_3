using System.Windows.Forms;

namespace U2_3
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private bool isDrawingCircle = false;   
        private Point startPoint;
        private Point currentPoint;
        private Rectangle square;
        private Rectangle circle;
        private Point? _prevPoint;
        private bool _drawLine;
        Pen Lapiz;
        Brush brocha;
        Graphics papel;
        int anchoPluma = 3;
        int x = 0, y = 0;
        bool moving;
        Pen pen;
        Color colores;
        byte r = 0;
        byte g = 0;
        byte b = 0;

        public Form1()
        {
            InitializeComponent();
            //Aqui asignamos nuestra propiedad graphics a nuestro pictureBox
            papel = pictureBoxPapel.CreateGraphics();
            colores = Color.Black;
             Lapiz = new Pen(Color.Black, anchoPluma);
             brocha = new SolidBrush(colores);
            //Para que los trazos sobre el picBox esten suavizados
            pen = new Pen(Color.Black, anchoPluma);
            //Cuando dibuje suaviza el trazo
            pictureBoxPapel.Image = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height);
            papel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        }
        //CODIGO PLUS+
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        private void CboxCuadrado_CheckedChanged(object sender, EventArgs e)
        {    
            // Verifica si el CheckBox está marcado.
            if (CboxCuadrado.Checked)
            {
                // Cambia el cursor del PictureBox a un cursor en forma de cruz.
                pictureBoxPapel.Cursor = Cursors.Cross;
            }
            else
            {      
                // Cambia el cursor del PictureBox al cursor predeterminado.
                pictureBoxPapel.Cursor = Cursors.Default;
            }
        }
        
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificar si el botón izquierdo del mouse está presionado y si se debe dibujar una línea
            if (e.Button == MouseButtons.Left && _drawLine)
            {
                // Almacenar la posición actual del mouse como el punto anterior
                _prevPoint = e.Location;
            }
            else
            {
                // Verifica si el CheckBox está marcado.
                if (CboxCirculo.Checked)
                {
                    // Activa el modo de dibujo de circulo.
                    isDrawingCircle = true;
                    // Guarda la ubicación inicial del mouse como el punto de inicio.
                    startPoint = e.Location;
                    // Establece el punto actual en el punto de inicio.
                    currentPoint = startPoint;
                    // Crea un nuevo rectángulo para representar el cuadrado.
                    circle = new Rectangle(startPoint, new Size(0, 0));
                    // Invalida el PictureBox para forzar el repintado.
                    pictureBoxPapel.Invalidate();
                }
                else
                {
                    // Verifica si el CheckBox está marcado.

                    if (CboxCuadrado.Checked)
                    {

                        // Activa el modo de dibujo de cuadrado.
                        isDrawing = true;
                        // Guarda la ubicación inicial del mouse como el punto de inicio.
                        startPoint = e.Location;
                        // Establece el punto actual en el punto de inicio.
                        currentPoint = startPoint;
                        // Crea un nuevo rectángulo para representar el cuadrado.
                        square = new Rectangle(startPoint, new Size(0, 0));
                        // Invalida el PictureBox para forzar el repintado.
                        pictureBoxPapel.Invalidate();

                    }
                    else
                    {
                        moving = true;
                        x = e.X;
                    }
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Verificar si se ha almacenado un punto anterior y si el botón izquierdo del mouse está presionado y si se debe dibujar una línea
            if (_prevPoint.HasValue && e.Button == MouseButtons.Left && _drawLine)
            {
                cambiarValoresPluma();
                // Invalidar el PictureBox para forzar un repintado
                pictureBoxPapel.Invalidate();
            }
            if (moving)
            {
                papel.DrawLine(pen, new Point(x, y), e.Location);
                x = e.X; y = e.Y;
                cambiarValoresPluma();
            }
            // Verifica si el modo de dibujo está activado.

            if (isDrawing)
            {
                cambiarValoresPluma();
                // Actualiza la posición actual del mouse y el rectángulo que representa el cuadrado.
                currentPoint = e.Location;
                int x = Math.Min(startPoint.X, currentPoint.X);
                int y = Math.Min(startPoint.Y, currentPoint.Y);
                int width = Math.Abs(startPoint.X - currentPoint.X);
                int height = Math.Abs(startPoint.Y - currentPoint.Y);
                square = new Rectangle(x, y, width, height);
                // Invalida el PictureBox para forzar el repintado.
                pictureBoxPapel.Invalidate();
            }

            if (isDrawingCircle)
            {
                cambiarValoresPluma();
                currentPoint = e.Location;
                // Actualiza la posición actual del mouse y el rectángulo que representa el cuadrado.
                int x = Math.Min(startPoint.X, currentPoint.X);
                int y = Math.Min(startPoint.Y, currentPoint.Y);
                int width = Math.Abs(startPoint.X - currentPoint.X);
                int height = Math.Abs(startPoint.Y - currentPoint.Y);
                int diameter = Math.Min(width, height);
                circle = new Rectangle(x, y, diameter, diameter);
                // Invalida el PictureBox para forzar el repintado.
                pictureBoxPapel.Invalidate();
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Verificar si el botón izquierdo del mouse está presionado y si se debe dibujar una línea
            if (e.Button == MouseButtons.Left && _drawLine)
            {
                // Obtener un objeto Graphics para el PictureBox
                using (Graphics g = Graphics.FromImage(pictureBoxPapel.Image))
                {
                    // Dibujar una línea desde el punto anterior hasta la posición actual del mouse
                    g.DrawLine(pen, _prevPoint.Value, e.Location);
                }
                // Invalidar el PictureBox para forzar un repintado
                pictureBoxPapel.Invalidate();
                // Establecer el punto anterior a nulo
                _prevPoint = null;
            }

            // Verifica si el modo de dibujo está activado.
            if (isDrawingCircle)
            {
                // Dibuja el circulo final en el PictureBox.
                using (Graphics g = Graphics.FromImage(pictureBoxPapel.Image))
                {
                    g.DrawEllipse(pen, circle);
                }
                // Invalida el PictureBox para forzar el repintado.
                pictureBoxPapel.Invalidate();
                // Desactiva el modo de dibujo.
                isDrawingCircle = false;
            }
            else
            {
                // Verifica si el modo de dibujo está activado.
                if (isDrawing)
                {
                    // Dibuja el cuadrado final en el PictureBox.
                    using (Graphics g = Graphics.FromImage(pictureBoxPapel.Image))
                    {

                        g.DrawRectangle(pen, square);
                    }
                    // Invalida el PictureBox para forzar el repintado.
                    pictureBoxPapel.Invalidate();
                    // Desactiva el modo de dibujo.
                    isDrawing = false;
                }
                else
                {
                    moving = false;

                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Verificar si se ha almacenado un punto anterior y si se debe dibujar una línea
            if (_prevPoint.HasValue && _drawLine)
            {
                // Dibujar una línea desde el punto anterior hasta la posición actual del mouse
                e.Graphics.DrawLine(pen, _prevPoint.Value, pictureBoxPapel.PointToClient(MousePosition));
            }

            // Verifica si el modo de dibujo está activado.
            if (isDrawing)
            {
                // Dibuja el cuadrado previsualizado.
                e.Graphics.DrawRectangle(pen, square);
            }
            // Verifica si el modo de dibujo está activado.
            if (isDrawingCircle)
            {
                // Dibuja el circulo previsualizado.

                e.Graphics.DrawEllipse(pen, circle);
            }

        }

        private void CboxCirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (CboxCirculo.Checked)
            {
                pictureBoxPapel.Cursor = Cursors.Cross;
            }
            else
            {
                pictureBoxPapel.Cursor = Cursors.Default;
            }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------


        private void trackBar1_Scroll_1(object sender, EventArgs e)
     {
         anchoPluma = trackBar1.Value;
     }

     private void cambiarValoresPluma()
     {
         pen = new Pen(Color.Black, anchoPluma);
         Lapiz = new Pen(Color.Black, anchoPluma);


            if (colores != null)
         {
             pen.Color = colores;
                Lapiz.Color = colores;
             //Los trazos inicien y terminen de forma ovalada
             pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

         }
         else
         {
             pen = new Pen(Color.Black, anchoPluma);
             Lapiz = new Pen(Color.Black, anchoPluma);
                pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
         }
     }
     
        
        

    //Evento que ocurre al hacer clic al boton Limpiar
    private void btnClear_Click(object sender, EventArgs e)
        {
            //ELIMINAR
            pictureBoxPapel.Image = null;
            pictureBoxPapel.Refresh();
            pictureBoxPapel.Image = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height);


        }
   
        //Evento que ocurre al hacer clic al boton RGB

        private void btnRGB_Click(object sender, EventArgs e)
        {

            int r = 0, g = 0, b = 0;
            if (int.TryParse(txtR.Text, out r) && int.TryParse(txtG.Text, out g) && int.TryParse(txtB.Text, out b))
            {
                if (r >= 0 && r <= 255 && g >= 0 && g <= 255 && b >= 0 && b <= 255)
                {
                    pen.Color = Color.FromArgb(r, g, b);
                    txtB.BackColor = Color.FromArgb(0, 0, b);
                    txtG.BackColor = Color.FromArgb(0, g, 0);
                    txtR.BackColor = Color.FromArgb(r, 0, 0);
                    pictureBox2.BackColor = Color.FromArgb(r, g, b);
                    Lapiz.Color = Color.FromArgb(r, g, b);
                    brocha = new SolidBrush(Color.FromArgb(r,g,b));

                    colores = Color.FromArgb(r, g, b);  
                    if (r == 0 || g == 0 || b == 0)
                    {
                        if (r == 0 && g != 0 && b != 0)
                        {
                            txtR.ForeColor = Color.FromArgb(255, 255, 255);

                        }
                        if (r != 0 && g == 0 && b != 0)
                        {
                            txtG.ForeColor = Color.FromArgb(255, 255, 255);

                        }
                        if (r != 0 && g != 0 && b == 0)
                        {
                            txtB.ForeColor = Color.FromArgb(255, 255, 255);

                        }
                        txtB.ForeColor = Color.FromArgb(255, 255, 255);
                        txtG.ForeColor = Color.FromArgb(255, 255, 255);
                        txtR.ForeColor = Color.FromArgb(255, 255, 255);
                    }
                    else
                    {
                        txtB.ForeColor = Color.FromArgb(255, 255, 255);
                        txtG.ForeColor = Color.FromArgb(255, 255, 255);
                        txtR.ForeColor = Color.FromArgb(255, 255, 255);
                    }

                }
                else
                {
                    MessageBox.Show("Ingrese valores R, G y B válidos (entre 0 y 255).");
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numéricos para R, G y B.");
            }
        }
        private void txtR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardarImage_Click(object sender, EventArgs e)
        {
            // Crea un objeto Bitmap del tamaño del PictureBox
            Bitmap bmp = new Bitmap(pictureBoxPapel.Width, pictureBoxPapel.Height);

            // Dibuja el contenido del PictureBox en el Bitmap
            pictureBoxPapel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

            // Muestra un cuadro de diálogo para guardar el archivo
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Archivos de imagen|*.bmp;*.jpg;*.png";
            saveFileDialog1.Title = "Guardar imagen como...";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Guarda el archivo en el formato seleccionado
                bmp.Save(saveFileDialog1.FileName);
            }
        }
        //Evento que ocurre al hacer clic al boton Colores

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColorDialog dialogoColor = new ColorDialog();
            if (dialogoColor.ShowDialog() == DialogResult.OK)
            {
                colorsrgb(dialogoColor, false);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ColorDialog dialogoColor = new ColorDialog();
            if (dialogoColor.ShowDialog() == DialogResult.OK)
            {
                colorsrgb(dialogoColor, true);
        
            }
        }

        private void colorsrgb(ColorDialog dialogoColor, bool picture)
        {
            pen.Color = dialogoColor.Color;
            colores = dialogoColor.Color;
            brocha = new SolidBrush(dialogoColor.Color);
            Lapiz.Color = dialogoColor.Color;
            txtR.Text = dialogoColor.Color.R.ToString();
            txtG.Text = dialogoColor.Color.G.ToString();
            txtB.Text = dialogoColor.Color.B.ToString();
            txtB.BackColor = Color.FromArgb(0, 0, int.Parse(txtB.Text));
            txtG.BackColor = Color.FromArgb(0, int.Parse(txtG.Text), 0);
            txtR.BackColor = Color.FromArgb(int.Parse(txtR.Text), 0, 0);
            txtB.ForeColor = Color.FromArgb(255, 255, 255);
            txtG.ForeColor = Color.FromArgb(255, 255, 255);
            txtR.ForeColor = Color.FromArgb(255, 255, 255);


            if (picture)
            {
                pictureBox3.BackColor = dialogoColor.Color;

            }
            else
            {
                pictureBox2.BackColor = dialogoColor.Color;
            }
        }

        private void btnGenerarFiguras_Click(object sender, EventArgs e)
        {

            //DIBUJAR
            if (CboxLinea.Checked)
            {
                cambiarValoresPluma();
                papel.DrawRectangle(Lapiz, 50, 50, 1, 100);

            }
            if (CboxRectangulo.Checked)
            {
                cambiarValoresPluma();
                papel.DrawRectangle(Lapiz, 10, 10, 100, 50);
            }
            if (CboxCuadradoUnico.Checked)
            {
                cambiarValoresPluma();
                papel.DrawRectangle(Lapiz, 80, 80, 50, 50);
            }
            if (CboxOvalo.Checked)
            {
                cambiarValoresPluma();
                Rectangle rect = new Rectangle(100, 100, 150, 100);
                papel.DrawEllipse(Lapiz, rect);
            }
            if (CboxOvaloRelleno.Checked)
            {
                cambiarValoresPluma();
                Rectangle rect = new Rectangle(150, 50, 150, 100);
                papel.FillEllipse(brocha, rect);
            }
            if (CboxRandom.Checked && CboxLinea.Checked)
            {
                Random rnd = new Random();
                int x = rnd.Next(pictureBoxPapel.Width - 100);
                int y = rnd.Next(pictureBoxPapel.Height - 100);
                int ancho = rnd.Next(1, 1);
                int alto = rnd.Next(50, 101);
                Rectangle rect = new Rectangle(x, y, ancho, alto);
                papel.DrawRectangle(Lapiz, rect);
            }
            if (CboxRandom.Checked && CboxRectangulo.Checked)
            {
                Random rnd = new Random();
                int x = rnd.Next(pictureBoxPapel.Width - 100);
                int y = rnd.Next(pictureBoxPapel.Height - 100);
                int ancho = rnd.Next(80, 80);
                int alto = rnd.Next(50, 50);
                Rectangle rect = new Rectangle(x, y, ancho, alto);
                papel.DrawRectangle(Lapiz, rect);
            }
            if (CboxRandom.Checked && CboxCuadrado.Checked)
            {

                Random rnd = new Random();
                int x = rnd.Next(pictureBoxPapel.Width - 100);
                int y = rnd.Next(pictureBoxPapel.Height - 100);
                int ancho = rnd.Next(50, 50);
                int alto = rnd.Next(50, 50);
                Rectangle rect = new Rectangle(x, y, ancho, alto);
                papel.DrawRectangle(Lapiz, rect);
            }
            if (CboxOvalo.Checked && CboxRandom.Checked)
            {
                Random rnd = new Random();
                int x = rnd.Next(pictureBoxPapel.Width - 100);
                int y = rnd.Next(pictureBoxPapel.Height - 100);
                int ancho = rnd.Next(50, 101);
                int alto = rnd.Next(50, 101);
                Rectangle rect = new Rectangle(x, y, ancho, alto);
                papel.DrawEllipse(Lapiz, rect);
            }
            if (CboxOvaloRelleno.Checked && CboxRandom.Checked)
            {
                Random rnd = new Random();
                int x = rnd.Next(pictureBoxPapel.Width - 100);
                int y = rnd.Next(pictureBoxPapel.Height - 100);
                int ancho = rnd.Next(50, 101);
                int alto = rnd.Next(50, 101);
                Rectangle rect = new Rectangle(x, y, ancho, alto);
                papel.FillEllipse(brocha, rect);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _drawLine = checkBox1.Checked;

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pen.Color = Color.FromArgb(255, 255, 255);
            colores = Color.FromArgb(255, 255, 255);
        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //TODO: Pasar las figuras a este programa
        // * Plus: arrastrar la figura como se va a dibujar y darle tamano EXENTO 
        //TODO: Boton para guardar el dibujo

    }
}