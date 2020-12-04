namespace _20_Lab8 {
	class ProtectedArray {
		// Напишіть програму, в якій є базовий клас
		// із захищеним int масивом,
		protected int[] array;

		// індексатором (з int індексом),
		// що дозволяє зчитувати та присвоювати значення елементів масиву,
		public int this[int index] {
			get => array[index];
			set => array[index] = value;
		}

		// а також властивість, яка повертає у вигляді результату розмір масиву.
		public int Length => array.Length;

		public ProtectedArray(int[] array) => this.array = array;
	}
}
