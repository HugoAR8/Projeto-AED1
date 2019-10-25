using System;
namespace Sistema {

 class MainClass {
  public static void Main(string[] args) {

   menu();

  }

  public static void menu() {
   string aux;
   DB db = new DB();
   Console.Clear();
   art();

   Console.WriteLine("Pacientes");
   Console.WriteLine("Consultas");
   Console.WriteLine("Médicos");
   aux = Console.ReadLine();

   if (aux == "Pacientes") {
    Console.Clear();
    Console.WriteLine("Cadastrar");
    Console.WriteLine("Listar");
    Console.WriteLine("Buscar");
    Console.WriteLine("Editar");
    Console.WriteLine("Excluir");
    Console.WriteLine("Menu");

    aux = (Console.ReadLine());

    if (aux == "Cadastrar") {
     Console.Clear();
     db.cadastrarPaciente();

    } else {
     if (aux == "Listar") {
      Console.Clear();
      db.listarPacientes();

     } else {
      if (aux == "Buscar") {
       Console.Clear();
       Console.WriteLine("Escreva o nome do Paciente: ");
       string buscarPaciente = Console.ReadLine();
       db.buscarPaciente(buscarPaciente);
       Console.WriteLine("\n");

      } else {
       if (aux == "Editar") {
        Console.Clear();
        db.editarPaciente();

       } else {
        if (aux == "Excluir") {
         Console.Clear();
         db.excluirPaciente();

        } else {
         menu();
        }

       }
      }
     }
    }

   } else {
    if (aux == "Consultas") {
     Console.Clear();
     Console.WriteLine("Marcar");
     Console.WriteLine("Listar");
     Console.WriteLine("Buscar");
     Console.WriteLine("Editar");
     Console.WriteLine("Excluir");
     Console.WriteLine("Menu");
     aux = (Console.ReadLine());

     if (aux == "Marcar") {
      Console.Clear();
      db.marcarConsulta();

     } else {
      if (aux == "Listar") {
       Console.Clear();
       db.listarPacientes();

      } else {
       if (aux == "Buscar") {
        Console.Clear();
        //db.buscarPaciente();

       } else {
        if (aux == "Editar") {
         Console.Clear();
         db.editarPaciente();

        } else {
         if (aux == "Excluir") {
          Console.Clear();
          db.excluirPaciente();

         } else {
          menu();
         }

        }
       }
      }
     }

    } else {
     if (aux == "Médicos") {
      Console.Clear();
      Console.WriteLine("Cadastrar");
      Console.WriteLine("Listar");
      Console.WriteLine("Buscar");
      Console.WriteLine("Editar");
      Console.WriteLine("Excluir");
      Console.WriteLine("Menu");
      aux = (Console.ReadLine());

      if (aux == "Cadastrar") {
       Console.Clear();
       // db.cadastrarMedico();

      } else {
       if (aux == "Listar") {
        Console.Clear();
        // db.listarMedicos();

       } else {
        if (aux == "Buscar") {
         Console.Clear();
         //  db.buscarMedico();

        } else {
         if (aux == "Editar") {
          Console.Clear();
          // db.editarMedico();

         } else {
          if (aux == "Excluir") {
           Console.Clear();
           //db.excluirMedico();

          } else {
           menu();
          }
         }
        }


       }
      }
     }


    }

    menu();

   }
  }

  public static void art() {

    Console.WriteLine(@"  
  __  __          _   ____  _           
 |  \/  | ___  __| | |  _ \| |_   _ ___ 
 | |\/| |/ _ \/ _` | | |_) | | | | / __|
 | |  | |  __/ (_| | |  __/| | |_| \__ \
 |_|  |_|\___|\__,_| |_|   |_|\__,_|___/
                                        ");
                                        
  }
 }
}