using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_e_pilha
{  class Program {
                       static void Main(string[] args)
        {
               
                Fila filaTest = new Fila();

                filaTest.Enfileirar("a");
                filaTest.Enfileirar("b");
                filaTest.Enfileirar("c");
                filaTest.Desinfileirar();
                //filaTest.Enfileirar("d");
                //filaTest.Enfileirar("e");               
                //filaTest.Desinfileirar();
                //filaTest.Desinfileirar();
                List<string> listanova = filaTest.getlista();
                
                foreach(string palavra in listanova)
                
                Console.WriteLine($"{palavra}");             

        }
              }
            }