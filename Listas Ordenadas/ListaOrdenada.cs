public class ListaOrdenada
{
    private List<int> lista = new List<int>();
    
    public void Inserir(int valor)
    {
        lista.Add(valor);
        lista.Sort();
    }
}
