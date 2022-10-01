namespace control_personal
{
    partial class frm_Personal
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
            this.bDFocusDataSet = new control_personal.BDFocusDataSet();
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personalTableAdapter = new control_personal.BDFocusDataSetTableAdapters.PersonalTableAdapter();
            this.tableAdapterManager = new control_personal.BDFocusDataSetTableAdapters.TableAdapterManager();
            this.lblidPersonal = new System.Windows.Forms.Label();
            this.txt_idPersonal = new System.Windows.Forms.TextBox();
            this.lblnombre = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lblapellidoP = new System.Windows.Forms.Label();
            this.txt_apellidoP = new System.Windows.Forms.TextBox();
            this.lblapellidoM = new System.Windows.Forms.Label();
            this.txt_apellidoM = new System.Windows.Forms.TextBox();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txt_cargo = new System.Windows.Forms.TextBox();
            this.lblcI = new System.Windows.Forms.Label();
            this.txt_cI = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbltel = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.lblpass = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.lbllibreta = new System.Windows.Forms.Label();
            this.txt_libreta = new System.Windows.Forms.TextBox();
            this.lblfechaNac = new System.Windows.Forms.Label();
            this.dtp_fechaNac = new System.Windows.Forms.DateTimePicker();
            this.lblgenero = new System.Windows.Forms.Label();
            this.txt_genero = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.lbl_vigencia = new System.Windows.Forms.Label();
            this.txt_vigencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bDFocusDataSet
            // 
            this.bDFocusDataSet.DataSetName = "BDFocusDataSet";
            this.bDFocusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.bDFocusDataSet;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.IdiomasTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.PublicacionesTableAdapter = null;
            this.tableAdapterManager.TitulosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_personal.BDFocusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblidPersonal
            // 
            this.lblidPersonal.AutoSize = true;
            this.lblidPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lblidPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidPersonal.Location = new System.Drawing.Point(177, 362);
            this.lblidPersonal.Name = "lblidPersonal";
            this.lblidPersonal.Size = new System.Drawing.Size(78, 16);
            this.lblidPersonal.TabIndex = 1;
            this.lblidPersonal.Text = "Id Personal:";
            // 
            // txt_idPersonal
            // 
            this.txt_idPersonal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "IdPersonal", true));
            this.txt_idPersonal.Enabled = false;
            this.txt_idPersonal.Location = new System.Drawing.Point(261, 356);
            this.txt_idPersonal.Name = "txt_idPersonal";
            this.txt_idPersonal.Size = new System.Drawing.Size(200, 22);
            this.txt_idPersonal.TabIndex = 2;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombre.Location = new System.Drawing.Point(177, 387);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(59, 16);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre:";
            // 
            // txt_nombre
            // 
            this.txt_nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Nombre", true));
            this.txt_nombre.Location = new System.Drawing.Point(261, 384);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(200, 22);
            this.txt_nombre.TabIndex = 4;
            // 
            // lblapellidoP
            // 
            this.lblapellidoP.AutoSize = true;
            this.lblapellidoP.BackColor = System.Drawing.Color.Transparent;
            this.lblapellidoP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblapellidoP.Location = new System.Drawing.Point(177, 415);
            this.lblapellidoP.Name = "lblapellidoP";
            this.lblapellidoP.Size = new System.Drawing.Size(72, 16);
            this.lblapellidoP.TabIndex = 5;
            this.lblapellidoP.Text = "Apellido P:";
            // 
            // txt_apellidoP
            // 
            this.txt_apellidoP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ApellidoP", true));
            this.txt_apellidoP.Location = new System.Drawing.Point(261, 412);
            this.txt_apellidoP.Name = "txt_apellidoP";
            this.txt_apellidoP.Size = new System.Drawing.Size(200, 22);
            this.txt_apellidoP.TabIndex = 6;
            // 
            // lblapellidoM
            // 
            this.lblapellidoM.AutoSize = true;
            this.lblapellidoM.BackColor = System.Drawing.Color.Transparent;
            this.lblapellidoM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblapellidoM.Location = new System.Drawing.Point(177, 443);
            this.lblapellidoM.Name = "lblapellidoM";
            this.lblapellidoM.Size = new System.Drawing.Size(74, 16);
            this.lblapellidoM.TabIndex = 7;
            this.lblapellidoM.Text = "Apellido M:";
            // 
            // txt_apellidoM
            // 
            this.txt_apellidoM.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ApellidoM", true));
            this.txt_apellidoM.Location = new System.Drawing.Point(261, 440);
            this.txt_apellidoM.Name = "txt_apellidoM";
            this.txt_apellidoM.Size = new System.Drawing.Size(200, 22);
            this.txt_apellidoM.TabIndex = 8;
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.BackColor = System.Drawing.Color.Transparent;
            this.lblcargo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcargo.Location = new System.Drawing.Point(177, 471);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(47, 16);
            this.lblcargo.TabIndex = 9;
            this.lblcargo.Text = "Cargo:";
            // 
            // txt_cargo
            // 
            this.txt_cargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Cargo", true));
            this.txt_cargo.Location = new System.Drawing.Point(261, 468);
            this.txt_cargo.Name = "txt_cargo";
            this.txt_cargo.Size = new System.Drawing.Size(200, 22);
            this.txt_cargo.TabIndex = 10;
            // 
            // lblcI
            // 
            this.lblcI.AutoSize = true;
            this.lblcI.BackColor = System.Drawing.Color.Transparent;
            this.lblcI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcI.Location = new System.Drawing.Point(177, 499);
            this.lblcI.Name = "lblcI";
            this.lblcI.Size = new System.Drawing.Size(22, 16);
            this.lblcI.TabIndex = 11;
            this.lblcI.Text = "CI:";
            // 
            // txt_cI
            // 
            this.txt_cI.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "CI", true));
            this.txt_cI.Location = new System.Drawing.Point(261, 496);
            this.txt_cI.Name = "txt_cI";
            this.txt_cI.Size = new System.Drawing.Size(200, 22);
            this.txt_cI.TabIndex = 12;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnumero.Location = new System.Drawing.Point(533, 356);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(58, 16);
            this.lblnumero.TabIndex = 13;
            this.lblnumero.Text = "Numero:";
            // 
            // txt_numero
            // 
            this.txt_numero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Numero", true));
            this.txt_numero.Location = new System.Drawing.Point(617, 353);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(200, 22);
            this.txt_numero.TabIndex = 14;
            // 
            // lbltel
            // 
            this.lbltel.AutoSize = true;
            this.lbltel.BackColor = System.Drawing.Color.Transparent;
            this.lbltel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltel.Location = new System.Drawing.Point(533, 384);
            this.lbltel.Name = "lbltel";
            this.lbltel.Size = new System.Drawing.Size(30, 16);
            this.lbltel.TabIndex = 15;
            this.lbltel.Text = "Tel:";
            // 
            // txt_tel
            // 
            this.txt_tel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Tel", true));
            this.txt_tel.Location = new System.Drawing.Point(617, 381);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(200, 22);
            this.txt_tel.TabIndex = 16;
            // 
            // lblpass
            // 
            this.lblpass.AutoSize = true;
            this.lblpass.BackColor = System.Drawing.Color.Transparent;
            this.lblpass.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblpass.Location = new System.Drawing.Point(533, 412);
            this.lblpass.Name = "lblpass";
            this.lblpass.Size = new System.Drawing.Size(41, 16);
            this.lblpass.TabIndex = 17;
            this.lblpass.Text = "Pass:";
            // 
            // txt_pass
            // 
            this.txt_pass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Pass", true));
            this.txt_pass.Location = new System.Drawing.Point(617, 409);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(200, 22);
            this.txt_pass.TabIndex = 18;
            // 
            // lbllibreta
            // 
            this.lbllibreta.AutoSize = true;
            this.lbllibreta.BackColor = System.Drawing.Color.Transparent;
            this.lbllibreta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbllibreta.Location = new System.Drawing.Point(533, 440);
            this.lbllibreta.Name = "lbllibreta";
            this.lbllibreta.Size = new System.Drawing.Size(51, 16);
            this.lbllibreta.TabIndex = 19;
            this.lbllibreta.Text = "Libreta:";
            // 
            // txt_libreta
            // 
            this.txt_libreta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Libreta", true));
            this.txt_libreta.Location = new System.Drawing.Point(617, 437);
            this.txt_libreta.Name = "txt_libreta";
            this.txt_libreta.Size = new System.Drawing.Size(200, 22);
            this.txt_libreta.TabIndex = 20;
            // 
            // lblfechaNac
            // 
            this.lblfechaNac.AutoSize = true;
            this.lblfechaNac.BackColor = System.Drawing.Color.Transparent;
            this.lblfechaNac.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblfechaNac.Location = new System.Drawing.Point(533, 469);
            this.lblfechaNac.Name = "lblfechaNac";
            this.lblfechaNac.Size = new System.Drawing.Size(76, 16);
            this.lblfechaNac.TabIndex = 21;
            this.lblfechaNac.Text = "Fecha Nac:";
            // 
            // dtp_fechaNac
            // 
            this.dtp_fechaNac.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "FechaNac", true));
            this.dtp_fechaNac.Location = new System.Drawing.Point(617, 465);
            this.dtp_fechaNac.Name = "dtp_fechaNac";
            this.dtp_fechaNac.Size = new System.Drawing.Size(260, 22);
            this.dtp_fechaNac.TabIndex = 22;
            // 
            // lblgenero
            // 
            this.lblgenero.AutoSize = true;
            this.lblgenero.BackColor = System.Drawing.Color.Transparent;
            this.lblgenero.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblgenero.Location = new System.Drawing.Point(533, 496);
            this.lblgenero.Name = "lblgenero";
            this.lblgenero.Size = new System.Drawing.Size(55, 16);
            this.lblgenero.TabIndex = 23;
            this.lblgenero.Text = "Genero:";
            // 
            // txt_genero
            // 
            this.txt_genero.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Genero", true));
            this.txt_genero.Location = new System.Drawing.Point(617, 493);
            this.txt_genero.Name = "txt_genero";
            this.txt_genero.Size = new System.Drawing.Size(200, 22);
            this.txt_genero.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(964, 289);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(894, 565);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 28);
            this.btn_atras.TabIndex = 28;
            this.btn_atras.Text = "ATRAS";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.btn_editar.Location = new System.Drawing.Point(777, 565);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 27;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(227)))), ((int)(((byte)(96)))));
            this.btn_crear.Location = new System.Drawing.Point(652, 565);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(100, 28);
            this.btn_crear.TabIndex = 26;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = false;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(536, 565);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 29;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // lbl_vigencia
            // 
            this.lbl_vigencia.AutoSize = true;
            this.lbl_vigencia.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vigencia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_vigencia.Location = new System.Drawing.Point(177, 527);
            this.lbl_vigencia.Name = "lbl_vigencia";
            this.lbl_vigencia.Size = new System.Drawing.Size(63, 16);
            this.lbl_vigencia.TabIndex = 29;
            this.lbl_vigencia.Text = "Vigencia:";
            // 
            // txt_vigencia
            // 
            this.txt_vigencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Vigencia", true));
            this.txt_vigencia.Location = new System.Drawing.Point(261, 524);
            this.txt_vigencia.Name = "txt_vigencia";
            this.txt_vigencia.Size = new System.Drawing.Size(200, 22);
            this.txt_vigencia.TabIndex = 30;
            // 
            // frm_Personal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::control_personal.Properties.Resources.fondoSubmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1026, 613);
            this.Controls.Add(this.lbl_vigencia);
            this.Controls.Add(this.txt_vigencia);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblidPersonal);
            this.Controls.Add(this.txt_idPersonal);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lblapellidoP);
            this.Controls.Add(this.txt_apellidoP);
            this.Controls.Add(this.lblapellidoM);
            this.Controls.Add(this.txt_apellidoM);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.txt_cargo);
            this.Controls.Add(this.lblcI);
            this.Controls.Add(this.txt_cI);
            this.Controls.Add(this.lblnumero);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.lbltel);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.lblpass);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.lbllibreta);
            this.Controls.Add(this.txt_libreta);
            this.Controls.Add(this.lblfechaNac);
            this.Controls.Add(this.dtp_fechaNac);
            this.Controls.Add(this.lblgenero);
            this.Controls.Add(this.txt_genero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Personal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal";
            this.Load += new System.EventHandler(this.frm_Personal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDFocusDataSet bDFocusDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private BDFocusDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private BDFocusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_idPersonal;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_apellidoP;
        private System.Windows.Forms.TextBox txt_apellidoM;
        private System.Windows.Forms.TextBox txt_cargo;
        private System.Windows.Forms.TextBox txt_cI;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_libreta;
        private System.Windows.Forms.DateTimePicker dtp_fechaNac;
        private System.Windows.Forms.TextBox txt_genero;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label lblidPersonal;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblapellidoP;
        private System.Windows.Forms.Label lblapellidoM;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.Label lblcI;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lbltel;
        private System.Windows.Forms.Label lblpass;
        private System.Windows.Forms.Label lbllibreta;
        private System.Windows.Forms.Label lblfechaNac;
        private System.Windows.Forms.Label lblgenero;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label lbl_vigencia;
        private System.Windows.Forms.TextBox txt_vigencia;
    }
}