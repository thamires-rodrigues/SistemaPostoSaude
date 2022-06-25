using System;
using System.IO;
class Vacinas
{
    public void Vacinas_Disponiveis() // Parte Livia
    {
        string[] nome_vacinas = {"BCG","HPV","GRIPE","TÉTANO","MENINGITE","ROTAVÍRUS","HEPATITE A","HEPATITE B","FEBRE AMARELA","TRÍPLICE VIRAL"};
        int[] quantidade_vacinas = {30,35,150,50,35,50,75,60,80,50};
        int vac;
        string op = " ";
        
        for (int i=0; op!="XX"; i++)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine (" _____________________");
            Console.WriteLine ("|       VACINAS       |");
            Console.WriteLine ("|_____________________|");
            Console.WriteLine ("| 0 = BCG             |");
            Console.WriteLine ("| 1 = HPV             |");
            Console.WriteLine ("| 2 = Gripe           |");
            Console.WriteLine ("| 3 = Tétano          |");
            Console.WriteLine ("| 4 = Meningite       |");
            Console.WriteLine ("| 5 = Rotavírus       |");
            Console.WriteLine ("| 6 = Hepatite A      |");
            Console.WriteLine ("| 7 = Hepatite B      |");
            Console.WriteLine ("| 8 = Febre Amarela   |");
            Console.WriteLine ("| 9 = Tríplice Viral  |");
            Console.WriteLine ("|_____________________|");
            Console.ResetColor ();
            
            string path = @"C:\\Users\\gppga\\Downloads\\Vacinas.txt";
            if (!File.Exists(path))
            {
                File.WriteAllText (path, nome_vacinas[0] + "\n");
                for (i=1; i<9; i++)
                {
                    File.AppendAllText (path, nome_vacinas[i] + "\n");
                }
                File.AppendAllText (path, nome_vacinas[9]);
            }
            
            Console.Write ("De acordo com a tabela, informe a vacina desejada ou digite XX para encerrar: ");
            op = Console.ReadLine().ToUpper();
            
            if (op == "XX")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine ("APLICAÇÃO DE VACINA ENCERRADA!");
                Console.ResetColor();
                Console.WriteLine ("Pressione qualquer tecla para continuar");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            
            vac = Convert.ToInt32 (op);
            
            try
            {
                if (quantidade_vacinas[vac] >=1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine ("QUANTIDADE DA VACINA " + nome_vacinas[vac].ToUpper() + " DISPONÍVEL: " + quantidade_vacinas[vac]);
                    Console.ResetColor();
                    
                    Console.Write ("Se deseja tomar a vacina digite S, se não digite N: ");
                    string op_2 = Console.ReadLine().ToUpper();
                    if (op_2 == "S")
                    {
                        quantidade_vacinas[vac] = quantidade_vacinas[vac] - 1;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine ("QUANTIDADE ATUAL: " + quantidade_vacinas[vac]);
                        Console.ResetColor();
                    }
                }
                
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine ("VACINA " + nome_vacinas[vac].ToUpper() + " INDISPONÍVEL");
                    Console.ResetColor();
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
