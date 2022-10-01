namespace control_personal
{
    partial class frm_Titulos
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
            this.lbl_idTitulo = new System.Windows.Forms.Label();
            this.lbl_idPersonal = new System.Windows.Forms.Label();
            this.lbl_grado = new System.Windows.Forms.Label();
            this.lbl_nombreTitulo = new System.Windows.Forms.Label();
            this.lbl_fechaEmision = new System.Windows.Forms.Label();
            this.lbl_caso = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bDFocusDataSet = new control_personal.BDFocusDataSet();
            this.titulosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titulosTableAdapter = new control_personal.BDFocusDataSetTableAdapters.TitulosTableAdapter();
            this.tableAdapterManager = new control_personal.BDFocusDataSetTableAdapters.TableAdapterManager();
            this.txt_idTitulo = new System.Windows.Forms.TextBox();
            this.txt_idPersonal = new System.Windows.Forms.TextBox();
            this.txt_grado = new System.Windows.Forms.TextBox();
            this.txt_nombreTitulo = new System.Windows.Forms.TextBox();
            this.dtp_fechaEmision = new System.Windows.Forms.DateTimePicker();
            this.txt_caso = new System.Windows.Forms.TextBox();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pais = new System.Windows.Forms.Label();
            this.txt_pais = new System.Windows.Forms.TextBox();
            this.lbl_institucion = new System.Windows.Forms.Label();
            this.txt_institucion = new System.Windows.Forms.TextBox();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.txt_codigoTitulo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idTitulo
            // 
            this.lbl_idTitulo.AutoSize = true;
            this.lbl_idTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idTitulo.Location = new System.Drawing.Point(189, 537);
            this.lbl_idTitulo.Name = "lbl_idTitulo";
            this.lbl_idTitulo.Size = new System.Drawing.Size(57, 16);
            this.lbl_idTitulo.TabIndex = 16;
            this.lbl_idTitulo.Text = "Id Titulo:";
            // 
            // lbl_idPersonal
            // 
            this.lbl_idPersonal.AutoSize = true;
            this.lbl_idPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idPersonal.Location = new System.Drawing.Point(189, 565);
            this.lbl_idPersonal.Name = "lbl_idPersonal";
            this.lbl_idPersonal.Size = new System.Drawing.Size(78, 16);
            this.lbl_idPersonal.TabIndex = 18;
            this.lbl_idPersonal.Text = "Id Personal:";
            // 
            // lbl_grado
            // 
            this.lbl_grado.AutoSize = true;
            this.lbl_grado.BackColor = System.Drawing.Color.Transparent;
            this.lbl_grado.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_grado.Location = new System.Drawing.Point(189, 593);
            this.lbl_grado.Name = "lbl_grado";
            this.lbl_grado.Size = new System.Drawing.Size(48, 16);
            this.lbl_grado.TabIndex = 20;
            this.lbl_grado.Text = "Grado:";
            // 
            // lbl_nombreTitulo
            // 
            this.lbl_nombreTitulo.AutoSize = true;
            this.lbl_nombreTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombreTitulo.Location = new System.Drawing.Point(189, 621);
            this.lbl_nombreTitulo.Name = "lbl_nombreTitulo";
            this.lbl_nombreTitulo.Size = new System.Drawing.Size(95, 16);
            this.lbl_nombreTitulo.TabIndex = 22;
            this.lbl_nombreTitulo.Text = "Nombre Titulo:";
            // 
            // lbl_fechaEmision
            // 
            this.lbl_fechaEmision.AutoSize = true;
            this.lbl_fechaEmision.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaEmision.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fechaEmision.Location = new System.Drawing.Point(189, 650);
            this.lbl_fechaEmision.Name = "lbl_fechaEmision";
            this.lbl_fechaEmision.Size = new System.Drawing.Size(99, 16);
            this.lbl_fechaEmision.TabIndex = 24;
            this.lbl_fechaEmision.Text = "Fecha Emision:";
            // 
            // lbl_caso
            // 
            this.lbl_caso.AutoSize = true;
            this.lbl_caso.BackColor = System.Drawing.Color.Transparent;
            this.lbl_caso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_caso.Location = new System.Drawing.Point(582, 540);
            this.lbl_caso.Name = "lbl_caso";
            this.lbl_caso.Size = new System.Drawing.Size(42, 16);
            this.lbl_caso.TabIndex = 26;
            this.lbl_caso.Text = "Caso:";
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
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bDFocusDataSet
            // 
            this.bDFocusDataSet.DataSetName = "BDFocusDataSet";
            this.bDFocusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // titulosBindingSource
            // 
            this.titulosBindingSource.DataMember = "Titulos";
            this.titulosBindingSource.DataSource = this.bDFocusDataSet;
            // 
            // titulosTableAdapter
            // 
            this.titulosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.PublicacionesTableAdapter = null;
            this.tableAdapterManager.TitulosTableAdapter = this.titulosTableAdapter;
            this.tableAdapterManager.UpdateOrder = control_personal.BDFocusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_idTitulo
            // 
            this.txt_idTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "IdTitulo", true));
            this.txt_idTitulo.Enabled = false;
            this.txt_idTitulo.Location = new System.Drawing.Point(294, 534);
            this.txt_idTitulo.Name = "txt_idTitulo";
            this.txt_idTitulo.Size = new System.Drawing.Size(200, 22);
            this.txt_idTitulo.TabIndex = 17;
            // 
            // txt_idPersonal
            // 
            this.txt_idPersonal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "IdPersonal", true));
            this.txt_idPersonal.Enabled = false;
            this.txt_idPersonal.Location = new System.Drawing.Point(294, 562);
            this.txt_idPersonal.Name = "txt_idPersonal";
            this.txt_idPersonal.Size = new System.Drawing.Size(200, 22);
            this.txt_idPersonal.TabIndex = 19;
            // 
            // txt_grado
            // 
            this.txt_grado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "Grado", true));
            this.txt_grado.Location = new System.Drawing.Point(294, 590);
            this.txt_grado.Name = "txt_grado";
            this.txt_grado.Size = new System.Drawing.Size(200, 22);
            this.txt_grado.TabIndex = 21;
            // 
            // txt_nombreTitulo
            // 
            this.txt_nombreTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "NombreTitulo", true));
            this.txt_nombreTitulo.Location = new System.Drawing.Point(294, 618);
            this.txt_nombreTitulo.Name = "txt_nombreTitulo";
            this.txt_nombreTitulo.Size = new System.Drawing.Size(200, 22);
            this.txt_nombreTitulo.TabIndex = 23;
            // 
            // dtp_fechaEmision
            // 
            this.dtp_fechaEmision.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.titulosBindingSource, "FechaEmision", true));
            this.dtp_fechaEmision.Location = new System.Drawing.Point(294, 646);
            this.dtp_fechaEmision.Name = "dtp_fechaEmision";
            this.dtp_fechaEmision.Size = new System.Drawing.Size(251, 22);
            this.dtp_fechaEmision.TabIndex = 25;
            // 
            // txt_caso
            // 
            this.txt_caso.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "Caso", true));
            this.txt_caso.Location = new System.Drawing.Point(678, 537);
            this.txt_caso.Name = "txt_caso";
            this.txt_caso.Size = new System.Drawing.Size(200, 22);
            this.txt_caso.TabIndex = 27;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(558, 694);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 45;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(916, 694);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 28);
            this.btn_atras.TabIndex = 44;
            this.btn_atras.Text = "ATRAS";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.btn_editar.Location = new System.Drawing.Point(799, 694);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 43;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(227)))), ((int)(((byte)(96)))));
            this.btn_crear.Location = new System.Drawing.Point(674, 694);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(100, 28);
            this.btn_crear.TabIndex = 42;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(92, 360);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(862, 150);
            this.dataGridView2.TabIndex = 46;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(89, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "PERSONAL ACTIVO";
            // 
            // lbl_pais
            // 
            this.lbl_pais.AutoSize = true;
            this.lbl_pais.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pais.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_pais.Location = new System.Drawing.Point(582, 568);
            this.lbl_pais.Name = "lbl_pais";
            this.lbl_pais.Size = new System.Drawing.Size(37, 16);
            this.lbl_pais.TabIndex = 47;
            this.lbl_pais.Text = "Pais:";
            // 
            // txt_pais
            // 
            this.txt_pais.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "Pais", true));
            this.txt_pais.Location = new System.Drawing.Point(678, 565);
            this.txt_pais.Name = "txt_pais";
            this.txt_pais.Size = new System.Drawing.Size(200, 22);
            this.txt_pais.TabIndex = 48;
            // 
            // lbl_institucion
            // 
            this.lbl_institucion.AutoSize = true;
            this.lbl_institucion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_institucion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_institucion.Location = new System.Drawing.Point(582, 596);
            this.lbl_institucion.Name = "lbl_institucion";
            this.lbl_institucion.Size = new System.Drawing.Size(68, 16);
            this.lbl_institucion.TabIndex = 48;
            this.lbl_institucion.Text = "Institucion:";
            // 
            // txt_institucion
            // 
            this.txt_institucion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "Institucion", true));
            this.txt_institucion.Location = new System.Drawing.Point(678, 593);
            this.txt_institucion.Name = "txt_institucion";
            this.txt_institucion.Size = new System.Drawing.Size(200, 22);
            this.txt_institucion.TabIndex = 49;
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_codigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_codigo.Location = new System.Drawing.Point(582, 624);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(90, 16);
            this.lbl_codigo.TabIndex = 49;
            this.lbl_codigo.Text = "Codigo Titulo:";
            // 
            // txt_codigoTitulo
            // 
            this.txt_codigoTitulo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.titulosBindingSource, "CodigoTitulo", true));
            this.txt_codigoTitulo.Location = new System.Drawing.Point(678, 621);
            this.txt_codigoTitulo.Name = "txt_codigoTitulo";
            this.txt_codigoTitulo.Size = new System.Drawing.Size(200, 22);
            this.txt_codigoTitulo.TabIndex = 50;
            // 
            // frm_Titulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::control_personal.Properties.Resources.fondoSubmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1043, 735);
            this.Controls.Add(this.lbl_codigo);
            this.Controls.Add(this.txt_codigoTitulo);
            this.Controls.Add(this.lbl_institucion);
            this.Controls.Add(this.txt_institucion);
            this.Controls.Add(this.lbl_pais);
            this.Controls.Add(this.txt_pais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.lbl_idTitulo);
            this.Controls.Add(this.txt_idTitulo);
            this.Controls.Add(this.lbl_idPersonal);
            this.Controls.Add(this.txt_idPersonal);
            this.Controls.Add(this.lbl_grado);
            this.Controls.Add(this.txt_grado);
            this.Controls.Add(this.lbl_nombreTitulo);
            this.Controls.Add(this.txt_nombreTitulo);
            this.Controls.Add(this.lbl_fechaEmision);
            this.Controls.Add(this.dtp_fechaEmision);
            this.Controls.Add(this.lbl_caso);
            this.Controls.Add(this.txt_caso);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Titulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Titulos";
            this.Load += new System.EventHandler(this.frm_Titulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titulosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BDFocusDataSet bDFocusDataSet;
        private System.Windows.Forms.BindingSource titulosBindingSource;
        private BDFocusDataSetTableAdapters.TitulosTableAdapter titulosTableAdapter;
        private BDFocusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_idTitulo;
        private System.Windows.Forms.TextBox txt_idPersonal;
        private System.Windows.Forms.TextBox txt_grado;
        private System.Windows.Forms.TextBox txt_nombreTitulo;
        private System.Windows.Forms.DateTimePicker dtp_fechaEmision;
        private System.Windows.Forms.TextBox txt_caso;
        private System.Windows.Forms.Label lbl_idTitulo;
        private System.Windows.Forms.Label lbl_idPersonal;
        private System.Windows.Forms.Label lbl_grado;
        private System.Windows.Forms.Label lbl_nombreTitulo;
        private System.Windows.Forms.Label lbl_fechaEmision;
        private System.Windows.Forms.Label lbl_caso;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pais;
        private System.Windows.Forms.TextBox txt_institucion;
        private System.Windows.Forms.TextBox txt_codigoTitulo;
        private System.Windows.Forms.Label lbl_pais;
        private System.Windows.Forms.Label lbl_institucion;
        private System.Windows.Forms.Label lbl_codigo;
    }
}