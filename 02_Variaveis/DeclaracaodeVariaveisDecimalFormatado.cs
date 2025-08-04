using System;
class DeclaracaoVariaveisDecimalFormatado
{ 
	static void main(string[] args) 
	{
		decimal x = 0.99m;
		decimal y = 9999999999999999999999999999m;
		Console.WriteLine("Minha quantia = [0:c}",x};
		Console.WriteLine("Sua quantia = {0:c}", y};
		}
}		