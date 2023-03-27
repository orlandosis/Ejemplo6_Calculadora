namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double num1 = 0;
        double num2 = 0;
        double resultado = 0;
        bool flagsuma = false;
        bool flagresta = false;
        bool flagmultiplicacion = false;
        bool flagdivision = false;

        private void button0_Click(object sender, EventArgs e)
        {
            if (Pantalla1.Text == "")
            {

            }
            else
            {
                Pantalla1.Text = Pantalla1.Text + "0";
            }
            if (Pantalla1.Text == "")
            {

            }
            else
            {
                Pantalla2.Text = Pantalla2.Text + "0";
            }


        }

        private void buttonN1_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "1";
            Pantalla2.Text = Pantalla2.Text + "1";
        }

        private void buttonN2_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "2";
            Pantalla2.Text = Pantalla2.Text + "2";
        }

        private void buttonN3_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "3";
            Pantalla2.Text = Pantalla2.Text + "3";
        }

        private void buttonN4_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "4";
            Pantalla2.Text = Pantalla2.Text + "4";
        }

        private void buttonN5_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "5";
            Pantalla2.Text = Pantalla2.Text + "5";
        }

        private void buttonN6_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "6";
            Pantalla2.Text = Pantalla2.Text + "6";
        }

        private void buttonN7_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "7";
            Pantalla2.Text = Pantalla2.Text + "7";
        }

        private void buttonN8_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "8";
            Pantalla2.Text = Pantalla2.Text + "8";
        }

        private void buttonN9_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = Pantalla1.Text + "9";
            Pantalla2.Text = Pantalla2.Text + "9";
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla1.Text); // varialbe local
            Pantalla1.Text = "";

            Pantalla2.Text = Pantalla2.Text + "+";
            flagsuma = true;


        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (Pantalla1.Text != "")
            {
                num2 = Convert.ToDouble(Pantalla1.Text);




                if (flagsuma == true)
                {
                    resultado = num1 + num2;
                    flagsuma = false;
                }
                if (flagresta == true)
                {
                    resultado = num1 - num2;
                    flagresta = false;
                }
                if (flagmultiplicacion == true)
                {
                    resultado = num1 * num2;
                    flagmultiplicacion = false;

                }
                if (flagdivision == true)
                {
                    resultado = num1 / num2;
                    flagdivision = false;
                }

                string resul = Convert.ToString(resultado);
                Pantalla1.Text = resul;

            }
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla1.Text);
            Pantalla1.Text = "";
            Pantalla2.Text = Pantalla2.Text + "-";
            flagresta = true;
        }

        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla1.Text);
            Pantalla1.Text = "";
            Pantalla2.Text = Pantalla2.Text + "*";
            flagmultiplicacion = true;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(Pantalla1.Text);
            Pantalla1.Text = "";

            Pantalla2.Text = Pantalla2.Text + "/";
            flagdivision = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Pantalla1.Text = "";
            Pantalla2.Text = "";

            flagsuma = false;
            flagresta = false;
            flagmultiplicacion = false;
            flagdivision = false;
        }
    }
}