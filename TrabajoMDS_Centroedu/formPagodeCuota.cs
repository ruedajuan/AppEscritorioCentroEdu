using iText.IO.Image;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using Image = System.Drawing.Image;

namespace TrabajoMDS_Centroedu
{
    public partial class formPagodeCuota : Form
    {
        string email, nombre, apellido, id_tutor, usuario;
        double intercal, montoPagar;
        int montoBase;
        public formPagodeCuota(string nombre, string apellido, string id_tutor, string usuario, string email)
        {
            InitializeComponent();
            this.email = email;
            this.nombre = nombre;
            this.apellido = apellido;
            this.id_tutor = id_tutor;
            this.usuario = usuario;
            cargarTabla(id_tutor);
            cargarvalores();
            pictureBox1.Visible = false;
            button2.Enabled=false;
            button3.Enabled = false;
            if (id_tutor != null)
            {
                textBox1.Enabled=false;
                textBox2.Enabled = false;
                button4.Visible=false;
            }
            {
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            intercal = interes();
            montoBase = int.Parse(textBox2.Text);
            if (intercal > 1) label9.Text = "10%";
            else label9.Text = "0%";
            montoPagar = intercal * montoBase * int.Parse(label3.Text);
            label6.Text = montoPagar.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
        private void crearPDF(string mesPagado, string montoPagado, string nombre, string apellido)
        {
            DateTime now = DateTime.Now;
            string fechaHoraFormateada = now.ToString("dd/MM/yyyy HH:mm:ss");
            // Crear el cuadro de diálogo para elegir la ubicación del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Comprobante de Pago";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ubicación elegida por el usuario
                string rutaArchivo = saveFileDialog.FileName;

                // Crear el archivo PDF en la ubicación seleccionada
                PdfWriter pdfWriter = new PdfWriter(rutaArchivo);
                PdfDocument pdf = new PdfDocument(pdfWriter);
                Document documento = new Document(pdf);

                // Resto del código para agregar contenido al PDF
                // Obtener la imagen del PictureBox
                Image imagenPictureBox = pictureBox1.Image;

                // Convertir la imagen del PictureBox en un arreglo de bytes
                using (MemoryStream stream = new MemoryStream())
                {
                    imagenPictureBox.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imageBytes = stream.ToArray();

                    // Crear una imagen iText7 a partir de los bytes
                    iText.Layout.Element.Image imagenPdf = new iText.Layout.Element.Image(ImageDataFactory.Create(imageBytes));

                    // Cambiar el tamaño de la imagen (por ejemplo, a 100x100 puntos)
                    imagenPdf.ScaleToFit(100, 100);

                    // Agregar la imagen al documento
                    documento.Add(imagenPdf);
                }

                // Título
                Paragraph titulo2 = new Paragraph("Centro educar para Transformar")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(16);
                documento.Add(titulo2);
                Paragraph titulo = new Paragraph("Comprobante de Pago")
                .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                .SetFontSize(14);
                documento.Add(titulo);
                // Información del comprobante

                Paragraph infoComprobante2 = new Paragraph("Este es un documento emitido por el Instituto Educar para transformar en caracter de recibo por el pago de un arancel.")
                .SetMarginTop(20)
                .SetMarginBottom(10)
                .SetFontSize(10);
                documento.Add(infoComprobante2);
                Paragraph infoComprobante3 = new Paragraph($"Recibí de: {apellido}, {nombre}.")
                    .SetMarginTop(2)
                    .SetMarginBottom(2)
                    .SetFontSize(10);
                documento.Add(infoComprobante3);
                Paragraph infoComprobante = new Paragraph($"Mes Pagado: {mesPagado}\nMonto Pagado: {montoPagado:C} pesos \n Fecha y hora: {fechaHoraFormateada}.")
                    .SetMarginTop(20)
                    .SetMarginBottom(20)
                    .SetFontSize(10);
                documento.Add(infoComprobante);

                // Pie de página
                Paragraph pieDePagina = new Paragraph("Gracias por su pago.")
                    .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                    .SetFontSize(10);
                documento.Add(pieDePagina);

                // Cerrar el documento
                documento.Close();

                MessageBox.Show("Comprobante creado y guardado en " + rutaArchivo);
            }




        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            {
                Modelo mm1 = new Modelo();
                Control control = new Control();
                DateTime fechaActual = DateTime.Now;
                string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
                string modadlidad = modalidadPago();
                string mes_pagado = mesPagado();
                string anio_pago = textBox1.Text;
                mm1.registroPagos(fechaFormateada, id_tutor, modadlidad, label6.Text, mes_pagado,anio_pago);
                string respuesta = control.crlPago();
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pago cargado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                button3.Enabled = true;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string mes_pagado = mesPagado();
            crearPDF(mes_pagado, label6.Text, nombre,apellido);
        }

        public void cargarvalores()
        {
            // Cargar los valores de la configuración de la aplicación y establecerlos en los TextBox
            string textBox1Value = ConfigurationManager.AppSettings["TextBox1Value"];
            string textBox2Value = ConfigurationManager.AppSettings["TextBox2Value"];

            textBox1.Text = textBox1Value;
            textBox2.Text = textBox2Value;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //ver como guardar nuevos valores
            // Guardar los valores de los TextBox en la configuración de la aplicación
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["TextBox1Value"].Value = textBox1.Text;
            config.AppSettings.Settings["TextBox2Value"].Value = textBox2.Text;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
            MessageBox.Show("Cambios guardados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modelo mm1 = new Modelo();
            Control control = new Control();
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
            string modadlidad = modalidadPago();
            string mes_pagado = mesPagado();
            string año_pagar = textBox1.Text;
            mm1.registroPagos(fechaFormateada, id_tutor, modadlidad, label6.Text, mes_pagado,año_pagar);
            string respuesta = control.crlPago();
            if (respuesta.Length > 0)
            {
                MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pago cargado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        public string modalidadPago()
        {
            string modalidad = null;

            if (radioButton11.Checked)
            {
                modalidad = "Debito";
            }
            if (radioButton12.Checked)
            {
                modalidad = "Credito";
            }
            if (radioButton13.Checked)
            {
                modalidad = "Efectivo";
            }
            return modalidad;

        }
        public string mesPagado()
        {
            string mes_pagado = null;
            if (radioButton1.Checked)
            {
                mes_pagado = "Marzo";
            }
            if (radioButton2.Checked)
            {
                mes_pagado = "Abril";
            }
            if (radioButton3.Checked)
            {
                mes_pagado = "Mayo";
            }
            if (radioButton4.Checked)
            {
                mes_pagado = "Junio";
            }
            if (radioButton5.Checked)
            {
                mes_pagado = "Julio";
            }
            if (radioButton6.Checked)
            {
                mes_pagado = "Agosto";
            }
            if (radioButton7.Checked)
            {
                mes_pagado = "Septiembre";
            }
            if (radioButton8.Checked)
            {
                mes_pagado = "Octubre";
            }
            if (radioButton9.Checked)
            {
                mes_pagado = "Noviembre";
            }
            if (radioButton10.Checked)
            {
                mes_pagado = "Diciembre";
            }
            return mes_pagado;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void cargarTabla(string dato)
        {
            List<Alumnos> lista = new List<Alumnos>();
            Modelo md = new Modelo();
            dataGridView1.DataSource = md.alumnosPorTutor(dato);
            List<Object> cantidad = new List<Object>();
            cantidad = md.alumnosPorTutor(dato);
            label3.Text = cantidad.Count.ToString();

        }
        public double interes()
        {
            double interes = 0;
            DateTime fechaActual = DateTime.Now;
            string fechaFormateada = fechaActual.ToString("yyyy-MM-dd");
            string fechaStr1;
            if (radioButton1.Checked)
            {
                fechaStr1 = "2023-03-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;

            }
            if (radioButton2.Checked)
            {
                fechaStr1 = "2023-04-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;

            }
            if (radioButton3.Checked)
            {
                fechaStr1 = "2023-05-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;

            }
            if (radioButton4.Checked)
            {
                fechaStr1 = "2023-06-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;

            }
            if (radioButton5.Checked)
            {
                fechaStr1 = "2023-07-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;

            }
            if (radioButton6.Checked)
            {
                fechaStr1 = "2023-08-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;
            }
            if (radioButton7.Checked)
            {
                fechaStr1 = "2023-09-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;
            }
            if (radioButton8.Checked)
            {
                fechaStr1 = "2023-10-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;
            }
            if (radioButton9.Checked)
            {
                fechaStr1 = "2023-11-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;
            }
            if (radioButton10.Checked)
            {
                fechaStr1 = "2023-12-15";
                DateTime fecha1 = DateTime.ParseExact(fechaStr1, "yyyy-MM-dd", null);
                DateTime fecha2 = DateTime.ParseExact(fechaFormateada, "yyyy-MM-dd", null);
                if (fecha1 < fecha2) interes = 1.1;
                else interes = 1;
            }

            return interes;
        }
    }
}
