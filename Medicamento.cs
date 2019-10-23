using System;
namespace Sistema{

class Medicamento {

 private string nome;
 private string validade;
 private string horario;




 public Medicamento(string n,string v) {
   nome = n;
   validade = v;


 }

 public setHorario(string h){
   horario = h;

 }

 public string getNome(){
   return nome;
  
 }

}
}