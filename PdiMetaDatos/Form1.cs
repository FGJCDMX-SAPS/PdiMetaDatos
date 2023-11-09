﻿using ImageMagick;
using MetadataExtractor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PdiMetaDatos
{
    public partial class Form1 : Form
    {
        bool calculando { get; set; }
        bool cancelar { get; set; }

        Task TareaAgregarArchivosLista { get; set; }
        CancellationTokenSource CTStoken { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {

        }

        private async void dgvListaArchivos_DragDrop(object sender, DragEventArgs e)
        {
            List<string> lista_archivos = new List<string>();

            // Checa si es un archivo/carpeta
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {

                //Tarea que genera la lista de archivos antes de llenar datagridview
                TareaAgregarArchivosLista = Task.Run(() =>
                {
                    // obten la lista de los que se arrastraron (lista original)
                    string[] archivos = (string[])e.Data.GetData(DataFormats.FileDrop);

                    // Comprueba para cada elemento que tipo es,si archivo o carpeta
                    foreach (string elemento in archivos)
                    {
                        FileAttributes attr = File.GetAttributes(elemento);
                        bool esFolder = (attr & FileAttributes.Directory) == FileAttributes.Directory;

                        // Si es un folder, obten todos los elementos del mismo (con posible recursion) y los agrega a las lista
                        if (esFolder)
                        {
                            string[] sub_archivos = System.IO.Directory.GetFiles(elemento, "*",
                                (cBRecursivo.Checked) ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly)
                            .Where(s => 
                            s.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                            s.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                            s.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                            s.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                            s.EndsWith(".heic", StringComparison.OrdinalIgnoreCase) ||
                            s.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                            s.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase)
                            )
                            .ToArray();
                            ;
                            if (sub_archivos.Length > 0)
                            {
                                lista_archivos.AddRange(sub_archivos);
                            }
                        }
                        else
                        {
                            // si solo estaba seleccionado un archivo, lo agrega a la lista
                            if (
                            elemento.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                            elemento.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                            elemento.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                            elemento.EndsWith(".gif", StringComparison.OrdinalIgnoreCase) ||
                            elemento.EndsWith(".heic", StringComparison.OrdinalIgnoreCase) ||
                            elemento.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase) ||
                            elemento.EndsWith(".tiff", StringComparison.OrdinalIgnoreCase)
                            )
                            {
                                lista_archivos.Add(elemento);
                            }
                        }
                    }

                });
                await TareaAgregarArchivosLista;



                dgvListaArchivos.Rows.Clear();
                dgvListaArchivos.Rows.Add();
                DataGridViewRow rbase = (DataGridViewRow)dgvListaArchivos.Rows[0].Clone();
                dgvListaArchivos.Rows.Clear();

                List<DataGridViewRow> listadgv_files = new List<DataGridViewRow>();

                IProgress<List<DataGridViewRow>> ProgLista = new Progress<List<DataGridViewRow>>((val) =>
                {
                    dgvListaArchivos.Rows.AddRange(val.ToArray());
                });
                TareaAgregarArchivosLista = Task.Run(() =>
                {
                    //hace vaciado de lista en la tabla
                    for (int i = 0; i < lista_archivos.Count; i++)
                    {
                        var r_temp = (DataGridViewRow)rbase.Clone();
                        r_temp.Cells[0].Value = lista_archivos[i];

                        listadgv_files.Add(r_temp);
                    }

                    ProgLista.Report(listadgv_files);
                });

                await TareaAgregarArchivosLista;

                dgvListaArchivos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);


            }
        }
        private void dgvListaArchivos_DragEnter(object sender, DragEventArgs e)
        {
            // Si el mouse que arrrastra algo, pasa por el contenedor y es un archivo/folder, se copia el origen
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void dgvListaArchivos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListaArchivos.CurrentRow == null)
            {
                return;
            }
            if (dgvListaArchivos.CurrentRow == null)
            {
                return;
            }
            if (dgvListaArchivos.CurrentRow.Index < 0)
            {
                return;
            }
            if (dgvListaArchivos.SelectedRows.Count <= 0)
            {
                return;
            }
            if(dgvListaArchivos.SelectedRows[0].Cells["Archivo"].Value == null)
            {
                return;
            }

            string nombre_archivo = dgvListaArchivos.SelectedRows[0].Cells["Archivo"].Value.ToString();

            try
            {
                MagickImage imagen = new MagickImage(nombre_archivo);
                var mstream = new MemoryStream();
                imagen.Write(mstream, MagickFormat.Bmp);
                var r = new System.Drawing.Bitmap(mstream);
                pbPreview.Image = r;
            }
            catch (Exception)
            {

               // throw;
            }
            finally
            {

            }

            dgvMetadatos.Rows.Clear();

            var directories = ImageMetadataReader.ReadMetadata(nombre_archivo);

            //string resultado = "";

            foreach (var directory in directories)
            {
                foreach (var tag in directory.Tags)
                {
                    dgvMetadatos.Rows.Add(new object[] { directory.Name, tag.Name, tag.Description });
                }
                if (directory.HasError)
                {
                    foreach (var error in directory.Errors)
                    {
                        //textBoxDatos.AppendText("ERROR: "+error);
                        //textBoxDatos.AppendText(Environment.NewLine);
                        //MessageBox.Show(error, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            dgvMetadatos.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);


        }
        
    }
}
