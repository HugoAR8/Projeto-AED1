using System;
namespace Sistema{

class Paciente {

 private string nome;
 private int idade;
 private double peso;
 private double altura;
 private Medicamento medicamento;


 public Paciente() {

 }

 public void listarP() {

  }

  public void adicionarP() {

  }

  public void excluirP() {

  }

  public void alterarP() {

  }

public void setIdade(int i) {
  this.idade = i;
 }

 public int getIdade() {
  return idade;
 }

 public void setPeso(double p) {
  this.peso = p;
 }


 public double getPeso() {
  return peso;
 }

 public void setAltura(double a) {
  this.peso = a;
 }

 public double getAltura() {
  return altura;
 }

}
}