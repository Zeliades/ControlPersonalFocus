namespace control_personal
{
    partial class frm_Idiomas
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
            this.idiomasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idiomasTableAdapter = new control_personal.BDFocusDataSetTableAdapters.IdiomasTableAdapter();
            this.tableAdapterManager = new control_personal.BDFocusDataSetTableAdapters.TableAdapterManager();
            this.lblidIdioma = new System.Windows.Forms.Label();
            this.txt_idIdioma = new System.Windows.Forms.TextBox();
            this.lblidPersonal = new System.Windows.Forms.Label();
            this.txt_idPersonal = new System.Windows.Forms.TextBox();
            this.lblidioma = new System.Windows.Forms.Label();
            this.txt_idioma = new System.Windows.Forms.TextBox();
            this.lblnivel = new System.Windows.Forms.Label();
            this.txt_nivel = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bDFocusDataSet
            // 
            this.bDFocusDataSet.DataSetName = "BDFocusDataSet";
            this.bDFocusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // idiomasBindingSource
            // 
            this.idiomasBindingSource.DataMember = "Idiomas";
            this.idiomasBindingSource.DataSource = this.bDFocusDataSet;
            // 
            // idiomasTableAdapter
            // 
            this.idiomasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EmpresasTableAdapter = null;
            this.tableAdapterManager.IdiomasTableAdapter = this.idiomasTableAdapter;
            this.tableAdapterManager.PersonalTableAdapter = null;
            this.tableAdapterManager.PublicacionesTableAdapter = null;
            this.tableAdapterManager.TitulosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = control_personal.BDFocusDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lblidIdioma
            // 
            this.lblidIdioma.AutoSize = true;
            this.lblidIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblidIdioma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidIdioma.Location = new System.Drawing.Point(29, 421);
            this.lblidIdioma.Name = "lblidIdioma";
            this.lblidIdioma.Size = new System.Drawing.Size(65, 16);
            this.lblidIdioma.TabIndex = 1;
            this.lblidIdioma.Text = "Id Idioma:";
            // 
            // txt_idIdioma
            // 
            this.txt_idIdioma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idiomasBindingSource, "IdIdioma", true));
            this.txt_idIdioma.Enabled = false;
            this.txt_idIdioma.Location = new System.Drawing.Point(113, 418);
            this.txt_idIdioma.Name = "txt_idIdioma";
            this.txt_idIdioma.Size = new System.Drawing.Size(100, 22);
            this.txt_idIdioma.TabIndex = 2;
            // 
            // lblidPersonal
            // 
            this.lblidPersonal.AutoSize = true;
            this.lblidPersonal.BackColor = System.Drawing.Color.Transparent;
            this.lblidPersonal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidPersonal.Location = new System.Drawing.Point(29, 449);
            this.lblidPersonal.Name = "lblidPersonal";
            this.lblidPersonal.Size = new System.Drawing.Size(78, 16);
            this.lblidPersonal.TabIndex = 3;
            this.lblidPersonal.Text = "Id Personal:";
            // 
            // txt_idPersonal
            // 
            this.txt_idPersonal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idiomasBindingSource, "IdPersonal", true));
            this.txt_idPersonal.Enabled = false;
            this.txt_idPersonal.Location = new System.Drawing.Point(113, 446);
            this.txt_idPersonal.Name = "txt_idPersonal";
            this.txt_idPersonal.Size = new System.Drawing.Size(100, 22);
            this.txt_idPersonal.TabIndex = 4;
            // 
            // lblidioma
            // 
            this.lblidioma.AutoSize = true;
            this.lblidioma.BackColor = System.Drawing.Color.Transparent;
            this.lblidioma.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblidioma.Location = new System.Drawing.Point(29, 477);
            this.lblidioma.Name = "lblidioma";
            this.lblidioma.Size = new System.Drawing.Size(51, 16);
            this.lblidioma.TabIndex = 5;
            this.lblidioma.Text = "Idioma:";
            // 
            // txt_idioma
            // 
            this.txt_idioma.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idiomasBindingSource, "Idioma", true));
            this.txt_idioma.Location = new System.Drawing.Point(113, 474);
            this.txt_idioma.Name = "txt_idioma";
            this.txt_idioma.Size = new System.Drawing.Size(100, 22);
            this.txt_idioma.TabIndex = 6;
            // 
            // lblnivel
            // 
            this.lblnivel.AutoSize = true;
            this.lblnivel.BackColor = System.Drawing.Color.Transparent;
            this.lblnivel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnivel.Location = new System.Drawing.Point(29, 505);
            this.lblnivel.Name = "lblnivel";
            this.lblnivel.Size = new System.Drawing.Size(41, 16);
            this.lblnivel.TabIndex = 7;
            this.lblnivel.Text = "Nivel:";
            // 
            // txt_nivel
            // 
            this.txt_nivel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.idiomasBindingSource, "Nivel", true));
            this.txt_nivel.Location = new System.Drawing.Point(113, 502);
            this.txt_nivel.Name = "txt_nivel";
            this.txt_nivel.Size = new System.Drawing.Size(100, 22);
            this.txt_nivel.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(233, 540);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(100, 28);
            this.btn_limpiar.TabIndex = 33;
            this.btn_limpiar.Text = "LIMPIAR";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(591, 540);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(4);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 28);
            this.btn_atras.TabIndex = 32;
            this.btn_atras.Text = "ATRAS";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(195)))), ((int)(((byte)(236)))));
            this.btn_editar.Location = new System.Drawing.Point(474, 540);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(100, 28);
            this.btn_editar.TabIndex = 31;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(227)))), ((int)(((byte)(96)))));
            this.btn_crear.Location = new System.Drawing.Point(349, 540);
            this.btn_crear.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(100, 28);
            this.btn_crear.TabIndex = 30;
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
            this.label1.Location = new System.Drawing.Point(50, 214);
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
            this.dataGridView2.Location = new System.Drawing.Point(35, 246);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(644, 150);
            this.dataGridView2.TabIndex = 50;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // frm_Idiomas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::control_personal.Properties.Resources.fondoSubmenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 583);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblidIdioma);
            this.Controls.Add(this.txt_idIdioma);
            this.Controls.Add(this.lblidPersonal);
            this.Controls.Add(this.txt_idPersonal);
            this.Controls.Add(this.lblidioma);
            this.Controls.Add(this.txt_idioma);
            this.Controls.Add(this.lblnivel);
            this.Controls.Add(this.txt_nivel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frm_Idiomas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idiomas";
            this.Load += new System.EventHandler(this.frm_Idiomas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDFocusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idiomasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDFocusDataSet bDFocusDataSet;
        private System.Windows.Forms.BindingSource idiomasBindingSource;
        private BDFocusDataSetTableAdapters.IdiomasTableAdapter idiomasTableAdapter;
        private BDFocusDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txt_idIdioma;
        private System.Windows.Forms.TextBox txt_idPersonal;
        private System.Windows.Forms.TextBox txt_idioma;
        private System.Windows.Forms.TextBox txt_nivel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Label lblidIdioma;
        private System.Windows.Forms.Label lblidPersonal;
        private System.Windows.Forms.Label lblidioma;
        private System.Windows.Forms.Label lblnivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}