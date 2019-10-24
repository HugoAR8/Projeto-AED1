using System;
namespace Sistema{

class MainClass {
  public static void Main (string[] args) {
    Console.Clear();
    string aux;

    Console.WriteLine("Pacientes");
    Console.WriteLine("Consultas");

    aux = (Console.ReadLine());

    if(aux == "Pacientes"){
     Paciente p = new Paciente();
     p.listarP();
    }



  


    



  }}
}