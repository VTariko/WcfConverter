using System.Collections.Generic;
using System.ServiceModel;
using SimpleWcf.Contracts;

namespace SimpleWcf.Proxies
{
	public class CurrencyConvertClient: ClientBase<ICurrencyConverterService>, ICurrencyConverterService
	{
		public List<CurrencyData> GetCurrenciesList()
		{
			return Channel.GetCurrenciesList();
		}

		public ConverterValueData ConvertValue(string currencyCodeFrom, string currencyCodeTo, decimal value)
		{
			return Channel.ConvertValue(currencyCodeFrom, currencyCodeTo, value);
		}
	}
}
