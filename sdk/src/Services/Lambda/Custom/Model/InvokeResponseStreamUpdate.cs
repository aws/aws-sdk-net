using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Amazon.Lambda.Model
{

    public partial class InvokeResponseStreamUpdate : IEventStreamEvent
    {
        /// <summary>
        /// Construct an instance of InvokeResponseStreamUpdate
        /// </summary>
        [Obsolete("The parameterless constructor for InvokeResponseStreamUpdate has been deprecated and is no longer used in the SDK.")]
        public InvokeResponseStreamUpdate()
        {
        }

        /// <summary>
        /// Construct an instance of InvokeResponseStreamUpdate
        /// </summary>
        /// <param name="message"></param>
        [Obsolete("The version of InvokeResponseStreamUpdate that accepts an IEventStreamMessage is no longer used in the SDK.")]
        public InvokeResponseStreamUpdate(IEventStreamMessage message)
        {
            Payload = new MemoryStream(message.Payload);
        }
        partial void Deserialize(IEventStreamMessage message);
    }
}
