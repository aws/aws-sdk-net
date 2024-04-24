using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Amazon.Lambda.Model
{
    
    public partial class InvokeWithResponseStreamCompleteEvent: IEventStreamEvent
    {
        /// <summary>
        /// Construct an instance of InvokeWithResponseStreamCompleteEvent
        /// </summary>
        [Obsolete("The empty constructor for InvokeWithResponseStreamCompleteEvent has been deprecated and is no longer used in the SDK")]
        public InvokeWithResponseStreamCompleteEvent()
        {
        }

        /// <summary>
        /// Construct an instance of InvokeWithResponseStreamCompleteEvent
        /// </summary>
        /// <param name="message"></param>
        [Obsolete("The constructor for InvokeWithResponseStreamCompleteEvent that takes in IEventStreamMessage is deprecated and no longer used throughout the SDK ")]
        public InvokeWithResponseStreamCompleteEvent(IEventStreamMessage message)
        {
            Deserialize(message);
        }
        partial void Deserialize(IEventStreamMessage message);
    }
}