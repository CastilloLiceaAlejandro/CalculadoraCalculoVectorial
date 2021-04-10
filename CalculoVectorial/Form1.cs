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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {
				case "Graficar Vector":
						break;
				case "Magnitud Vector":
					Form magnitudvector = new MagnitudVector();
					magnitudvector.Show();
					break;
				/*case "Vector Unitario":
					Form vector_unitario = new Vector_Unitario();
					vector_unitario.Show();
					break;*/
				case "Suma - Resta Vector":
					Form suma_y_resta= new Suma_y_Resta();
					suma_y_resta.Show();
					break;
				case "Valores Escalares":
					Form valores_escalares= new Valores_Escalares();
					valores_escalares.Show();
					break;
				case "Producto Escalar":
					Form producto_punto = new Producto_Punto();
					producto_punto.Show();
					break;
				case "Producto Cruz":
					Form producto_cruz = new Producto_Cruz();
					producto_cruz.Show();
					break;
				case "Angulo Entre Vectores":
					Form angulo_entre_vectores = new Angulo_entre_Vectores();
					angulo_entre_vectores.Show();
					break;
				case "Proyeccion de un Vector":
					Form proyeccion_de_un_vector = new Proyeccion_de_un_Vector();
					proyeccion_de_un_vector.Show();
					break;
				case "Area en un Plano con Vectores":
					Form area_en_un_plano_con_vectores = new Area_en_un_plano_con_vectores();
					area_en_un_plano_con_vectores.Show();
					break;
				case "Ecuaciones Simetricas-Parametricas":
					Form ecuaciones_simetricas_y_parametricas = new Ecuaciones_Simetricas_Y_Parametricas();
					ecuaciones_simetricas_y_parametricas.Show();
					break;
				/*case "Inteeseccion de Puntos":
					Form  = new ();
					.Show();
					break;
				case "Distancia Punto - Plano":
					Form  = new ();
					.Show();
					break;
				case "Distancia Punto-Vector":
					Form  = new ();
					.Show();
					break;
				case "Coordenadas Cilindricas a Rectangulares":
					Form  = new ();
					.Show();
					break;
				case "Coordenadas Rectangulares a Cilindricas":
					Form  = new ();
					.Show();
					break;*/

			}
        }
    }
}
