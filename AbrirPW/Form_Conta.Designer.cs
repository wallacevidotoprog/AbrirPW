namespace AbrirPW
{
	partial class Form_Conta
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Conta));
			this.pictureBox_sair = new System.Windows.Forms.PictureBox();
			this.textBox_Login = new System.Windows.Forms.TextBox();
			this.dataGridView_ContaCriar = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomePw = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contextMenuStrip_GRID = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dELETARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eDITARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contaspwBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet1 = new AbrirPW.pwDBDataSet();
			this.pictureBox_Classes = new System.Windows.Forms.PictureBox();
			this.comboBox_Classes = new System.Windows.Forms.ComboBox();
			this.pictureBox_Add = new System.Windows.Forms.PictureBox();
			this.textBox_Senha = new System.Windows.Forms.TextBox();
			this.textBox_Char = new System.Windows.Forms.TextBox();
			this.comboBox_IdPw = new System.Windows.Forms.ComboBox();
			this.caminho_pwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet = new AbrirPW.pwDBDataSet();
			this.contas_pwTableAdapter = new AbrirPW.pwDBDataSetTableAdapters.contas_pwTableAdapter();
			this.caminho_pwTableAdapter = new AbrirPW.pwDBDataSetTableAdapters.caminho_pwTableAdapter();
			this.tableAdapterManager = new AbrirPW.pwDBDataSetTableAdapters.TableAdapterManager();
			this.contaspwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.checkBox_SENHA = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sair)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContaCriar)).BeginInit();
			this.contextMenuStrip_GRID.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caminho_pwBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox_sair
			// 
			this.pictureBox_sair.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_sair.BackgroundImage = global::AbrirPW.Properties.Resources.x;
			this.pictureBox_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_sair.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_sair.Location = new System.Drawing.Point(12, 12);
			this.pictureBox_sair.Name = "pictureBox_sair";
			this.pictureBox_sair.Size = new System.Drawing.Size(49, 40);
			this.pictureBox_sair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_sair.TabIndex = 6;
			this.pictureBox_sair.TabStop = false;
			this.pictureBox_sair.Click += new System.EventHandler(this.pictureBox_sair_Click);
			// 
			// textBox_Login
			// 
			this.textBox_Login.BackColor = System.Drawing.SystemColors.Menu;
			this.textBox_Login.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.textBox_Login.Location = new System.Drawing.Point(498, 177);
			this.textBox_Login.Multiline = true;
			this.textBox_Login.Name = "textBox_Login";
			this.textBox_Login.Size = new System.Drawing.Size(191, 36);
			this.textBox_Login.TabIndex = 1;
			this.textBox_Login.Text = "login";
			this.textBox_Login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Login.Click += new System.EventHandler(this.textBox_Login_Click);
			// 
			// dataGridView_ContaCriar
			// 
			this.dataGridView_ContaCriar.AllowUserToAddRows = false;
			this.dataGridView_ContaCriar.AllowUserToDeleteRows = false;
			this.dataGridView_ContaCriar.AllowUserToResizeColumns = false;
			this.dataGridView_ContaCriar.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dataGridView_ContaCriar.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_ContaCriar.AutoGenerateColumns = false;
			this.dataGridView_ContaCriar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.dataGridView_ContaCriar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_ContaCriar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_ContaCriar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_ContaCriar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_ContaCriar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.NomePw,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.pwDataGridViewTextBoxColumn,
            this.NomeChar,
            this.classeDataGridViewTextBoxColumn});
			this.dataGridView_ContaCriar.ContextMenuStrip = this.contextMenuStrip_GRID;
			this.dataGridView_ContaCriar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_ContaCriar.DataSource = this.contaspwBindingSource1;
			this.dataGridView_ContaCriar.GridColor = System.Drawing.Color.White;
			this.dataGridView_ContaCriar.Location = new System.Drawing.Point(24, 48);
			this.dataGridView_ContaCriar.MultiSelect = false;
			this.dataGridView_ContaCriar.Name = "dataGridView_ContaCriar";
			this.dataGridView_ContaCriar.ReadOnly = true;
			this.dataGridView_ContaCriar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridView_ContaCriar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridView_ContaCriar.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_ContaCriar.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dataGridView_ContaCriar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_ContaCriar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_ContaCriar.Size = new System.Drawing.Size(355, 432);
			this.dataGridView_ContaCriar.TabIndex = 6;
			this.dataGridView_ContaCriar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Conta_CellDoubleClick);
			this.dataGridView_ContaCriar.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_ContaCriar_CellMouseClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "ID";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			this.idDataGridViewTextBoxColumn.Width = 43;
			// 
			// NomePw
			// 
			this.NomePw.DataPropertyName = "NomePw";
			this.NomePw.FillWeight = 170.5584F;
			this.NomePw.HeaderText = "NOME PW";
			this.NomePw.Name = "NomePw";
			this.NomePw.ReadOnly = true;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.FillWeight = 110.408F;
			this.loginDataGridViewTextBoxColumn.HeaderText = "LOGIN";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			this.loginDataGridViewTextBoxColumn.Width = 97;
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
			this.senhaDataGridViewTextBoxColumn.FillWeight = 110.408F;
			this.senhaDataGridViewTextBoxColumn.HeaderText = "SENHA";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
			this.senhaDataGridViewTextBoxColumn.Visible = false;
			this.senhaDataGridViewTextBoxColumn.Width = 97;
			// 
			// pwDataGridViewTextBoxColumn
			// 
			this.pwDataGridViewTextBoxColumn.DataPropertyName = "pw";
			this.pwDataGridViewTextBoxColumn.HeaderText = "P. W.";
			this.pwDataGridViewTextBoxColumn.Name = "pwDataGridViewTextBoxColumn";
			this.pwDataGridViewTextBoxColumn.ReadOnly = true;
			this.pwDataGridViewTextBoxColumn.Visible = false;
			this.pwDataGridViewTextBoxColumn.Width = 59;
			// 
			// NomeChar
			// 
			this.NomeChar.DataPropertyName = "NomeChar";
			this.NomeChar.HeaderText = "NOME CHAR";
			this.NomeChar.Name = "NomeChar";
			this.NomeChar.ReadOnly = true;
			this.NomeChar.Width = 97;
			// 
			// classeDataGridViewTextBoxColumn
			// 
			this.classeDataGridViewTextBoxColumn.DataPropertyName = "classe";
			this.classeDataGridViewTextBoxColumn.FillWeight = 8.625625F;
			this.classeDataGridViewTextBoxColumn.HeaderText = "CLASSE";
			this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
			this.classeDataGridViewTextBoxColumn.ReadOnly = true;
			this.classeDataGridViewTextBoxColumn.Width = 58;
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
			// contaspwBindingSource1
			// 
			this.contaspwBindingSource1.DataMember = "contas_pw";
			this.contaspwBindingSource1.DataSource = this.pwDBDataSet1;
			// 
			// pwDBDataSet1
			// 
			this.pwDBDataSet1.DataSetName = "pwDBDataSet";
			this.pwDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pictureBox_Classes
			// 
			this.pictureBox_Classes.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.neutro;
			this.pictureBox_Classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Classes.Location = new System.Drawing.Point(541, 23);
			this.pictureBox_Classes.Name = "pictureBox_Classes";
			this.pictureBox_Classes.Size = new System.Drawing.Size(110, 97);
			this.pictureBox_Classes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox_Classes.TabIndex = 9;
			this.pictureBox_Classes.TabStop = false;
			// 
			// comboBox_Classes
			// 
			this.comboBox_Classes.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBox_Classes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Classes.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox_Classes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.comboBox_Classes.FormattingEnabled = true;
			this.comboBox_Classes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBox_Classes.Items.AddRange(new object[] {
            "[ CLASSE ]",
            "WR",
            "MG",
            " ",
            "EA",
            "EP",
            " ",
            "WB",
            "WF",
            " ",
            "MC",
            "PSY",
            " ",
            "SK",
            "MS",
            " ",
            "RT",
            "TM"});
			this.comboBox_Classes.Location = new System.Drawing.Point(532, 125);
			this.comboBox_Classes.Name = "comboBox_Classes";
			this.comboBox_Classes.Size = new System.Drawing.Size(121, 23);
			this.comboBox_Classes.TabIndex = 0;
			this.comboBox_Classes.SelectedIndexChanged += new System.EventHandler(this.comboBox_Classes_SelectedIndexChanged);
			// 
			// pictureBox_Add
			// 
			this.pictureBox_Add.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox_Add.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.进入游戏选择;
			this.pictureBox_Add.Location = new System.Drawing.Point(480, 376);
			this.pictureBox_Add.Name = "pictureBox_Add";
			this.pictureBox_Add.Size = new System.Drawing.Size(230, 94);
			this.pictureBox_Add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_Add.TabIndex = 6;
			this.pictureBox_Add.TabStop = false;
			this.pictureBox_Add.Click += new System.EventHandler(this.pictureBox_Add_Click);
			// 
			// textBox_Senha
			// 
			this.textBox_Senha.BackColor = System.Drawing.SystemColors.Menu;
			this.textBox_Senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Senha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.textBox_Senha.Location = new System.Drawing.Point(498, 241);
			this.textBox_Senha.Multiline = true;
			this.textBox_Senha.Name = "textBox_Senha";
			this.textBox_Senha.PasswordChar = '*';
			this.textBox_Senha.Size = new System.Drawing.Size(191, 36);
			this.textBox_Senha.TabIndex = 2;
			this.textBox_Senha.Text = "senha";
			this.textBox_Senha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Senha.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Senha_MouseClick);
			// 
			// textBox_Char
			// 
			this.textBox_Char.BackColor = System.Drawing.SystemColors.Menu;
			this.textBox_Char.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox_Char.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox_Char.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.textBox_Char.Location = new System.Drawing.Point(498, 304);
			this.textBox_Char.Multiline = true;
			this.textBox_Char.Name = "textBox_Char";
			this.textBox_Char.Size = new System.Drawing.Size(191, 36);
			this.textBox_Char.TabIndex = 3;
			this.textBox_Char.Text = "personagem";
			this.textBox_Char.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.textBox_Char.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Char_MouseClick);
			// 
			// comboBox_IdPw
			// 
			this.comboBox_IdPw.Cursor = System.Windows.Forms.Cursors.Default;
			this.comboBox_IdPw.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.caminho_pwBindingSource, "id", true));
			this.comboBox_IdPw.DataSource = this.pwDBDataSet;
			this.comboBox_IdPw.DisplayMember = "caminho_pw.Nome_Pw";
			this.comboBox_IdPw.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_IdPw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
			this.comboBox_IdPw.FormattingEnabled = true;
			this.comboBox_IdPw.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.comboBox_IdPw.Location = new System.Drawing.Point(502, 349);
			this.comboBox_IdPw.Name = "comboBox_IdPw";
			this.comboBox_IdPw.Size = new System.Drawing.Size(182, 21);
			this.comboBox_IdPw.TabIndex = 4;
			this.comboBox_IdPw.ValueMember = "caminho_pw.id";
			// 
			// caminho_pwBindingSource
			// 
			this.caminho_pwBindingSource.DataMember = "caminho_pw";
			this.caminho_pwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// pwDBDataSet
			// 
			this.pwDBDataSet.DataSetName = "pwDBDataSet";
			this.pwDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// contas_pwTableAdapter
			// 
			this.contas_pwTableAdapter.ClearBeforeFill = true;
			// 
			// caminho_pwTableAdapter
			// 
			this.caminho_pwTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.caminho_pwTableAdapter = this.caminho_pwTableAdapter;
			this.tableAdapterManager.contas_pwTableAdapter = this.contas_pwTableAdapter;
			this.tableAdapterManager.UpdateOrder = AbrirPW.pwDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// contaspwBindingSource
			// 
			this.contaspwBindingSource.DataSource = this.pwDBDataSet;
			this.contaspwBindingSource.Position = 0;
			// 
			// checkBox_SENHA
			// 
			this.checkBox_SENHA.AutoSize = true;
			this.checkBox_SENHA.Checked = true;
			this.checkBox_SENHA.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBox_SENHA.Location = new System.Drawing.Point(695, 249);
			this.checkBox_SENHA.Name = "checkBox_SENHA";
			this.checkBox_SENHA.Size = new System.Drawing.Size(15, 14);
			this.checkBox_SENHA.TabIndex = 12;
			this.checkBox_SENHA.UseVisualStyleBackColor = true;
			this.checkBox_SENHA.CheckedChanged += new System.EventHandler(this.checkBox_SENHA_CheckedChanged);
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = global::AbrirPW.Properties.Resources.conta;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(804, 529);
			this.panel1.TabIndex = 13;
			// 
			// Form_Conta
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BackgroundImage = global::AbrirPW.Properties.Resources.conta;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(804, 529);
			this.Controls.Add(this.checkBox_SENHA);
			this.Controls.Add(this.pictureBox_Classes);
			this.Controls.Add(this.comboBox_IdPw);
			this.Controls.Add(this.comboBox_Classes);
			this.Controls.Add(this.dataGridView_ContaCriar);
			this.Controls.Add(this.textBox_Char);
			this.Controls.Add(this.textBox_Senha);
			this.Controls.Add(this.textBox_Login);
			this.Controls.Add(this.pictureBox_Add);
			this.Controls.Add(this.pictureBox_sair);
			this.Controls.Add(this.panel1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_Conta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Registrar Conta";
			this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Load += new System.EventHandler(this.Form_Conta_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_sair)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_ContaCriar)).EndInit();
			this.contextMenuStrip_GRID.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Add)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caminho_pwBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox_sair;
		private System.Windows.Forms.TextBox textBox_Login;
		private System.Windows.Forms.PictureBox pictureBox_Classes;
		private System.Windows.Forms.ComboBox comboBox_Classes;
		private System.Windows.Forms.PictureBox pictureBox_Add;
		private System.Windows.Forms.TextBox textBox_Senha;
		private pwDBDataSet pwDBDataSet;
		private pwDBDataSetTableAdapters.contas_pwTableAdapter contas_pwTableAdapter;
		private System.Windows.Forms.BindingSource caminho_pwBindingSource;
		private pwDBDataSetTableAdapters.caminho_pwTableAdapter caminho_pwTableAdapter;
		private pwDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.ComboBox comboBox_IdPw;
		private System.Windows.Forms.DataGridView dataGridView_ContaCriar;
		private pwDBDataSet pwDBDataSet1;
		private System.Windows.Forms.BindingSource contaspwBindingSource;
		private System.Windows.Forms.BindingSource contaspwBindingSource1;
		private System.Windows.Forms.TextBox textBox_Char;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NomePw;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pwDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NomeChar;
		private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
		private System.Windows.Forms.CheckBox checkBox_SENHA;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_GRID;
		private System.Windows.Forms.ToolStripMenuItem dELETARToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eDITARToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
	}
}