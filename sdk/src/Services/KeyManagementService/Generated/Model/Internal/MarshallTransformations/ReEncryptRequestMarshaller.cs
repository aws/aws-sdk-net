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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;
#pragma warning disable CS0612,CS0618
namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReEncrypt Request Marshaller
    /// </summary>       
    public class ReEncryptRequestMarshaller : IMarshaller<IRequest, ReEncryptRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReEncryptRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReEncryptRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.ReEncrypt";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if NETCOREAPP3_1_OR_GREATER
            ArrayBufferWriter<byte> arrayBufferWriter = new ArrayBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCiphertextBlob())
            {
                context.Writer.WritePropertyName("CiphertextBlob");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.CiphertextBlob));
            }

            if(publicRequest.IsSetDestinationEncryptionAlgorithm())
            {
                context.Writer.WritePropertyName("DestinationEncryptionAlgorithm");
                context.Writer.WriteStringValue(publicRequest.DestinationEncryptionAlgorithm);
            }

            if(publicRequest.IsSetDestinationEncryptionContext())
            {
                context.Writer.WritePropertyName("DestinationEncryptionContext");
                context.Writer.WriteStartObject();
                foreach (var publicRequestDestinationEncryptionContextKvp in publicRequest.DestinationEncryptionContext)
                {
                    context.Writer.WritePropertyName(publicRequestDestinationEncryptionContextKvp.Key);
                    var publicRequestDestinationEncryptionContextValue = publicRequestDestinationEncryptionContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestDestinationEncryptionContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDestinationKeyId())
            {
                context.Writer.WritePropertyName("DestinationKeyId");
                context.Writer.WriteStringValue(publicRequest.DestinationKeyId);
            }

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetGrantTokens())
            {
                context.Writer.WritePropertyName("GrantTokens");
                context.Writer.WriteStartArray();
                foreach(var publicRequestGrantTokensListValue in publicRequest.GrantTokens)
                {
                        context.Writer.WriteStringValue(publicRequestGrantTokensListValue);
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetSourceEncryptionAlgorithm())
            {
                context.Writer.WritePropertyName("SourceEncryptionAlgorithm");
                context.Writer.WriteStringValue(publicRequest.SourceEncryptionAlgorithm);
            }

            if(publicRequest.IsSetSourceEncryptionContext())
            {
                context.Writer.WritePropertyName("SourceEncryptionContext");
                context.Writer.WriteStartObject();
                foreach (var publicRequestSourceEncryptionContextKvp in publicRequest.SourceEncryptionContext)
                {
                    context.Writer.WritePropertyName(publicRequestSourceEncryptionContextKvp.Key);
                    var publicRequestSourceEncryptionContextValue = publicRequestSourceEncryptionContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestSourceEncryptionContextValue);
                }
                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSourceKeyId())
            {
                context.Writer.WritePropertyName("SourceKeyId");
                context.Writer.WriteStringValue(publicRequest.SourceKeyId);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETCOREAPP3_1_OR_GREATER
            request.Content = arrayBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


            return request;
        }
        private static ReEncryptRequestMarshaller _instance = new ReEncryptRequestMarshaller();        

        internal static ReEncryptRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReEncryptRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}