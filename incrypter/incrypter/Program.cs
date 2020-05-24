using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace incrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            bool die = true;
            while (die)
            {
                Console.WriteLine("tryk 1 hvis du vil lave en ny fil eller overskrive en eksisterende fil");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value)) {
                    if (Convert.ToInt32(input) == 1)
                    {
                        Console.WriteLine("fuck uuuuuuu");
                        methods.inhold();
                    }
                    else
                    {
                        Console.WriteLine("HEY KAN DU IK LÆSE!? SKRIV FORHELVEDE ET TAL SOM HAR EN FUNTKION..\n GOD DIT RETADEREDE BARN.\n DET VAR HELE GRUNDEN TIL AT JEG FORLOD DIN MOR EFTER AT JEG HAVDE SPERMET HENDE I ANSIGTET.\n HUN LIGNEDE FANDME ET JULETRÆ MED SPERM SOM GIRLANDER.\n MEN HEY IDET MINDSTE KOSTEDE HUN KUN 10 KR.\n Prøv igen DIN RETADEREDE MØGUNGE.");
                    }
                }
                else
                {
                    Console.WriteLine("BITCH HVA FUCK MENER DU? KAN DU VIRKELIG IK FORSTÅ ET SIMPELT VALG MED AT TRYKKE PÅ ET TAL?!?! DIN INKOMPETENTE SATAN.\n FORSTÅR SKU GODT HVORFOR AT DIN MOR SAGDE TIL MIG IGÅR AT DU VAR ET UHELD.\n FORSTÅR OGS GODT AT DIN FAR VALGTE AT HÆNGE SIG SELV END AT KOMME HJEM MED MÆLKEN.");
                }
            }
        }

    }
}
