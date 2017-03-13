using System.Runtime.Serialization;

namespace SimpleWcf.Contracts
{
	[DataContract]
	public class ConverterValueData
	{
		[DataMember]
		public decimal ConvertResult { get; set; }

		[DataMember]
		public decimal ConvertCource { get; set; }
	}
}
