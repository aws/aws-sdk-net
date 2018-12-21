/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the sms-voice-2018-09-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PinpointSMSVoice.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.PinpointSMSVoice.Model.Internal.MarshallTransformations
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
            if(requestObject.IsSetCloudWatchLogsDestination())
            {
                context.Writer.WritePropertyName("CloudWatchLogsDestination");
                context.Writer.WriteObjectStart();

                var marshaller = CloudWatchLogsDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.CloudWatchLogsDestination, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetEnabled())
            {
                context.Writer.WritePropertyName("Enabled");
                context.Writer.Write(requestObject.Enabled);
            }

            if(requestObject.IsSetKinesisFirehoseDestination())
            {
                context.Writer.WritePropertyName("KinesisFirehoseDestination");
                context.Writer.WriteObjectStart();

                var marshaller = KinesisFirehoseDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.KinesisFirehoseDestination, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetMatchingEventTypes())
            {
                context.Writer.WritePropertyName("MatchingEventTypes");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectMatchingEventTypesListValue in requestObject.MatchingEventTypes)
                {
                        context.Writer.Write(requestObjectMatchingEventTypesListValue);
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetSnsDestination())
            {
                context.Writer.WritePropertyName("SnsDestination");
                context.Writer.WriteObjectStart();

                var marshaller = SnsDestinationMarshaller.Instance;
                marshaller.Marshall(requestObject.SnsDestination, context);

                context.Writer.WriteObjectEnd();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static EventDestinationDefinitionMarshaller Instance = new EventDestinationDefinitionMarshaller();

    }
}