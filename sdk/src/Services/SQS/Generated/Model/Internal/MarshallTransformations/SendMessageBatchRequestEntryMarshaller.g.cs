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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SQS.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.SQS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// SendMessageBatchRequestEntry Marshaller
    /// </summary>
    public partial class SendMessageBatchRequestEntryMarshaller : IRequestMarshaller<SendMessageBatchRequestEntry, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(SendMessageBatchRequestEntry requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDelaySeconds())
            {
                context.Writer.WritePropertyName("DelaySeconds");
                context.Writer.WriteNumberValue(requestObject.DelaySeconds.Value);
            }

            if (requestObject.IsSetId())
            {
                context.Writer.WritePropertyName("Id");
                context.Writer.WriteStringValue(requestObject.Id);
            }

            if (requestObject.IsSetMessageAttributes())
            {
                context.Writer.WritePropertyName("MessageAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMessageAttributesKvp in requestObject.MessageAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectMessageAttributesKvp.Key);
                    var requestObjectMessageAttributesValue = requestObjectMessageAttributesKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = MessageAttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessageAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetMessageBody())
            {
                context.Writer.WritePropertyName("MessageBody");
                context.Writer.WriteStringValue(requestObject.MessageBody);
            }

            if (requestObject.IsSetMessageDeduplicationId())
            {
                context.Writer.WritePropertyName("MessageDeduplicationId");
                context.Writer.WriteStringValue(requestObject.MessageDeduplicationId);
            }

            if (requestObject.IsSetMessageGroupId())
            {
                context.Writer.WritePropertyName("MessageGroupId");
                context.Writer.WriteStringValue(requestObject.MessageGroupId);
            }

            if (requestObject.IsSetMessageSystemAttributes())
            {
                context.Writer.WritePropertyName("MessageSystemAttributes");
                context.Writer.WriteStartObject();
                foreach (var requestObjectMessageSystemAttributesKvp in requestObject.MessageSystemAttributes)
                {
                    context.Writer.WritePropertyName(requestObjectMessageSystemAttributesKvp.Key);
                    var requestObjectMessageSystemAttributesValue = requestObjectMessageSystemAttributesKvp.Value;
                    context.Writer.WriteStartObject();

                    var marshaller = MessageSystemAttributeValueMarshaller.Instance;
                    marshaller.Marshall(requestObjectMessageSystemAttributesValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static SendMessageBatchRequestEntryMarshaller Instance = new SendMessageBatchRequestEntryMarshaller();
    }
}
