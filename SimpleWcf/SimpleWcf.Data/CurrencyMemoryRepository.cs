using System.Collections.Generic;
using System.Linq;
using SimpleWcf.Core.DataClasses;
using SimpleWcf.Core.Interfaces;

namespace SimpleWcf.Data
{
	public class CurrencyMemoryRepository : ICurrencyRepository
	{
		#region Currencies

		private readonly List<Currency> _currencies = new List<Currency>(3)
		{
			new Currency
			{
				CurrencyCode = "RUB",
				CurrencyName = "Российский рубль"
			},
			new Currency
			{
				CurrencyCode = "EUR",
				CurrencyName = "Евро"
			},
			new Currency
			{
				CurrencyCode = "USD",
				CurrencyName = "Доллар США"
			},
			new Currency
			{
				CurrencyCode = "BYN",
				CurrencyName = "Белорусский рубль"
			}
		};

		#endregion

		#region Cources

		private readonly List<Cource> _cources = new List<Cource>
		{
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				Value = 1.0000m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				Value = 0.0169m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				Value = 0.0159m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				Value = 0.0323m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				CurrencyTo = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				Value = 1.0000m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				CurrencyTo = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				Value = 1.06165m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				CurrencyTo = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				Value = 62.7408m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				CurrencyTo = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				Value = 2.0247m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				CurrencyTo = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				Value = 1.0000m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				CurrencyTo = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				Value = 59.2174m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				CurrencyTo = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				Value = 0.9438m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				CurrencyTo = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				Value = 1.9110m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				Value = 1.0000m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "RUB", CurrencyName = "Российский рубль"},
				Value = 30.9877m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "EUR", CurrencyName = "Евро"},
				Value = 0.4939m
			},
			new Cource
			{
				CurrencyFrom = new Currency {CurrencyCode = "BYN", CurrencyName = "Белорусский рубль"},
				CurrencyTo = new Currency {CurrencyCode = "USD", CurrencyName = "Доллар США"},
				Value = 0.5233m
			}
		};

		#endregion

		public List<Currency> GetCurrencies()
		{
			return _currencies;
		}

		public Currency GetCurrencyByCode(string currencyCode)
		{
			return _currencies.FirstOrDefault(c => c.CurrencyCode.Equals(currencyCode));
		}

		public decimal? GetCourse(string currencyCodeFrom, string currencyCodeTo)
		{
			Cource course =
				_cources.FirstOrDefault(
					c => c.CurrencyFrom.CurrencyCode.Equals(currencyCodeFrom)
					&& c.CurrencyTo.CurrencyCode.Equals(currencyCodeTo));
			if (ReferenceEquals(course,null))
				return null;
			return course.Value;
		}
	}
}
