using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace WebApplication.Rest
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TutorialService
    {
        // To use HTTP GET, add [WebGet] attribute. (Default ResponseFormat is WebMessageFormat.Json)
        // To create an operation that returns XML,
        //     add [WebGet(ResponseFormat=WebMessageFormat.Xml)],
        //     and include the following line in the operation body:
        //         WebOperationContext.Current.OutgoingResponse.ContentType = "text/xml";
        [OperationContract]
        public void DoWork()
        {
            // Add your operation implementation here
            return;
        }
        private static List<string> lst = new List<string>
         { "Arrays", "Queues", "Stacks" };

        [WebGet(UriTemplate = "/Tutorial")]

        public string GetAllTutorial()
        {
            int count = lst.Count;
            string TutorialList = "";
            for (int i = 0; i < count; i++)
                TutorialList = TutorialList + lst[i] + ",";
            return TutorialList;
        }

        [WebGet(UriTemplate = "/Tutorial/{Tutorialid}")]

        public string GetTutorialbyID(string Tutorialid)
        {
            int.TryParse(Tutorialid, out int pid);
            return lst[pid];
        }

        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json,
    UriTemplate = "/Tutorial", ResponseFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Wrapped)]

        public void AddTutorial(string str)
        {
            lst.Add(str);
        }
        [WebInvoke(Method = "DELETE", RequestFormat = WebMessageFormat.Json,
    UriTemplate = "/Tutorial/{Tutorialid}", ResponseFormat = WebMessageFormat.Json,
    BodyStyle = WebMessageBodyStyle.Wrapped)]

        public void DeleteTutorial(String Tutorialid)
        {
            int pid;
            int.TryParse(Tutorialid, out pid);
            lst.RemoveAt(pid);
        }
        // Add more operations here and mark them with [OperationContract]
    }
}
