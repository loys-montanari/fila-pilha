namespace fila_e_pilha
{
    public class Pilha : ListaEncadeada
    {
          public void Empilhar(string elemento)
        {
            insereInicio(elemento);
        }

        public void Desempilhar()
        {
            retiraInicio();
        }

    }
}