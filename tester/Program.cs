using Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var repo = new RepositorioMaestro();
            var list = repo.ListaEps();
            Console.ReadKey();

        }
    }
}
