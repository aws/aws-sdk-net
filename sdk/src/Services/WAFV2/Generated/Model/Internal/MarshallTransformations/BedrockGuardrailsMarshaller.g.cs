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

using Amazon.WAFV2.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.WAFV2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// BedrockGuardrails Marshaller
    /// </summary>
    public partial class BedrockGuardrailsMarshaller : IRequestMarshaller<BedrockGuardrails, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(BedrockGuardrails requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetDisable())
            {
                context.Writer.WritePropertyName("Disable");
                context.Writer.WriteStartObject();

                var marshaller = DisableBedrockGuardrailsMarshaller.Instance;
                marshaller.Marshall(requestObject.Disable, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetProtectRequestAndResponse())
            {
                context.Writer.WritePropertyName("ProtectRequestAndResponse");
                context.Writer.WriteStartObject();

                var marshaller = BedrockGuardrailsRequestAndResponseMarshaller.Instance;
                marshaller.Marshall(requestObject.ProtectRequestAndResponse, context);

                context.Writer.WriteEndObject();
            }

            if (requestObject.IsSetProtectRequestOnly())
            {
                context.Writer.WritePropertyName("ProtectRequestOnly");
                context.Writer.WriteStartObject();

                var marshaller = BedrockGuardrailsRequestOnlyMarshaller.Instance;
                marshaller.Marshall(requestObject.ProtectRequestOnly, context);

                context.Writer.WriteEndObject();
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static BedrockGuardrailsMarshaller Instance = new BedrockGuardrailsMarshaller();
    }
}
