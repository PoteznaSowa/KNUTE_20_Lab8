using System;

namespace _20_Lab8 {
	class BiIndex<T> {
		T x;
		T y;

		public T this[int index] {
			get => index switch {
				0 => x,
				1 => y,
				_ => throw new IndexOutOfRangeException($"Індекс може бути тільки 0 або 1, але не {index}!")
			};
			set {
				switch (index) {
				case 0:
					x = value;
					return;
				case 1:
					y = value;
					return;
				default:
					throw new IndexOutOfRangeException($"Індекс може бути тільки 0 або 1, але не {index}!");
				}
			}
		}
	}
}
