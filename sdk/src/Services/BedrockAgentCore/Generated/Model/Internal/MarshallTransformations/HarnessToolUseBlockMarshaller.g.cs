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

using Amazon.BedrockAgentCore.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;

#pragma warning disable CS0612,CS0618

namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// HarnessToolUseBlock Marshaller
    /// </summary>
    public partial class HarnessToolUseBlockMarshaller : IRequestMarshaller<HarnessToolUseBlock, JsonMarshallerContext>
    {
        /// <summary>
        /// Marshall the structure from the request object to the service
        /// </summary>
        public void Marshall(HarnessToolUseBlock requestObject, JsonMarshallerContext context)
        {
            if (requestObject == null) return;

            if (requestObject.IsSetInput())
            {
                context.Writer.WritePropertyName("input");
                Amazon.Runtime.Documents.Internal.Transform.DocumentMarshaller.Instance.Write(context.Writer, requestObject.Input);
            }

            if (requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if (requestObject.IsSetServerName())
            {
                context.Writer.WritePropertyName("serverName");
                context.Writer.WriteStringValue(requestObject.ServerName);
            }

            if (requestObject.IsSetToolUseId())
            {
                context.Writer.WritePropertyName("toolUseId");
                context.Writer.WriteStringValue(requestObject.ToolUseId);
            }

            if (requestObject.IsSetType())
            {
                context.Writer.WritePropertyName("type");
                context.Writer.WriteStringValue(requestObject.Type);
            }
        }

        /// <summary>
        /// Singleton Marshaller
        /// </summary>
        public readonly static HarnessToolUseBlockMarshaller Instance = new HarnessToolUseBlockMarshaller();
    }
}
