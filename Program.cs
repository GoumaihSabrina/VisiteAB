class Program{
  static void Main(){
Node nodo5 = new("5", null, null);
Node nodo4 = new("4", null, null);
Node nodo3 = new("3", nodo4, nodo5);
Node nodo2 = new("2", null, null);
Node nodo1 = new("1", nodo2, nodo3);


        
        Albero albero = new(nodo1);//Albero con radice nodo1

        Node nodo = nodo3;
        bool trovato = albero.Bfs(nodo);
        if (trovato)
        {
            Console.WriteLine("Il nodo è stato trovato nell'albero.");
        }
        else
        {
            Console.WriteLine("Il nodo non è stato trovato nell'albero.");
        }
}}