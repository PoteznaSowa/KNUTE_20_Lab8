using System;

namespace _20_Lab8 {
	class BiIndex<T> {
		// Написати клас, який має індексатор, що дозволяє
		// за індексом 0 звертатися до поля x,
		// за індексом 1 - до поля y,
		// при інших значеннях індексу видається повідомлення про помилку.

		readonly T x;
		readonly T y;

		public BiIndex(T x, T y) {
			this.x = x;
			this.y = y;
		}

		public T this[int index] => index switch {
			0 => x,
			1 => y,
			_ => throw new IndexOutOfRangeException($"Індекс може бути тільки 0 або 1, але не {index}!")
		};
	}
}
