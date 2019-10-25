using System;
namespace Sistema {
 class DB {
  private Paciente[] pacientes = new Paciente[20];
  private Consulta[] consultas = new Consulta[20];

  public DB() {

  }


  //--------------- Bloco Pacientes

  public void listarPacientes() {
   Paciente aux = new Paciente();
   Console.Write("Lista de Pacientes:\n");
   Console.Write("\n");

   //--------------- teste
   Paciente p1 = new Paciente();
   p1.setNome("a");
   pacientes[0] = p1;

   Paciente p2 = new Paciente();
   p2.setNome("Teste2");
   pacientes[2] = p2;

   Paciente p3 = new Paciente();
   p3.setNome("Teste3");
   pacientes[3] = p3;

   Paciente p4 = new Paciente();
   p4.setNome("Teste4");
   pacientes[4] = p4;

   Paciente p5 = new Paciente();
   p5.setNome("Teste5");
   pacientes[5] = p5;
   //---------------------

   for (int i = 0; i < pacientes.Length; i++) {
    if (pacientes[i] != null) {
     aux = pacientes[i];
     Console.Write(aux.getNome());
     Console.Write("\n");
    }
   }
  }

  public void buscarPaciente(string nome) {
   Paciente aux = new Paciente();

   //--------------- teste

  Paciente p1 = new Paciente();
   p1.setNome("a");
   pacientes[0] = p1;

   Paciente p2 = new Paciente();
   p2.setNome("b");
   pacientes[2] = p2;

   Paciente p3 = new Paciente();
   p3.setNome("c");
   pacientes[3] = p3;

   Paciente p4 = new Paciente();
   p4.setNome("d");
   pacientes[4] = p4;

   Paciente p5 = new Paciente();
   p5.setNome("e");
   pacientes[5] = p5;
   //---------------------

   for (int i = 0; i < pacientes.Length; i++) {
  
    if (pacientes[i] != null) {
     aux = pacientes[i];

     if (String.Equals(aux.getNome(), nome)) {
       Console.Clear();
      Console.Write("Nome: {0}", aux.getNome());
      Console.Write("\n");
      Console.Write("Idade: {0}", aux.getIdade());
      Console.Write("\n");
      Console.Write("Peso: {0}", aux.getPeso());
      Console.Write("\n");
      Console.Write("Altura: {0}", aux.getAltura());
      Console.Write("\n");

      break;

     } 
    } 
   } 

  }

  public void excluirPaciente() {


  }

  public void editarPaciente() {

  }

  public void cadastrarPaciente() {
   for (int i = 0; i < pacientes.Length; i++) {
    Console.WriteLine("Escreva o nome do paciente {0}", i + 1);
    pacientes[i].setNome(Console.ReadLine());

    Console.WriteLine("Escreva a idade do paciente {0}", i + 1);
    pacientes[i].setIdade(int.Parse(Console.ReadLine()));

    Console.WriteLine("Escreva a altura do paciente {0}", i + 1);
    pacientes[i].setAltura(double.Parse(Console.ReadLine()));


    Console.WriteLine("Escreva o peso do paciente {0}", i + 1);
    pacientes[i].setPeso(double.Parse(Console.ReadLine()));
   }
  }




  //------------------ Bloco Consulta 

  public void marcarConsulta() {

  }

  public void listarConsultas() {
   for (int i = 0; i < consultas.Length; i++) {
    Paciente p = consultas[i].getPaciente();
    Console.WriteLine(p.getNome());
   }
  }



  public Consulta buscarConsulta(int cod) {
   return consultas[cod];
  }

  public void excluirConsulta() {

  }

  public void editarConsulta() {

  }


 }
}