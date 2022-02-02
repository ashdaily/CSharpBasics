using System;
using static CSharpBasics.CSharpDataTypes;
using static CSharpBasics.CSharpTypeCasting;
using static CSharpBasics.CSharpUserInput;
using static CSharpBasics.CSharpConditionalStatements;
using static CSharpBasics.CSharpArrays;


namespace CSharpBasics
{
    class CSharpBasics
    {
        static void Main(string[] args)
        {
            //creating object of class Program
            CSharpBasics program = new CSharpBasics();
            
            // c sharp basics concepts
            program.PlayWithConsole();
            program.PlayWithDataTypes();
            program.PlayWithCastType();
            program.PlayWithUserInput();
            program.PlayWithArrays();
        }

        private void PlayWithDataTypes()
        {
            PlayWithInt();
            PlayWithFloat();
            PlayWithDouble();
            PlayWithDecimal();
            PlayWithBool();
        }

        private void PlayWithConsole()
        {
            int b;
            // this will break because we cannot print null to console
            // Console.WriteLine(b); 
        }

        private void PlayWithCastType()
        {
            PlayWithCastTypeManualAndAutomatic();
        }

        private void PlayWithUserInput()
        {
            UserInput();
            ConditionalStatements();
        }

        private void PlayWithArrays()
        {   
            Arrays();
        }
    }
}