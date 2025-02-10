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
 * Do not modify this file. This file is generated from the ecr-public-2020-10-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECRPublic.Model;
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
namespace Amazon.ECRPublic.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// PutImage Request Marshaller
    /// </summary>       
    public class PutImageRequestMarshaller : IMarshaller<IRequest, PutImageRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((PutImageRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(PutImageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECRPublic");
            string target = "SpencerFrontendService.PutImage";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-10-30";
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
            if(publicRequest.IsSetImageDigest())
            {
                context.Writer.WritePropertyName("imageDigest");
                context.Writer.WriteStringValue(publicRequest.ImageDigest);
            }

            if(publicRequest.IsSetImageManifest())
            {
                context.Writer.WritePropertyName("imageManifest");
                context.Writer.WriteStringValue(publicRequest.ImageManifest);
            }

            if(publicRequest.IsSetImageManifestMediaType())
            {
                context.Writer.WritePropertyName("imageManifestMediaType");
                context.Writer.WriteStringValue(publicRequest.ImageManifestMediaType);
            }

            if(publicRequest.IsSetImageTag())
            {
                context.Writer.WritePropertyName("imageTag");
                context.Writer.WriteStringValue(publicRequest.ImageTag);
            }

            if(publicRequest.IsSetRegistryId())
            {
                context.Writer.WritePropertyName("registryId");
                context.Writer.WriteStringValue(publicRequest.RegistryId);
            }

            if(publicRequest.IsSetRepositoryName())
            {
                context.Writer.WritePropertyName("repositoryName");
                context.Writer.WriteStringValue(publicRequest.RepositoryName);
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
        private static PutImageRequestMarshaller _instance = new PutImageRequestMarshaller();        

        internal static PutImageRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PutImageRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}