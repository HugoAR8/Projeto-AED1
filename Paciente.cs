using System;

class Paciente {

 private string nome;
 private int idade;
 private double peso;
 private double altura;
 private Medicamento medicamento;


 public Paciente() {

 }


 public int setIdade(int i) {
  this.idade = i;
 }

 public int getIdade() {
  return this.idade;
 }


 public int getPeso() {
  return this.peso;
 }


 public int setPeso(int p) {
  this.peso = p;
 }

 public int getAltura() {
  return this.altura;
 }


 public int setAltura(int a) {
  this.peso = a;
 }

}