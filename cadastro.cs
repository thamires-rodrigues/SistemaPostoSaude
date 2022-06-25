using System;
using System.IO;
class Cadastro 
{
    public void Cadastro_Concluido (string nome_paciente, long cpf_paciente, int telefone_paciente)
    {
        Console.WriteLine ("NOME: " + nome_paciente + ", CPF: " + cpf_paciente + ", TELEFONE: " + telefone_paciente);
        Console.WriteLine ("Pressione qualquer tecla para continuar");
        Console.ReadKey ();
        Console.Clear ();
    }
    
    public void Cadastro_Paciente ()
    {
        int i, telefone, idade;
        string nome = " ", endereco;
        long cpf;
                
        for (i=1; nome!="XX"; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CADASTRO DE PACIENTE");
            Console.ResetColor ();
            Console.WriteLine ("Para encerrar o cadastro digite XX no nome do paciente");
            Console.Write ("Informe o nome completo: ");
            nome = Console.ReadLine().ToUpper();
        
            if (nome == "XX")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("CADASTRO ENCERRADO!");
                Console.ResetColor ();
                Console.WriteLine ("Pressione qualquer tecla para continuar");
                Console.ReadKey ();
                Console.Clear ();
                break;
            }
            
            Console.Write ("Informe a data de nascimento no formato DD/MM/AAAA: ");
            idade = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Informe o CPF: ");
            cpf = Convert.ToInt64 (Console.ReadLine());
            Console.Write ("Digite o telefone: ");
            telefone = Convert.ToInt32 (Console.ReadLine());
            Console.Write ("Informe o endereço residencial: ");
            endereco = Console.ReadLine().ToUpper();
            
            Cadastro_Concluido (nome, cpf, telefone);
            
            using (StreamWriter writer = new StreamWriter ("C:\\Users\\gppga\\Downloads\\Cadastros.txt", true))
            {
                writer.WriteLine (nome + ", " + idade + ", " + cpf + ", " + telefone + ", " + endereco );
            }
        }
    }
}
