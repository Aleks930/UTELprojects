using System;

public class Nodo
{
  public Nodo siguiente;
  public Object dato;
}

public class ListaLigada
{
  private Nodo cabeza;

  public void ImprimirTodosLosNodos ()
  {
    Nodo actual = cabeza;
    while (actual != null)
      {
	Console.WriteLine (actual.dato);
	actual = actual.siguiente;
      }
  }

  public void AgregarAlFrente (Object nuevoDato)
  {
    Nodo nodoAAgregar = new Nodo ();
    nodoAAgregar.dato = nuevoDato;
    nodoAAgregar.siguiente = cabeza;

    cabeza = nodoAAgregar;
  }
}

public class MiPrograma
{
  static void Main (String[]args)
  {
    Console.Write ("Cuantos elementos quieres insertar? ");
    int numero = int.Parse (Console.ReadLine ());

      Console.WriteLine ("Creamos la lista ligada e insertamos al frente...");
    ListaLigada miLista = new ListaLigada ();

    for (int i = 0; i < numero; i++)
      {
	Console.Write ("Escribe el dato...");
	String cadena = Console.ReadLine ();
	  miLista.AgregarAlFrente (cadena);
      }

    Console.WriteLine ("----------------------");
    miLista.ImprimirTodosLosNodos ();

    Console.WriteLine ();
  }
}
