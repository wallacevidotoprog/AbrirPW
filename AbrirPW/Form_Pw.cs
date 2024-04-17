using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Media;

namespace AbrirPW
{
	public partial class Form_Pw : Form
	{
		public Form_Pw()
		{
			InitializeComponent();
		}
		int ID = 0;
		string CM = null;
		private void Form_Pw_Load(object sender, EventArgs e)
		{
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.caminho_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			// TODO: esta linha de código carrega dados na tabela 'pwDBDataSet.caminho_pw'. Você pode movê-la ou removê-la conforme necessário.
			this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
			dataGridView_PW.ClearSelection();
		}

		private void Form_Pw_Shown(object sender, EventArgs e)
		{
			this.TransparencyKey = this.BackColor;
		}


		private void pictureBox4_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		private void button_buscar_Click(object sender, EventArgs e)
		{
			string CM = null;
			FolderBrowserDialog browser = new FolderBrowserDialog();
			if (browser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				CM = browser.SelectedPath;
				MessageBox.Show("O caminho esta correto ? :"+CM);
				label1.Text = CM;
			}

		}

		
		private void pictureBox_Add_Click(object sender, EventArgs e)
		{
			if (ID == 0)
			{


				try
				{
					this.caminho_pwTableAdapter.InsertQuery(Convert.ToInt32(DateTime.Now.ToString("HHmmss")), textBox_NomePw.Text, label1.Text);
					textBox_NomePw.Text = "NOME DO PERFECT WOLRD";
					label1.Text = "Caminho da Pasta " + "elemente" + " do seu  Perfct World";
					this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);

				}
				catch (Exception ex)
				{

					MessageBox.Show("ERRO AO INSERIR" + ex);
				}



				CM = null;
			}
			else
			{
				this.caminho_pwTableAdapter.UpdateCAMINHO(textBox_NomePw.Text, label1.Text, ID);

				ID = 0;
				textBox_NomePw.Text = "NOME DO PERFECT WOLRD";
				label1.Text= "Caminho da Pasta "+"elemente"+" do seu  Perfct World";
				SoundPlayer player = new SoundPlayer(@"sound\alterarconta.wav");
				player.Play();
				MessageBox.Show("Alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
				this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.add2;
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		
		private void button1_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Para deletar alguma conta, basta dar 2 cliques na conta que deseja deletart", "Informações", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void dELETARToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (ID != 0)
			{
				if (MessageBox.Show("Deseja excluir essa conta ?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					try
					{
						this.caminho_pwTableAdapter.DeleteQueryCaminho_Pw(ID);
						this.caminho_pwTableAdapter.Fill(this.pwDBDataSet.caminho_pw);
						MessageBox.Show("Conta deletada.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
						dataGridView_PW.ClearSelection();
						ID = 0;
						this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.add2;
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
				textBox_NomePw.Text = dataGridView_PW.CurrentRow.Cells[1].Value.ToString();
				label1.Text = dataGridView_PW.CurrentRow.Cells[2].Value.ToString();

				this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.editar;
				
			}
			else
			{
				MessageBox.Show("Selecione a conta desejada.", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void textBox_NomePw_TextChanged(object sender, EventArgs e)
		{

		}

		private void dataGridView_PW_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
			ID = 0; this.pictureBox_Add.Image = global::AbrirPW.Properties.Resources.add2;
			ID = Convert.ToInt32(dataGridView_PW.Rows[e.RowIndex].Cells[0].Value.ToString());
		}
	}
}
