public class Albero
{
  public Node radice;
  List<Node> coda = new List<Node>();//questa lista mi serve per la coda degli elementi
   


  public Albero(Node root){
  this.radice = root;

  }
  public bool Bfs(Node nodo){//ricerca in ampiezza,nodi adiacenti
   
    if(radice == null){
      return false;

    }
    
   coda.Add(radice);

while(coda.Count > 0){
  Node nodoCorrente = coda[0];
  coda.RemoveAt(0);//ho preso il primo elemento della coda 
  if(nodoCorrente == nodo ){
    return true;// solito controllo,se trovo il nodo che cerco ed é uguale a quello corrente appost
  }  
  if(nodoCorrente.nododx != null){
    coda.Add(nodoCorrente.nododx);

  }
  if(nodoCorrente.nodosx != null){
    coda.Add(nodoCorrente.nodosx);
  }



  }
  return false;// se non trovo nulla,return false 
  }

    
  }
