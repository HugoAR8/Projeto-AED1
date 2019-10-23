using System;
namespace Sistema{


class Consulta {

 private string nomePaciente;
 private DateTime data;
 private string horario;




 public Consulta() {

 }

 public void listarC() {
   

  }

  public void adicionarC() {

  }

  public void excluirC() {

  }

  public void alterarC() {

  }

  public void setNomePaciente(string n) {
  this.nomePaciente = n;
 }

 public string getNomePaciente() {
  return nomePaciente;
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