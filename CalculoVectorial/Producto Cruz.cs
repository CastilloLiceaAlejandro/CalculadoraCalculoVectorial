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
	public partial class Producto_Cruz : Form
	{
		public Producto_Cruz()
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

			int Valor_i = ((Valor_aj * Valor_bk) - (Valor_ak*Valor_bj));
			int Valor_j = -1*((Valor_ai * Valor_bk) - (Valor_ak * Valor_bi));
			int Valor_K = ((Valor_ai * Valor_bj) - (Valor_aj * Valor_bi));

			Resultado_i.Text = Valor_i.ToString();
			Resultado_j.Text = Valor_j.ToString();
			Resultado_k.Text = Valor_K.ToString();

		}

		private void Producto_Cruz_Load(object sender, EventArgs e)
		{

		}
	}
}
