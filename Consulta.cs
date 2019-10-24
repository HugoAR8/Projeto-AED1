using System;
namespace Sistema{


class Consulta {

 private Paciente paciente = new Paciente();
 private DateTime data;
 private string horario;


  public void setPaciente(Paciente p) {
  this.paciente = p;
 }

 public Paciente getPaciente() {
  return paciente;
 }

 public void setData(DateTime d) {
  this.data = d;
 }


 public DateTime getData() {
  return data;
 }

 public void setHorario(string h) {
  this.horario = h;
 }

 public string getHorario() {
  return horario;
 }
 
}}