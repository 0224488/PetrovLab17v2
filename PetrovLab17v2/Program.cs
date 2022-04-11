using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrovLab17
{
	// Создать класс для моделирования счета в банке. 
	// Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.
	// Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета.
	// Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения.
	// Создать  несколько экземпляров класса, параметризированного различными типам.
	// Заполнить его поля и вывести информацию об экземпляре класса на печать.
	class Program
	{
		// Я правильно понял, что "вывести на печать" нужно понимать в контексте "вывести на экран"?
		// Может я что-то пропустил, но вроде мы ещё не проходили как выводить на принтер...
		// или это задача для самостоятельного изучения?
		static void Main(string[] args)
		{
			var account1 = new Account<int>(); //Создаем счет с целочисленным номером счета
			Console.WriteLine("Введите номер счета (целое число):");
			account1.SetNumber(int.Parse(Console.ReadLine()));
			Console.WriteLine("Введите ФИО владельца:");
			account1.SetOwner(Console.ReadLine());
			Console.WriteLine("Введите баланс счета:");
			account1.SetBalance(double.Parse(Console.ReadLine()));
			Console.WriteLine($" Параметры счета 1:\n Номер счета={account1.GetNumber()}\n Баланс={account1.GetBalance()}\n ФИО владельца={account1.GetOwner()}");
			Console.WriteLine("\n Для продолжения нажмите любую клавишу");
			Console.ReadKey();
			
			var account2 = new Account<string>(); //Создаем счет с текстовым номером счета
			Console.WriteLine("Введите номер счета (текстовая строка):"); //Заполняем поля. Вариант с текстовой строкой 
			account2.SetNumber(Console.ReadLine());
			Console.WriteLine("Введите ФИО владельца:");
			account2.SetOwner(Console.ReadLine());
			Console.WriteLine("Введите баланс счета:");
			account2.SetBalance(double.Parse(Console.ReadLine()));
			Console.WriteLine($"Параметры счета 2:\n Номер счета={account2.GetNumber()}\n Баланс={account2.GetBalance()}\n ФИО владельца={account2.GetOwner()}");
			Console.ReadKey();
		}

		public class Account<T>
		{
			private T _number; // номер счета
			private double _balance; // баланс
			private string _owner; // ФИО владельца

			// Методы чтения данных
			public double GetBalance()
			{
				return _balance;
			}

			public T GetNumber()
			{
				return _number;
			}

			public string GetOwner()
			{
				return _owner;
			}

			// Методы заполнения данных
			public void SetBalance(double balance)
			{
				_balance = balance;
			}

			public void SetNumber(T number)
			{
				_number = number;
			}

			public void SetOwner(string owner)
			{
				_owner = owner;
			}
		}
	}
}
