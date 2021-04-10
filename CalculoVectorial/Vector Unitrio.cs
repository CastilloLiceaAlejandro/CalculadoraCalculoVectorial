using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoVectorial
{
	public partial class Vector_Unitario : Form
	{
		public Vector_Unitario()
		{
			InitializeComponent();
		}

		private void Vector_Unitario_Load(object sender, EventArgs e)
		{
			
		}

		private void btnRealizar_Click(object sender, EventArgs e)
		{
			int Valor_ai = Convert.ToInt32(ai.Text);
			int Valor_aj = Convert.ToInt32(aj.Text);
			int Valor_ak = Convert.ToInt32(ak.Text);

			int Valor_bi = Convert.ToInt32(bi.Text);
			int Valor_bj = Convert.ToInt32(bj.Text);
			int Valor_bk = Convert.ToInt32(bk.Text);

			int Valor_ci = Convert.ToInt32(ci.Text);
			int Valor_cj = Convert.ToInt32(cj.Text);
			int Valor_ck = Convert.ToInt32(ck.Text);

			double Magn_A = Math.Sqrt((Valor_ai) ^ 2 + (Valor_aj) ^ 2 + (Valor_ak) ^ 2);
			double Magn_B = Math.Sqrt((Valor_bi) ^ 2 + (Valor_bj) ^ 2 + (Valor_bk) ^ 2);
			double Magn_C = Math.Sqrt((Valor_ci) ^ 2 + (Valor_cj) ^ 2 + (Valor_ck) ^ 2);

			numai.Text = ai.Text;
			denai.Text = Magn_A.ToString();
			numaj.Text = aj.Text;
			denaj.Text = Magn_A.ToString();
			numak.Text = ak.Text;
			denak.Text = Magn_A.ToString();

			numbi.Text = bi.Text;
			denbi.Text = Magn_B.ToString();
			numbj.Text = bj.Text;
			denbj.Text = Magn_B.ToString();
			numbk.Text = bk.Text;
			denbk.Text = Magn_B.ToString();

			numci.Text = ci.Text;
			denci.Text = Magn_C.ToString();
			numcj.Text = cj.Text;
			dencj.Text = Magn_C.ToString();
			numck.Text = ck.Text;
			denck.Text = Magn_C.ToString();

		}
	}
}
