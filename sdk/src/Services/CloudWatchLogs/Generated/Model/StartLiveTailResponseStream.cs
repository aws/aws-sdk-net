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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
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
using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CloudWatchLogs.Model
{
    /// <summary>
    /// This object includes the stream returned by your <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTail.html">StartLiveTail</a>
    /// request.
    /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "StartLiveTailResponseStreamCollection is not descriptive")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventStream. Users need to be able to call Dispose.")]
    public sealed class StartLiveTailResponseStream : EnumerableEventStream<IEventStreamEvent, CloudWatchLogsEventStreamException>
    {
        /// <summary>
        ///The mapping of event message to a generator function to construct the matching EventStream event
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage, IEventStreamEvent>> EventMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,IEventStreamEvent>>(StringComparer.OrdinalIgnoreCase)
        {
            {"Initial-Response", payload => new InitialResponseEvent(payload)},
            {"SessionStart", payload => new LiveTailSessionStartUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))},
            {"SessionUpdate", payload => new LiveTailSessionUpdateUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))},
        };
        /// <summary>
        /// The mapping of event message to a generator function to construct the matching EventStream Exception
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage,CloudWatchLogsEventStreamException>> ExceptionMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,CloudWatchLogsEventStreamException>>(StringComparer.OrdinalIgnoreCase)
        {
            { "SessionStreamingException", payload => new CloudWatchLogsEventStreamException(Encoding.UTF8.GetString(payload.Payload), new SessionStreamingExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "SessionTimeoutException", payload => new CloudWatchLogsEventStreamException(Encoding.UTF8.GetString(payload.Payload), new SessionTimeoutExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
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

        /// <summary>
        /// Event that encompasses all events.
        /// </summary>
        public override event EventHandler<EventStreamEventReceivedArgs<IEventStreamEvent>> EventReceived;

        /// <summary>
        /// Event that encompasses exceptions.
        /// </summary>
        public override event EventHandler<EventStreamExceptionReceivedArgs<CloudWatchLogsEventStreamException>> ExceptionReceived;
        /// <summary>
        /// Event for the initial response.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<InitialResponseEvent>> InitialResponseReceived;
        ///<summary>
        ///Raised when an SessionStart event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<LiveTailSessionStart>> SessionStartReceived;
        ///<summary>
        ///Raised when an SessionUpdate event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<LiveTailSessionUpdate>> SessionUpdateReceived;

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name="stream"></param>        
        public StartLiveTailResponseStream(Stream stream) : this (stream, null)
        {
        }

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="eventStreamDecoder"></param>
        public StartLiveTailResponseStream(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)
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

                //Call RaiseEvent until it returns true or all calls complete. This way only a subset of casts are perfromed
                // and we can avoid a cascade of nested if else statements. The result is thrown away
                var _ =
                    RaiseEvent(InitialResponseReceived, ev) ||
                    RaiseEvent(SessionStartReceived,ev) ||
                    RaiseEvent(SessionUpdateReceived,ev);
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