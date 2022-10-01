namespace control_personal
{
    partial class frm_Empresas
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
            this.lbl_idEmpresa = new System.Windows.Forms.Label();
            this.lbl_idPersonal = new System.Windows.Forms.Label();
            this.lbl_nombreEmp = new System.Windows.Forms.Label();
            this.lbl_fechaInicio = new System.Windows.Forms.Label();
            this.lbl_fechaFinal = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.bDFocusDataSet = new control_personal.BDFocusDataSet();
            this.empresasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasTableAdapter = new control_personal.BDFocusDataSetTableAdapters.EmpresasTableAdapter();
            this.tableAdapterManager = new control_personal.BDFocusDataSetTableAdapters.TableAdapterManager();
            this.txt_idEmpresa = new System.Windows.Forms.TextBox();
            this.txt_idPersonal = new System.Windows.Forms.TextBox();
            this.txt_nombreEmp = new System.Windows.Forms.TextBox();
            this.dtp_fechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_idEmpresa
            // 
            this.lbl_idEmpresa.AutoSize = true;
            this.lbl_idEmpresa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idEmpresa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idEmpresa.Location = new System.Drawing.Point(202, 547);
            this.lbl_idEmpresa.Name = "lbl_idEmpresa";
            this.lbl_idEmpresa.Size = new System.Drawing.Size(79, 16);
            this.lbl_idEmpresa.TabIndex = 1;
            this.lbl_idEmpresa.Text = "Id Empresa:";
            // 
            // lbl_idPersonal
            // 
            this.lbl_idPersonal.AutoSize = true;
            this.lbl_idPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_idPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_idPersonal.Location = new System.Drawing.Point(202, 575);
            this.lbl_idPersonal.Name = "lbl_idPersonal";
            this.lbl_idPersonal.Size = new System.Drawing.Size(78, 16);
            this.lbl_idPersonal.TabIndex = 3;
            this.lbl_idPersonal.Text = "Id Personal:";
            // 
            // lbl_nombreEmp
            // 
            this.lbl_nombreEmp.AutoSize = true;
            this.lbl_nombreEmp.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nombreEmp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_nombreEmp.Location = new System.Drawing.Point(202, 603);
            this.lbl_nombreEmp.Name = "lbl_nombreEmp";
            this.lbl_nombreEmp.Size = new System.Drawing.Size(90, 16);
            this.lbl_nombreEmp.TabIndex = 5;
            this.lbl_nombreEmp.Text = "Nombre Emp:";
            // 
            // lbl_fechaInicio
            // 
            this.lbl_fechaInicio.AutoSize = true;
            this.lbl_fechaInicio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaInicio.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fechaInicio.Location = new System.Drawing.Point(527, 548);
            this.lbl_fechaInicio.Name = "lbl_fechaInicio";
            this.lbl_fechaInicio.Size = new System.Drawing.Size(82, 16);
            this.lbl_fechaInicio.TabIndex = 7;
            this.lbl_fechaInicio.Text = "Fecha Inicio:";
            // 
            // lbl_fechaFinal
            // 
            this.lbl_fechaFinal.AutoSize = true;
            this.lbl_fechaFinal.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fechaFinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_fechaFinal.Location = new System.Drawing.Point(527, 576);
            this.lbl_fechaFinal.Name = "lbl_fechaFinal";
            this.lbl_fechaFinal.Size = new System.Drawing.Size(80, 16);
            this.lbl_fechaFinal.TabIndex = 9;
            this.lbl_fechaFinal.Text = "Fecha Final:";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_cargo.Location = new System.Drawing.Point(527, 603);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(47, 16);
            this.lbl_cargo.TabIndex = 11;
            this.lbl_cargo.Text = "Cargo:";
            // 
            // bDFocusDataSet
            // 
            this.bDFocusDataSet.DataSetName = "BDFocusDataSet";
            this.bDFocusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empresasBindingSource
            // 
            this.empresasBindingSource.DataMember = "Empresas";
            this.empresasBindingSource.DataSource = this.bDFocusDataSet;
            // 
            // empresasTableAdapter
            // 
            this.empresasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = this.empresasTableAdapter;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.PublicacionesTableAdapter = null;
            this.tableAdapterManager.TitulosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_personal.BDFocusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txt_idEmpresa
            // 
            this.txt_idEmpresa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "IdEmpresa", true));
            this.txt_idEmpresa.Enabled = false;
            this.txt_idEmpresa.Location = new System.Drawing.Point(298, 544);
            this.txt_idEmpresa.Name = "txt_idEmpresa";
            this.txt_idEmpresa.Size = new System.Drawing.Size(200, 22);
            this.txt_idEmpresa.TabIndex = 2;
            // 
            // txt_idPersonal
            // 
            this.txt_idPersonal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "IdPersonal", true));
            this.txt_idPersonal.Enabled = false;
            this.txt_idPersonal.Location = new System.Drawing.Point(298, 572);
            this.txt_idPersonal.Name = "txt_idPersonal";
            this.txt_idPersonal.Size = new System.Drawing.Size(200, 22);
            this.txt_idPersonal.TabIndex = 4;
            // 
            // txt_nombreEmp
            // 
            this.txt_nombreEmp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "NombreEmp", true));
            this.txt_nombreEmp.Location = new System.Drawing.Point(298, 600);
            this.txt_nombreEmp.Name = "txt_nombreEmp";
            this.txt_nombreEmp.Size = new System.Drawing.Size(200, 22);
            this.txt_nombreEmp.TabIndex = 6;
            // 
            // dtp_fechaInicio
            // 
            this.dtp_fechaInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empresasBindingSource, "FechaInicio", true));
            this.dtp_fechaInicio.Location = new System.Drawing.Point(623, 544);
            this.dtp_fechaInicio.Name = "dtp_fechaInicio";
            this.dtp_fechaInicio.Size = new System.Drawing.Size(255, 22);
            this.dtp_fechaInicio.TabIndex = 8;
            // 
            // dtp_fechaFinal
            // 
            this.dtp_fechaFinal.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.empresasBindingSource, "FechaFinal", true));
            this.dtp_fechaFinal.Location = new System.Drawing.Point(623, 572);
            this.dtp_fechaFinal.Name = "dtp_fechaFinal";
            this.dtp_fechaFinal.Size = new System.Drawing.Size(255, 22);
            this.dtp_fechaFinal.TabIndex = 10;
            // 
            // txt_cargo
            // 
            this.txt_cargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empresasBindingSource, "Cargo", true));
            this.txt_cargo.Location = new System.Drawing.Point(623, 600);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(200, 22);
            this.txt_cargo.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(989, 293);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(580, 651);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 37;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(938, 651);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 28);
            this.btn_atras.TabIndex = 36;
            this.btn_atras.Text = "ATRAS";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.btn_editar.Location = new System.Drawing.Point(821, 651);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 35;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(227)))), ((int)(((byte)(96)))));
            this.btn_crear.Location = new System.Drawing.Point(696, 651);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(100, 28);
            this.btn_crear.TabIndex = 34;
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
            this.label1.Location = new System.Drawing.Point(100, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "PERSONAL ACTIVO";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(103, 372);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(862, 150);
            this.dataGridView2.TabIndex = 48;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frm_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::control_personal.Properties.Resources.fondoSubmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1049, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_idEmpresa);
            this.Controls.Add(this.txt_idEmpresa);
            this.Controls.Add(this.lbl_idPersonal);
            this.Controls.Add(this.txt_idPersonal);
            this.Controls.Add(this.lbl_nombreEmp);
            this.Controls.Add(this.txt_nombreEmp);
            this.Controls.Add(this.lbl_fechaInicio);
            this.Controls.Add(this.dtp_fechaInicio);
            this.Controls.Add(this.lbl_fechaFinal);
            this.Controls.Add(this.dtp_fechaFinal);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.txt_cargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Empresas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empresas";
            this.Load += new System.EventHandler(this.frm_Empresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDFocusDataSet bDFocusDataSet;
        private System.Windows.Forms.BindingSource empresasBindingSource;
        private BDFocusDataSetTableAdapters.EmpresasTableAdapter empresasTableAdapter;
        private BDFocusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_idEmpresa;
        private System.Windows.Forms.TextBox txt_idPersonal;
        private System.Windows.Forms.TextBox txt_nombreEmp;
        private System.Windows.Forms.DateTimePicker dtp_fechaInicio;
        private System.Windows.Forms.DateTimePicker dtp_fechaFinal;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.Label lbl_idEmpresa;
        private System.Windows.Forms.Label lbl_idPersonal;
        private System.Windows.Forms.Label lbl_nombreEmp;
        private System.Windows.Forms.Label lbl_fechaInicio;
        private System.Windows.Forms.Label lbl_fechaFinal;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}