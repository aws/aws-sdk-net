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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Connect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// NewSessionDetails Marshaller
    /// </summary>
    public class NewSessionDetailsMarshaller : IRequestMarshaller<NewSessionDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(NewSessionDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAttributes())
            {
                context.Writer.WritePropertyName("Attributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAttributesKvp in requestObject.Attributes)
                {
                    context.Writer.WritePropertyName(requestObjectAttributesKvp.Key);
                    var requestObjectAttributesValue = requestObjectAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParticipantDetails())
            {
                context.Writer.WritePropertyName("ParticipantDetails");
                context.Writer.WriteStartObject();

                var marshaller = ParticipantDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.ParticipantDetails, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetStreamingConfiguration())
            {
                context.Writer.WritePropertyName("StreamingConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ChatStreamingConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.StreamingConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSupportedMessagingContentTypes())
            {
                context.Writer.WritePropertyName("SupportedMessagingContentTypes");
                context.Writer.WriteStartArray();
                foreach(var requestObjectSupportedMessagingContentTypesListValue in requestObject.SupportedMessagingContentTypes)
                {
                        context.Writer.WriteStringValue(requestObjectSupportedMessagingContentTypesListValue);
                }
                context.Writer.WriteEndArray();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static NewSessionDetailsMarshaller Instance = new NewSessionDetailsMarshaller();

    }
}