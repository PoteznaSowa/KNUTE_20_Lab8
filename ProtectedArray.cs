namespace _20_Lab8 {
	class ProtectedArray {
		protected int[] array;

		public int this[int index] {
			get => array[index];
			set => array[index] = value;
		}

		public int Length => array.Length;

		public ProtectedArray(int[] array) => this.array = array;
	}
}
