using System.Collections.Generic;
using SimpleWcf.Core.DataClasses;

namespace SimpleWcf.Core.Interfaces
{
	public interface ICurrencyRepository
	{
		/// <summary>
		/// Список валют
		/// </summary>
		/// <returns></returns>
		List<Currency> GetCurrencies();
		
		/// <summary>
		/// Получить валюту по коду
		/// </summary>
		/// <param name="currencyCode">Код валюты</param>
		/// <returns></returns>
		Currency GetCurrencyByCode(string currencyCode);
		
		/// <summary>
		/// Получить обменный курс
		/// </summary>
		/// <param name="currencyCodeFrom">Из какой валюты</param>
		/// <param name="currencyCodeTo">В какую валюту</param>
		/// <returns>Значение, если все верно, иначе null</returns>
		decimal? GetCourse(string currencyCodeFrom, string currencyCodeTo);
	}
}
