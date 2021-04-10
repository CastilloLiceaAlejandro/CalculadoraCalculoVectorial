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
	public partial class Proyeccion_de_un_Vector : Form
	{
		public Proyeccion_de_un_Vector()
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

			double Magnitud_B = Math.Sqrt((Valor_bi) ^ 2 + (Valor_bj) ^ 2 + (Valor_bk) ^ 2);

			double Bu_i = Valor_bi / Magnitud_B;
			double Bu_j = Valor_bj / Magnitud_B;
			double Bu_k = Valor_bk / Magnitud_B;

			double Resultadoi = Valor_ai * Bu_i;
			double Resultadoj = Valor_aj * Bu_j;
			double Resultadok = Valor_ak * Bu_k;

			Resultado_i.Text = Resultadoi.ToString();
			Resultado_j.Text = Resultadoj.ToString();
			Resultado_k.Text = Resultadok.ToString();

		}
	}
}
