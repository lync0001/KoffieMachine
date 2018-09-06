using System;
using System.Collections.Generic;
using System.Text;

namespace KoffieMachine
{
    class Bekertje
    {
        private KoffieSoort SoortKoffie;

        public Bekertje(KoffieSoort koffieSoort)
        {
            SoortKoffie = koffieSoort;
        }

        private void PrintKoffieZwart()
        {
            Console.WriteLine("Koffie");
        }

        private void PrintLatteMacchiato()
        {
            Console.WriteLine("Gewoon een bak melk");
        }

        private void PrintAmericano()
        {
            Console.WriteLine("Water met koffie");
        }
       
        private void PrintEspresso()
        {
            Console.WriteLine("Pittig bakkie");
        }

        private void PrintCappuccino()
        {
            Console.WriteLine("          {");
            Console.WriteLine("       }   }   {");
            Console.WriteLine("      {   {  }  }");
            Console.WriteLine("       }   }{  {");
            Console.WriteLine("      {  }{  }  }");
            Console.WriteLine("     ( }{ }{  { )");
            Console.WriteLine("    .-{   }   }-.");
            Console.WriteLine("   ( ( } { } { } )");
            Console.WriteLine("   |`-.._____..-'|");
            Console.WriteLine("   |             ;--.");
            Console.WriteLine("   |   (__)     (__  \\");
            Console.WriteLine("   |   (oo)      | )  )");
            Console.WriteLine("   |    \\/       |/  /");
            Console.WriteLine("   |             /  /    ");
            Console.WriteLine("   |            (  /");
            Console.WriteLine("   \\             y'");
            Console.WriteLine("    `-.._____..-'");
            // Thanks to -Felix Lee- (Decorative)-
        }

        public void Print()
        {
            if(this.SoortKoffie == KoffieSoort.cappuccino)
            {
                PrintCappuccino();
            }

            else if (this.SoortKoffie == KoffieSoort.koffie)
            {
                PrintKoffieZwart();
            }

            else if (this.SoortKoffie == KoffieSoort.lattemacchiato)
            {
                PrintLatteMacchiato();
            }

            else if (this.SoortKoffie == KoffieSoort.americano)
            {
                PrintAmericano();
            }

            else if (this.SoortKoffie == KoffieSoort.espresso)
            {
                PrintEspresso();
            }
        }

    }
}