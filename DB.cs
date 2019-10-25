using System;
namespace Sistema{
class DB {
private Paciente[] pacientes = new Paciente[20];
private Consulta[] consultas = new Consulta[20];

public DB(){

}


//-------------

 public void listarPacientes() {
   for(int i = 0; i < pacientes.Length; i++){
        Console.Write(pacientes[i].getNome());
      }
 }

 public Paciente[] buscarPaciente(int cpf){
  return pacientes;
 }

 public void excluirPaciente() {
   
   
 }

 public void editarPaciente() {
   
 }

 public void cadastrarPacientes(){
   for(int i = 0; i < pacientes.Length; i ++){
     Console.WriteLine("Escreva o nome do paciente {0}", i+1);
     pacientes[i].setNome(Console.ReadLine());

     Console.WriteLine("Escreva a idade do paciente {0}", i+1);
     pacientes[i].setIdade(int.Parse(Console.ReadLine()));

     Console.WriteLine("Escreva a altura do paciente {0}", i+1);
     pacientes[i].setAltura(double.Parse(Console.ReadLine()));


     Console.WriteLine("Escreva o peso do paciente {0}", i+1);
     pacientes[i].setPeso(double.Parse(Console.ReadLine()));
   }
 }




//-------------

 public void listarConsultas() {
   for(int i = 0; i < consultas.Length; i++){
     Paciente p = consultas[i].getPaciente();
        Console.WriteLine(p.getNome());
      }
 }



 public Consulta buscarConsulta(int cod){
  return consultas[cod];
 }

 public void excluirConsulta() {  
   
 }

 public void editarConsulta() {
   
 }


 }
}