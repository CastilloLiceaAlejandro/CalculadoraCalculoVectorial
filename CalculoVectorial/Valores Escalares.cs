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
	public partial class Valores_Escalares : Form
	{
		public Valores_Escalares()
		{
			InitializeComponent();
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

			int Valor_ri = Convert.ToInt32(r4i.Text);
			int Valor_rj = Convert.ToInt32(r4j.Text);
			int Valor_rk = Convert.ToInt32(r4k.Text);

			double X = ((Valor_ai * Valor_bj * Valor_ck) + (Valor_bi * Valor_cj * Valor_ak) + (Valor_ci * Valor_aj * Valor_bk))
				       - 
					   ((Valor_ak * Valor_bj * Valor_ci) + (Valor_bk * Valor_cj * Valor_ai) + (Valor_ck * Valor_aj * Valor_bi));

			double A = (((Valor_ri * Valor_bj * Valor_ck) + (Valor_bi * Valor_cj * Valor_rk) + (Valor_ci * Valor_rj * Valor_bk))
					   -
					   ((Valor_rk * Valor_bj * Valor_ci) + (Valor_bk * Valor_cj * Valor_ri) + (Valor_ck * Valor_rj * Valor_bi)))/X;

			double B = (((Valor_ai * Valor_rj * Valor_ck) + (Valor_ri * Valor_cj * Valor_ak) + (Valor_ci * Valor_aj * Valor_rk))
					   -
					   ((Valor_ak * Valor_rj * Valor_ci) + (Valor_rk * Valor_cj * Valor_ai) + (Valor_ck * Valor_aj * Valor_ri)))/X;

			double C = (((Valor_ai * Valor_bj * Valor_rk) + (Valor_bi * Valor_rj * Valor_ak) + (Valor_ri * Valor_aj * Valor_bk))
					   -
					   ((Valor_ak * Valor_bj * Valor_ri) + (Valor_bk * Valor_rj * Valor_ai) + (Valor_rk * Valor_aj * Valor_bi)))/X;

			Valor_A.Text = A.ToString();
			Valor_B.Text = B.ToString();
			Valor_C.Text = C.ToString();

		}

		private void label16_Click(object sender, EventArgs e)
		{

		}
	}
}
