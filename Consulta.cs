using System;
namespace Sistema{


class Consulta {

 private Paciente paciente = new Paciente();
 private string data;
 private string horario;


  public void setPaciente(Paciente p) {
  this.paciente = p;
 }

 public Paciente getPaciente() {
  return paciente;
 }

 public void setData(string d) {
  this.data = d;
 }


 public string getData() {
  return data;
 }

 public void setHorario(string h) {
  this.horario = h;
 }

 public string getHorario() {
  return horario;
 }
 
}}