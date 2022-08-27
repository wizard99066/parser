namespace parser
{   
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите имя файла: ");
                string? fileName = Console.ReadLine();
                FileParser? parser = FileParser.GetParser(fileName);
                if (parser == null)
                    Console.WriteLine("Парсер для данного файла не был найден! Попробуйте еще раз!");
                else
                    parser.Parse();
                Console.WriteLine();
                Console.ReadKey();



                /*   скрин работающей программы                https://i.postimg.cc/Gm06HwhY/2022-08-27-122358818.png)](https://postimg.cc/fJK8rPdT
                 */


            }
        }
    }
}