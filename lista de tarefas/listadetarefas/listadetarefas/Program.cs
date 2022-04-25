using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listadeutilizadores
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Insira a opção desejada: \n 1- Login 2- Registar 3- Listar utilizadores  4- Adicionar tarefa  5- alterar tarefa  6- remover tarefa");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1: Login(); break;
                case 2: Registo(); break;
                case 3: getutilizadores(); break;
                case 4: AdicionatarefasAsync(); break;
                case 5: AlterartarefasAsync(); break;
                case 6: await RemovertarefaAsync();  break;


            }
            Console.Read();
        }

        private static async Task RemovertarefaAsync()
        {
            Console.WriteLine("introduza  a tarefa a remover");
            String nome = Console.ReadLine();


            object id = null;
            Task<string> resultTask = ligaçãobd.alterartarefa(id, hash.sha256_hash(nome));
            String result = await resultTask;

            //Console.WriteLine(Hash.sha256_hash(password));

            Console.WriteLine(result);

            Console.Read();
        }

       

        private static async void AlterartarefasAsync()
        {
            Console.WriteLine("introduza  a tarefa alterar");
            String nome = Console.ReadLine();


            object id = null;
            Task<string> resultTask = ligaçãobd.alterartarefa(id, hash.sha256_hash(nome));
            String result = await resultTask;

            //Console.WriteLine(Hash.sha256_hash(password));

            Console.WriteLine(result);

            Console.Read();
        }

        static async void AdicionatarefasAsync()
        {
            Console.WriteLine("Introduza a tarefa");
            String ñome = Console.ReadLine();
           

            object id = null;
            string nome = null;
            Task<string> resultTask = ligaçãobd.adicionatarefas(id, hash.sha256_hash(nome));
            String result = await resultTask;

            //Console.WriteLine(Hash.sha256_hash(password));

            Console.WriteLine(result);

            Console.Read();


        }

        static async void Registo()
        {
            Console.WriteLine("Insira o utilizador: ");
            String username = Console.ReadLine();
            Console.WriteLine("Insira a password");
            String password = Console.ReadLine();

            Task<string> resultTask = ligaçãobd.Registutilizadores(username, hash.sha256_hash(password));
            String result = await resultTask;

            //Console.WriteLine(Hash.sha256_hash(password));

            Console.WriteLine(result);

            Console.Read();
        }

        static async void Login()
        {
            Console.WriteLine("Introduza o utilizador");
            String username = Console.ReadLine();
            Console.WriteLine("Introduza a password");
            String password = Console.ReadLine();

            Task<string> resultTask = ligaçãobd.loginutilizadores(username, hash.sha256_hash(password));
            String result = await resultTask;

            //Console.WriteLine(Hash.sha256_hash(password));

            Console.WriteLine(result);

            Console.Read();
        }

        static async void getutilizadores()
        {
            Task<string> resultTask = ligaçãobd.getutilizadores();
            string result = await resultTask;

            Console.WriteLine(result);
            Console.Read();
        }

    }

    










    }
