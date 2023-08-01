using System;

namespace _20_Lab8 {
	class DateObj {
		public DateTime this[int i] => Date.AddDays(i);

		public DateTime Date { get; set; }

		public DateObj(DateTime date) => Date = date;
	}
}
