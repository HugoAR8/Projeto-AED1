using System;
namespace Sistema {

  class Medico{

    private string nome;
    private string especializacao;
    private string[] horarios = new string[5]; 

    public Medico(string n, string e){
      nome = n;
      especializacao = e;
      
    }

    // Horários disponíveis do médico em questão.
    public void setHorarios(string h1, string h2, string h3, string h4, string h5){
      horarios[0] = h1;
      horarios[1] = h2;
      horarios[2] = h3;
      horarios[3] = h4;
      horarios[4] = h5;
    }

    public void imprimirHorarios(){
      for(int i = 0; i < horarios.Length; i++){
        Console.WriteLine(horarios[i]);
      }
    }

    
  }
}