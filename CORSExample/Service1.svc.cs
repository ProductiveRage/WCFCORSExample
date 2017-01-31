using System;
using System.ServiceModel.Activation;

namespace CORSExample
{
	public class Service1 : IService1
	{
		public ServiceResponse GetData(string value)
		{
			return new ServiceResponse
			{
				ReceivedAt = DateTime.Now,
				Value = string.Format("You entered: {0}", value)
			};
		}
	}
}