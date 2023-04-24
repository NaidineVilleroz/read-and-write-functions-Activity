
 class Program
{
    private static void Main(string[] args)
    {
        string line;

        StreamReader StreamR = new StreamReader("C:\\Users\\ville\\Downloads\\Streamreader.txt");

        // Read lines from input file
        while ((line = StreamR.ReadLine()) != null)
        {
            Console.WriteLine(line);
        }

        StreamR.Close();

        StreamWriter StreamW = new StreamWriter("C:\\Users\\ville\\Downloads\\Streamreader.txt");

        // Write lines to output file
        StreamW.WriteLine(@"________$$$$_______________
_______$$__$_______________
_______$___$$______________
_______$___$$______________
_______$$___$$_____________
________$____$$____________
________$$____$$$__________
_________$$_____$$_________
_________$$______$$________
__________$_______$$_______
____$$$$$$$________$$______
__$$$_______________$$$$$$
_$$____$$$$____________$$$
_$___$$$__$$$____________$$
_$$________$$$____________$
__$$____$$$$$$____________$
__$$$$$$$____$$___________$
__$$_______$$$$___________$
___$$$$$$$$$__$$_________$$
____$________$$$$_____$$$$
____$$____$$$$$$____$$$$$$
_____$$$$$$____$$__$$
_______$_____$$$_$$$
________$$$$$$$$$$

");
        StreamW.WriteLine("HELLO READ AND WRITE TEXT LINE");

        StreamW.Close();
    }
}
