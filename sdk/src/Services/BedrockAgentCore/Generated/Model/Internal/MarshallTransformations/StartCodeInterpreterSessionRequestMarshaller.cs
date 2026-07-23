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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.BedrockAgentCore.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// StartCodeInterpreterSession Request Marshaller
    /// </summary>       
    public class StartCodeInterpreterSessionRequestMarshaller : IMarshaller<IRequest, StartCodeInterpreterSessionRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((StartCodeInterpreterSessionRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(StartCodeInterpreterSessionRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.BedrockAgentCore");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetCodeInterpreterIdentifier())
                throw new AmazonBedrockAgentCoreException("Request object does not have required field CodeInterpreterIdentifier set");
            request.AddPathResource("{codeInterpreterIdentifier}", StringUtils.FromString(publicRequest.CodeInterpreterIdentifier));
            request.ResourcePath = "/code-interpreters/{codeInterpreterIdentifier}/sessions/start";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCertificates())
            {
                context.Writer.WritePropertyName("certificates");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCertificatesListValue in publicRequest.Certificates)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CertificateMarshaller.Instance;
                    marshaller.Marshall(publicRequestCertificatesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            else if(!(publicRequest.IsSetClientToken()))
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(Guid.NewGuid().ToString());
            }
            if(publicRequest.IsSetFilesystemConfigurations())
            {
                context.Writer.WritePropertyName("filesystemConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestFilesystemConfigurationsListValue in publicRequest.FilesystemConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ToolsFileSystemConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestFilesystemConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetSessionTimeoutSeconds())
            {
                context.Writer.WritePropertyName("sessionTimeoutSeconds");
                context.Writer.WriteNumberValue(publicRequest.SessionTimeoutSeconds.Value);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif
            

        
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
        private static StartCodeInterpreterSessionRequestMarshaller _instance = new StartCodeInterpreterSessionRequestMarshaller();        

        internal static StartCodeInterpreterSessionRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StartCodeInterpreterSessionRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}