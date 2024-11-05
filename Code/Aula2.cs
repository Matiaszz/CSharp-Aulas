using Code;
using System;

namespace Code{
    class Aula2{
        public static void Variaveis(string[] args){

            //Aulas sobre variavies
            int num = 1;
            float numFlutuante = 2.5f;
            double OutroNumFlutuante = 2.45;
            string frase = "Letras";
            char umCaractere = 'w';
            byte baite = 23; // 0 -> 255

            num++; // num += 1; num = num + 1 //mesma coisa para todos

            bool verificar = (5>3)||(10<5) && (1>2); 
            System.Console.WriteLine(verificar);
            System.Console.WriteLine($"{num} {numFlutuante} {OutroNumFlutuante} {frase} {umCaractere} {baite}");


        }
    }
}