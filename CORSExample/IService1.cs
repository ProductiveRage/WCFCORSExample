using System.ServiceModel;
using System.ServiceModel.Web;

namespace CORSExample
{
	[ServiceContract]
	public interface IService1
	{
		[WebGet(UriTemplate = "GetData/{value}", ResponseFormat = WebMessageFormat.Json)]
		[OperationContract]
		ServiceResponse GetData(string value);
	}
}