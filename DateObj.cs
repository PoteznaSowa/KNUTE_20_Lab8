using System;

namespace _20_Lab8 {
	class DateObj {
		// Написати клас, який має індексатор, що дозволяє визначити
		// дату i-того по рахунку дня відносно встановленої дати
		// (при негативних значеннях індексу
		// відлік ведеться в зворотному порядку).

		public DateTime this[int i] => Date.AddDays(i);

		public DateTime Date { get; set; }

		public DateObj(DateTime date) => Date = date;
	}
}
