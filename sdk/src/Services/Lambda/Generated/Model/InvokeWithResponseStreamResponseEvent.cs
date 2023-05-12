/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the lambda-2015-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;

namespace Amazon.Lambda.Model
{
    /// <summary>
    /// An object that includes a chunk of the response payload. When the stream has ended,
    /// Lambda includes a <code>InvokeComplete</code> object.
    /// </summary>

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "InvokeWithResponseStreamResponseEventCollection is not descriptive")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventStream. Users need to be able to call Dispose.")]
    public sealed class InvokeWithResponseStreamResponseEvent : EnumerableEventStream<IEventStreamEvent, LambdaEventStreamException>
    {
        ///summary>
        ///The mapping of event message to a generator function to construct the matching EventStream event
        ///</summary>
        protected override IDictionary<string,Func<IEventStreamMessage, IEventStreamEvent>> EventMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,IEventStreamEvent>>
        {
            {"InvokeComplete", payload => new InvokeWithResponseStreamCompleteEvent(payload)},
            {"PayloadChunk", payload => new InvokeResponseStreamUpdate(payload)},
        };
        /// <summary>
        /// The mapping of event message to a generator function to construct the matching EventStream Exception
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage,LambdaEventStreamException>> ExceptionMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,LambdaEventStreamException>>
        {
        };
        // Backing by a volatile bool. The flag only changes one way, so no need for a lock.
        // This is located in the subclass to be CLS compliant.
        private volatile bool _isProcessing;

        /// <summary>
        /// Whether the backround processing loop is running.
        /// </summary>
        protected override bool IsProcessing
        {
            get { return _isProcessing; }
            set { _isProcessing = value; }
        }
        public override event EventHandler<EventStreamEventReceivedArgs<IEventStreamEvent>> EventReceived;
        public override event EventHandler<EventStreamExceptionReceivedArgs<LambdaEventStreamException>> ExceptionReceived;
        ///<summary>
        ///Raised when an InvokeComplete event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<InvokeWithResponseStreamCompleteEvent>> InvokeCompleteReceived;
        ///<summary>
        ///Raised when an PayloadChunk event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<InvokeResponseStreamUpdate>> PayloadChunkReceived;
        public InvokeWithResponseStreamResponseEvent(Stream stream) : this (stream, null)
        {
        }
        public InvokeWithResponseStreamResponseEvent(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)
        {
            base.EventReceived += (sender,args) => EventReceived?.Invoke(this, args);
            base.ExceptionReceived += (sender,args) => ExceptionReceived?.Invoke(this, args);

            //Mapping the generic Event to more specific Events
            Decoder.MessageReceived += (sender, args) =>
            {
                IEventStreamEvent ev;
                try
                {
                    ev = ConvertMessageToEvent(args.Message);
                }
                catch(UnknownEventStreamException)
                {
                    throw new UnknownEventStreamException("Received an unknown event stream type");
                }
                EventReceived?.Invoke(this, new EventStreamEventReceivedArgs<IEventStreamEvent>(ev));

                //Call RaiseEvent until it returns true or all calls complete. This way only a subset of casts is perfromed
                // and we can avoid a cascade of nested if else statements. The result is thrown away
                var _ =
                    RaiseEvent(InvokeCompleteReceived,ev) ||
                    RaiseEvent(PayloadChunkReceived,ev);
            };       
        }
        private bool RaiseEvent<T>(EventHandler<EventStreamEventReceivedArgs<T>> eventHandler, IEventStreamEvent ev) where T : class, IEventStreamEvent
        {
            var convertedEvent = ev as T;
            if (convertedEvent != null)
            {
                eventHandler?.Invoke(this, new EventStreamEventReceivedArgs<T>(convertedEvent));
                return true;
            }

            return false;
        }

    }
}