using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Control
{
    public static class ControllerTeste
    {
        public static bool AdicionaPessoa(string nome, string cpf, string rg)
        {
            if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf) && !string.IsNullOrEmpty(rg))
            {
                return DBTeste.AdicionaPessoa(nome, cpf, rg);


            }
            else
            {
                return false;
            }

            
        }

        public static List<string[]> SelecionaPessoas()
        {
            return DBTeste.SelecionaPessoas();
        }
    }
}
