namespace fila_e_pilha
{
    public class Fila : ListaEncadeada
    {        public void Enfileirar(string elemento)
        {
            insereInicio(elemento);
        }

        public void Desinfileirar()
        {   
            retiraFim();
        }

        
    }
}