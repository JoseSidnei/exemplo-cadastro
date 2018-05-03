using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExemploSistemaComForWhileVetor
{
    class Sistema
    {
        Barco barco = new Barco();
        public Sistema()
        {
            GeriMenu();
        }
        // apresentar o menu para o usuário
        public void Menu()
        {
            Console.WriteLine(
                @"
1 - Cadastro de barcos
2 - Ediar Barco
3 - Listar Barcos
4 - Buscar Barco
20 - Sair");
        }
        public void GeriMenu()
        {
            /*
             * Chama método para apresentar o menu
             * para o usuário 
             */
            Menu();
            int menuEscolha = Convert.ToInt32(Console.ReadLine());
            while (menuEscolha != 20)
            {
                switch (menuEscolha)
                {
                    case 1:
                        barco.CadastroBarcos();
                        break;
                    case 2:
                        barco.EditarBarco();
                        break;
                    case 3:
                        barco.ListarBarcos();
                        break;
                    case 4:
                        barco.BuscarBarco();
                        break;
                }
            Menu();
            menuEscolha = Convert.ToInt32(Console.ReadLine());
            }
           
           


        }
    }
}
