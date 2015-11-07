using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WelcomeRESTJSONService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WelcomeRESTJSONService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WelcomeRESTJSONService.svc o WelcomeRESTJSONService.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WelcomeRESTJSONService : IWelcomeRESTJSONService
    {
        public TextMessage Welcome(string yourName)
        {
            TextMessage message = new TextMessage();
            message.Message = string.Format("WelcomeServices With REST and JSON,{0}!", yourName);
            return message;
        }
    }
}
