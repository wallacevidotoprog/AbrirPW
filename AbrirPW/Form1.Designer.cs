namespace AbrirPW
{
	partial class Form1
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.configuraçõesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarPerfectWorldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.atualizarDadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.adicionarPerfectWorldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.dataGridView_Conta = new System.Windows.Forms.DataGridView();
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.senhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomePwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NomeChar = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoBatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contaspwBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet1 = new AbrirPW.pwDBDataSet();
			this.pictureBox_Classes = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.dataGridView_PW = new System.Windows.Forms.DataGridView();
			this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nome_Pw = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhoPwDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.caminhopwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.pwDBDataSet = new AbrirPW.pwDBDataSet();
			this.button_Play = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.login = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.contaspwBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.caminho_pwTableAdapter = new AbrirPW.pwDBDataSetTableAdapters.caminho_pwTableAdapter();
			this.contas_pwTableAdapter = new AbrirPW.pwDBDataSetTableAdapters.contas_pwTableAdapter();
			this.tableAdapterManager = new AbrirPW.pwDBDataSetTableAdapters.TableAdapterManager();
			this.button_Fechar = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.notifyIcon_PW = new System.Windows.Forms.NotifyIcon(this.components);
			this.contextMenuStrip_NOTE = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.aBRIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aUTOLOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDMCONTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aDMPWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.fECHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox_START = new System.Windows.Forms.PictureBox();
			this.menuStrip.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Conta)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.contextMenuStrip_NOTE.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_START)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem1,
            this.atualizarDadosToolStripMenuItem,
            this.sobreToolStripMenuItem1});
			this.menuStrip.Location = new System.Drawing.Point(139, 38);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip.Size = new System.Drawing.Size(261, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// configuraçõesToolStripMenuItem1
			// 
			this.configuraçõesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarPerfectWorldToolStripMenuItem1,
            this.adicionarContaToolStripMenuItem});
			this.configuraçõesToolStripMenuItem1.Name = "configuraçõesToolStripMenuItem1";
			this.configuraçõesToolStripMenuItem1.Size = new System.Drawing.Size(98, 20);
			this.configuraçõesToolStripMenuItem1.Text = "Configurações";
			// 
			// adicionarPerfectWorldToolStripMenuItem1
			// 
			this.adicionarPerfectWorldToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
			this.adicionarPerfectWorldToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.adicionarPerfectWorldToolStripMenuItem1.Image = global::AbrirPW.Properties.Resources.seta;
			this.adicionarPerfectWorldToolStripMenuItem1.Name = "adicionarPerfectWorldToolStripMenuItem1";
			this.adicionarPerfectWorldToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
			this.adicionarPerfectWorldToolStripMenuItem1.Text = "Adicionar Perfect World";
			this.adicionarPerfectWorldToolStripMenuItem1.Click += new System.EventHandler(this.adicionarPerfectWorldToolStripMenuItem1_Click);
			// 
			// adicionarContaToolStripMenuItem
			// 
			this.adicionarContaToolStripMenuItem.Image = global::AbrirPW.Properties.Resources.seta;
			this.adicionarContaToolStripMenuItem.Name = "adicionarContaToolStripMenuItem";
			this.adicionarContaToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
			this.adicionarContaToolStripMenuItem.Text = "Adicionar Conta";
			this.adicionarContaToolStripMenuItem.Click += new System.EventHandler(this.adicionarContaToolStripMenuItem_Click);
			// 
			// atualizarDadosToolStripMenuItem
			// 
			this.atualizarDadosToolStripMenuItem.Name = "atualizarDadosToolStripMenuItem";
			this.atualizarDadosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
			this.atualizarDadosToolStripMenuItem.Text = "Atualizar dados";
			this.atualizarDadosToolStripMenuItem.Click += new System.EventHandler(this.atualizarDadosToolStripMenuItem_Click);
			// 
			// sobreToolStripMenuItem1
			// 
			this.sobreToolStripMenuItem1.Name = "sobreToolStripMenuItem1";
			this.sobreToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
			this.sobreToolStripMenuItem1.Text = "Sobre";
			this.sobreToolStripMenuItem1.Click += new System.EventHandler(this.sobreToolStripMenuItem1_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
			this.toolStripMenuItem1.Text = "...";
			// 
			// sobreToolStripMenuItem
			// 
			this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
			this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
			this.sobreToolStripMenuItem.Text = "Sobre";
			// 
			// configuraçõesToolStripMenuItem
			// 
			this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarPerfectWorldToolStripMenuItem,
            this.toolStripSeparator1,
            this.contasToolStripMenuItem,
            this.toolStripSeparator2});
			this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
			this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
			this.configuraçõesToolStripMenuItem.Text = "Configurações";
			// 
			// adicionarPerfectWorldToolStripMenuItem
			// 
			this.adicionarPerfectWorldToolStripMenuItem.Name = "adicionarPerfectWorldToolStripMenuItem";
			this.adicionarPerfectWorldToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.adicionarPerfectWorldToolStripMenuItem.Text = "Adicionar Perfect World";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(197, 6);
			// 
			// contasToolStripMenuItem
			// 
			this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
			this.contasToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
			this.contasToolStripMenuItem.Text = "Contas";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(197, 6);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.dataGridView_Conta);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(241, 71);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(259, 293);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Contas";
			// 
			// dataGridView_Conta
			// 
			this.dataGridView_Conta.AllowUserToAddRows = false;
			this.dataGridView_Conta.AllowUserToDeleteRows = false;
			this.dataGridView_Conta.AllowUserToResizeColumns = false;
			this.dataGridView_Conta.AllowUserToResizeRows = false;
			this.dataGridView_Conta.AutoGenerateColumns = false;
			this.dataGridView_Conta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_Conta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_Conta.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_Conta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_Conta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Conta.ColumnHeadersVisible = false;
			this.dataGridView_Conta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.senhaDataGridViewTextBoxColumn,
            this.pwDataGridViewTextBoxColumn,
            this.nomePwDataGridViewTextBoxColumn,
            this.NomeChar,
            this.classeDataGridViewTextBoxColumn,
            this.caminhoBatDataGridViewTextBoxColumn});
			this.dataGridView_Conta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_Conta.DataSource = this.contaspwBindingSource1;
			this.dataGridView_Conta.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_Conta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_Conta.Location = new System.Drawing.Point(3, 16);
			this.dataGridView_Conta.Name = "dataGridView_Conta";
			this.dataGridView_Conta.ReadOnly = true;
			this.dataGridView_Conta.RowHeadersVisible = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_Conta.RowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridView_Conta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_Conta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_Conta.Size = new System.Drawing.Size(253, 274);
			this.dataGridView_Conta.TabIndex = 1;
			this.dataGridView_Conta.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_Conta_CellMouseClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			this.idDataGridViewTextBoxColumn.ReadOnly = true;
			this.idDataGridViewTextBoxColumn.Visible = false;
			// 
			// loginDataGridViewTextBoxColumn
			// 
			this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
			this.loginDataGridViewTextBoxColumn.FillWeight = 121.8274F;
			this.loginDataGridViewTextBoxColumn.HeaderText = "login";
			this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
			this.loginDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// senhaDataGridViewTextBoxColumn
			// 
			this.senhaDataGridViewTextBoxColumn.DataPropertyName = "senha";
			this.senhaDataGridViewTextBoxColumn.HeaderText = "senha";
			this.senhaDataGridViewTextBoxColumn.Name = "senhaDataGridViewTextBoxColumn";
			this.senhaDataGridViewTextBoxColumn.ReadOnly = true;
			this.senhaDataGridViewTextBoxColumn.Visible = false;
			// 
			// pwDataGridViewTextBoxColumn
			// 
			this.pwDataGridViewTextBoxColumn.DataPropertyName = "pw";
			this.pwDataGridViewTextBoxColumn.HeaderText = "pw";
			this.pwDataGridViewTextBoxColumn.Name = "pwDataGridViewTextBoxColumn";
			this.pwDataGridViewTextBoxColumn.ReadOnly = true;
			this.pwDataGridViewTextBoxColumn.Visible = false;
			// 
			// nomePwDataGridViewTextBoxColumn
			// 
			this.nomePwDataGridViewTextBoxColumn.DataPropertyName = "NomePw";
			this.nomePwDataGridViewTextBoxColumn.HeaderText = "NomePw";
			this.nomePwDataGridViewTextBoxColumn.Name = "nomePwDataGridViewTextBoxColumn";
			this.nomePwDataGridViewTextBoxColumn.ReadOnly = true;
			this.nomePwDataGridViewTextBoxColumn.Visible = false;
			// 
			// NomeChar
			// 
			this.NomeChar.DataPropertyName = "NomeChar";
			this.NomeChar.FillWeight = 98.20537F;
			this.NomeChar.HeaderText = "NomeChar";
			this.NomeChar.Name = "NomeChar";
			this.NomeChar.ReadOnly = true;
			// 
			// classeDataGridViewTextBoxColumn
			// 
			this.classeDataGridViewTextBoxColumn.DataPropertyName = "classe";
			this.classeDataGridViewTextBoxColumn.FillWeight = 79.96722F;
			this.classeDataGridViewTextBoxColumn.HeaderText = "classe";
			this.classeDataGridViewTextBoxColumn.Name = "classeDataGridViewTextBoxColumn";
			this.classeDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// caminhoBatDataGridViewTextBoxColumn
			// 
			this.caminhoBatDataGridViewTextBoxColumn.DataPropertyName = "caminhoBat";
			this.caminhoBatDataGridViewTextBoxColumn.HeaderText = "caminhoBat";
			this.caminhoBatDataGridViewTextBoxColumn.Name = "caminhoBatDataGridViewTextBoxColumn";
			this.caminhoBatDataGridViewTextBoxColumn.ReadOnly = true;
			this.caminhoBatDataGridViewTextBoxColumn.Visible = false;
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
			this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.piscadinha;
			this.pictureBox_Classes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox_Classes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox_Classes.Location = new System.Drawing.Point(3, 16);
			this.pictureBox_Classes.Name = "pictureBox_Classes";
			this.pictureBox_Classes.Size = new System.Drawing.Size(182, 120);
			this.pictureBox_Classes.TabIndex = 10;
			this.pictureBox_Classes.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.dataGridView_PW);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(29, 71);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(209, 293);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Perfect Wolrd";
			// 
			// dataGridView_PW
			// 
			this.dataGridView_PW.AllowUserToAddRows = false;
			this.dataGridView_PW.AllowUserToDeleteRows = false;
			this.dataGridView_PW.AllowUserToResizeColumns = false;
			this.dataGridView_PW.AllowUserToResizeRows = false;
			this.dataGridView_PW.AutoGenerateColumns = false;
			this.dataGridView_PW.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView_PW.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridView_PW.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.dataGridView_PW.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.dataGridView_PW.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_PW.ColumnHeadersVisible = false;
			this.dataGridView_PW.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nome_Pw,
            this.caminhoPwDataGridViewTextBoxColumn});
			this.dataGridView_PW.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridView_PW.DataSource = this.caminhopwBindingSource;
			this.dataGridView_PW.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView_PW.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.dataGridView_PW.Location = new System.Drawing.Point(3, 16);
			this.dataGridView_PW.MultiSelect = false;
			this.dataGridView_PW.Name = "dataGridView_PW";
			this.dataGridView_PW.ReadOnly = true;
			this.dataGridView_PW.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
			this.dataGridView_PW.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridView_PW.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView_PW.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridView_PW.Size = new System.Drawing.Size(203, 274);
			this.dataGridView_PW.TabIndex = 0;
			this.dataGridView_PW.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_PW_CellMouseClick);
			// 
			// id
			// 
			this.id.DataPropertyName = "id";
			this.id.HeaderText = "ID";
			this.id.Name = "id";
			this.id.ReadOnly = true;
			this.id.Visible = false;
			// 
			// Nome_Pw
			// 
			this.Nome_Pw.DataPropertyName = "Nome_Pw";
			this.Nome_Pw.HeaderText = "PW";
			this.Nome_Pw.Name = "Nome_Pw";
			this.Nome_Pw.ReadOnly = true;
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
			// button_Play
			// 
			this.button_Play.BackColor = System.Drawing.Color.Transparent;
			this.button_Play.BackgroundImage = global::AbrirPW.Properties.Resources.小虎占卜底板;
			this.button_Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.button_Play.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Play.FlatAppearance.BorderSize = 0;
			this.button_Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button_Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button_Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Play.Location = new System.Drawing.Point(528, 150);
			this.button_Play.Name = "button_Play";
			this.button_Play.Size = new System.Drawing.Size(197, 137);
			this.button_Play.TabIndex = 2;
			this.button_Play.UseVisualStyleBackColor = false;
			this.button_Play.Click += new System.EventHandler(this.button_Play_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
			this.dataGridViewTextBoxColumn1.HeaderText = "id";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// login
			// 
			this.login.DataPropertyName = "login";
			this.login.HeaderText = "login";
			this.login.Name = "login";
			// 
			// contaspwBindingSource
			// 
			this.contaspwBindingSource.DataMember = "contas_pw";
			this.contaspwBindingSource.DataSource = this.pwDBDataSet;
			// 
			// caminho_pwTableAdapter
			// 
			this.caminho_pwTableAdapter.ClearBeforeFill = true;
			// 
			// contas_pwTableAdapter
			// 
			this.contas_pwTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.caminho_pwTableAdapter = this.caminho_pwTableAdapter;
			this.tableAdapterManager.contas_pwTableAdapter = this.contas_pwTableAdapter;
			this.tableAdapterManager.UpdateOrder = AbrirPW.pwDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// button_Fechar
			// 
			this.button_Fechar.BackColor = System.Drawing.Color.Transparent;
			this.button_Fechar.BackgroundImage = global::AbrirPW.Properties.Resources.fechar;
			this.button_Fechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button_Fechar.FlatAppearance.BorderSize = 0;
			this.button_Fechar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.button_Fechar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.button_Fechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Fechar.Location = new System.Drawing.Point(474, 12);
			this.button_Fechar.Name = "button_Fechar";
			this.button_Fechar.Size = new System.Drawing.Size(37, 23);
			this.button_Fechar.TabIndex = 11;
			this.button_Fechar.UseVisualStyleBackColor = false;
			this.button_Fechar.Click += new System.EventHandler(this.button_Fechar_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.Transparent;
			this.groupBox4.Controls.Add(this.pictureBox_Classes);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox4.ForeColor = System.Drawing.Color.White;
			this.groupBox4.Location = new System.Drawing.Point(32, 382);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(188, 139);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Classe Selecionada";
			// 
			// notifyIcon_PW
			// 
			this.notifyIcon_PW.ContextMenuStrip = this.contextMenuStrip_NOTE;
			this.notifyIcon_PW.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon_PW.Icon")));
			this.notifyIcon_PW.Text = "FACILITADOR";
			this.notifyIcon_PW.Visible = true;
			// 
			// contextMenuStrip_NOTE
			// 
			this.contextMenuStrip_NOTE.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aBRIRToolStripMenuItem,
            this.fECHARToolStripMenuItem});
			this.contextMenuStrip_NOTE.Name = "contextMenuStrip_NOTE";
			this.contextMenuStrip_NOTE.Size = new System.Drawing.Size(119, 48);
			// 
			// aBRIRToolStripMenuItem
			// 
			this.aBRIRToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aUTOLOGINToolStripMenuItem,
            this.aDMCONTAToolStripMenuItem,
            this.aDMPWToolStripMenuItem});
			this.aBRIRToolStripMenuItem.Name = "aBRIRToolStripMenuItem";
			this.aBRIRToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.aBRIRToolStripMenuItem.Text = "ABRIR";
			// 
			// aUTOLOGINToolStripMenuItem
			// 
			this.aUTOLOGINToolStripMenuItem.Name = "aUTOLOGINToolStripMenuItem";
			this.aUTOLOGINToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.aUTOLOGINToolStripMenuItem.Text = "AUTO LOGIN";
			this.aUTOLOGINToolStripMenuItem.Click += new System.EventHandler(this.aUTOLOGINToolStripMenuItem_Click);
			// 
			// aDMCONTAToolStripMenuItem
			// 
			this.aDMCONTAToolStripMenuItem.Name = "aDMCONTAToolStripMenuItem";
			this.aDMCONTAToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.aDMCONTAToolStripMenuItem.Text = "ADM. CONTA";
			this.aDMCONTAToolStripMenuItem.Click += new System.EventHandler(this.aDMCONTAToolStripMenuItem_Click);
			// 
			// aDMPWToolStripMenuItem
			// 
			this.aDMPWToolStripMenuItem.Name = "aDMPWToolStripMenuItem";
			this.aDMPWToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
			this.aDMPWToolStripMenuItem.Text = "ADM. PW";
			this.aDMPWToolStripMenuItem.Click += new System.EventHandler(this.aDMPWToolStripMenuItem_Click);
			// 
			// fECHARToolStripMenuItem
			// 
			this.fECHARToolStripMenuItem.Name = "fECHARToolStripMenuItem";
			this.fECHARToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
			this.fECHARToolStripMenuItem.Text = "FECHAR";
			this.fECHARToolStripMenuItem.Click += new System.EventHandler(this.fECHARToolStripMenuItem_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			this.panel1.Location = new System.Drawing.Point(12, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(504, 32);
			this.panel1.TabIndex = 14;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
			// 
			// pictureBox_START
			// 
			this.pictureBox_START.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox_START.Cursor = System.Windows.Forms.Cursors.Hand;
			//this.pictureBox_START.Image = global::AbrirPW.Properties.Resources.btn_fix1;
			this.pictureBox_START.Location = new System.Drawing.Point(223, 382);
			this.pictureBox_START.Name = "pictureBox_START";
			this.pictureBox_START.Size = new System.Drawing.Size(277, 142);
			this.pictureBox_START.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox_START.TabIndex = 15;
			this.pictureBox_START.TabStop = false;
			this.pictureBox_START.MouseLeave += new System.EventHandler(this.pictureBox_START_MouseLeave);
			this.pictureBox_START.MouseHover += new System.EventHandler(this.pictureBox_START_MouseHover);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(65)))), ((int)(((byte)(57)))));
			this.BackgroundImage = global::AbrirPW.Properties.Resources.接受任务;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(782, 536);
			this.Controls.Add(this.pictureBox_START);
			this.Controls.Add(this.button_Fechar);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.button_Play);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.DoubleBuffered = true;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Percft World";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Conta)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_Classes)).EndInit();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_PW)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caminhopwBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pwDBDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.contaspwBindingSource)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.contextMenuStrip_NOTE.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox_START)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem adicionarPerfectWorldToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.DataGridView dataGridView_PW;
		private System.Windows.Forms.DataGridView dataGridView_Conta;
		private System.Windows.Forms.Button button_Play;
		private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem adicionarPerfectWorldToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem adicionarContaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem1;
		private System.Windows.Forms.PictureBox pictureBox_Classes;
		private System.Windows.Forms.ToolStripMenuItem atualizarDadosToolStripMenuItem;
		private pwDBDataSet pwDBDataSet;
		private System.Windows.Forms.BindingSource caminhopwBindingSource;
		private pwDBDataSetTableAdapters.caminho_pwTableAdapter caminho_pwTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn id;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nome_Pw;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoPwDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource contaspwBindingSource;
		private pwDBDataSetTableAdapters.contas_pwTableAdapter contas_pwTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn login;
		private pwDBDataSet pwDBDataSet1;
		private System.Windows.Forms.BindingSource contaspwBindingSource1;
		private pwDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn senhaDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn pwDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomePwDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NomeChar;
		private System.Windows.Forms.DataGridViewTextBoxColumn classeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn caminhoBatDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button button_Fechar;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.NotifyIcon notifyIcon_PW;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip_NOTE;
		private System.Windows.Forms.ToolStripMenuItem aBRIRToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aUTOLOGINToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDMCONTAToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aDMPWToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fECHARToolStripMenuItem;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox_START;
	}
}

