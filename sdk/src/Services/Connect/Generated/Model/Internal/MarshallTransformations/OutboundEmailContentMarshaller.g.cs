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

using Amazon.Connect.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.Connect.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// OutboundEmailContent Marshaller
    /// </summary>
    public partial class OutboundEmailContentMarshaller : IRequestMarshaller<OutboundEmailContent, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(OutboundEmailContent requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetMessageSourceType())
            {
                context.Writer.WritePropertyName("MessageSourceType");
                context.Writer.WriteStringValue(requestObject.MessageSourceType);
            }

            if (requestObject.IsSetRawMessage())
            {
                context.Writer.WritePropertyName("RawMessage");
                context.Writer.WriteStartObject();

                var marshaller = OutboundRawMessageMarshaller.Instance;
                marshaller.Marshall(requestObject.RawMessage, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetTemplatedMessageConfig())
            {
                context.Writer.WritePropertyName("TemplatedMessageConfig");
                context.Writer.WriteStartObject();

                var marshaller = TemplatedMessageConfigMarshaller.Instance;
                marshaller.Marshall(requestObject.TemplatedMessageConfig, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static OutboundEmailContentMarshaller Instance = new OutboundEmailContentMarshaller();
    }
}
