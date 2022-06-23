namespace fila_e_pilha
{
    public class No
    {
        public String elemento;
        public No? next, prev;

        public No()
        {
            this.elemento = "";
            this.next = null;
            this.prev = null;

        }
        public No(String s, No n, No p)
        {
            elemento = s;
            next = n;
            prev = p;
        }
        public String getElemento() { return elemento; }
        public No getNext() { return next; }
        public No getPrev() { return prev; }
        public void setElemento(String e) { elemento = e; }
        public void setNext(No n) { next = n; }
        public void setPrev(No n) { prev = n; }
        
    }
}