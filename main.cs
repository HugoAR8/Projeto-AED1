using System;
namespace Sistema{

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    string aux;

    Console.WriteLine("Pacientes");
    Console.WriteLine("Consultas");
    Console.WriteLine("Médicos");

    aux = (Console.ReadLine());

    if(aux == "Pacientes"){
    Console.Clear();  
    Console.WriteLine("Listar");
    Console.WriteLine("Buscar");
    aux = (Console.ReadLine());
    Console.Clear();
      Console.WriteLine("Editar");
      Console.WriteLine("Excluir");
      aux = (Console.ReadLine());

    }



  


    



  }}
}