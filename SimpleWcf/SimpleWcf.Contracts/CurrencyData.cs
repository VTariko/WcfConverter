using System.Runtime.Serialization;

namespace SimpleWcf.Contracts
{
	[DataContract]
	public class CurrencyData
	{
		[DataMember]
		public string CurrencyCode { get; set; }

		[DataMember]
		public string CurrencyName { get; set; }
	}
}
