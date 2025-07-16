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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
using Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Contains output from a code interpreter stream.
    /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "CodeInterpreterStreamOutputCollection is not descriptive")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventStream. Users need to be able to call Dispose.")]
    public sealed class CodeInterpreterStreamOutput : EnumerableEventStream<IEventStreamEvent, BedrockAgentCoreEventStreamException>
    {
        /// <summary>
        ///The mapping of event message to a generator function to construct the matching EventStream event
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage, IEventStreamEvent>> EventMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,IEventStreamEvent>>(StringComparer.OrdinalIgnoreCase)
        {
            {"Initial-Response", payload => new InitialResponseEvent(payload)},
            {"Result", payload => new CodeInterpreterResultUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))},
        };
        /// <summary>
        /// The mapping of event message to a generator function to construct the matching EventStream Exception
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage,BedrockAgentCoreEventStreamException>> ExceptionMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,BedrockAgentCoreEventStreamException>>(StringComparer.OrdinalIgnoreCase)
        {
            { "AccessDeniedException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new AccessDeniedExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "ConflictException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ConflictExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "InternalServerException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new InternalServerExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "ResourceNotFoundException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ResourceNotFoundExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "ServiceQuotaExceededException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ServiceQuotaExceededExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "ThrottlingException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ThrottlingExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
            { "ValidationException", payload => new BedrockAgentCoreEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ValidationExceptionUnmarshaller().Unmarshall(EventStreamUtils.ConvertMessageToJsonContext(payload))) },
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
        public override event EventHandler<EventStreamExceptionReceivedArgs<BedrockAgentCoreEventStreamException>> ExceptionReceived;
        /// <summary>
        /// Event for the initial response.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<InitialResponseEvent>> InitialResponseReceived;
        ///<summary>
        ///Raised when an Result event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<CodeInterpreterResult>> ResultReceived;

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name="stream"></param>        
        public CodeInterpreterStreamOutput(Stream stream) : this (stream, null)
        {
        }

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="eventStreamDecoder"></param>
        public CodeInterpreterStreamOutput(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)
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
                    RaiseEvent(ResultReceived,ev);
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