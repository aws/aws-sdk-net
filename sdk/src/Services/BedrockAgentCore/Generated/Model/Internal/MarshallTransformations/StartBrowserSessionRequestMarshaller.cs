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
    /// StartBrowserSession Request Marshaller
    /// </summary>       
    public class StartBrowserSessionRequestMarshaller : IMarshaller<IRequest, StartBrowserSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartBrowserSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartBrowserSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetBrowserIdentifier())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field BrowserIdentifier set");
            request.AddPathResource("{browserIdentifier}", StringUtils.FromString(publicRequest.BrowserIdentifier));
            request.ResourcePath = "/browsers/{browserIdentifier}/sessions/start";
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
                if(publicRequest.IsSetExtensions())
                {
                    context.Writer.WritePropertyName("extensions");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestExtensionsListValue in publicRequest.Extensions)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = BrowserExtensionMarshaller.Instance;
                        marshaller.Marshall(publicRequestExtensionsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetName())
                {
                    context.Writer.WritePropertyName("name");
                    context.Writer.Write(publicRequest.Name);
                }

                if(publicRequest.IsSetSessionTimeoutSeconds())
                {
                    context.Writer.WritePropertyName("sessionTimeoutSeconds");
                    context.Writer.Write(publicRequest.SessionTimeoutSeconds);
                }

                if(publicRequest.IsSetViewPort())
                {
                    context.Writer.WritePropertyName("viewPort");
                    context.Writer.WriteObjectStart();

                    var marshaller = ViewPortMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ViewPort, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
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
        private static StartBrowserSessionRequestMarshaller _instance = new StartBrowserSessionRequestMarshaller();        

        internal static StartBrowserSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartBrowserSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}