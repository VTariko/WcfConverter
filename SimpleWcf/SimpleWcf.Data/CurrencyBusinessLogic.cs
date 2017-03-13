using System.Collections.Generic;
using SimpleWcf.Core.DataClasses;
using SimpleWcf.Core.Interfaces;

namespace SimpleWcf.Data
{
	public class CurrencyBusinessLogic
	{
		private ICurrencyRepository _currencyRepository;

		public CurrencyBusinessLogic()
		{
			_currencyRepository = new CurrencyMemoryRepository();
		}

		public List<Currency> GetCurrencies()
		{
			return _currencyRepository.GetCurrencies();
		}

		public decimal? GetCource(string currencyCodeFrom, string currencyCodeTo)
		{
			return _currencyRepository.GetCourse(currencyCodeFrom, currencyCodeTo);
		}

		public decimal GetResult(decimal cource, decimal value)
		{
			return value*cource;
		}
	}
}
