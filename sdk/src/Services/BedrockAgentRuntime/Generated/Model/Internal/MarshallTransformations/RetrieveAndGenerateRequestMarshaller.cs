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
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RetrieveAndGenerate Request Marshaller
    /// </summary>       
    public class RetrieveAndGenerateRequestMarshaller : IMarshaller<IRequest, RetrieveAndGenerateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RetrieveAndGenerateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RetrieveAndGenerateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentRuntime");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-07-26";
            request.HttpMethod = "POST";

            request.ResourcePath = "/retrieveAndGenerate";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInput())
                {
                    context.Writer.WritePropertyName("input");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetrieveAndGenerateInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Input, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetRetrieveAndGenerateConfiguration())
                {
                    context.Writer.WritePropertyName("retrieveAndGenerateConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetrieveAndGenerateConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RetrieveAndGenerateConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSessionConfiguration())
                {
                    context.Writer.WritePropertyName("sessionConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = RetrieveAndGenerateSessionConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.SessionConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSessionId())
                {
                    context.Writer.WritePropertyName("sessionId");
                    context.Writer.Write(publicRequest.SessionId);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RetrieveAndGenerateRequestMarshaller _instance = new RetrieveAndGenerateRequestMarshaller();        

        internal static RetrieveAndGenerateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RetrieveAndGenerateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}