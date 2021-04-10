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
	public partial class Ecuaciones_Simetricas_Y_Parametricas : Form
	{
		public Ecuaciones_Simetricas_Y_Parametricas()
		{
			InitializeComponent();
		}

		private void btnRealizar_Click(object sender, EventArgs e)
		{
			int Valor_pi = Convert.ToInt32(Pi.Text);
			int Valor_pj = Convert.ToInt32(Pj.Text);
			int Valor_pk = Convert.ToInt32(Pk.Text);

			int Valor_vi = Convert.ToInt32(Vi.Text);
			int Valor_vj = Convert.ToInt32(Vj.Text);
			int Valor_vk = Convert.ToInt32(Vk.Text);

			int X_param = Valor_pi + Valor_vi;
			int Y_param = Valor_pj + Valor_vj;
			int Z_param = Valor_pk + Valor_vk;

			Par_x.Text = X_param.ToString();
			Par_y.Text = Y_param.ToString();
			Par_z.Text = Z_param.ToString();

			int X_Sim = (Valor_pi / Valor_vi);
			int Y_Sim = (Valor_pj / Valor_vj);
			int Z_Sim = (Valor_pk / Valor_vk);

			Sim_x.Text = X_Sim.ToString();
			Sim_y.Text = Y_Sim.ToString();
			Sim_z.Text = Z_Sim.ToString();

		}
	}
}
