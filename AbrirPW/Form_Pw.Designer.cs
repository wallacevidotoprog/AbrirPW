namespace AbrirPW
{
	partial class Form_Pw
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pw));
			this.textBox_NomePw = new System.Windows.Forms.TextBox();
			this.dataGridView_PW = new System.Windows.Forms.DataGridView();
			this.ID_PW = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PW = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoPwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhopwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet = new AbrirPW.pwDBDataSet();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.button_buscar = new System.Windows.Forms.Button();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.label_Caminho = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox_Add = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.caminho_pwTableAdapter = new AbrirPW.pwDBDataSetTableAdapters.caminho_pwTableAdapter();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.contextMenuStrip_GRID = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.contextMenuStrip_GRID.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_NomePw
			// 
			this.textBox_NomePw.BackColor = System.Drawing.Color.White;
			this.textBox_NomePw.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.textBox_NomePw.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_NomePw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.textBox_NomePw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.textBox_NomePw.Location = new System.Drawing.Point(339, 301);
			this.textBox_NomePw.Multiline = true;
			this.textBox_NomePw.Name = "textBox_NomePw";
			this.textBox_NomePw.Size = new System.Drawing.Size(219, 24);
			this.textBox_NomePw.TabIndex = 1;
			this.textBox_NomePw.Text = "NOME DO PERFECT WOLRD";
			this.textBox_NomePw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_NomePw.TextChanged += new System.EventHandler(this.textBox_NomePw_TextChanged);
			// 
			// dataGridView_PW
			// 
			this.dataGridView_PW.AllowUserToAddRows = false;
			this.dataGridView_PW.AllowUserToDeleteRows = false;
			this.dataGridView_PW.AllowUserToResizeColumns = false;
			this.dataGridView_PW.AllowUserToResizeRows = false;
			this.dataGridView_PW.AutoGenerateColumns = false;
			this.dataGridView_PW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_PW.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_PW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_PW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_PW.ColumnHeadersVisible = false;
			this.dataGridView_PW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_PW,
            this.PW,
            this.caminhoPwDataGridViewTextBoxColumn});
			this.dataGridView_PW.ContextMenuStrip = this.contextMenuStrip_GRID;
			this.dataGridView_PW.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_PW.DataSource = this.caminhopwBindingSource;
			this.dataGridView_PW.GridColor = System.Drawing.Color.White;
			this.dataGridView_PW.Location = new System.Drawing.Point(355, 65);
			this.dataGridView_PW.MultiSelect = false;
			this.dataGridView_PW.Name = "dataGridView_PW";
			this.dataGridView_PW.ReadOnly = true;
			this.dataGridView_PW.RowHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_PW.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_PW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_PW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_PW.Size = new System.Drawing.Size(203, 201);
			this.dataGridView_PW.TabIndex = 2;
			this.dataGridView_PW.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_PW_CellMouseClick);
			// 
			// ID_PW
			// 
			this.ID_PW.DataPropertyName = "id";
			this.ID_PW.HeaderText = "ID";
			this.ID_PW.Name = "ID_PW";
			this.ID_PW.ReadOnly = true;
			this.ID_PW.Visible = false;
			// 
			// PW
			// 
			this.PW.DataPropertyName = "Nome_Pw";
			this.PW.HeaderText = "PW";
			this.PW.Name = "PW";
			this.PW.ReadOnly = true;
			// 
			// caminhoPwDataGridViewTextBoxColumn
			// 
			this.caminhoPwDataGridViewTextBoxColumn.DataPropertyName = "Caminho_Pw";
			this.caminhoPwDataGridViewTextBoxColumn.HeaderText = "Caminho_Pw";
			this.caminhoPwDataGridViewTextBoxColumn.Name = "caminhoPwDataGridViewTextBoxColumn";
			this.caminhoPwDataGridViewTextBoxColumn.ReadOnly = true;
			this.caminhoPwDataGridViewTextBoxColumn.Visible = false;
			// 
			// caminhopwBindingSource
			// 
			this.caminhopwBindingSource.DataMember = "caminho_pw";
			this.caminhopwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// pwDBDataSet
			// 
			this.pwDBDataSet.DataSetName = "pwDBDataSet";
			this.pwDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox2.BackgroundImage = global::AbrirPW.Properties.Resources.texbox;
			this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox2.Location = new System.Drawing.Point(323, 297);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(270, 39);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 3;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox3.BackgroundImage = global::AbrirPW.Properties.Resources.texbox;
			this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox3.Location = new System.Drawing.Point(323, 352);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(270, 39);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			// 
			// button_buscar
			// 
			this.button_buscar.BackColor = System.Drawing.Color.Transparent;
			this.button_buscar.BackgroundImage = global::AbrirPW.Properties.Resources.完美银票2;
			this.button_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_buscar.FlatAppearance.BorderSize = 0;
			this.button_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_buscar.Location = new System.Drawing.Point(591, 352);
			this.button_buscar.Name = "button_buscar";
			this.button_buscar.Size = new System.Drawing.Size(39, 36);
			this.button_buscar.TabIndex = 4;
			this.button_buscar.UseVisualStyleBackColor = false;
			this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
			// 
			// pictureBox4
			// 
			this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox4.BackgroundImage = global::AbrirPW.Properties.Resources.x;
			this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox4.Location = new System.Drawing.Point(643, 32);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(71, 56);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 5;
			this.pictureBox4.TabStop = false;
			this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
			// 
			// label_Caminho
			// 
			this.label_Caminho.AutoSize = true;
			this.label_Caminho.BackColor = System.Drawing.Color.Transparent;
			this.label_Caminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Caminho.Location = new System.Drawing.Point(390, 365);
			this.label_Caminho.Name = "label_Caminho";
			this.label_Caminho.Size = new System.Drawing.Size(122, 13);
			this.label_Caminho.TabIndex = 6;
			this.label_Caminho.Text = "Caminho do Perfct World";
			this.label_Caminho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label_Caminho.Visible = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = global::AbrirPW.Properties.Resources.x2;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(564, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(39, 36);
			this.button1.TabIndex = 4;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox_Add
			// 
			this.pictureBox_Add.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Add.BackgroundImage = global::AbrirPW.Properties.Resources.x;
			this.pictureBox_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.add2;
			this.pictureBox_Add.Location = new System.Drawing.Point(408, 394);
			this.pictureBox_Add.Name = "pictureBox_Add";
			this.pictureBox_Add.Size = new System.Drawing.Size(210, 73);
			this.pictureBox_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Add.TabIndex = 5;
			this.pictureBox_Add.TabStop = false;
			this.pictureBox_Add.Click += new System.EventHandler(this.pictureBox_Add_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(325, 364);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(246, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Caminho da Pasta \"elemente\" do seu  Perfct World";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// caminho_pwTableAdapter
			// 
			this.caminho_pwTableAdapter.ClearBeforeFill = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.pictureBox1.Image = global::AbrirPW.Properties.Resources.pw;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(755, 511);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// contextMenuStrip_GRID
			// 
			this.contextMenuStrip_GRID.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dELETARToolStripMenuItem,
            this.eDITARToolStripMenuItem});
			this.contextMenuStrip_GRID.Name = "contextMenuStrip_GRID";
			this.contextMenuStrip_GRID.Size = new System.Drawing.Size(123, 48);
			// 
			// dELETARToolStripMenuItem
			// 
			this.dELETARToolStripMenuItem.Image = global::AbrirPW.Properties.Resources.unnamed;
			this.dELETARToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
			this.dELETARToolStripMenuItem.Name = "dELETARToolStripMenuItem";
			this.dELETARToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.dELETARToolStripMenuItem.Text = "DELETAR";
			this.dELETARToolStripMenuItem.Click += new System.EventHandler(this.dELETARToolStripMenuItem_Click);
			// 
			// eDITARToolStripMenuItem
			// 
			this.eDITARToolStripMenuItem.Image = global::AbrirPW.Properties.Resources.imp;
			this.eDITARToolStripMenuItem.Name = "eDITARToolStripMenuItem";
			this.eDITARToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
			this.eDITARToolStripMenuItem.Text = "EDITAR";
			this.eDITARToolStripMenuItem.Click += new System.EventHandler(this.eDITARToolStripMenuItem_Click);
			// 
			// Form_Pw
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BackgroundImage = global::AbrirPW.Properties.Resources.pw;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(755, 511);
			this.Controls.Add(this.dataGridView_PW);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_Caminho);
			this.Controls.Add(this.pictureBox_Add);
			this.Controls.Add(this.button_buscar);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.textBox_NomePw);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.pictureBox1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form_Pw";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registrar Perfect World";
			this.Load += new System.EventHandler(this.Form_Pw_Load);
			this.Shown += new System.EventHandler(this.Form_Pw_Shown);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.contextMenuStrip_GRID.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBox_NomePw;
		private System.Windows.Forms.DataGridView dataGridView_PW;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.Button button_buscar;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.Label label_Caminho;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox_Add;
		private pwDBDataSet pwDBDataSet;
		private System.Windows.Forms.BindingSource caminhopwBindingSource;
		private pwDBDataSetTableAdapters.caminho_pwTableAdapter caminho_pwTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn ID_PW;
		private System.Windows.Forms.DataGridViewTextBoxColumn PW;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoPwDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_GRID;
		private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
	}
}