using System;

namespace Sistema {


 class MainClass {


  public static void Main() {
   DB db = new DB();

   menu(db);

  }

  public static void menu(DB data) {
   DB db = new DB();
   db = data;
   string aux;


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
     menu(db);


    } else {
     if (aux == "Listar") {
      Console.Clear();
      db.listarPacientes();
      Console.WriteLine("Menu");
       string i = "";
       while (i != "Menu") {
        i = Console.ReadLine();
       }
       menu(db);

     } else {
      if (aux == "Buscar") {
       Console.Clear();
       Console.WriteLine("Escreva o nome do Paciente: ");
       string paciente = Console.ReadLine();
       db.buscarPaciente(paciente);
       Console.WriteLine("\n");
       Console.WriteLine("Menu");

       //--- escape
       string i = "";
       while (i != "Menu") {
        i = Console.ReadLine();
       }
       menu(db);

      } else {
       if (aux == "Editar") {
        Console.Clear();
        Console.WriteLine("Nome do Paciente: ");
        string editarPaciente = Console.ReadLine();
        db.editarPaciente(editarPaciente);
        menu(db);

       } else {
        if (aux == "Excluir") {
         Console.Clear();
         //db.excluirPaciente();
         menu(db);

        } else {
         menu(db);
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
       db.listarConsultas();

      } else {
       if (aux == "Buscar") {
        Console.Clear();
        //db.buscarPaciente();

       } else {
        if (aux == "Editar") {
         Console.Clear();
         // db.editarPaciente();

        } else {
         if (aux == "Excluir") {
          Console.Clear();
          //db.excluirPaciente();

         } else {
          menu(db);
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
           menu(db);
          }
         }
        }


       }
      }
     }


    }

    menu(db);

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
