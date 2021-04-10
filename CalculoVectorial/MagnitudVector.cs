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
	public partial class MagnitudVector : Form
	{
		
		public MagnitudVector()
		{
			InitializeComponent();
		}

		public void MagnitudVector_Load(object sender, EventArgs e)
		{
			valor_i.Text = "0";
			valor_j.Text = "0";
			valor_k.Text = "0";
			Resultado_Magnitud.Text = "0";
		}

		private void btnRealizar_Click(object sender, EventArgs e)
		{
			int i = Convert.ToInt32(valor_i.Text);
			int j = Convert.ToInt32(valor_j.Text);
			int k = Convert.ToInt32(valor_k.Text);

			double Resultado_1 = Math.Sqrt((i)^2 + (j)^2 + (k)^2);
			Resultado_Magnitud.Text = Resultado_1.ToString();
		}

		private void label7_Click(object sender, EventArgs e)
		{

		}
	}
}
