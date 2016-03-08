using System;
using Amazon.Runtime;
using Amazon.Util;
using ThirdParty.Json.LitJson;
using System.IO;
using Amazon.MobileAnalytics.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using System.Net;
using System.Globalization;

namespace Amazon.MobileAnalytics.Model
{
    public partial class Event
    {

        private class DummyResponse : IWebResponseData
        {
            long IWebResponseData.ContentLength { get { return 0; } }
            string IWebResponseData.ContentType { get { return ""; } }
            HttpStatusCode IWebResponseData.StatusCode { get { return HttpStatusCode.OK; } }
            bool IWebResponseData.IsSuccessStatusCode { get { return false; } }
            IHttpResponseBody IWebResponseData.ResponseBody { get { return null; } }
            bool IWebResponseData.IsHeaderPresent(string headerName)
            {
                return false;
            }
            string IWebResponseData.GetHeaderValue(string headerName)
            {
                return null;
            }
            string[] IWebResponseData.GetHeaderNames()
            {
                return new string[0];
            }
        }


        /// <summary>
        /// Creates a Json string from the Event. Expects Event and Session Timestamps to be in UTC.
        /// </summary>
        public string MarshallToJson()
        {
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                EventMarshaller.Instance.Marshall(this, new Runtime.Internal.Transform.JsonMarshallerContext(null, writer));
                writer.WriteObjectEnd();
                return stringWriter.ToString();
            }
        }

        /// <summary>
        /// Creates an Event object from Json.
        /// </summary>
        /// <param name="eventValue">
        /// The Json string representing the Event.
        /// </param>
        public static Event UnmarshallFromJson(String eventValue)
        {
            using (MemoryStream responseStream = new MemoryStream())
            {
                using (StreamWriter writer = new StreamWriter(responseStream))
                {
                    writer.Write(eventValue);
                    writer.Flush();
                    responseStream.Position = 0;
                    return EventUnmarshaller.Instance.Unmarshall(new Runtime.Internal.Transform.JsonUnmarshallerContext(responseStream, false, new DummyResponse()));
                }
            }
        }
    }
}
