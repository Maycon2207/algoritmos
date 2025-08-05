using System;
class CalculoIMC
{	
	static void	Main()
	{
		Double peso,altura,imc;
		Console.WriteLine("digite seu peso (KG):");
		// Console.readLine() é equivale ao leia do Portugol
		peso = Double.Parse (Console.ReadLine() );
		
		Console.Write("digite sua altura (M) :");
		altura = Double.Parse (Console.ReadLine() );
	
		imc = peso / (altura * altura );
	Console.WriteLine ("seu IMC é {0:F3}", imc);
	
	if(imc < 18.5 )
	{
		Console.WriteLine("Classificação: abaixo do peso ");
	}else if (imc < 25)
	{
		Console.WriteLine("Classificação: peso normal");
	}else 
	{	Console.WriteLine("Classificação: acima do peso");

	}
	
	}
	
}	