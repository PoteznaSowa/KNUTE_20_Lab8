using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_Lab8 {
	class BiIndex<T> {  // Читається "бі-індекс".
		readonly T x;
		readonly T y;

		public BiIndex(T x, T y) {
			this.x = x;
			this.y = y;
		}

		public T this[int index] => index switch {
			0 => x,
			1 => y,
			_ => throw new IndexOutOfRangeException($"Індекс може бути тільки 0 або 1, але не {index}!"),
		};
	}
}
