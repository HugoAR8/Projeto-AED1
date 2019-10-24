using System;
namespace Sistema{
class DB {
private Paciente[] pacientes = new Paciente[20];
private Consulta[] consultas = new Consulta[20];

public DB(){

}


//-------------

 public Paciente[] listarPacientes() {
   return pacientes;
 }

 public Paciente[] buscarPaciente(int cpf){
  return pacientes;
 }

 public void excluirPaciente() {
   
   
 }

 public void editarPaciente() {
   
 }


//-------------

 public Consulta[] listarConsultas() {
   return consultas;
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