using Code;


namespace Code{
    class Aula1{

        public static void Aula(string[] args){

            // se o tamanho do argumento passado for maior que 0, printe o valor
            // se não, printe "Não há argumentos"
            if (args.GetLength(0) > 0){
                Console.WriteLine(args.GetValue(0));  
                
            }else{
                Console.WriteLine("Não há argumentos");
            }
            


            string letras = "asndf";
            if (letras.Length > 3){
                Console.WriteLine($"{letras} tem {letras.Length} letras");
                return;
            }
            Console.WriteLine("Não tem mais que 3 letras");
            return;
            
            
            
        }
    }
}