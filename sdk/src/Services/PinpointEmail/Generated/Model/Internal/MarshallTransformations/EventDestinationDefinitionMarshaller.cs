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
 * Do not modify this file. This file is generated from the pinpoint-email-2018-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointEmail.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.PinpointEmail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EventDestinationDefinition Marshaller
    /// </summary>
    public class EventDestinationDefinitionMarshaller : IRequestMarshaller<EventDestinationDefinition, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(EventDestinationDefinition requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCloudWatchDestination())
            {
                context.Writer.WritePropertyName("CloudWatchDestination");
                context.Writer.WriteStartObject();

                var marshaller = CloudWatchDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchDestination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.WriteBooleanValue(requestObject.Enabled.Value);
            }

            if(requestObject.IsSetKinesisFirehoseDestination())
            {
                context.Writer.WritePropertyName("KinesisFirehoseDestination");
                context.Writer.WriteStartObject();

                var marshaller = KinesisFirehoseDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseDestination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMatchingEventTypes())
            {
                context.Writer.WritePropertyName("MatchingEventTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectMatchingEventTypesListValue in requestObject.MatchingEventTypes)
                {
                        context.Writer.WriteStringValue(requestObjectMatchingEventTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPinpointDestination())
            {
                context.Writer.WritePropertyName("PinpointDestination");
                context.Writer.WriteStartObject();

                var marshaller = PinpointDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.PinpointDestination, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSnsDestination())
            {
                context.Writer.WritePropertyName("SnsDestination");
                context.Writer.WriteStartObject();

                var marshaller = SnsDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnsDestination, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static EventDestinationDefinitionMarshaller Instance = new EventDestinationDefinitionMarshaller();

    }
}