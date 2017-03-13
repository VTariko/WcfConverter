using System.Collections.Generic;
using System.ServiceModel;

namespace SimpleWcf.Contracts
{
	[ServiceContract]
	public interface ICurrencyConverterService
	{
		[OperationContract]
		List<CurrencyData> GetCurrenciesList();

		[OperationContract]
		ConverterValueData ConvertValue(string currencyCodeFrom, string currencyCodeTo, decimal value);
	}
}
