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
 * Do not modify this file. This file is generated from the transfer-2018-11-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Transfer.Model;
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
namespace Amazon.Transfer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateAccess Request Marshaller
    /// </summary>       
    public class UpdateAccessRequestMarshaller : IMarshaller<IRequest, UpdateAccessRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateAccessRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateAccessRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Transfer");
            string target = "TransferService.UpdateAccess";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-11-05";
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
            if(publicRequest.IsSetExternalId())
            {
                context.Writer.WritePropertyName("ExternalId");
                context.Writer.WriteStringValue(publicRequest.ExternalId);
            }

            if(publicRequest.IsSetHomeDirectory())
            {
                context.Writer.WritePropertyName("HomeDirectory");
                context.Writer.WriteStringValue(publicRequest.HomeDirectory);
            }

            if(publicRequest.IsSetHomeDirectoryMappings())
            {
                context.Writer.WritePropertyName("HomeDirectoryMappings");
                context.Writer.WriteStartArray();
                foreach(var publicRequestHomeDirectoryMappingsListValue in publicRequest.HomeDirectoryMappings)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = HomeDirectoryMapEntryMarshaller.Instance;
                    marshaller.Marshall(publicRequestHomeDirectoryMappingsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetHomeDirectoryType())
            {
                context.Writer.WritePropertyName("HomeDirectoryType");
                context.Writer.WriteStringValue(publicRequest.HomeDirectoryType);
            }

            if(publicRequest.IsSetPolicy())
            {
                context.Writer.WritePropertyName("Policy");
                context.Writer.WriteStringValue(publicRequest.Policy);
            }

            if(publicRequest.IsSetPosixProfile())
            {
                context.Writer.WritePropertyName("PosixProfile");
                context.Writer.WriteStartObject();

                var marshaller = PosixProfileMarshaller.Instance;
                marshaller.Marshall(publicRequest.PosixProfile, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetServerId())
            {
                context.Writer.WritePropertyName("ServerId");
                context.Writer.WriteStringValue(publicRequest.ServerId);
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
        private static UpdateAccessRequestMarshaller _instance = new UpdateAccessRequestMarshaller();        

        internal static UpdateAccessRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateAccessRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}