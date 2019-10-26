using System;
namespace Sistema {
 class DB {
  private Paciente[] pacientes = new Paciente[20];
  private Consulta[] consultas = new Consulta[20];
  private Medico[] medicos = new Medico[20];

  public DB() {

  }


  //--------------- Bloco Pacientes

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
   for(int i = 0; i < pacientes.Length; i++){
     if(pacientes[i].getNome() == n){
       pacientes[i] = null;
     }
   }
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
    Consulta aux = new Consulta();
    Paciente pacienteX = new Paciente();

    Console.WriteLine("Digite a data da consulta.");
    aux.setData(Console.ReadLine());
    Console.WriteLine("Digite o nome do paciente.");
    string auxN = Console.ReadLine();
    for(int i = 0; i < pacientes.Length; i ++){
      if(pacientes[i].getNome() == auxN){
        pacienteX = pacientes[i];
        aux.setPaciente(pacienteX);
      }
    }
    
    Console.WriteLine("Digite o horário da consulta.");
    aux.setHorario(Console.ReadLine());
    }

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



  //------------------ Bloco Medico

  public void inicializarMedicos(){
    for(int i = 0; i < medicos.Length; i++){
      medicos[i] = new Medico();
    }
  }

  public void cadastrarMedico(){
    Medico aux = new Medico();

    Console.WriteLine("Escreva o nome do medico.");
    aux.setNome(Console.ReadLine());
    Console.WriteLine("Escreva a especializacao do medico.");
    aux.setEspecializacao(Console.ReadLine());
    for(int i = 0; i < aux.horarios.Length; i ++){
      Console.WriteLine("Digite o {0}° horário disponivel do médico.",i+1);
      string auxH = Console.ReadLine();
      aux.setHorario(auxH,i);

    }

      for (int u = 0; u < medicos.Length; u++) {

      if (medicos[u] == null) {
       medicos[u] = aux;
       break;

     }
   }
  }

  public void excluirMedico(string n) {
   for(int i = 0; i < medicos.Length; i++){
     if(medicos[i].getNome() == n){
       medicos[i] = null;
     }
   }
 }

  public void listarMedicos() {
   Medico aux = new Medico();
   Console.Write("Lista de Medicos:\n");
   Console.Write("\n");

   for (int i = 0; i < medicos.Length; i++) {
    if (medicos[i] != null) {
     aux = medicos[i];
     Console.Write(aux.getNome());
     Console.Write("\n");
    }
   }
  }

  public void buscarMedico(string nome) {
    Medico aux = new Medico();

   for (int i = 0; i < medicos.Length; i++) {
    aux = medicos[i];

    if (String.Equals(aux.getNome(), nome)) {
     Console.Clear();
     Console.Write("Nome: {0}", aux.getNome());
     Console.Write("\n");
     Console.Write("Especialização: {0}", aux.getEspecializacao());
     Console.Write("\n");
     Console.WriteLine("Horarios :\n ");
     for(int u = 0; u < aux.horarios.Length; u ++){
       Console.WriteLine(aux.horarios[u]);
       
     }

     break;

   }
    Console.Write("false");

   }
  }
  public void editarMedico(string nome) {
   Medico aux = new Medico();

   for (int i = 0; i < pacientes.Length; i++) {
    aux = medicos[i];

    if (medicos[i] != null) {

     if (String.Equals(aux.getNome(), nome)) {
      Console.WriteLine("Editar nome do médico: ");
      aux.setNome(Console.ReadLine());
      Console.WriteLine("Editar especialização do médico: ");
      aux.setEspecializacao(Console.ReadLine());
      medicos[i] = aux;
      Console.WriteLine("Editar horarios do médico:");
      for(int x = 0; x < aux.horarios.Length; x ++){
        Console.WriteLine("Edite o {0} horario do medico", x+1);
        aux.horarios[x] = Console.ReadLine();
      }
      break;
     }
    }
   }
  }
 }
}
