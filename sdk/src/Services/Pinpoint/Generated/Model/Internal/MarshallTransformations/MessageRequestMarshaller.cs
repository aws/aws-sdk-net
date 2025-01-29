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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Pinpoint.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.Pinpoint.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MessageRequest Marshaller
    /// </summary>
    public class MessageRequestMarshaller : IRequestMarshaller<MessageRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MessageRequest requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAddresses())
            {
                context.Writer.WritePropertyName("Addresses");
                context.Writer.WriteStartObject();
                foreach (var requestObjectAddressesKvp in requestObject.Addresses)
                {
                    context.Writer.WritePropertyName(requestObjectAddressesKvp.Key);
                    var requestObjectAddressesValue = requestObjectAddressesKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = AddressConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectAddressesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetContext())
            {
                context.Writer.WritePropertyName("Context");
                context.Writer.WriteStartObject();
                foreach (var requestObjectContextKvp in requestObject.Context)
                {
                    context.Writer.WritePropertyName(requestObjectContextKvp.Key);
                    var requestObjectContextValue = requestObjectContextKvp.Value;

                        context.Writer.WriteStringValue(requestObjectContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetEndpoints())
            {
                context.Writer.WritePropertyName("Endpoints");
                context.Writer.WriteStartObject();
                foreach (var requestObjectEndpointsKvp in requestObject.Endpoints)
                {
                    context.Writer.WritePropertyName(requestObjectEndpointsKvp.Key);
                    var requestObjectEndpointsValue = requestObjectEndpointsKvp.Value;

                    context.Writer.WriteStartObject();

                    var marshaller = EndpointSendConfigurationMarshaller.Instance;
                    marshaller.Marshall(requestObjectEndpointsValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetMessageConfiguration())
            {
                context.Writer.WritePropertyName("MessageConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DirectMessageConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.MessageConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTemplateConfiguration())
            {
                context.Writer.WritePropertyName("TemplateConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = TemplateConfigurationMarshaller.Instance;
                marshaller.Marshall(requestObject.TemplateConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTraceId())
            {
                context.Writer.WritePropertyName("TraceId");
                context.Writer.WriteStringValue(requestObject.TraceId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageRequestMarshaller Instance = new MessageRequestMarshaller();

    }
}