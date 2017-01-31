using System;
using System.Runtime.Serialization;

namespace CORSExample
{
	[DataContract]
	public class ServiceResponse
	{
		[DataMember]
		public DateTime ReceivedAt { get; set; }

		[DataMember]
		public string Value { get; set; }
	}
}