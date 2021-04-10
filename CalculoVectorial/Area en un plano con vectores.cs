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
	public partial class Area_en_un_plano_con_vectores : Form
	{
		public Area_en_un_plano_con_vectores()
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

			int Valor_di = Convert.ToInt32(di.Text);
			int Valor_dj = Convert.ToInt32(dj.Text);
			int Valor_dk = Convert.ToInt32(dk.Text);

			int AB_i = (Valor_bi - Valor_ai);
			int AB_j = (Valor_bj - Valor_aj);
			int AB_k = (Valor_bk - Valor_ak);

			int CD_i = (Valor_di - Valor_ci);
			int CD_j = (Valor_dj - Valor_cj);
			int CD_k = (Valor_dk - Valor_ck);

			int AD_i = (Valor_di - Valor_ai);
			int AD_j = (Valor_dj - Valor_aj);
			int AD_k = (Valor_dk - Valor_ak);

			int CB_i = (Valor_bi - Valor_ci);
			int CB_j = (Valor_bj - Valor_cj);
			int CB_k = (Valor_bk - Valor_ck);

			int PCruz_AB_X_AD_i = ((AB_j * AD_k) - (AB_k * AD_j));
			int PCruz_AB_X_AD_j = -1*((AB_i * AD_k) - (AB_k * AD_i));
			int PCruz_AB_X_AD_k = ((AB_i * AD_j) - (AB_j * AD_i));

			Resultado_i.Text = PCruz_AB_X_AD_i.ToString();
			Resultado_j.Text = PCruz_AB_X_AD_j.ToString();
			Resultado_k.Text = PCruz_AB_X_AD_k.ToString();
		}
	}
}
