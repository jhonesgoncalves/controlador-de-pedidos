﻿using ControladorDePedidos.Model;
using ControladorDePedidos.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ControladorDePedidos.WPF
{
    /// <summary>
    /// Lógica interna para FormCadastroDeCompra.xaml
    /// </summary>
    public partial class FormCadastroDeCompra : Window
    {
        public FormCadastroDeCompra()
        {
            InitializeComponent();
            this.DataContext = new Compra();
        }

        public FormCadastroDeCompra(Compra compra)
        {
            InitializeComponent();
            this.DataContext = compra;
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            var compra = (Compra)this.DataContext;
            var repositorio = new RepositorioCompra();
            if (compra.Codigo == 0)
            {
                //Novo Cadastro
                repositorio.Adicione(compra);
            }
            else
            {
                //Editando Cadastro
                repositorio.Atualize(compra);
            }

            this.Close();
        }
    }
}