using System;
using System.Collections.Generic;
using System.Text;

namespace KoffieMachine
{
    class KoffieMachine
    {
        private int Suikerklontjes;

        private int KoffieBonen;

        private int Melkpoeder;

        public KoffieMachine(int Melkpoeder, int Koffiebonen, int Suikerklontjes){
            this.Melkpoeder = Melkpoeder;
            this.KoffieBonen = KoffieBonen;
            this.Suikerklontjes = Suikerklontjes;
        }

        private void ControleerResources()
        {
            if (this.Suikerklontjes < 0)
            {
             throw new Exception("De suiker is op!");
            }

            if (this.KoffieBonen < 0)
            {
             throw new Exception("Vul koffiebonen bij!");
            }

            if (this.Melkpoeder < 0)
            {
             throw new Exception("Er is een tekort aan melkpoeder!");
            }
        }

        public Bekertje GeefCappuccino()
        {
            ControleerResources();
            this.Suikerklontjes -= 2;
            this.KoffieBonen -= 5;
            this.Melkpoeder -= 15;

            Bekertje bekertje = new Bekertje(KoffieSoort.cappuccino);

            return bekertje;
        }

        public Bekertje GeefKoffie()
        {
            ControleerResources();
            this.Suikerklontjes -= 0;
            this.KoffieBonen -= 6;
            this.Melkpoeder -= 0;

            Bekertje bekertje = new Bekertje(KoffieSoort.cappuccino);

            return bekertje;
        }
    }
}
