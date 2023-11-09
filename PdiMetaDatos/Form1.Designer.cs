namespace PdiMetaDatos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tlpPrincipal = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainerPrincipal = new System.Windows.Forms.SplitContainer();
            this.gbListaArchivos = new System.Windows.Forms.GroupBox();
            this.dgvListaArchivos = new System.Windows.Forms.DataGridView();
            this.Archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainerImagenMetadatos = new System.Windows.Forms.SplitContainer();
            this.gbVistaPreviaImagen = new System.Windows.Forms.GroupBox();
            this.gbMetadatos = new System.Windows.Forms.GroupBox();
            this.dgvMetadatos = new System.Windows.Forms.DataGridView();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etiqueta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.cBRecursivo = new System.Windows.Forms.CheckBox();
            this.bAcercaDe = new System.Windows.Forms.Button();
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.bExportarTodos = new System.Windows.Forms.Button();
            this.bExportarActual = new System.Windows.Forms.Button();
            this.tlpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).BeginInit();
            this.splitContainerPrincipal.Panel1.SuspendLayout();
            this.splitContainerPrincipal.Panel2.SuspendLayout();
            this.splitContainerPrincipal.SuspendLayout();
            this.gbListaArchivos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImagenMetadatos)).BeginInit();
            this.splitContainerImagenMetadatos.Panel1.SuspendLayout();
            this.splitContainerImagenMetadatos.Panel2.SuspendLayout();
            this.splitContainerImagenMetadatos.SuspendLayout();
            this.gbVistaPreviaImagen.SuspendLayout();
            this.gbMetadatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadatos)).BeginInit();
            this.panelOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpPrincipal
            // 
            this.tlpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpPrincipal.ColumnCount = 1;
            this.tlpPrincipal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Controls.Add(this.splitContainerPrincipal, 0, 1);
            this.tlpPrincipal.Controls.Add(this.panelOpciones, 0, 0);
            this.tlpPrincipal.Location = new System.Drawing.Point(1, 1);
            this.tlpPrincipal.Name = "tlpPrincipal";
            this.tlpPrincipal.RowCount = 2;
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpPrincipal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPrincipal.Size = new System.Drawing.Size(800, 455);
            this.tlpPrincipal.TabIndex = 0;
            // 
            // splitContainerPrincipal
            // 
            this.splitContainerPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerPrincipal.Location = new System.Drawing.Point(3, 103);
            this.splitContainerPrincipal.Name = "splitContainerPrincipal";
            // 
            // splitContainerPrincipal.Panel1
            // 
            this.splitContainerPrincipal.Panel1.Controls.Add(this.gbListaArchivos);
            // 
            // splitContainerPrincipal.Panel2
            // 
            this.splitContainerPrincipal.Panel2.Controls.Add(this.splitContainerImagenMetadatos);
            this.splitContainerPrincipal.Size = new System.Drawing.Size(794, 349);
            this.splitContainerPrincipal.SplitterDistance = 264;
            this.splitContainerPrincipal.TabIndex = 0;
            // 
            // gbListaArchivos
            // 
            this.gbListaArchivos.Controls.Add(this.dgvListaArchivos);
            this.gbListaArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbListaArchivos.Location = new System.Drawing.Point(0, 0);
            this.gbListaArchivos.Name = "gbListaArchivos";
            this.gbListaArchivos.Size = new System.Drawing.Size(264, 349);
            this.gbListaArchivos.TabIndex = 0;
            this.gbListaArchivos.TabStop = false;
            this.gbListaArchivos.Text = "Lista de Archivos";
            // 
            // dgvListaArchivos
            // 
            this.dgvListaArchivos.AllowDrop = true;
            this.dgvListaArchivos.AllowUserToAddRows = false;
            this.dgvListaArchivos.AllowUserToDeleteRows = false;
            this.dgvListaArchivos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvListaArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaArchivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Archivo});
            this.dgvListaArchivos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListaArchivos.Location = new System.Drawing.Point(3, 16);
            this.dgvListaArchivos.Name = "dgvListaArchivos";
            this.dgvListaArchivos.ReadOnly = true;
            this.dgvListaArchivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaArchivos.Size = new System.Drawing.Size(258, 330);
            this.dgvListaArchivos.TabIndex = 0;
            this.dgvListaArchivos.SelectionChanged += new System.EventHandler(this.dgvListaArchivos_SelectionChanged);
            this.dgvListaArchivos.DragDrop += new System.Windows.Forms.DragEventHandler(this.dgvListaArchivos_DragDrop);
            this.dgvListaArchivos.DragEnter += new System.Windows.Forms.DragEventHandler(this.dgvListaArchivos_DragEnter);
            // 
            // Archivo
            // 
            this.Archivo.HeaderText = "Archivo";
            this.Archivo.Name = "Archivo";
            this.Archivo.ReadOnly = true;
            // 
            // splitContainerImagenMetadatos
            // 
            this.splitContainerImagenMetadatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerImagenMetadatos.Location = new System.Drawing.Point(0, 0);
            this.splitContainerImagenMetadatos.Name = "splitContainerImagenMetadatos";
            this.splitContainerImagenMetadatos.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerImagenMetadatos.Panel1
            // 
            this.splitContainerImagenMetadatos.Panel1.Controls.Add(this.gbVistaPreviaImagen);
            // 
            // splitContainerImagenMetadatos.Panel2
            // 
            this.splitContainerImagenMetadatos.Panel2.Controls.Add(this.gbMetadatos);
            this.splitContainerImagenMetadatos.Size = new System.Drawing.Size(526, 349);
            this.splitContainerImagenMetadatos.SplitterDistance = 177;
            this.splitContainerImagenMetadatos.TabIndex = 0;
            // 
            // gbVistaPreviaImagen
            // 
            this.gbVistaPreviaImagen.Controls.Add(this.pbPreview);
            this.gbVistaPreviaImagen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbVistaPreviaImagen.Location = new System.Drawing.Point(0, 0);
            this.gbVistaPreviaImagen.Name = "gbVistaPreviaImagen";
            this.gbVistaPreviaImagen.Size = new System.Drawing.Size(526, 177);
            this.gbVistaPreviaImagen.TabIndex = 0;
            this.gbVistaPreviaImagen.TabStop = false;
            this.gbVistaPreviaImagen.Text = "Vista Previa";
            // 
            // gbMetadatos
            // 
            this.gbMetadatos.Controls.Add(this.dgvMetadatos);
            this.gbMetadatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMetadatos.Location = new System.Drawing.Point(0, 0);
            this.gbMetadatos.Name = "gbMetadatos";
            this.gbMetadatos.Size = new System.Drawing.Size(526, 168);
            this.gbMetadatos.TabIndex = 0;
            this.gbMetadatos.TabStop = false;
            this.gbMetadatos.Text = "MetaDatos";
            // 
            // dgvMetadatos
            // 
            this.dgvMetadatos.AllowUserToAddRows = false;
            this.dgvMetadatos.AllowUserToDeleteRows = false;
            this.dgvMetadatos.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            this.dgvMetadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMetadatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Categoria,
            this.Etiqueta,
            this.Descripción});
            this.dgvMetadatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMetadatos.Location = new System.Drawing.Point(3, 16);
            this.dgvMetadatos.Name = "dgvMetadatos";
            this.dgvMetadatos.ReadOnly = true;
            this.dgvMetadatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMetadatos.Size = new System.Drawing.Size(520, 149);
            this.dgvMetadatos.TabIndex = 0;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // Etiqueta
            // 
            this.Etiqueta.HeaderText = "Etiqueta";
            this.Etiqueta.Name = "Etiqueta";
            this.Etiqueta.ReadOnly = true;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.Name = "Descripción";
            this.Descripción.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(801, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.bAcercaDe);
            this.panelOpciones.Controls.Add(this.bExportarTodos);
            this.panelOpciones.Controls.Add(this.bExportarActual);
            this.panelOpciones.Controls.Add(this.cBRecursivo);
            this.panelOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOpciones.Location = new System.Drawing.Point(3, 3);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(794, 94);
            this.panelOpciones.TabIndex = 1;
            // 
            // cBRecursivo
            // 
            this.cBRecursivo.AutoSize = true;
            this.cBRecursivo.Checked = true;
            this.cBRecursivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBRecursivo.Location = new System.Drawing.Point(8, 8);
            this.cBRecursivo.Name = "cBRecursivo";
            this.cBRecursivo.Size = new System.Drawing.Size(124, 17);
            this.cBRecursivo.TabIndex = 0;
            this.cBRecursivo.Text = "Incluir Subdirectorios";
            this.cBRecursivo.UseVisualStyleBackColor = true;
            // 
            // bAcercaDe
            // 
            this.bAcercaDe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bAcercaDe.Image = global::PdiMetaDatos.Properties.Resources.help;
            this.bAcercaDe.Location = new System.Drawing.Point(297, 8);
            this.bAcercaDe.Name = "bAcercaDe";
            this.bAcercaDe.Size = new System.Drawing.Size(137, 83);
            this.bAcercaDe.TabIndex = 3;
            this.bAcercaDe.Text = "Acerca de...";
            this.bAcercaDe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bAcercaDe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAcercaDe.UseVisualStyleBackColor = true;
            // 
            // pbPreview
            // 
            this.pbPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbPreview.Location = new System.Drawing.Point(3, 16);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(520, 158);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // bExportarTodos
            // 
            this.bExportarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExportarTodos.Image = global::PdiMetaDatos.Properties.Resources.excel_exports;
            this.bExportarTodos.Location = new System.Drawing.Point(505, 8);
            this.bExportarTodos.Name = "bExportarTodos";
            this.bExportarTodos.Size = new System.Drawing.Size(137, 83);
            this.bExportarTodos.TabIndex = 2;
            this.bExportarTodos.Text = "Exportar Todos";
            this.bExportarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bExportarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExportarTodos.UseVisualStyleBackColor = true;
            // 
            // bExportarActual
            // 
            this.bExportarActual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bExportarActual.Image = global::PdiMetaDatos.Properties.Resources.excel_exports;
            this.bExportarActual.Location = new System.Drawing.Point(648, 8);
            this.bExportarActual.Name = "bExportarActual";
            this.bExportarActual.Size = new System.Drawing.Size(137, 83);
            this.bExportarActual.TabIndex = 1;
            this.bExportarActual.Text = "Exportar Actual";
            this.bExportarActual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bExportarActual.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bExportarActual.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 481);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tlpPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(817, 520);
            this.Name = "Form1";
            this.Text = "FGJCDMX - Análisis de Metadatos";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tlpPrincipal.ResumeLayout(false);
            this.splitContainerPrincipal.Panel1.ResumeLayout(false);
            this.splitContainerPrincipal.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerPrincipal)).EndInit();
            this.splitContainerPrincipal.ResumeLayout(false);
            this.gbListaArchivos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaArchivos)).EndInit();
            this.splitContainerImagenMetadatos.Panel1.ResumeLayout(false);
            this.splitContainerImagenMetadatos.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerImagenMetadatos)).EndInit();
            this.splitContainerImagenMetadatos.ResumeLayout(false);
            this.gbVistaPreviaImagen.ResumeLayout(false);
            this.gbMetadatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMetadatos)).EndInit();
            this.panelOpciones.ResumeLayout(false);
            this.panelOpciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPrincipal;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainerPrincipal;
        private System.Windows.Forms.GroupBox gbListaArchivos;
        private System.Windows.Forms.DataGridView dgvListaArchivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Archivo;
        private System.Windows.Forms.SplitContainer splitContainerImagenMetadatos;
        private System.Windows.Forms.GroupBox gbVistaPreviaImagen;
        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.GroupBox gbMetadatos;
        private System.Windows.Forms.DataGridView dgvMetadatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etiqueta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.CheckBox cBRecursivo;
        private System.Windows.Forms.Button bExportarTodos;
        private System.Windows.Forms.Button bExportarActual;
        private System.Windows.Forms.Button bAcercaDe;
    }
}

