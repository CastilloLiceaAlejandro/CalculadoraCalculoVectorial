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
	public partial class Producto_Punto : Form
	{
		public Producto_Punto()
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

			int Resultado = ((Valor_ai * Valor_bi * Valor_ci) + (Valor_aj * Valor_bj * Valor_cj) + (Valor_ak * Valor_bk * Valor_ck));

			txtbResultado.Text = Resultado.ToString();

		}
	}
}
