namespace VetorBuscaBinaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] vetor = new int[100000000]; /// Tamanho do vetor; os dados devem estar ordenados
            int contador =0;
            for (int i = 0; i < vetor.Length; i++)
            {
                vetor[i] = i * 2;
            }

            Console.WriteLine("Digite o numero a ser buscado: ");
            int numeroBuscado = Convert.ToInt32(Console.ReadLine());

            bool achou = false;
            int inicio = 0;          
            int meio ;
            int fim = vetor.Length - 1;            
            
            while (inicio <= fim)
            {
                contador++;
                meio = Convert.ToInt32((inicio + fim) / 2);

                if (vetor[meio] == numeroBuscado)
                {
                    achou = true;                   

                    break;
                }

                else if (vetor[meio] < numeroBuscado)
                {
                    inicio = meio + 1;

                }
                else
                {
                    fim = meio - 1;

                } 
            }
            if (achou)
            {
                Console.WriteLine("Valor foi encontrado, qtd de testes: "+ contador);              
            }
            else
            {
                Console.WriteLine("Valor nao foi encontrado, qtd de testes: " + contador);
            }

        }
    }
}
