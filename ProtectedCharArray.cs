namespace _20_Lab8 {
	class ProtectedCharArray : ProtectedArray {
		// На основі базового класу створюється похідний клас,
		// у якого з'являється захищений символьний масив.
		protected char[] chararray;

		// Опишіть в похідному класі версію індексатора з символьним індексом,
		// який повертає значення елемента символьного масиву
		// і дозволяє присвоїти значення елементу символьного масиву.
		public char this[char index] {
			get => chararray[index];
			set => chararray[index] = value;
		}

		// Для властивості з базового класу необхідно виконати заміщення так,
		// щоб результатом повертався цілочисельний масив з двох елементів:
		// перший елемент визначає розмір цілочисленного масиву об'єкта,
		// а другий елемент визначає розмір символьного масиву об'єкта.
		public new int[] Length => new[] {
			array.Length,
			chararray.Length
		};

		public ProtectedCharArray(int[] array, char[] chararray)
			: base(array) => this.chararray = chararray;
	}
}
