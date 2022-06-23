using System;


namespace fila_e_pilha
{
    public class ListaEncadeada
    {
                public No cabeca, cauda;
        public int qtdElementos;
        public ListaEncadeada()
        {   
            //this.cabeca.next = cauda;
            //this.cauda.prev = cabeca;
            //this.qtdElementos = 0;
        }

        //Inserir elemento no inicio da lista
        public void insereInicio(string elemento)
        {
            No novo = new No();
            novo.elemento = elemento;
            

            if (cabeca == null)
            {
                cabeca = novo;
                cauda = novo;
                qtdElementos = 1;
            }
            else
            {
                novo.next = cabeca;
                
                qtdElementos = ++qtdElementos;
            }
            cabeca = novo;
            
            
        }

        //Inserir elemento no fim da lista
        public void insereFim(string elemento)
        {
            No novo = new No();
            novo.elemento = elemento;
            qtdElementos = qtdElementos++;

            if (cabeca == null)
            {
                cabeca = novo;
                
            }
            else
            {
                cauda.next = novo;
            }
            cauda = novo;
        }

        public void retiraFim()
        {

            if (cabeca == null)
                return;

            if (cabeca.next == null)
            {

                cabeca = null;
            }
            else
            {
                No ultimo = cabeca.next;
                No penultimo = cabeca;

                while (ultimo.next != null)
                {
                    penultimo = ultimo;
                    ultimo = ultimo.next;
                }
                penultimo.next = null;
                cauda.prev = penultimo;
            }
            qtdElementos = qtdElementos--;
            


        }


        public void exibir()
        {
            if (cabeca != null)
            {
                No temp = cabeca;
                while (temp != null)
                {
                    Console.Write(temp.elemento + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nLista vazia");
            }
        }





            //Retirar elemento do inicio da lista
            public void retiraInicio()
        {
            if (cabeca != null)
            {

                cabeca = cabeca.next;
                qtdElementos--;
            }

        }

        public bool buscaElemento(string palavra)
        {
            bool resultado = true;

            if (cabeca != null)
            {
                No temp = cabeca;
                
                string elemento = temp.elemento;
                while (palavra != elemento && temp != null)
                {
                    if (palavra != elemento && temp != null)
                    {
                        resultado = false;
                        temp = temp.next;

                        if (temp != null)
                        {
                            elemento = temp.elemento;
                        }
                    }
                }
                if (palavra == elemento)
                {
                    resultado = true;


                }
            }
            return resultado;
        }

      public List<string> getlista(){
 
                 var lista = new List<string>();
                 var temp = cabeca;
                 var cd = cauda;
                 while(temp != null){
                      lista.Add(temp.elemento.ToString());
                      temp	= temp.next;

                 }
                    lista.Add(cauda.elemento.ToString());
                 return lista;
      }


    }
}