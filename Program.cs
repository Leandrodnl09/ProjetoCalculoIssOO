
using PrejetoBepecor;
using PrejetoBepecor.Entities;

List<Seguradoras> list = new List<Seguradoras>();

Seguradoras bradesco = new Seguradoras(1, "BRADESCO", "51.990.695/0006-41", 0.0, " DO MUNICIPIO");
Seguradoras allianz = new Seguradoras(2, "ALLIANZ", "61.573.796/0116-05", 0.0, " DO MUNICIPIO");
Seguradoras azul = new Seguradoras(3, "AZUL", "33.448.150/0011-93", 0.0, " DE OUTRO MUNICIPIO");
Seguradoras hdi = new Seguradoras(4, "HDI", "29.980.158/0022-81", 0.0, " DO MUNICIPIO");
Seguradoras sompo = new Seguradoras(5, "SOMPO", "61.383.493/0013-14", 0.0, " DO MUNICIPIO");
Seguradoras portoSeguro = new Seguradoras(6, "PORTO SEGURO", "61.198.164/0065-24", 0.0, " DO MUNICIPIO");
Seguradoras sulAmerica = new Seguradoras(7, "SUL AMERICA", "01.685.053/0257-36", 0.0, " DO MUNICIPIO");
Seguradoras liberty = new Seguradoras(8, "LIBERTY", "61.550.141/0024-69", 0.0, " DO MUNICIPIO");
Seguradoras tokioMarine = new Seguradoras(9, "TOKIO MARINE", "33.164.021/0105-98", 0.0, " DO MUNICIPIO");
Seguradoras mapfreVida = new Seguradoras(10, "MAPFRE (VIDA)", "54.484.753/0001-49", 0.0, " DE OUTRO MUNICIPIO");
Seguradoras mapfreGeral = new Seguradoras(11, "MAPFRE (GERAL)", "61.074.175/0075-74", 0.0, " DO MUNICIPIO");

int opcao = 1;
double valor = 0.0;
double valorSemImposto = 0.0;
double imposto = 0.0;
Seguradoras dataAtual = new Seguradoras();
string texto = dataAtual.TextoParaNota();

list.Add(bradesco);
list.Add(allianz);
list.Add(azul);
list.Add(hdi);
list.Add(sompo);
list.Add(portoSeguro);
list.Add(sulAmerica);
list.Add(liberty);
list.Add(tokioMarine);
list.Add(mapfreVida);
list.Add(mapfreGeral);


Console.WriteLine();
Console.WriteLine("      S E J A    B E M    V I N D O    L E A N D R O");
Console.WriteLine();

do
{
    Menu.OpcaoMenu();
    Console.WriteLine();
    Console.Write(" DIGITE A OPÇÃO DESEJADA -->>  ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor do BRADESCO R$ : ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            bradesco.Valor += CalculoIss.Calculo(valor); break;

        case 2:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor do ALLIANZ R$ : ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            allianz.Valor += CalculoIss.Calculo(valor); break;
            
        case 3:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da AZUL R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            azul.Valor += CalculoIss.Calculo(valor); break;

        case 4:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da HDI R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            hdi.Valor += CalculoIss.Calculo(valor); break;

        case 5:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da SOMPO R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            sompo.Valor += CalculoIss.Calculo(valor); break;

        case 6:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da PORTO SEGURO R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            portoSeguro.Valor += CalculoIss.Calculo(valor); break;

        case 7:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da SUL AMÉRICA R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            sulAmerica.Valor += CalculoIss.Calculo(valor); break;

        case 8:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da LIBERTY R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            liberty.Valor = CalculoIss.Calculo(valor); break;

        case 9:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da TÓKIO MARINE R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            tokioMarine.Valor = CalculoIss.Calculo(valor); break;

        case 10:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da MAPFRE (VIDA) R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            mapfreVida.Valor = CalculoIss.Calculo(valor); break;

        case 11:
            Console.Clear();
            Console.WriteLine();
            Console.Write("Digite o valor da MAPFRE (GERAL) R$:  ");
            valor = double.Parse(Console.ReadLine());
            valorSemImposto += valor;
            mapfreGeral.Valor = CalculoIss.Calculo(valor); break;
    }

} while (opcao != 0);

Console.WriteLine();
Console.WriteLine("VALOR TOTAL DE COMISSÕES SEM IMPOSTO: " 
    + valorSemImposto.ToString("C", new System.Globalization.CultureInfo("pt-BR")));

Console.WriteLine();
double total = list.Sum(v => v.Valor);
Console.WriteLine("VALOR TOTAL DE COMISSÕES COM IMPOSTO: " 
    + total.ToString("C", new System.Globalization.CultureInfo("pt-BR")));

Console.WriteLine();
Console.WriteLine("VALOR TOTAL DE IMPOSTO: " 
    + CalculoIss.Imposto(total, valorSemImposto).ToString("C", new System.Globalization.CultureInfo("pt-BR")));

Console.WriteLine();
Console.WriteLine(texto);

Console.WriteLine();
foreach (Seguradoras print in list)
{
    if(print.Valor > 0){
    Console.WriteLine(print);
    }
}

