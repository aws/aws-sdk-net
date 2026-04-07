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
 * Do not modify this file. This file is generated from the s3files-2025-05-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.S3Files.Model;
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
namespace Amazon.S3Files.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateMountTarget Request Marshaller
    /// </summary>       
    public class CreateMountTargetRequestMarshaller : IMarshaller<IRequest, CreateMountTargetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateMountTargetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateMountTargetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.S3Files");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2025-05-05";
            request.HttpMethod = "PUT";

            request.ResourcePath = "/mount-targets";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetFileSystemId())
            {
                context.Writer.WritePropertyName("fileSystemId");
                context.Writer.WriteStringValue(publicRequest.FileSystemId);
            }

            if(publicRequest.IsSetIpAddressType())
            {
                context.Writer.WritePropertyName("ipAddressType");
                context.Writer.WriteStringValue(publicRequest.IpAddressType);
            }

            if(publicRequest.IsSetIpv4Address())
            {
                context.Writer.WritePropertyName("ipv4Address");
                context.Writer.WriteStringValue(publicRequest.Ipv4Address);
            }

            if(publicRequest.IsSetIpv6Address())
            {
                context.Writer.WritePropertyName("ipv6Address");
                context.Writer.WriteStringValue(publicRequest.Ipv6Address);
            }

            if(publicRequest.IsSetSecurityGroups())
            {
                context.Writer.WritePropertyName("securityGroups");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSecurityGroupsListValue in publicRequest.SecurityGroups)
                {
                        context.Writer.WriteStringValue(publicRequestSecurityGroupsListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSubnetId())
            {
                context.Writer.WritePropertyName("subnetId");
                context.Writer.WriteStringValue(publicRequest.SubnetId);
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
        private static CreateMountTargetRequestMarshaller _instance = new CreateMountTargetRequestMarshaller();        

        internal static CreateMountTargetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateMountTargetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}