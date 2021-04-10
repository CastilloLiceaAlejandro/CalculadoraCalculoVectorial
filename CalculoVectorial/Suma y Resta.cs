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
	public partial class Suma_y_Resta : Form
	{
		public Suma_y_Resta()
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

			int Suma_i = (Valor_ai + Valor_bi + Valor_ci);
			int Suma_j = (Valor_aj + Valor_bj + Valor_cj);
			int Suma_k = (Valor_ak + Valor_bk + Valor_ck);

			Resultado_i.Text = Suma_i.ToString();
			Resultado_j.Text = Suma_j.ToString();
			Resultado_k.Text = Suma_k.ToString();
		}
	}
}
