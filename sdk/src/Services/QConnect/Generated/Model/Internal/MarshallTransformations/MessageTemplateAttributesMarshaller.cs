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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QConnect.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.QConnect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// MessageTemplateAttributes Marshaller
    /// </summary>
    public class MessageTemplateAttributesMarshaller : IRequestMarshaller<MessageTemplateAttributes, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(MessageTemplateAttributes requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetAgentAttributes())
            {
                context.Writer.WritePropertyName("agentAttributes");
                context.Writer.WriteStartObject();

                var marshaller = AgentAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.AgentAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomAttributes())
            {
                context.Writer.WritePropertyName("customAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectCustomAttributesKvp in requestObject.CustomAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectCustomAttributesKvp.Key);
                    var requestObjectCustomAttributesValue = requestObjectCustomAttributesKvp.Value;

                        context.Writer.WriteStringValue(requestObjectCustomAttributesValue);
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetCustomerProfileAttributes())
            {
                context.Writer.WritePropertyName("customerProfileAttributes");
                context.Writer.WriteStartObject();

                var marshaller = CustomerProfileAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.CustomerProfileAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetSystemAttributes())
            {
                context.Writer.WritePropertyName("systemAttributes");
                context.Writer.WriteStartObject();

                var marshaller = SystemAttributesMarshaller.Instance;
                marshaller.Marshall(requestObject.SystemAttributes, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static MessageTemplateAttributesMarshaller Instance = new MessageTemplateAttributesMarshaller();

    }
}