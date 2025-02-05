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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Omics.Model;
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
namespace Amazon.Omics.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutS3AccessPolicy Request Marshaller
    /// </summary>       
    public class PutS3AccessPolicyRequestMarshaller : IMarshaller<IRequest, PutS3AccessPolicyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutS3AccessPolicyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutS3AccessPolicyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Omics");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-11-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetS3AccessPointArn())
                throw new AmazonOmicsException("Request object does not have required field S3AccessPointArn set");
            request.AddPathResource("{s3AccessPointArn}", StringUtils.FromString(publicRequest.S3AccessPointArn));
            request.ResourcePath = "/s3accesspolicy/{s3AccessPointArn}";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetS3AccessPolicy())
            {
                context.Writer.WritePropertyName("s3AccessPolicy");
                context.Writer.WriteStringValue(publicRequest.S3AccessPolicy);
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            

            
            request.HostPrefix = $"control-storage-";

            return request;
        }
        private static PutS3AccessPolicyRequestMarshaller _instance = new PutS3AccessPolicyRequestMarshaller();        

        internal static PutS3AccessPolicyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutS3AccessPolicyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}