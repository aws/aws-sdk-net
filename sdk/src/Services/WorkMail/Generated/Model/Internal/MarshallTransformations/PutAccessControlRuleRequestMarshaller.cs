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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.WorkMail.Model;
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
namespace Amazon.WorkMail.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutAccessControlRule Request Marshaller
    /// </summary>       
    public class PutAccessControlRuleRequestMarshaller : IMarshaller<IRequest, PutAccessControlRuleRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutAccessControlRuleRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutAccessControlRuleRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.WorkMail");
            string target = "WorkMailService.PutAccessControlRule";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-10-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetActions())
            {
                context.Writer.WritePropertyName("Actions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestActionsListValue in publicRequest.Actions)
                {
                        context.Writer.WriteStringValue(publicRequestActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetEffect())
            {
                context.Writer.WritePropertyName("Effect");
                context.Writer.WriteStringValue(publicRequest.Effect);
            }

            if(publicRequest.IsSetImpersonationRoleIds())
            {
                context.Writer.WritePropertyName("ImpersonationRoleIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestImpersonationRoleIdsListValue in publicRequest.ImpersonationRoleIds)
                {
                        context.Writer.WriteStringValue(publicRequestImpersonationRoleIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIpRanges())
            {
                context.Writer.WritePropertyName("IpRanges");
                context.Writer.WriteStartArray();
                foreach(var publicRequestIpRangesListValue in publicRequest.IpRanges)
                {
                        context.Writer.WriteStringValue(publicRequestIpRangesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(publicRequest.Name);
            }

            if(publicRequest.IsSetNotActions())
            {
                context.Writer.WritePropertyName("NotActions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotActionsListValue in publicRequest.NotActions)
                {
                        context.Writer.WriteStringValue(publicRequestNotActionsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotImpersonationRoleIds())
            {
                context.Writer.WritePropertyName("NotImpersonationRoleIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotImpersonationRoleIdsListValue in publicRequest.NotImpersonationRoleIds)
                {
                        context.Writer.WriteStringValue(publicRequestNotImpersonationRoleIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotIpRanges())
            {
                context.Writer.WritePropertyName("NotIpRanges");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotIpRangesListValue in publicRequest.NotIpRanges)
                {
                        context.Writer.WriteStringValue(publicRequestNotIpRangesListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNotUserIds())
            {
                context.Writer.WritePropertyName("NotUserIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestNotUserIdsListValue in publicRequest.NotUserIds)
                {
                        context.Writer.WriteStringValue(publicRequestNotUserIdsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetOrganizationId())
            {
                context.Writer.WritePropertyName("OrganizationId");
                context.Writer.WriteStringValue(publicRequest.OrganizationId);
            }

            if(publicRequest.IsSetUserIds())
            {
                context.Writer.WritePropertyName("UserIds");
                context.Writer.WriteStartArray();
                foreach(var publicRequestUserIdsListValue in publicRequest.UserIds)
                {
                        context.Writer.WriteStringValue(publicRequestUserIdsListValue);
                }
                context.Writer.WriteEndArray();
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
        private static PutAccessControlRuleRequestMarshaller _instance = new PutAccessControlRuleRequestMarshaller();        

        internal static PutAccessControlRuleRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutAccessControlRuleRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}