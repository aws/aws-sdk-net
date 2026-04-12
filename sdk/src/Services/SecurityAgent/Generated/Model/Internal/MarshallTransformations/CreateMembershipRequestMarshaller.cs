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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityAgent.Model;
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
namespace Amazon.SecurityAgent.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMembership Request Marshaller
    /// </summary>       
    public class CreateMembershipRequestMarshaller : IMarshaller<IRequest, CreateMembershipRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMembershipRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMembershipRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.SecurityAgent");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-09-06";
            request.HttpMethod = "POST";

            request.ResourcePath = "/CreateMembership";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAgentSpaceId())
            {
                context.Writer.WritePropertyName("agentSpaceId");
                context.Writer.WriteStringValue(publicRequest.AgentSpaceId);
            }

            if(publicRequest.IsSetApplicationId())
            {
                context.Writer.WritePropertyName("applicationId");
                context.Writer.WriteStringValue(publicRequest.ApplicationId);
            }

            if(publicRequest.IsSetConfig())
            {
                context.Writer.WritePropertyName("config");
                context.Writer.WriteStartObject();

                var marshaller = MembershipConfigMarshaller.Instance;
                marshaller.Marshall(publicRequest.Config, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMembershipId())
            {
                context.Writer.WritePropertyName("membershipId");
                context.Writer.WriteStringValue(publicRequest.MembershipId);
            }

            if(publicRequest.IsSetMemberType())
            {
                context.Writer.WritePropertyName("memberType");
                context.Writer.WriteStringValue(publicRequest.MemberType);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static CreateMembershipRequestMarshaller _instance = new CreateMembershipRequestMarshaller();        

        internal static CreateMembershipRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMembershipRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}