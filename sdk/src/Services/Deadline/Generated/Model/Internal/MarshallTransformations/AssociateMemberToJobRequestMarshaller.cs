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
 * Do not modify this file. This file is generated from the deadline-2023-10-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Deadline.Model;
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
namespace Amazon.Deadline.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AssociateMemberToJob Request Marshaller
    /// </summary>       
    public class AssociateMemberToJobRequestMarshaller : IMarshaller<IRequest, AssociateMemberToJobRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((AssociateMemberToJobRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(AssociateMemberToJobRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Deadline");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-10-12";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetFarmId())
                throw new AmazonDeadlineException("Request object does not have required field FarmId set");
            request.AddPathResource("{farmId}", StringUtils.FromString(publicRequest.FarmId));
            if (!publicRequest.IsSetJobId())
                throw new AmazonDeadlineException("Request object does not have required field JobId set");
            request.AddPathResource("{jobId}", StringUtils.FromString(publicRequest.JobId));
            if (!publicRequest.IsSetPrincipalId())
                throw new AmazonDeadlineException("Request object does not have required field PrincipalId set");
            request.AddPathResource("{principalId}", StringUtils.FromString(publicRequest.PrincipalId));
            if (!publicRequest.IsSetQueueId())
                throw new AmazonDeadlineException("Request object does not have required field QueueId set");
            request.AddPathResource("{queueId}", StringUtils.FromString(publicRequest.QueueId));
            request.ResourcePath = "/2023-10-12/farms/{farmId}/queues/{queueId}/jobs/{jobId}/members/{principalId}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetIdentityStoreId())
            {
                context.Writer.WritePropertyName("identityStoreId");
                context.Writer.WriteStringValue(publicRequest.IdentityStoreId);
            }

            if(publicRequest.IsSetMembershipLevel())
            {
                context.Writer.WritePropertyName("membershipLevel");
                context.Writer.WriteStringValue(publicRequest.MembershipLevel);
            }

            if(publicRequest.IsSetPrincipalType())
            {
                context.Writer.WritePropertyName("principalType");
                context.Writer.WriteStringValue(publicRequest.PrincipalType);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"management.";

            return request;
        }
        private static AssociateMemberToJobRequestMarshaller _instance = new AssociateMemberToJobRequestMarshaller();        

        internal static AssociateMemberToJobRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AssociateMemberToJobRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}