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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DevOpsAgent.Model;
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
namespace Amazon.DevOpsAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// EnableOperatorApp Request Marshaller
    /// </summary>       
    public class EnableOperatorAppRequestMarshaller : IMarshaller<IRequest, EnableOperatorAppRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((EnableOperatorAppRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(EnableOperatorAppRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DevOpsAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2026-01-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAgentSpaceId())
                throw new AmazonDevOpsAgentException("Request object does not have required field AgentSpaceId set");
            request.AddPathResource("{agentSpaceId}", StringUtils.FromString(publicRequest.AgentSpaceId));
            request.ResourcePath = "/v1/agentspaces/{agentSpaceId}/operator";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAuthFlow())
            {
                context.Writer.WritePropertyName("authFlow");
                context.Writer.WriteStringValue(publicRequest.AuthFlow);
            }

            if(publicRequest.IsSetIdcInstanceArn())
            {
                context.Writer.WritePropertyName("idcInstanceArn");
                context.Writer.WriteStringValue(publicRequest.IdcInstanceArn);
            }

            if(publicRequest.IsSetIdpClientId())
            {
                context.Writer.WritePropertyName("idpClientId");
                context.Writer.WriteStringValue(publicRequest.IdpClientId);
            }

            if(publicRequest.IsSetIdpClientSecret())
            {
                context.Writer.WritePropertyName("idpClientSecret");
                context.Writer.WriteStringValue(publicRequest.IdpClientSecret);
            }

            if(publicRequest.IsSetIssuerUrl())
            {
                context.Writer.WritePropertyName("issuerUrl");
                context.Writer.WriteStringValue(publicRequest.IssuerUrl);
            }

            if(publicRequest.IsSetOperatorAppRoleArn())
            {
                context.Writer.WritePropertyName("operatorAppRoleArn");
                context.Writer.WriteStringValue(publicRequest.OperatorAppRoleArn);
            }

            if(publicRequest.IsSetProvider())
            {
                context.Writer.WritePropertyName("provider");
                context.Writer.WriteStringValue(publicRequest.Provider);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"cp.";

            return request;
        }
        private static EnableOperatorAppRequestMarshaller _instance = new EnableOperatorAppRequestMarshaller();        

        internal static EnableOperatorAppRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EnableOperatorAppRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}