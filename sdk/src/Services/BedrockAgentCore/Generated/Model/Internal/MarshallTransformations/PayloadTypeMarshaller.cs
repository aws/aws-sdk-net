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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PayloadType Marshaller
    /// </summary>
    public class PayloadTypeMarshaller : IRequestMarshaller<PayloadType, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(PayloadType requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetBlob())
            {
                context.Writer.WritePropertyName("blob");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.Blob);
            }

            if(requestObject.IsSetConversational())
            {
                context.Writer.WritePropertyName("conversational");
                context.Writer.WriteStartObject();

                var marshaller = ConversationalMarshaller.Instance;
                marshaller.Marshall(requestObject.Conversational, context);

                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static PayloadTypeMarshaller Instance = new PayloadTypeMarshaller();

    }
}