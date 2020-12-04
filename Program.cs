using System;

namespace _20_Lab8 {
	class Program {
		static void Main() {
			Console.OutputEncoding = System.Text.Encoding.UTF8;
			Console.Title = "20_Lab8";

			// Використання випадкових чисел прискорює перевірку лабораторної роботи.
			Console.WriteLine("Для перевірки класів використовуватимемо довільні цілі числа.");
			Console.WriteLine();
			Random random = new Random();

			Console.WriteLine("Перевіряємо клас BiIndex...");
			BiIndex<int> biIndex = new BiIndex<int>(random.Next(), random.Next());
			try {
				// Для наглядності запустимо цикл з 9999 ітераціями, але не всі ітерації запрацюють.
				for (int j = 0; j < 9999; j++) {
					Console.Write($"biIndex[{j}] = ");
					int a = biIndex[j];
					Console.WriteLine(a);
				}
			} catch (Exception e) {
				// Під час ітерації N виникне виняток, треба показати дані про нього.
				Console.WriteLine(e);
			}
			Console.WriteLine();

			Console.WriteLine("Перевіряємо клас DateObj...");
			DateTime currentdate = DateTime.Now;  // Нехай це буде поточна дата.
			DateObj dateObj = new DateObj(currentdate);
			int i = random.Next(-99_999, 100_000);
			Console.WriteLine($"Зараз {currentdate:D}, i = {i}. i-тий день відносно цієї дати: {dateObj[i]:D}");
			Console.WriteLine();

			Console.WriteLine("А на цьому все! ProtectedArray та ProtectedCharArray у цій програмі не будуть розглядатися, бо їхній принцип роботи здається досить зрозумілим.");
			Console.WriteLine("Натисніть будь-яку клавішу, щоб продовжити...");

			while (Console.KeyAvailable) {
				Console.ReadKey(true);
			}
			Console.ReadKey(true);
		}
	}
}
