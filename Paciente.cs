using System;
namespace Sistema{

class Paciente {

 private string nome;
 private int idade;
 private double peso;
 private double altura;
 private Medicamento medicamento;
 private Paciente[] paciente = new Paciente[20];


 public Paciente() {

 }

 public void listarP() {

    Paciente p1 = new Paciente();
    

    
   




  }

  public void adicionarP() {

  }

  public void excluirP() {

  }

  public void alterarP() {

  }

  
public void setNome(string n) {
  this.nome = n;
 }

 public string getNome() {
  return nome;
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