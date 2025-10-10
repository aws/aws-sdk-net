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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeCodeInterpreter Request Marshaller
    /// </summary>       
    public class InvokeCodeInterpreterRequestMarshaller : IMarshaller<IRequest, InvokeCodeInterpreterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeCodeInterpreterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeCodeInterpreterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetCodeInterpreterIdentifier())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field CodeInterpreterIdentifier set");
            request.AddPathResource("{codeInterpreterIdentifier}", StringUtils.FromString(publicRequest.CodeInterpreterIdentifier));
            request.ResourcePath = "/code-interpreters/{codeInterpreterIdentifier}/tools/invoke";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetArguments())
                {
                    context.Writer.WritePropertyName("arguments");
                    context.Writer.WriteObjectStart();

                    var marshaller = ToolArgumentsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Arguments, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }

        
            if (publicRequest.IsSetSessionId()) 
            {
                request.Headers["x-amzn-code-interpreter-session-id"] = publicRequest.SessionId;
            }
        
            if (publicRequest.IsSetTraceId()) 
            {
                request.Headers["X-Amzn-Trace-Id"] = publicRequest.TraceId;
            }
        
            if (publicRequest.IsSetTraceParent()) 
            {
                request.Headers["traceparent"] = publicRequest.TraceParent;
            }

            return request;
        }
        private static InvokeCodeInterpreterRequestMarshaller _instance = new InvokeCodeInterpreterRequestMarshaller();        

        internal static InvokeCodeInterpreterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeCodeInterpreterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}