using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Runtime.InteropServices;

namespace AbrirPW
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// this.Cursor = new Cursor(Properties.Resources.espada.Handle);
			
		}

		string caminnho = null;
		string conta = null;
		string senha = null;
		string classe = null;
		string bat = null;
		string Char = null;
		string PWC = null; string CONTEXT = null;

		[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
		private extern static void ReleaseCapture();
		[DllImport("user32.DLL", EntryPoint = "SendMessage")]
		private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

		private void Form1_Load(object sender, EventArgs e)
		{
			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			this.TransparencyKey = this.BackColor;


		}

		private void adicionarPerfectWorldToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Form_Pw form_Pw = new Form_Pw();
			form_Pw.ShowDialog(); this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			this.contas_pwTableAdapter.FillByPW(this.pwDBDataSet1.contas_pw, Convert.ToInt32(0));
		}

		private void adicionarContaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Conta form_Pw = new Form_Conta();
			form_Pw.ShowDialog(); this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			this.contas_pwTableAdapter.FillByPW(this.pwDBDataSet1.contas_pw, Convert.ToInt32(0));
		}

		private void button_Play_Click(object sender, EventArgs e)
		{
			if (conta != null)
			{
				try
				{
					var startInfo = new ProcessStartInfo(conta + senha + classe + Char + ".bat");
					startInfo.WorkingDirectory = caminnho;
					Process.Start(startInfo);

					notifyIcon_PW.BalloonTipTitle = "PWzinho";
					notifyIcon_PW.BalloonTipText = "A SUA CONTA ( "+conta+" ) ABRIRA EM BREVE COM O PERSONAGEM ( "+classe+" - "+Char+" ).";
					notifyIcon_PW.BalloonTipIcon = ToolTipIcon.Info;
					notifyIcon_PW.Visible = true;
					notifyIcon_PW.ShowBalloonTip(30000);


					SoundPlayer player = new SoundPlayer(@"sound\play.wav");
					player.Play();
				}
				catch (Exception ex)
				{

					MessageBox.Show("Erro ao iniciar: "+ex);
				}
			}
			
			
		}

		private void dataGridView_Conta_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{

			conta = null;
			senha = null;
			classe = null;
			bat = null;

			conta = dataGridView_Conta.Rows[e.RowIndex].Cells[1].Value.ToString();
			senha = dataGridView_Conta.Rows[e.RowIndex].Cells[2].Value.ToString();
			classe = dataGridView_Conta.Rows[e.RowIndex].Cells[6].Value.ToString();
			bat = dataGridView_Conta.Rows[e.RowIndex].Cells[7].Value.ToString();
			Char = dataGridView_Conta.Rows[e.RowIndex].Cells[5].Value.ToString();
			CONTEXT = dataGridView_Conta.Rows[e.RowIndex].Cells[7].Value.ToString();
			string X = @"\";

		//	MessageBox.Show(""+conta+" $  "+senha+"  $ "+classe+" $   "+bat + " $   " + Char);

			if (bat == "")
			{
				
				StreamWriter x;
				string CaminhoNome = @""+ caminnho + X + conta + senha + classe + Char+".bat";

				try
				{
					x = File.CreateText(CaminhoNome);
					x.WriteLine("start elementclient.exe startbypatcher console:1 user:" + conta + " pwd:" + senha+ " role:" + Char);
					x.Close();

					this.contas_pwTableAdapter.UpdateQueryBAT(CaminhoNome, Convert.ToInt32(dataGridView_Conta.Rows[e.RowIndex].Cells[0].Value.ToString()));
					this.contas_pwTableAdapter.FillByPW(this.pwDBDataSet1.contas_pw, Convert.ToInt32(PWC));
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.piscadinha;
					MessageBox.Show("Olá, é a primeira vez que você abre essa conta nesse programa.\n E por isso o programa tem que executar algumas coisa.\n É só clicar novamente na conta desejada e da um PLAY.\n \n (Essa mensagem só aparece um vez a cada conta nova)","AVISO!!",MessageBoxButtons.OK,MessageBoxIcon.Information);

				}
				catch (Exception ex)
				{

					MessageBox.Show("ERRO ao criar executável: "+ex);
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.piscadinha;
				}
				
			}
			else
			{
				if (classe == "WR")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.wr;
				}
				if (classe == "MG")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.mg;
				}
				if (classe == "EA")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.ea;
				}
				if (classe == "EP")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.ep;
				}
				if (classe == "WB")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.wb;
				}
				if (classe == "WF")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.wf;
				}
				if (classe == "MC")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.mc;
				}
				if (classe == "PSY")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.psy;
				}
				if (classe == "SK")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.sk;
				}
				if (classe == "MS")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.my;
				}
				if (classe == "RT")
				{
					this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.rt;
				}
				if (classe == "TM")
				{
					pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.tm;
				}
			}
			
		}

		
		private void atualizarDadosToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			this.contas_pwTableAdapter.FillByPW(this.pwDBDataSet1.contas_pw, Convert.ToInt32(0));
		}

		private void dataGridView_PW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			string PW = null;

			PW = dataGridView_PW.Rows[e.RowIndex].Cells[0].Value.ToString();
			PWC = dataGridView_PW.Rows[e.RowIndex].Cells[0].Value.ToString();
			caminnho = dataGridView_PW.Rows[e.RowIndex].Cells[2].Value.ToString();
			this.contas_pwTableAdapter.FillByPW(this.pwDBDataSet1.contas_pw, Convert.ToInt32(PW));
		}

		private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			MessageBox.Show(" Dúvidas.\n wallacevidoto@gmail.com");
		}

		private void testToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_PgInicial PgInicial = new Form_PgInicial();
			PgInicial.ShowDialog();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button_Fechar_Click(object sender, EventArgs e)
		{
			//Application.Exit();
			this.Hide();
			notifyIcon_PW.BalloonTipTitle = "PWzinho";
			notifyIcon_PW.BalloonTipText = "ESTOU AQUI SE PRECISAR DOS MEUS SERVIÇOS.";
			notifyIcon_PW.BalloonTipIcon = ToolTipIcon.Info;
			notifyIcon_PW.Visible = true;
			notifyIcon_PW.ShowBalloonTip(30000);
		}

		private void fECHARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void aUTOLOGINToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form1 PgInicial = new Form1();
			PgInicial.Show();
			
		}

		private void aDMCONTAToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Conta PgInicial = new Form_Conta();
			PgInicial.Show();
		}

		private void aDMPWToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form_Pw PgInicial = new Form_Pw();
			PgInicial.Show();
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			ReleaseCapture();
			SendMessage(this.Handle, 0x112, 0xf012, 0);
		}

		private void pictureBox_START_MouseHover(object sender, EventArgs e)
		{
			this.pictureBox_START.Image = Properties.Resources.btn;
		}

		private void pictureBox_START_MouseLeave(object sender, EventArgs e)
		{
			//this.pictureBox_START.Image = Properties.Resources.btn_fix;
		}
	}
}
