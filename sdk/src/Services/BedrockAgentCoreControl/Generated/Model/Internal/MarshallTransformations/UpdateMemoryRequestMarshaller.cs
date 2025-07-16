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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.BedrockAgentCoreControl.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCoreControl.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateMemory Request Marshaller
    /// </summary>       
    public class UpdateMemoryRequestMarshaller : IMarshaller<IRequest, UpdateMemoryRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateMemoryRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateMemoryRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCoreControl");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-06-05";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetMemoryId())
                throw new AmazonBedrockAgentCoreControlException("Request object does not have required field MemoryId set");
            request.AddPathResource("{memoryId}", StringUtils.FromString(publicRequest.MemoryId));
            request.ResourcePath = "/memories/{memoryId}/update";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetDescription())
                {
                    context.Writer.WritePropertyName("description");
                    context.Writer.Write(publicRequest.Description);
                }

                if(publicRequest.IsSetEventExpiryDuration())
                {
                    context.Writer.WritePropertyName("eventExpiryDuration");
                    context.Writer.Write(publicRequest.EventExpiryDuration);
                }

                if(publicRequest.IsSetMemoryExecutionRoleArn())
                {
                    context.Writer.WritePropertyName("memoryExecutionRoleArn");
                    context.Writer.Write(publicRequest.MemoryExecutionRoleArn);
                }

                if(publicRequest.IsSetMemoryStrategies())
                {
                    context.Writer.WritePropertyName("memoryStrategies");
                    context.Writer.WriteObjectStart();

                    var marshaller = ModifyMemoryStrategiesMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MemoryStrategies, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateMemoryRequestMarshaller _instance = new UpdateMemoryRequestMarshaller();        

        internal static UpdateMemoryRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateMemoryRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}