using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WelcomeRESTJSONService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IWelcomeRESTJSONService" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IWelcomeRESTJSONService
    {

        [OperationContract]
        [WebGet (ResponseFormat = WebMessageFormat.Json, UriTemplate = "/welcome/{yourName}")]
        TextMessage Welcome(string yourName);
    }

    [DataContract]
    public class TextMessage
    {
        [DataMember]
        public string Message { get; set; }
    }
}
