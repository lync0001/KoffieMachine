using System;
using System.Collections.Generic;
using System.Text;

namespace KoffieMachine
{
    class KoffieMachine
    {
        // Het aantal suikerklontjes

        // Het aantal koffiebonen

        // Het aantal gram melkpoeder

        public Bekertje GeefCappuccino()
        {
            // Een cappuccino bestaat uit:
            // 2 suikerklontjes
            // 4 koffiebonen
            // 10 gram melk

            Bekertje bekertje = new Bekertje(KoffieSoort.cappuccino);

            return bekertje;
        }
    }
}
