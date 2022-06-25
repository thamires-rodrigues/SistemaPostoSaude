using System;
using System.IO;
class Medicamentos 
{
    public void Medicamentos_Disponiveis ()
    {
        string [] nome_medicamentos = {"INSULINA","ASMA","HIPERTENSÃO","ESCLEROSE MÚLTIPLA","AIDS","MAL DE PARKINSON","MAL DE ALZHEIMER","ESQUIZOFRENIA","DEPRESSÃO","TUBERCULOSE"};
        int [] quantidade_medicamentos = {250,35,150,45,26,98,88,44,92,55};
        int med;
        string op = " ";
    
        for (int i=0; op!="XX"; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (" _________________________________");
            Console.WriteLine ("|          MEDICAMENTOS           |");
            Console.WriteLine ("|_________________________________|");
            Console.WriteLine ("| 0 = Insulina                    |");
            Console.WriteLine ("| 1 = Contra a Asma               |");
            Console.WriteLine ("| 2 = Para a Hipertensão          |");
            Console.WriteLine ("| 3 = Contra a Esclerose Múltipla |");
            Console.WriteLine ("| 4 = Contra a AIDS               |");
            Console.WriteLine ("| 5 = Para Mal de Parkinson       |");
            Console.WriteLine ("| 6 = Para o Mal de Alzheimer     |");
            Console.WriteLine ("| 7 = Esquizofrenia               |");
            Console.WriteLine ("| 8 = Para a Depressão            |");
            Console.WriteLine ("| 9 = Contra a Tuberculose        |");
            Console.WriteLine ("|_________________________________|");
            Console.ResetColor ();
            
            string path = @"C:\\Users\\gppga\\Downloads\\Medicamentos.txt";
            if (!File.Exists(path))
            {
                File.WriteAllText (path, nome_medicamentos[0] + "\n");
                for (i=1; i<9; i++)
                {
                    File.AppendAllText (path, nome_medicamentos[i] + "\n");
                }
                File.AppendAllText (path, nome_medicamentos[9]);
            }
        
            Console.Write ("De acordo com a tabela, informe o medicamento desejado ou digite XX para encerrar: ");
            op = Console.ReadLine().ToUpper();
            
            if (op == "XX")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("CONSULTA DE MEDICAMENTOS DISPONÍVEIS ENCERRADA!");
                Console.ResetColor();
                Console.WriteLine ("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            
            med = Convert.ToInt32 (op);
        
            try
            {
               if (quantidade_medicamentos[med] >=1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("QUANTIDADE DE MEDICAMENTO " + nome_medicamentos[med].ToUpper() + " DISPONÍVEL: " + quantidade_medicamentos[med]);
                    Console.ResetColor ();
                    
                    Console.Write ("Se deseja retirar o medicamento digite S, se não digite N: ");
                    string op_2 = Console.ReadLine().ToUpper();
                    if (op_2 == "S")
                    {
                        quantidade_medicamentos[med] = quantidade_medicamentos[med] - 1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ("QUANTIDADE ATUAL: " + quantidade_medicamentos[med]);
                        Console.ResetColor();
                    }
                }
            
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ("MEDICAMENTO " + nome_medicamentos[med].ToUpper() + " INDISPONÍVEL");
                    Console.ResetColor ();
                }
            
                Console.WriteLine ("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }   
                catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("ERRO!");
                Console.WriteLine ("Índice digitado não corresponde!");
                Console.ResetColor();
                Console.WriteLine ("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
