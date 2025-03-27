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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentRuntime.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AgentActionGroup Marshaller
    /// </summary>
    public class AgentActionGroupMarshaller : IRequestMarshaller<AgentActionGroup, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AgentActionGroup requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetActionGroupExecutor())
            {
                context.Writer.WritePropertyName("actionGroupExecutor");
                context.Writer.WriteStartObject();

                var marshaller = ActionGroupExecutorMarshaller.Instance;
                marshaller.Marshall(requestObject.ActionGroupExecutor, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetActionGroupName())
            {
                context.Writer.WritePropertyName("actionGroupName");
                context.Writer.WriteStringValue(requestObject.ActionGroupName);
            }

            if(requestObject.IsSetApiSchema())
            {
                context.Writer.WritePropertyName("apiSchema");
                context.Writer.WriteStartObject();

                var marshaller = APISchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.ApiSchema, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDescription())
            {
                context.Writer.WritePropertyName("description");
                context.Writer.WriteStringValue(requestObject.Description);
            }

            if(requestObject.IsSetFunctionSchema())
            {
                context.Writer.WritePropertyName("functionSchema");
                context.Writer.WriteStartObject();

                var marshaller = FunctionSchemaMarshaller.Instance;
                marshaller.Marshall(requestObject.FunctionSchema, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetParentActionGroupSignature())
            {
                context.Writer.WritePropertyName("parentActionGroupSignature");
                context.Writer.WriteStringValue(requestObject.ParentActionGroupSignature);
            }

            if(requestObject.IsSetParentActionGroupSignatureParams())
            {
                context.Writer.WritePropertyName("parentActionGroupSignatureParams");
                context.Writer.WriteStartObject();
                foreach (var requestObjectParentActionGroupSignatureParamsKvp in requestObject.ParentActionGroupSignatureParams)
                {
                    context.Writer.WritePropertyName(requestObjectParentActionGroupSignatureParamsKvp.Key);
                    var requestObjectParentActionGroupSignatureParamsValue = requestObjectParentActionGroupSignatureParamsKvp.Value;

                        context.Writer.WriteStringValue(requestObjectParentActionGroupSignatureParamsValue);
                }
                context.Writer.WriteEndObject();
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AgentActionGroupMarshaller Instance = new AgentActionGroupMarshaller();

    }
}