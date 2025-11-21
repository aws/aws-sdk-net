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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.DirectoryService.Model;
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
namespace Amazon.DirectoryService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateTrust Request Marshaller
    /// </summary>       
    public class CreateTrustRequestMarshaller : IMarshaller<IRequest, CreateTrustRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTrustRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTrustRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.DirectoryService");
            string target = "DirectoryService_20150416.CreateTrust";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-04-16";
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
            if(publicRequest.IsSetConditionalForwarderIpAddrs())
            {
                context.Writer.WritePropertyName("ConditionalForwarderIpAddrs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestConditionalForwarderIpAddrsListValue in publicRequest.ConditionalForwarderIpAddrs)
                {
                        context.Writer.WriteStringValue(publicRequestConditionalForwarderIpAddrsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetConditionalForwarderIpv6Addrs())
            {
                context.Writer.WritePropertyName("ConditionalForwarderIpv6Addrs");
                context.Writer.WriteStartArray();
                foreach(var publicRequestConditionalForwarderIpv6AddrsListValue in publicRequest.ConditionalForwarderIpv6Addrs)
                {
                        context.Writer.WriteStringValue(publicRequestConditionalForwarderIpv6AddrsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetDirectoryId())
            {
                context.Writer.WritePropertyName("DirectoryId");
                context.Writer.WriteStringValue(publicRequest.DirectoryId);
            }

            if(publicRequest.IsSetRemoteDomainName())
            {
                context.Writer.WritePropertyName("RemoteDomainName");
                context.Writer.WriteStringValue(publicRequest.RemoteDomainName);
            }

            if(publicRequest.IsSetSelectiveAuth())
            {
                context.Writer.WritePropertyName("SelectiveAuth");
                context.Writer.WriteStringValue(publicRequest.SelectiveAuth);
            }

            if(publicRequest.IsSetTrustDirection())
            {
                context.Writer.WritePropertyName("TrustDirection");
                context.Writer.WriteStringValue(publicRequest.TrustDirection);
            }

            if(publicRequest.IsSetTrustPassword())
            {
                context.Writer.WritePropertyName("TrustPassword");
                context.Writer.WriteStringValue(publicRequest.TrustPassword);
            }

            if(publicRequest.IsSetTrustType())
            {
                context.Writer.WritePropertyName("TrustType");
                context.Writer.WriteStringValue(publicRequest.TrustType);
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
        private static CreateTrustRequestMarshaller _instance = new CreateTrustRequestMarshaller();        

        internal static CreateTrustRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTrustRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}