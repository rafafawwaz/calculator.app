class Calculator
{
	static void Main(string[] args)
	{
			int a = 10;
			int b = 6;
			
			Console.WriteLine("Hasil Penjumlahan: {0} + {1} = {2}", a, b, Penjumlahan(a, b));
			Console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
			
			Console.WriteLine("\nPress Twice to Exit");
			Console.ReadKey();	
	}
	
	static int Penjumlahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
	
}