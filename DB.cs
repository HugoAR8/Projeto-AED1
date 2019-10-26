using System;
namespace Sistema {
 class DB {
  private Paciente[] pacientes = new Paciente[20];
  private Consulta[] consultas = new Consulta[20];

  public DB() {

  }


  //--------------- Bloco Pacientes

  public void inicializarPacientes(){
    for(int i = 0; i < pacientes.Length; i++){
      pacientes[i] = new Paciente();
    }
  }

  public void listarPacientes() {
   Paciente aux = new Paciente();
   Console.Write("Lista de Pacientes:\n");
   Console.Write("\n");

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

  

   for (int i = 0; i < pacientes.Length; i++) {
    
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

     break;

   }
    Console.Write("false");

   }

  }

   public void excluirPaciente(string n) {
   // Resetando os atributos do paciente, assim da pra depois cadastrar outro por cima.
   /*for(int i = 0; i < pacientes.Length; i++){
     if(pacientes[i].getNome() == n){
       pacientes[i] = null;
     }
   }
   */
   
 }

public void editarPaciente(string nome) {
   Paciente aux = new Paciente();

   for (int i = 0; i < pacientes.Length; i++) {
    aux = pacientes[i];

    if (pacientes[i] != null) {

     if (String.Equals(aux.getNome(), nome)) {
      Console.WriteLine("Editar nome do paciente: ");
      aux.setNome(Console.ReadLine());
      Console.WriteLine("Editar idade do paciente: ");
      aux.setIdade(int.Parse(Console.ReadLine()));
      Console.WriteLine("Editar altura do paciente: ");
      aux.setAltura(double.Parse(Console.ReadLine()));
      Console.WriteLine("Editar peso do paciente: ");
      aux.setPeso(double.Parse(Console.ReadLine()));

      pacientes[i] = aux;
      break;
     }
    }

   }


  }

  public void cadastrarPaciente() {
   Paciente aux = new Paciente();

   Console.WriteLine("Escreva o nome do paciente: ");
   aux.setNome(Console.ReadLine());
   Console.WriteLine("Escreva a idade do paciente: ");
   aux.setIdade(int.Parse(Console.ReadLine()));
   Console.WriteLine("Escreva a altura do paciente: ");
   aux.setAltura(double.Parse(Console.ReadLine()));
   Console.WriteLine("Escreva o peso do paciente: ");
   aux.setPeso(double.Parse(Console.ReadLine()));

   for (int i = 0; i < pacientes.Length; i++) {

    if (pacientes[i] == null) {
     pacientes[i] = aux;
     break;

    }
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
