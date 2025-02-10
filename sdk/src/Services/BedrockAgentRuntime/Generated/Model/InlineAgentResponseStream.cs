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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
using Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The response from invoking the agent and associated citations and trace information.
    /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Naming", "CA1710:Identifiers should have correct suffix", Justification = "InlineAgentResponseStreamCollection is not descriptive")]
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1063", Justification = "IDisposable is a transient interface from IEventStream. Users need to be able to call Dispose.")]
    public sealed class InlineAgentResponseStream : EnumerableEventStream<IEventStreamEvent, BedrockAgentRuntimeEventStreamException>
    {
        /// <summary>
        ///The mapping of event message to a generator function to construct the matching EventStream event
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage, IEventStreamEvent>> EventMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,IEventStreamEvent>>(StringComparer.OrdinalIgnoreCase)
        {
            {"Initial-Response", payload => new InitialResponseEvent(payload)},
            {"Chunk", payload => 
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream);
                    return new InlineAgentPayloadPartUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {"Files", payload => 
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream);
                    return new InlineAgentFilePartUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {"ReturnControl", payload => 
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream);
                    return new InlineAgentReturnControlPayloadUnmarshaller().Unmarshall(context, ref reader);
                }
            },
            {"Trace", payload => 
                {
                    var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                    var reader = new StreamingUtf8JsonReader(context.Stream);
                    return new InlineAgentTracePartUnmarshaller().Unmarshall(context, ref reader);
                }
            },
        };
        /// <summary>
        /// The mapping of event message to a generator function to construct the matching EventStream Exception
        /// </summary>
        protected override IDictionary<string,Func<IEventStreamMessage,BedrockAgentRuntimeEventStreamException>> ExceptionMapping {get;} =
        new Dictionary<string,Func<IEventStreamMessage,BedrockAgentRuntimeEventStreamException>>(StringComparer.OrdinalIgnoreCase)
        {
                    {"AccessDeniedException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new AccessDeniedExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"BadGatewayException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new BadGatewayExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"ConflictException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ConflictExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"DependencyFailedException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new DependencyFailedExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"InternalServerException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new InternalServerExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"ResourceNotFoundException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ResourceNotFoundExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"ServiceQuotaExceededException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ServiceQuotaExceededExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"ThrottlingException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ThrottlingExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
                    {"ValidationException", payload => 
                        {
                            var context = EventStreamUtils.ConvertMessageToJsonContext(payload);
                            var reader = new StreamingUtf8JsonReader(context.Stream);
                            return new BedrockAgentRuntimeEventStreamException(Encoding.UTF8.GetString(payload.Payload), new ValidationExceptionUnmarshaller().Unmarshall(context, ref reader));
                        }
                    },
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
        public override event EventHandler<EventStreamExceptionReceivedArgs<BedrockAgentRuntimeEventStreamException>> ExceptionReceived;
        /// <summary>
        /// Event for the initial response.
        /// </summary>
        public event EventHandler<EventStreamEventReceivedArgs<InitialResponseEvent>> InitialResponseReceived;
        ///<summary>
        ///Raised when an Chunk event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<InlineAgentPayloadPart>> ChunkReceived;
        ///<summary>
        ///Raised when an Files event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<InlineAgentFilePart>> FilesReceived;
        ///<summary>
        ///Raised when an ReturnControl event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<InlineAgentReturnControlPayload>> ReturnControlReceived;
        ///<summary>
        ///Raised when an Trace event is received
        ///</summary>
        public event EventHandler<EventStreamEventReceivedArgs<InlineAgentTracePart>> TraceReceived;

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name="stream"></param>        
        public InlineAgentResponseStream(Stream stream) : this (stream, null)
        {
        }

        /// <summary>
        /// Construct an instance
        /// </summary>
        /// <param name="stream"></param>
        /// <param name="eventStreamDecoder"></param>
        public InlineAgentResponseStream(Stream stream, IEventStreamDecoder eventStreamDecoder) : base(stream, eventStreamDecoder)
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
                    RaiseEvent(ChunkReceived,ev) ||
                    RaiseEvent(FilesReceived,ev) ||
                    RaiseEvent(ReturnControlReceived,ev) ||
                    RaiseEvent(TraceReceived,ev);
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