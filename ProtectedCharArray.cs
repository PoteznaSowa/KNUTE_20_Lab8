using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Lab8 {
	class ProtectedCharArray : ProtectedArray {
		readonly char[] chararray;

		public new char this[int index] {
			get => chararray[index];
			set => chararray[index] = value;
		}

		public new int[] Length => new[] { array.Length, chararray.Length };

		public ProtectedCharArray(int[] array, char[] chararray) : base(array) {
			this.chararray = chararray;
		}
	}
}
