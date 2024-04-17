using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirPW
{
	public partial class Form_Conta : Form
	{
		public Form_Conta()
		{
			InitializeComponent();
		}

		int ID = 0;

		private void Form_Conta_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet1.contas_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.contas_pwTableAdapter.FillByFULL(this.pwDBDataSet1.contas_pw);
			//// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet1.contas_pw'. Você pode movê-la ou removê-la conforme necessário.
			//this.contas_pwTableAdapter.Fill(this.pwDBDataSet1.contas_pw);
			//// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet1.contas_pw'. Você pode movê-la ou removê-la conforme necessário.
			//this.contas_pwTableAdapter.Fill(this.pwDBDataSet1.contas_pw);

			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet1.caminho_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);

			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.contas_pw'. Você pode movê-la ou removê-la conforme necessário.
			//this.contas_pwTableAdapter.FillByInnerJoin(this.pwDBDataSet.contas_pw);
			this.TransparencyKey = this.BackColor;
			//textBox_Login.BackColor = TransparencyKey;
			comboBox_Classes.Text = "[ CLASSE ]";
			this.contas_pwTableAdapter.Fill(this.pwDBDataSet.contas_pw);
			dataGridView_ContaCriar.ClearSelection(); //this.textBox_Login.BackColor = this.BackColor;
		}

		private void pictureBox_sair_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void comboBox_Classes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox_Classes.Text == " " | comboBox_Classes.Text == "[ CLASSE ]")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.piscadinha;
			}
			if (comboBox_Classes.Text == "WR")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.wr;
			}
			if (comboBox_Classes.Text == "MG")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.mg;
			}
			if (comboBox_Classes.Text == "EA")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.ea;
			}
			if (comboBox_Classes.Text == "EP")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.ep;
			}
			if (comboBox_Classes.Text == "WB")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.wb;
			}
			if (comboBox_Classes.Text == "WF")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.wf;
			}
			if (comboBox_Classes.Text == "MC")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.mc;
			}
			if (comboBox_Classes.Text == "PSY")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.psy;
			}
			if (comboBox_Classes.Text == "SK")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.sk;
			}
			if (comboBox_Classes.Text == "MS")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.my;
			}
			if (comboBox_Classes.Text == "RT")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.rt;
			}
			if (comboBox_Classes.Text == "TM")
			{
				this.pictureBox_Classes.BackgroundImage = global::AbrirPW.Properties.Resources.tm;
			}


		}

		private void pictureBox_Add_Click(object sender, EventArgs e)
		{
			if (ID == 0)
			{
				

				if (comboBox_Classes.Text != " " && comboBox_Classes.Text != "[ CLASSE ]" && comboBox_IdPw.Text != "" && textBox_Login.Text != "login" && textBox_Senha.Text != "senha")
				{
					try
					{
						int IdConta = 0;
						IdConta = Convert.ToInt32(DateTime.Now.ToString("HHmmss"));

						this.contas_pwTableAdapter.InsertQuerycContas_pw(IdConta, textBox_Login.Text, textBox_Senha.Text, Convert.ToInt32(comboBox_IdPw.SelectedValue), comboBox_Classes.Text, comboBox_IdPw.Text, textBox_Char.Text);
						this.contas_pwTableAdapter.FillByFULL(this.pwDBDataSet1.contas_pw); //this.contas_pwTableAdapter.Fill(this.pwDBDataSet.contas_pw);

						comboBox_Classes.Text = "[ CLASSE ]";
						textBox_Login.Text = "login";
						textBox_Senha.Text = "senha";
						textBox_Char.Text = "Personagem";

						SoundPlayer player = new SoundPlayer(@"sound\criarconta.wav");
						player.Play();
						MessageBox.Show("Registrado", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						dataGridView_ContaCriar.ClearSelection();
					}
					catch (Exception ex)
					{

						MessageBox.Show("ERRO AO INSERIR: " + ex); ;
					}
				}
				else
				{
					MessageBox.Show("Algo não foi preenchido !", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{

				if (comboBox_Classes.Text != " " && comboBox_Classes.Text != "[ CLASSE ]" && comboBox_IdPw.Text != "" && textBox_Login.Text != "login" && textBox_Senha.Text != "senha")
				{


					this.contas_pwTableAdapter.UpdateDADOS(textBox_Login.Text, textBox_Senha.Text, Convert.ToInt32(comboBox_IdPw.SelectedValue),comboBox_IdPw.Text, comboBox_Classes.Text, textBox_Char.Text, ID);

					this.contas_pwTableAdapter.FillByFULL(this.pwDBDataSet1.contas_pw);
					comboBox_Classes.Text = "[ CLASSE ]";
					textBox_Login.Text = "login";
					textBox_Senha.Text = "senha";
					textBox_Char.Text = "senha";
					dataGridView_ContaCriar.ClearSelection();
					ID = 0;
					SoundPlayer player = new SoundPlayer(@"sound\alterarconta.wav");
					player.Play();
					this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.进入游戏选择;
					MessageBox.Show("Alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}

		private void dataGridView_Conta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			//ID = Convert.ToInt32(dataGridView_ContaCriar.Rows[e.RowIndex].Cells[0].Value.ToString());

			
		}

		private void pictureBox_dell_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Para deletar alguma conta, basta dar 2 cliques na conta que deseja deletart","Informações",MessageBoxButtons.OK,MessageBoxIcon.Information);
		}

		private void fillByFULLToolStripButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.contas_pwTableAdapter.FillByFULL(this.pwDBDataSet.contas_pw);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
		{

		}

		private void textBox_Login_Click(object sender, EventArgs e)
		{
			textBox_Login.Clear();
		}

		private void textBox_Senha_MouseClick(object sender, MouseEventArgs e)
		{
			textBox_Senha.Clear();
		}

		private void textBox_Char_MouseClick(object sender, MouseEventArgs e)
		{
			textBox_Char.Clear();
		}

		private void fillByFULLToolStripButton_Click_1(object sender, EventArgs e)
		{
			try
			{
				this.contas_pwTableAdapter.FillByFULL(this.pwDBDataSet1.contas_pw);
			}
			catch (System.Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}

		}

		private void checkBox_SENHA_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox_SENHA.Checked == true)
			{
				textBox_Senha.PasswordChar = '*';
			}
			else
			{
				textBox_Senha.PasswordChar = '\0';
			}
		}

		private void dataGridView_ContaCriar_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = Convert.ToInt32(dataGridView_ContaCriar.Rows[e.RowIndex].Cells[0].Value.ToString());
			this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.进入游戏选择;
		}

		private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				if (MessageBox.Show("Deseja excluir essa conta ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						this.contas_pwTableAdapter.DeleteQuerContas_pw(ID);
						this.contas_pwTableAdapter.Fill(this.pwDBDataSet1.contas_pw);
						MessageBox.Show("Conta deletada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						dataGridView_ContaCriar.ClearSelection();
						ID = 0; this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.进入游戏选择;
					}
					catch (Exception ex)
					{
						MessageBox.Show("ERRO AO DELETAR: " + ex); ;
					}
				}
				else
				{
					MessageBox.Show("OPERAÇÃO CANCELADA");
				}
			}
			else
			{
				MessageBox.Show("Selecione a conta desejada.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void eDITARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				comboBox_Classes.Text = dataGridView_ContaCriar.CurrentRow.Cells[6].Value.ToString();
				textBox_Login.Text = dataGridView_ContaCriar.CurrentRow.Cells[2].Value.ToString();
				textBox_Senha.Text = dataGridView_ContaCriar.CurrentRow.Cells[3].Value.ToString();
				textBox_Char.Text = dataGridView_ContaCriar.CurrentRow.Cells[5].Value.ToString();
				comboBox_IdPw.Text = dataGridView_ContaCriar.CurrentRow.Cells[1].Value.ToString();

				this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.ALTERAR;			

			}
			else
			{
				MessageBox.Show("Selecione a conta desejada.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
