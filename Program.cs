namespace Questionario_Cinema{
    class Program{
        public static void Main (string[] args){

            /*Em um cinema, certo dia, cada espectador respondeu a um questionário, 
            que perguntava a sua idade (ID) e a opinião em relação ao filme (OP), 
            seguindo os seguintes critérios:

                Opinião   |     Significado
                  A       |        Ótimo
                  B       |         Bom
                  C       |       Regular
                  D       |         Ruim
                  E       |       Péssimo

            A entrada de dados sobre a opinião deve ser validada. 
            O final da pesquisa será indicado quando a idade do usuário for 
            informada como negativa (idade inexistente).
            Construa um programa que, lendo esses dados, calcule e apresente:
            - Quantidade de pessoas que respondeu a pesquisa
            - Média de idade das pessoas que responderam a pesquisa
            - Porcentagem de cada uma das respostas*/

            int idade, itt, i, media, a, b, c, d, e;
            double pora, porb, porc, pord, pore;
            char op;

            Console.WriteLine("");
            Console.WriteLine("Pesquisa de satisfação do filme.");
            Console.WriteLine("- Para finalizar a pesquisa entre com uma idade negativa qualquer.");
            itt=0;
            i=0;
            a=0;
            b=0;
            c=0;
            d=0;
            e=0;
            do{
                Console.WriteLine("");
                Console.Write("Entre com a idade: ");
                idade = int.Parse(Console.ReadLine());
                if (idade<0){
                    Console.WriteLine("");
                    Console.WriteLine("Fim da pesquisa!");
                    Console.WriteLine("");
                }
                if (idade>0){
                    itt = itt+idade;
                    i=i+1;
                    do{
                        Console.WriteLine("Opinião sobre o filme:");
                        Console.WriteLine("A - Ótimo");
                        Console.WriteLine("B - Bom");
                        Console.WriteLine("C - Regular");
                        Console.WriteLine("D - Ruim");
                        Console.WriteLine("E - Péssimo");
                        Console.Write("Entre com a opinião: ");
                        op = char.Parse(Console.ReadLine().ToUpper());
                        if (op=='A')
                            a=a+1;
                        if (op=='B')
                            b=b+1;
                        if (op=='C')
                            c=c+1;
                        if (op=='D')
                            d=d+1;
                        if (op=='E')
                            e=e+1;
                        if (op!='A' && op!='B' && op!='C' && op!='D' && op!='E'){
                            Console.WriteLine("Opção inválida!");
                            Console.WriteLine("");
                        }
                    } while(op!='A' && op!='B' && op!='C' && op!='D' && op!='E');
                }
            } while(idade>0);
            //Média de idade
            media = itt/i;
            //Porcentagem de cada opção
            pora = (a*100)/i;
            porb = (b*100)/i;
            porc = (c*100)/i;
            pord = (d*100)/i;
            pore = (e*100)/i;
            Console.WriteLine("");
            Console.WriteLine("Responderam essa pesquisa um total de {0} pessoas.", i);
            Console.WriteLine("");
            Console.WriteLine("A média de idade das pessoas que responderam foi de {0} anos.", media);
            Console.WriteLine("A porcentagem de pessoas que responderam A - ótimo: {0}%.", pora);
            Console.WriteLine("A porcentagem de pessoas que responderam B - bom: {0}%.", porb);
            Console.WriteLine("A porcentagem de pessoas que responderam C - regular: {0}%.", porc);
            Console.WriteLine("A porcentagem de pessoas que responderam D - ruim: {0}%.", pord);
            Console.WriteLine("A porcentagem de pessoas que responderam E - péssimo: {0}%.", pore);
            Console.WriteLine("");
        }
    }
}
