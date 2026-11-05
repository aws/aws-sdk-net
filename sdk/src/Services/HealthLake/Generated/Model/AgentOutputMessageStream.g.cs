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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;
using Amazon.HealthLake.Model.Internal.MarshallTransformations;
using RuntimeEvent = Amazon.Runtime.EventStreams.IEventStreamEvent;
using EventFactory = System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.Runtime.EventStreams.IEventStreamEvent>;
using ExceptionFactory = System.Func<Amazon.Runtime.EventStreams.IEventStreamMessage, Amazon.HealthLake.HealthLakeEventStreamException>;
#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Represents the response stream type from the agent during chat-based profile customization.
    /// </summary>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "AgentOutputMessageStreamCollection is not descriptive")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventOutputStream. Users need to be able to call Dispose.")]
    public sealed class AgentOutputMessageStream : EnumerableEventOutputStream<RuntimeEvent, HealthLakeEventStreamException>
    {
        /// <summary>
        /// The mapping of event message to a generator function to construct the matching EventStream event.
        /// </summary>
        protected override IDictionary<string, EventFactory> EventMapping { get; } = new Dictionary<string, EventFactory>(StringComparer.OrdinalIgnoreCase)
        {
            {
                "Initial-Response", payload => new InitialResponseEvent(payload)
            },
            {
                "EndOfOutputEvent", payload =>
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    return new EndOfOutputEventUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {
                "ErrorEvent", payload =>
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    return new ErrorEventUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {
                "HeartbeatEvent", payload =>
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    return new HeartbeatEventUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {
                "ProgressEvent", payload =>
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    return new ProgressEventUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {
                "TextMessageEvent", payload =>
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream, AWSConfigs.StreamingUtf8JsonReaderBufferSize ?? 4096, context.JsonMaxDepth);
                    return new TextMessageEventUnmarshaller().Unmarshall(context, ref reader);
                }
            },
        };

        /// <summary>
        /// The mapping of event message to a generator function to construct the matching EventStream Exception
        /// </summary>
        protected override IDictionary<string, ExceptionFactory> ExceptionMapping { get; } = new Dictionary<string, ExceptionFactory>(StringComparer.OrdinalIgnoreCase)
        {
        };

        // Backing by a volatile bool. The flag only changes one way, so no need for a lock.
        // This is located in the subclass to be CLS compliant.
        private volatile bool _isProcessing;

        /// <summary>
        /// Whether the background processing loop is running.
        /// </summary>
        protected override bool IsProcessing
        {
            get { return _isProcessing; }
            set { _isProcessing = value; }
        }

        /// <summary>
        /// Event that encompasses all events.
        /// </summary>
        public override event EventHandler<EventStreamEventReceivedArgs<RuntimeEvent>> EventReceived;

        /// <summary>
        /// Event that encompasses exceptions.
        /// </summary>
        public override event EventHandler<EventStreamExceptionReceivedArgs<HealthLakeEventStreamException>> ExceptionReceived;

        /// <summary>
        /// Event for the initial response.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<InitialResponseEvent>> InitialResponseReceived;

        ///<summary>
        ///Raised when an EndOfOutputEvent event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<EndOfOutputEvent>> EndOfOutputEventReceived;

        ///<summary>
        ///Raised when an ErrorEvent event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<ErrorEvent>> ErrorEventReceived;

        ///<summary>
        ///Raised when an HeartbeatEvent event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<HeartbeatEvent>> HeartbeatEventReceived;

        ///<summary>
        ///Raised when an ProgressEvent event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<ProgressEvent>> ProgressEventReceived;

        ///<summary>
        ///Raised when an TextMessageEvent event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<TextMessageEvent>> TextMessageEventReceived;

        /// <summary>
        /// Construct an instance
        /// </summary>
        public AgentOutputMessageStream(Stream stream) : this(stream, null)
        {
        }

        /// <summary>
        /// Construct an instance
        /// </summary>
        public AgentOutputMessageStream(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)
        {
            base.EventReceived += (sender, args) => EventReceived?.Invoke(this, args);
            base.ExceptionReceived += (sender, args) => ExceptionReceived?.Invoke(this, args);

            //Mapping the generic Event to more specific Events
            Decoder.MessageReceived += (sender, args) =>
            {
                RuntimeEvent ev;
                try
                {
                    ev = ConvertMessageToEvent(args.Message);
                }
                catch (UnknownEventStreamException)
                {
                    throw new UnknownEventStreamException("Received an unknown event stream type");
                }
                EventReceived?.Invoke(this, new EventStreamEventReceivedArgs<RuntimeEvent>(ev));

                // Call RaiseEvent until it returns true or all calls complete. This way only a subset of casts are performed
                // and we can avoid a cascade of nested if else statements. The result is thrown away
                var _ =
                RaiseEvent(InitialResponseReceived, ev) ||
                RaiseEvent(EndOfOutputEventReceived, ev) ||
                RaiseEvent(ErrorEventReceived, ev) ||
                RaiseEvent(HeartbeatEventReceived, ev) ||
                RaiseEvent(ProgressEventReceived, ev) ||
                RaiseEvent(TextMessageEventReceived, ev);
            };
        }

        private bool RaiseEvent<T>(EventHandler<EventStreamEventReceivedArgs<T>> eventHandler, RuntimeEvent ev) where T : class, RuntimeEvent
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
