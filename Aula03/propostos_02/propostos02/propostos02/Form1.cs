﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace propostos02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox.SelectedIndex)
            {
                case 0:
                    MessageBox.Show("Digite um Janeiro");
                    break;
                case 1:
                    MessageBox.Show("Selecionou Fevereiro");
                    break;
                case 2:
                    MessageBox.Show("Selecionou Março");
                    break;
                case 3:
                    MessageBox.Show("Selecionou Abril");
                    break;
                case 4:
                    MessageBox.Show("Selecionou Maio");
                    break;
                case 5:
                    MessageBox.Show("Selecionou Junho");
                    break;
                case 6:
                    MessageBox.Show("Selecionou Julho");
                    break;
                case 7:
                    MessageBox.Show("Selecionou Agosto");
                    break;
                case 8:
                    MessageBox.Show("Selecionou Setembro");
                    break;
                case 9:
                    MessageBox.Show("Selecionou Outubro");
                    break;
                case 10:
                    MessageBox.Show("Selecionou Novembro");
                    break;
                case 11:
                    MessageBox.Show("Selecionou Dezembro");
                    break;
                default:
                    MessageBox.Show("Selecione um mês");
                    break;
                }
            }
        }
    }
