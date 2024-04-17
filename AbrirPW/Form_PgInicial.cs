using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbrirPW
{
	public partial class Form_PgInicial : Form
	{
		public Form_PgInicial()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start(@"D:\wallace\PW\NewHorizons-PerfectWorld-Oficial\element\elementclient.exe"	, "startbypatcher console:1 user:nano500 pwd:32195018 role:ALBINO");
		}
	}
}
