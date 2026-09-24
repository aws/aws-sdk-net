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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.EventBridgeV2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using Amazon.Extensions.CborProtocol;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618
namespace Amazon.EventBridgeV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SnsParameters Marshaller
    /// </summary>
    public class SnsParametersMarshaller : IRequestMarshaller<SnsParameters, CborMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(SnsParameters requestObject, CborMarshallerContext context)
        {
            if (requestObject == null)
                return;

            if (requestObject.IsSetMessageAttributes())
            {
                context.Writer.WriteTextString("MessageAttributes");
                context.Writer.WriteStartMap(null);
                foreach (var requestObjectMessageAttributesKvp in requestObject.MessageAttributes)
                {
                    context.Writer.WriteTextString(requestObjectMessageAttributesKvp.Key);
                    var requestObjectMessageAttributesValue = requestObjectMessageAttributesKvp.Value;

                    context.Writer.WriteStartMap(null);

                    var marshaller = SnsMessageAttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessageAttributesValue, context);

                    context.Writer.WriteEndMap();
                }
                context.Writer.WriteEndMap();
            }
            if (requestObject.IsSetMessageDeduplicationId())
            {
                context.Writer.WriteTextString("MessageDeduplicationId");
                context.Writer.WriteTextString(requestObject.MessageDeduplicationId);
            }
            if (requestObject.IsSetMessageGroupId())
            {
                context.Writer.WriteTextString("MessageGroupId");
                context.Writer.WriteTextString(requestObject.MessageGroupId);
            }
            if (requestObject.IsSetMessageStructure())
            {
                context.Writer.WriteTextString("MessageStructure");
                context.Writer.WriteTextString(requestObject.MessageStructure);
            }
            if (requestObject.IsSetSubject())
            {
                context.Writer.WriteTextString("Subject");
                context.Writer.WriteTextString(requestObject.Subject);
            }
        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static SnsParametersMarshaller Instance = new SnsParametersMarshaller();

    }
}