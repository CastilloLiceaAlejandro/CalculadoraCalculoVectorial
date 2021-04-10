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
	public partial class Angulo_entre_Vectores : Form
	{
		public Angulo_entre_Vectores()
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

			double Magnitud_A = Math.Sqrt((Valor_ai) ^ 2 + (Valor_aj) ^ 2 + (Valor_ak) ^ 2);
			double Magnitud_B = Math.Sqrt((Valor_bi) ^ 2 + (Valor_bj) ^ 2 + (Valor_bk) ^ 2);
			double Producto_Magnitud = Magnitud_A * Magnitud_B;
			Convert.ToInt32(Producto_Magnitud);
			int Producto_punto = ((Valor_ai * Valor_bi) + (Valor_aj * Valor_bj) + (Valor_ak * Valor_bk));
			double Division = Producto_punto / Producto_Magnitud;

			//Investigar como obtener el angulo

		}
	}
}
