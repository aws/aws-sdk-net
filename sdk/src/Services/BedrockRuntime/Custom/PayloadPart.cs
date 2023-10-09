using Amazon.Runtime.EventStreams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ThirdParty.Json.LitJson;

namespace Amazon.BedrockRuntime.Model
{
    public partial class PayloadPart
    {
        partial void Deserialize(IEventStreamMessage message)
        {
            if (message.Payload == null)
                return;

            if (message.Payload.Length == 0)
            {
                this.Bytes = new MemoryStream();
                return;
            }

            var jsonObj = JsonMapper.ToObject(Encoding.UTF8.GetString(message.Payload));
            var base64 = (string)jsonObj["bytes"];
            var bytes = Convert.FromBase64String(base64);
            this.Bytes = new MemoryStream(bytes);
        }
    }
}
