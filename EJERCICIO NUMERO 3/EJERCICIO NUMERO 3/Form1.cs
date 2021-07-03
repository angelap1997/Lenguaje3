using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO_NUMERO_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //LLENAR
            int FILA = Convert.ToInt32(FilastextBox.Text);
            int COLUMNA = Convert.ToInt32(ColumtextBox.Text);

            int[,] MatrizAle = new int[FILA, COLUMNA];
            Random aleotorio = new Random();

            for (int fila = 0; fila < MatrizAle.GetLength(0); fila++)
            {
                for (int colum = 0; colum < MatrizAle.GetLength(0); colum++)
                {
                    MatrizAle[fila, colum] = aleotorio.Next(100);
                }
            }
            ////
            for (int fila = 0; fila < MatrizAle.GetLength(0); fila++)
            {
                for (int colum = 0; colum < MatrizAle.GetLength(0); colum++)
                {
                    MessageBox.Show("La pocicion es:" + fila + "," + colum + "=" + MatrizAle[fila, colum].ToString());
                }
            }
        }
    }
}
