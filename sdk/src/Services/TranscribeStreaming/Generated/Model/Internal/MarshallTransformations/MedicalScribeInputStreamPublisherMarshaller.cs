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
 * Do not modify this file. This file is generated from the transcribe-streaming-2017-10-26.normal.json service model.
 */
using System;
using System.IO;
using System.Threading.Tasks;
using Amazon.Runtime.EventStreams;
#pragma warning disable CS0612,CS0618
namespace Amazon.TranscribeStreaming.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Marshalles the service events for the event stream to the low level IEventStreamMessage.
    /// </summary>
    public partial class MedicalScribeInputStreamPublisherMarshaller : EventStreamPublisher
    {
        Func< Task<IMedicalScribeInputStreamEvent>> _publisher;

        /// <summary>
        /// Creates instance of MedicalScribeInputStreamPublisherMarshaller
        /// </summary>
        /// <param name="publisher">The service event publisher provided by the consumer of the SDK.</param>
        public MedicalScribeInputStreamPublisherMarshaller(Func<Task<IMedicalScribeInputStreamEvent>> publisher)
        {
            _publisher = publisher;
        }

        /// <summary>
        /// Gets the next service event provided by the consumer of the SDK and converts it to a IEventStreamMessage.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Amazon.Runtime.AmazonClientException">If the type of the event is unknown.</exception>
        public override async Task<IEventStreamMessage> NextEventAsync()
        {
            var evnt = await _publisher().ConfigureAwait(false);
            if (evnt == null)
                return null;

            byte[] eventPayload;
            string contentType;
            string eventType;
            if (evnt is MedicalScribeAudioEvent)
            {
                var memoryStream = new MemoryStream();
                var context = CreateJsonMarshallerContext(memoryStream);
                context.Writer.WriteStartObject();
                MedicalScribeAudioEventMarshaller.Instance.Marshall((MedicalScribeAudioEvent)evnt, context);
                context.Writer.WriteEndObject();
                context.Writer.Flush();

                eventType = "AudioEvent";
                contentType = "application/octet-stream";
                eventPayload = context.Request.Content;
            }
            else if (evnt is MedicalScribeConfigurationEvent)
            {
                var memoryStream = new MemoryStream();
                var context = CreateJsonMarshallerContext(memoryStream);
                context.Writer.WriteStartObject();
                MedicalScribeConfigurationEventMarshaller.Instance.Marshall((MedicalScribeConfigurationEvent)evnt, context);
                context.Writer.WriteEndObject();
                context.Writer.Flush();

                eventType = "ConfigurationEvent";
                contentType = "application/json";
                eventPayload = memoryStream.ToArray();
            }
            else if (evnt is MedicalScribeSessionControlEvent)
            {
                var memoryStream = new MemoryStream();
                var context = CreateJsonMarshallerContext(memoryStream);
                context.Writer.WriteStartObject();
                MedicalScribeSessionControlEventMarshaller.Instance.Marshall((MedicalScribeSessionControlEvent)evnt, context);
                context.Writer.WriteEndObject();
                context.Writer.Flush();

                eventType = "SessionControlEvent";
                contentType = "application/json";
                eventPayload = memoryStream.ToArray();
            }
            else
            {
                throw new Amazon.Runtime.AmazonClientException($"Type {evnt.GetType().FullName} is not a known event type for this streaming operation");
            }

            return CreateEventStreamMessage(eventType: eventType, contentType: contentType, marshalledEventHeaders: null, eventPayload: eventPayload);
        }
    }
}