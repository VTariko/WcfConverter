using System;
using System.Collections.Generic;
using System.Linq;
using SimpleWcf.Contracts;
using SimpleWcf.Core.DataClasses;
using SimpleWcf.Data;

namespace SimpleWcf.Services
{
	public class CurrencyConverterManager : ICurrencyConverterService
	{
		private readonly CurrencyBusinessLogic _currencyBusinessLogic = new CurrencyBusinessLogic();

		public List<CurrencyData> GetCurrenciesList()
		{
			List<Currency> currenciesList = _currencyBusinessLogic.GetCurrencies();
			return currenciesList.Select(currency => new CurrencyData()
			{
				CurrencyCode = currency.CurrencyCode,
				CurrencyName = currency.CurrencyName
			}).ToList();
		}

		public ConverterValueData ConvertValue(string currencyCodeFrom, string currencyCodeTo, decimal value)
		{
			decimal? cource = _currencyBusinessLogic.GetCource(currencyCodeFrom, currencyCodeTo);
			if (!cource.HasValue)
			{
				throw new InvalidOperationException("Курс отсутствует!");
			}
			decimal res = _currencyBusinessLogic.GetResult(cource.Value, value);
			return new ConverterValueData() {ConvertCource = cource.Value, ConvertResult = res};
		}
	}
}
