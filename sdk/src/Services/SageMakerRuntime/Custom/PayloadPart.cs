using Amazon.Runtime.EventStreams.Internal;
using Amazon.Runtime.EventStreams;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Amazon.SageMakerRuntime.Model
{
    public partial class PayloadPart : IEventStreamEvent
    {
        /// <summary>
        /// Construct an instance of PayloadPart
        /// </summary>
        [Obsolete("The parameterless constructor for PayloadPart has been deprecated and is no longer used in the SDK.")]
        public PayloadPart()
        {
        }

        /// <summary>
        /// Construct an instance of PayloadPart
        /// </summary>
        /// <param name="message"></param>
        [Obsolete("The version of PayloadPart that acceps IEventStream message is no longer used in the SDK.")]
        public PayloadPart(IEventStreamMessage message)
        {
            Bytes = new MemoryStream(message.Payload);
        }

        partial void Deserialize(IEventStreamMessage message);
    }
}
