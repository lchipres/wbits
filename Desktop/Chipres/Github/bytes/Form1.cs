using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bytes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnProcesar_Click(object sender, EventArgs e)
        {
            Int32 numero = Convert.ToInt32(txtEntrada.Text);
            direMovi(numero);
            nivTanq(numero);
            fechaToStr(numero);
            sensores(numero);
        }

        public void direMovi(Int32 numero)
        {
            Int32 mascara = 7;
            numero = numero >> 1;//Quito el bit menos significativo
            numero = numero & mascara;//Obtengo de 0 a 7
            switch (numero)
            {
                case 0:
                    lblDir.Text = "N";
                    break;
                case 1:
                    lblDir.Text = "NE";
                    break;
                case 2:
                    lblDir.Text = "E";
                    break;
                case 3:
                    lblDir.Text = "SE";
                    break;
                case 4:
                    lblDir.Text = "S";
                    break;
                case 5:
                    lblDir.Text = "SO";
                    break;
                case 6:
                    lblDir.Text = "O";
                    break;
                case 7:
                    lblDir.Text = "NO";
                    break;
            }//Fin de case
                
        }//Fin de funcion para saber la direccion del movimiento

        public void nivTanq(Int32 numero)
        {
            Int32 mascara = 48;
            numero = numero & mascara;//Obtengo 2 bits especificos
            switch (numero)
            {
                case 0:
                    nivelBar.Value = 0;
                    break;
                case 16:
                    nivelBar.Value = 1;
                    break;
                case 32:
                    nivelBar.Value = 2;
                    break;
                case 48:
                    nivelBar.Value = 3;
                    break;
            }
        }//Fin de funcion para saber el nivel del tanque
        public void sensores(Int32 numero)
        {
            int mascara = 192;
            numero = numero & mascara;
            switch (numero)
            {
                case 64:
                    lblSens1.Text = "1 Activo";
                    break;
                case 128:
                    lblSens2.Text = "2 Activo";
                    break;
                case 192:
                    lblSens1.Text = "1 Activo";
                    lblSens2.Text = "2 Activo";
                    break;
            }
        }
        public void fechaToStr(Int32 numero)
        {
            numero = numero >> 8;
            Int32 dia = 31;
            lblFecLec.Text = Convert.ToString(numero & dia);//Operacion and
            numero = numero >> 5;
            Int32 mes = 15;
            lblFecLec.Text += queMes(numero & mes);
            numero = numero >> 4;
            Int32 year = 127;
            lblFecLec.Text += (year & numero)+1900;
        }
        public string queMes(Int32 numero)
        {
            string q="";
            switch(numero)
            {
                case 1:
                    q = " de Enero de ";
                    break;
                case 2:
                    q = " de Febrero de ";
                    break;
                case 3:
                    q = " de Marzo de ";
                    break;
                case 4:
                    q = " de Abril de ";
                    break;
                case 5:
                    q = " de Mayo de ";
                    break;
                case 6:
                    q = " de Junio de ";
                    break;
                case 7:
                    q = " de Julio de ";
                    break;
                case 8:
                    q = " de Agosto de ";
                    break;
                case 9:
                    q = " de Septiembre de ";
                    break;
                case 10:
                    q = " de Octubre de ";
                    break;
                case 11:
                    q = " de Noviembre de ";
                    break;
                case 12:
                    q = " de Diciembre de ";
                    break;

            }//Fin switch
            return q;
        }//Fin de Funcion

        private void bttnAjustarFecha_Click(object sender, EventArgs e)
        {
            txtFecDes.Text = Convert.ToString(stringToNum(txtFecOrig.Text));
        }

        Int32 stringToNum(string texto)
        {
            Int32 num = 0;
            String[] substrings = texto.Split('/');//Parto los numeros de la fecha en dia mes y año
            num=Convert.ToInt32(substrings[0]);//Convierto el dia string a numero
            num += Convert.ToInt32(substrings[1]) << 5;//Convierto el mes string a numero y muevo 5 bits a la izquierda
            num += (Convert.ToInt32(substrings[2])-1900) << 9;//Convierto el año string a numero le resto 1900 y muevo 9 bits a la izquierda
            return num;
        }
    }
}
