namespace Sibenice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //slovo, které se bude hádat
            string hadaneSlovo = "kolotoč";


            //kopie slova - pomocná
            string kopieSlova = hadaneSlovo;


            //život 
            int zivot = 10;

            do
            {
                for (int i = 0; i <hadaneSlovo.Length; i++)
                {

                    if (kopieSlova.Contains(hadaneSlovo[i]))
                    {
                        //Pokud je znak v kopii slova, napíše _
                        Console.Write("_ ");

                    }
                    else
                    {
                        //Pokud není v kopii, tak napíše znak
                        Console.Write(hadaneSlovo[i]+" ");
                    }
                }
                Console.WriteLine("Zadej písmeno: ");

                char pismeno = char.Parse(Console.ReadLine());


                if(hadaneSlovo.Contains(pismeno))
                {
                    //pokud hadane slovo obsahuje znak, dá místo něj mezeru
                   kopieSlova = kopieSlova.Replace(pismeno.ToString(),"");

                }
                else
                {
                    //pokud hádané slovo neohsahuje znak, odečte život
                    zivot--;
                }


            } while (zivot>0 && kopieSlova!="");

            Console.WriteLine( "Díky za hru");
        }
    }
}