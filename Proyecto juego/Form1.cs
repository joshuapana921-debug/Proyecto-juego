using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;

namespace Proyecto_juego
{
    public partial class Form1 : Form


    {
        float a = 0, b = 0, resultado = 0;
        int opee = 0, limite = 11;
        int nivel = 1;

        char operador = ' ';
        Boolean jugador = false;

        public Form1()

        {
            InitializeComponent();
        }
        private void SeleccionarOperador()
        {
            a = Random.Shared.Next(1, limite);
            b = Random.Shared.Next(1, limite);
            opee = Random.Shared.Next(1, 5);
            switch (opee)
            {
                case 1:
                    operador = '+';
                    resultado = a + b;
                    break;
                case 2:
                    operador = '-';
                    resultado = a - b;
                    break;
                case 3:
                    operador = '*';
                    resultado = a * b;
                    break;
                case 4:
                    operador = '/';
                    resultado = a / b;
                    break;
                default:
                    break;

            }
            n1.Text = a.ToString();
            n2.Text = b.ToString();
            op.Text = operador.ToString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SeleccionarOperador();

        }

        private void button1_Click(object sender, EventArgs e)
       
        {
            if (float.TryParse(tresultado.Text, out float valor))
            {
                if (Math.Abs(valor - resultado) < 0.01f)
                {
                    MessageBox.Show("Correcto");

                    laciertos.Text = (int.Parse(laciertos.Text) + 1).ToString();
                    lpuntos.Text = (int.Parse(lpuntos.Text) + 5).ToString();

                    if (int.Parse(laciertos.Text) % 3 == 0)
                    {
                        nivel++;
                        limite += 10;
                        lnivel.Text = nivel.ToString();

                        MessageBox.Show("Subiste al nivel " + nivel);
                    }
                }
                else
                {
                    MessageBox.Show("Incorrecto");

                    lerrores.Text = (int.Parse(lerrores.Text) + 1).ToString();
                    lpuntos.Text = (int.Parse(lpuntos.Text) - 2).ToString();
                }

                SeleccionarOperador();
               
            }
            else
            {
                MessageBox.Show("Digite un número válido");
            }
        }
    

        


        private void laciertos_Click(object sender, EventArgs e)
        {

        }

        private void runo_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void lnivel_Click(object sender, EventArgs e)
        { 
        }
    }
}
