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
    /// Decrypt Request Marshaller
    /// </summary>       
    public class DecryptRequestMarshaller : IMarshaller<IRequest, DecryptRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((DecryptRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(DecryptRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.Decrypt";
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

            if(publicRequest.IsSetDryRun())
            {
                context.Writer.WritePropertyName("DryRun");
                context.Writer.WriteBooleanValue(publicRequest.DryRun.Value);
            }

            if(publicRequest.IsSetEncryptionAlgorithm())
            {
                context.Writer.WritePropertyName("EncryptionAlgorithm");
                context.Writer.WriteStringValue(publicRequest.EncryptionAlgorithm);
            }

            if(publicRequest.IsSetEncryptionContext())
            {
                context.Writer.WritePropertyName("EncryptionContext");
                context.Writer.WriteStartObject();
                foreach (var publicRequestEncryptionContextKvp in publicRequest.EncryptionContext)
                {
                    context.Writer.WritePropertyName(publicRequestEncryptionContextKvp.Key);
                    var publicRequestEncryptionContextValue = publicRequestEncryptionContextKvp.Value;

                        context.Writer.WriteStringValue(publicRequestEncryptionContextValue);
                }
                context.Writer.WriteEndObject();
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

            if(publicRequest.IsSetKeyId())
            {
                context.Writer.WritePropertyName("KeyId");
                context.Writer.WriteStringValue(publicRequest.KeyId);
            }

            if(publicRequest.IsSetRecipient())
            {
                context.Writer.WritePropertyName("Recipient");
                context.Writer.WriteStartObject();

                var marshaller = RecipientInfoMarshaller.Instance;
                marshaller.Marshall(publicRequest.Recipient, context);

                context.Writer.WriteEndObject();
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
        private static DecryptRequestMarshaller _instance = new DecryptRequestMarshaller();        

        internal static DecryptRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DecryptRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}