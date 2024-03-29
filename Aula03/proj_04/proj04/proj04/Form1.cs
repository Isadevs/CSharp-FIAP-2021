﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            byte codigo;

            codigo = byte.Parse(txtCodigo.Text);

            if(byte.TryParse(txtCodigo.Text, out codigo) == false)
            {
                MessageBox.Show("Digite o código corretamente.");
                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }

            switch (codigo)
            {
                case 1:
                    MessageBox.Show("Elogio Profissional.");
                    break;//aborta o bloco
                case 2:
                    MessageBox.Show("Elogio Físico.");
                    break;
                case 3:
                    MessageBox.Show("Elogio Pessoal.");
                    break;

                default:
                    MessageBox.Show("Cpidigo Inválido.");
                    break;
            }
        }
    }
}
