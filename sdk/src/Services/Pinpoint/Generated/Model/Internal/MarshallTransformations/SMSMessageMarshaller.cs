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
    /// SMSMessage Marshaller
    /// </summary>
    public class SMSMessageMarshaller : IRequestMarshaller<SMSMessage, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SMSMessage requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBody())
            {
                context.Writer.WritePropertyName("Body");
                context.Writer.WriteStringValue(requestObject.Body);
            }

            if(requestObject.IsSetEntityId())
            {
                context.Writer.WritePropertyName("EntityId");
                context.Writer.WriteStringValue(requestObject.EntityId);
            }

            if(requestObject.IsSetKeyword())
            {
                context.Writer.WritePropertyName("Keyword");
                context.Writer.WriteStringValue(requestObject.Keyword);
            }

            if(requestObject.IsSetMediaUrl())
            {
                context.Writer.WritePropertyName("MediaUrl");
                context.Writer.WriteStringValue(requestObject.MediaUrl);
            }

            if(requestObject.IsSetMessageType())
            {
                context.Writer.WritePropertyName("MessageType");
                context.Writer.WriteStringValue(requestObject.MessageType);
            }

            if(requestObject.IsSetOriginationNumber())
            {
                context.Writer.WritePropertyName("OriginationNumber");
                context.Writer.WriteStringValue(requestObject.OriginationNumber);
            }

            if(requestObject.IsSetSenderId())
            {
                context.Writer.WritePropertyName("SenderId");
                context.Writer.WriteStringValue(requestObject.SenderId);
            }

            if(requestObject.IsSetSubstitutions())
            {
                context.Writer.WritePropertyName("Substitutions");
                context.Writer.WriteStartObject();
                foreach (var requestObjectSubstitutionsKvp in requestObject.Substitutions)
                {
                    context.Writer.WritePropertyName(requestObjectSubstitutionsKvp.Key);
                    var requestObjectSubstitutionsValue = requestObjectSubstitutionsKvp.Value;

                    context.Writer.WriteStartArray();
                    foreach(var requestObjectSubstitutionsValueListValue in requestObjectSubstitutionsValue)
                    {
                            context.Writer.WriteStringValue(requestObjectSubstitutionsValueListValue);
                    }
                    context.Writer.WriteEndArray();
                }
                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetTemplateId())
            {
                context.Writer.WritePropertyName("TemplateId");
                context.Writer.WriteStringValue(requestObject.TemplateId);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SMSMessageMarshaller Instance = new SMSMessageMarshaller();

    }
}