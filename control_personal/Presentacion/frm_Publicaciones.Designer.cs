namespace control_personal
{
    partial class frm_Publicaciones
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
            this.components = new System.ComponentModel.Container();
            this.lbl_idPublicacion = new System.Windows.Forms.Label();
            this.lbl_idPersonal = new System.Windows.Forms.Label();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.lbl_fechaPublicacion = new System.Windows.Forms.Label();
            this.lbl_institucion = new System.Windows.Forms.Label();
            this.bDFocusDataSet = new control_personal.BDFocusDataSet();
            this.publicacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.publicacionesTableAdapter = new control_personal.BDFocusDataSetTableAdapters.PublicacionesTableAdapter();
            this.tableAdapterManager = new control_personal.BDFocusDataSetTableAdapters.TableAdapterManager();
            this.txt_idPublicacion = new System.Windows.Forms.TextBox();
            this.txt_idPersonal = new System.Windows.Forms.TextBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_tipo = new System.Windows.Forms.TextBox();
            this.dtp_fechaPublicacion = new System.Windows.Forms.DateTimePicker();
            this.txt_institucion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idPublicacion
            // 
            this.lbl_idPublicacion.AutoSize = true;
            this.lbl_idPublicacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idPublicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idPublicacion.Location = new System.Drawing.Point(167, 537);
            this.lbl_idPublicacion.Name = "lbl_idPublicacion";
            this.lbl_idPublicacion.Size = new System.Drawing.Size(94, 16);
            this.lbl_idPublicacion.TabIndex = 1;
            this.lbl_idPublicacion.Text = "Id Publicacion:";
            // 
            // lbl_idPersonal
            // 
            this.lbl_idPersonal.AutoSize = true;
            this.lbl_idPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idPersonal.Location = new System.Drawing.Point(167, 565);
            this.lbl_idPersonal.Name = "lbl_idPersonal";
            this.lbl_idPersonal.Size = new System.Drawing.Size(78, 16);
            this.lbl_idPersonal.TabIndex = 3;
            this.lbl_idPersonal.Text = "Id Personal:";
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_titulo.Location = new System.Drawing.Point(167, 593);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(43, 16);
            this.lbl_titulo.TabIndex = 5;
            this.lbl_titulo.Text = "Titulo:";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tipo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_tipo.Location = new System.Drawing.Point(533, 540);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(38, 16);
            this.lbl_tipo.TabIndex = 7;
            this.lbl_tipo.Text = "Tipo:";
            // 
            // lbl_fechaPublicacion
            // 
            this.lbl_fechaPublicacion.AutoSize = true;
            this.lbl_fechaPublicacion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaPublicacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fechaPublicacion.Location = new System.Drawing.Point(533, 569);
            this.lbl_fechaPublicacion.Name = "lbl_fechaPublicacion";
            this.lbl_fechaPublicacion.Size = new System.Drawing.Size(121, 16);
            this.lbl_fechaPublicacion.TabIndex = 9;
            this.lbl_fechaPublicacion.Text = "Fecha Publicacion:";
            // 
            // lbl_institucion
            // 
            this.lbl_institucion.AutoSize = true;
            this.lbl_institucion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_institucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_institucion.Location = new System.Drawing.Point(533, 596);
            this.lbl_institucion.Name = "lbl_institucion";
            this.lbl_institucion.Size = new System.Drawing.Size(68, 16);
            this.lbl_institucion.TabIndex = 11;
            this.lbl_institucion.Text = "Institucion:";
            // 
            // bDFocusDataSet
            // 
            this.bDFocusDataSet.DataSetName = "BDFocusDataSet";
            this.bDFocusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // publicacionesBindingSource
            // 
            this.publicacionesBindingSource.DataMember = "Publicaciones";
            this.publicacionesBindingSource.DataSource = this.bDFocusDataSet;
            // 
            // publicacionesTableAdapter
            // 
            this.publicacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.PublicacionesTableAdapter = this.publicacionesTableAdapter;
            this.tableAdapterManager.TitulosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_personal.BDFocusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_idPublicacion
            // 
            this.txt_idPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publicacionesBindingSource, "IdPublicacion", true));
            this.txt_idPublicacion.Enabled = false;
            this.txt_idPublicacion.Location = new System.Drawing.Point(294, 534);
            this.txt_idPublicacion.Name = "txt_idPublicacion";
            this.txt_idPublicacion.Size = new System.Drawing.Size(200, 22);
            this.txt_idPublicacion.TabIndex = 2;
            // 
            // txt_idPersonal
            // 
            this.txt_idPersonal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publicacionesBindingSource, "IdPersonal", true));
            this.txt_idPersonal.Enabled = false;
            this.txt_idPersonal.Location = new System.Drawing.Point(294, 562);
            this.txt_idPersonal.Name = "txt_idPersonal";
            this.txt_idPersonal.Size = new System.Drawing.Size(200, 22);
            this.txt_idPersonal.TabIndex = 4;
            // 
            // txt_titulo
            // 
            this.txt_titulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publicacionesBindingSource, "Titulo", true));
            this.txt_titulo.Location = new System.Drawing.Point(294, 590);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(200, 22);
            this.txt_titulo.TabIndex = 6;
            // 
            // txt_tipo
            // 
            this.txt_tipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publicacionesBindingSource, "Tipo", true));
            this.txt_tipo.Location = new System.Drawing.Point(660, 537);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(200, 22);
            this.txt_tipo.TabIndex = 8;
            // 
            // dtp_fechaPublicacion
            // 
            this.dtp_fechaPublicacion.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.publicacionesBindingSource, "FechaPublicacion", true));
            this.dtp_fechaPublicacion.Location = new System.Drawing.Point(660, 565);
            this.dtp_fechaPublicacion.Name = "dtp_fechaPublicacion";
            this.dtp_fechaPublicacion.Size = new System.Drawing.Size(248, 22);
            this.dtp_fechaPublicacion.TabIndex = 10;
            // 
            // txt_institucion
            // 
            this.txt_institucion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.publicacionesBindingSource, "Institucion", true));
            this.txt_institucion.Location = new System.Drawing.Point(660, 593);
            this.txt_institucion.Name = "txt_institucion";
            this.txt_institucion.Size = new System.Drawing.Size(200, 22);
            this.txt_institucion.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 293);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(554, 647);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 41;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(912, 647);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 28);
            this.btn_atras.TabIndex = 40;
            this.btn_atras.Text = "ATRAS";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.btn_editar.Location = new System.Drawing.Point(795, 647);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 39;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(227)))), ((int)(((byte)(96)))));
            this.btn_crear.Location = new System.Drawing.Point(670, 647);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(100, 28);
            this.btn_crear.TabIndex = 38;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(91, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "PERSONAL ACTIVO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(94, 361);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(862, 150);
            this.dataGridView2.TabIndex = 50;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frm_Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::control_personal.Properties.Resources.fondoSubmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1046, 689);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_idPublicacion);
            this.Controls.Add(this.txt_idPublicacion);
            this.Controls.Add(this.lbl_idPersonal);
            this.Controls.Add(this.txt_idPersonal);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.lbl_tipo);
            this.Controls.Add(this.txt_tipo);
            this.Controls.Add(this.lbl_fechaPublicacion);
            this.Controls.Add(this.dtp_fechaPublicacion);
            this.Controls.Add(this.lbl_institucion);
            this.Controls.Add(this.txt_institucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Publicaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Publicaciones";
            this.Load += new System.EventHandler(this.frm_Publicaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.publicacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDFocusDataSet bDFocusDataSet;
        private System.Windows.Forms.BindingSource publicacionesBindingSource;
        private BDFocusDataSetTableAdapters.PublicacionesTableAdapter publicacionesTableAdapter;
        private BDFocusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_idPublicacion;
        private System.Windows.Forms.TextBox txt_idPersonal;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_tipo;
        private System.Windows.Forms.DateTimePicker dtp_fechaPublicacion;
        private System.Windows.Forms.TextBox txt_institucion;
        private System.Windows.Forms.Label lbl_idPublicacion;
        private System.Windows.Forms.Label lbl_idPersonal;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label lbl_fechaPublicacion;
        private System.Windows.Forms.Label lbl_institucion;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}