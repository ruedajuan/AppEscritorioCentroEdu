﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoMDS_Centroedu
{
    public partial class formaAlumnosMorosos : Form
    {
        public formaAlumnosMorosos()
        {
            InitializeComponent();
            cargarTabla();
            pictureBox1.Visible = false;
        }
        private void cargarTabla()
        {
            List<Alumnos> lista = new List<Alumnos>();
            Modelo md = new Modelo();
            dataGridView1.DataSource = md.alumnosMorosos();

        }
        private void crearPDF()
        {

            // Crear el cuadro de diálogo para elegir la ubicación del archivo
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf";
            saveFileDialog.Title = "Guardar Lista Alumnos morosos";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ubicación elegida por el usuario
                string rutaArchivo = saveFileDialog.FileName;

                // Crear un objeto Document
                Document documento = new Document();

                //margenes
                documento.SetMargins(60, 20, 55, 20);

                // Crear un archivo PDF
                PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                // Obtener la imagen del PictureBox
                System.Drawing.Image imagenWinForms = pictureBox1.Image;

                // Convertir la imagen de WinForms a una imagen iTextSharp
                iTextSharp.text.Image imagenIText = iTextSharp.text.Image.GetInstance(imagenWinForms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imagenIText.ScaleAbsolute(50f, 50f); // Ajusta el tamaño de la imagen según tus necesidades

                // Agregar la imagen al documento
                documento.Add(imagenIText);

                // Agregar un título al PDF
                Paragraph titulo = new Paragraph("Lista de Alumnos morosos");
                titulo.Alignment = Element.ALIGN_CENTER;
                documento.Add(titulo);

                // Agregar espacio entre el título y la tabla
                Chunk espacio = new Chunk(" ");

                documento.Add(espacio);

                // Crear una tabla con las mismas columnas que el DataGridView
                PdfPTable tablaPDF = new PdfPTable(dataGridView1.Columns.Count);

                // Añadir encabezados de columna


                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    tablaPDF.AddCell(new Phrase(dataGridView1.Columns[i].HeaderText));
                }

                // Añadir filas de datos
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (dataGridView1[j, i].Value != null)
                        {
                            tablaPDF.AddCell(new Phrase(dataGridView1[j, i].Value.ToString()));
                        }
                    }
                }

                // Añadir la tabla al documento
                documento.Add(tablaPDF);

                // Cerrar el documento
                documento.Close();

                MessageBox.Show("Lista creada y guardada en " + rutaArchivo);
            }
        }
    }
}
