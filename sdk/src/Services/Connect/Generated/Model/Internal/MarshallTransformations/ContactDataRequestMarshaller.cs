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
    /// ContactDataRequest Marshaller
    /// </summary>
    public class ContactDataRequestMarshaller : IRequestMarshaller<ContactDataRequest, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(ContactDataRequest requestObject, JsonMarshallerContext context)
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

            if(requestObject.IsSetCampaign())
            {
                context.Writer.WritePropertyName("Campaign");
                context.Writer.WriteStartObject();

                var marshaller = CampaignMarshaller.Instance;
                marshaller.Marshall(requestObject.Campaign, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomerEndpoint())
            {
                context.Writer.WritePropertyName("CustomerEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = EndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomerEndpoint, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetQueueId())
            {
                context.Writer.WritePropertyName("QueueId");
                context.Writer.WriteStringValue(requestObject.QueueId);
            }

            if(requestObject.IsSetRequestIdentifier())
            {
                context.Writer.WritePropertyName("RequestIdentifier");
                context.Writer.WriteStringValue(requestObject.RequestIdentifier);
            }

            if(requestObject.IsSetSystemEndpoint())
            {
                context.Writer.WritePropertyName("SystemEndpoint");
                context.Writer.WriteStartObject();

                var marshaller = EndpointMarshaller.Instance;
                marshaller.Marshall(requestObject.SystemEndpoint, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static ContactDataRequestMarshaller Instance = new ContactDataRequestMarshaller();

    }
}