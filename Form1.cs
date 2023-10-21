using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea2Mike
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEncryptar_Click(object sender, EventArgs e)
        {
            int clave = int.Parse(txtClave.Text);
            TxtMensajeOriginal.Text = EncriptarCesar(TxtMensajeOriginal.Text, clave);

        }

        private void BtnDesencryptar_Click(object sender, EventArgs e)
        {
            int clave = int.Parse(txtClave.Text);
            TxtMensajeOriginal.Text = DesencriptarCesar(TxtMensajeOriginal.Text, clave);

        }

        static string EncriptarCesar(string mensaje, int clave)
        {
            char[] caracteres = mensaje.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (char.IsLetter(caracteres[i]))
                {
                    char offset = char.IsUpper(caracteres[i]) ? 'A' : 'a';
                    caracteres[i] = (char)((caracteres[i] - offset + clave) % 26 + offset);
                }
            }

            return new string(caracteres);
        }

        static string DesencriptarCesar(string mensajeEncriptado, int clave)
        {
            int claveNegativa = -clave;
            return EncriptarCesar(mensajeEncriptado, claveNegativa);
        }
    }
}
