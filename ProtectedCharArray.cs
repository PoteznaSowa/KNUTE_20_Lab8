namespace _20_Lab8 {
	class ProtectedCharArray : ProtectedArray {
		protected char[] chararray;

		public char this[char index] {
			get => chararray[index];
			set => chararray[index] = value;
		}

		public new int[] Length => new[] {
			array.Length,
			chararray.Length
		};

		public ProtectedCharArray(int[] array, char[] chararray)
			: base(array) => this.chararray = chararray;
	}
}
