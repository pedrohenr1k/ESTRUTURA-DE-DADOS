public class NodoArvore
{
    public int Valor;
    public NodoArvore Esquerda, Direita;

    public NodoArvore(int valor)
    {
        Valor = valor;
        Esquerda = Direita = null;
    }
}
