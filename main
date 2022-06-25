/*Projeto em grupo desenvolvido com a linguagem C#
Integrantes: Leticia Ferreira Silva, Livia Paliari Padovine e Thamires de Melo Rodrigues*/

using System;
using System.IO;
class Principal 
{
    static void Validacao ()
    {
        string[] user_aut = {"ADRIANA","DANIELLE","DENIS","GABRIEL","GUILHERME","LARA","LETICIA","LIVIA","THAMIRES","VANESSA"};
        string[] user_senha = {"A2020","DA2020","DE2020","GA2020","GU2020","LA2020","LE2020","LI2020","T2020","V2020"};
        
        int i;
        string nome, senha, path = @"C:\\Users\\gppga\\Downloads\\Usuarios.txt";
        bool aut = false;
        
        if (!File.Exists(path))
        {
            File.WriteAllText (path, user_aut[0] + ", " + user_senha[0] + "\n");
            for (i=1; i<9; i++)
            {
                File.AppendAllText (path, user_aut[i] + ", " + user_senha[i] + "\n");
            }
            File.AppendAllText  (path, user_aut[9] + ", " + user_senha[9]);
        }
        
        do
        {
            Console.WriteLine ("VALIDAÇÃO DE USUÁRIO");
            Console.Write ("Digite o nome do usuário: ");
            nome = Console.ReadLine().ToUpper();
            Console.Write ("Digite a senha do usuário: ");
            senha = Console.ReadLine().ToUpper();
            
            for (i=0; i<10; i++)
            {
                if (user_aut[i] == nome && user_senha[i] == senha)
                {
                    aut = true;
                }
            }
            
            if (aut == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("ACESSO NEGADO");
                Console.ResetColor();
                Console.WriteLine ("Pressione qualquer tecla para tentar novamente!");
                Console.ReadKey();
                Console.Clear();
            }
            
            else if (aut == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ("ACESSO AUTORIZADO");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine ("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }while (aut==false);
    }
    
    static void Main()
    {
        Vacinas Paciente = new Vacinas();
        Medicamentos Remedio = new Medicamentos();
        Cadastro Objeto = new Cadastro();
        int i;
        string op = " ";
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine ("POSTO DE SAÚDE - A SAÚDE DO POVO");
        Console.ResetColor();
        Console.WriteLine();
        Validacao();
        
        for (i=0; op!="XX"; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (" _________________________");
            Console.WriteLine ("|   SISTEMA DE CADASTRO   |");
            Console.WriteLine ("|_________________________|");
            Console.WriteLine ("| A = Aplicação de Vacina |");
            Console.WriteLine ("| B = Retirar Medicamento |");
            Console.WriteLine ("| C = Cadastrar Paciente  |");
            Console.WriteLine ("| XX = Encerrar Programa  |");
            Console.WriteLine ("|_________________________|");
            Console.ResetColor();
                    
            Console.Write ("De acordo com a tabela, informe a sua opção: ");
            op = Console.ReadLine().ToUpper();
                    
            if (op == "XX")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine ("PROGRAMA ENCERRADO COM SUCESSO!");
                Console.ResetColor();
                break;
            }
            
            Console.WriteLine ("Pressione qualquer tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        
            if (op == "A")
            {
                Paciente.Vacinas_Disponiveis();
            }
            
            else if (op == "B")
            {
                Remedio.Medicamentos_Disponiveis();
            }
            
            else if (op == "C")
            {
                Objeto.Cadastro_Paciente();
            }
        }
    }
}
