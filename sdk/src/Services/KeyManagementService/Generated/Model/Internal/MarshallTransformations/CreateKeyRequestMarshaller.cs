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
    /// CreateKey Request Marshaller
    /// </summary>       
    public class CreateKeyRequestMarshaller : IMarshaller<IRequest, CreateKeyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateKeyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateKeyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.CreateKey";
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
            if(publicRequest.IsSetBypassPolicyLockoutSafetyCheck())
            {
                context.Writer.WritePropertyName("BypassPolicyLockoutSafetyCheck");
                context.Writer.WriteBooleanValue(publicRequest.BypassPolicyLockoutSafetyCheck.Value);
            }

            if(publicRequest.IsSetCustomerMasterKeySpec())
            {
                context.Writer.WritePropertyName("CustomerMasterKeySpec");
                context.Writer.WriteStringValue(publicRequest.CustomerMasterKeySpec);
            }

            if(publicRequest.IsSetCustomKeyStoreId())
            {
                context.Writer.WritePropertyName("CustomKeyStoreId");
                context.Writer.WriteStringValue(publicRequest.CustomKeyStoreId);
            }

            if(publicRequest.IsSetDescription())
            {
                context.Writer.WritePropertyName("Description");
                context.Writer.WriteStringValue(publicRequest.Description);
            }

            if(publicRequest.IsSetKeySpec())
            {
                context.Writer.WritePropertyName("KeySpec");
                context.Writer.WriteStringValue(publicRequest.KeySpec);
            }

            if(publicRequest.IsSetKeyUsage())
            {
                context.Writer.WritePropertyName("KeyUsage");
                context.Writer.WriteStringValue(publicRequest.KeyUsage);
            }

            if(publicRequest.IsSetMultiRegion())
            {
                context.Writer.WritePropertyName("MultiRegion");
                context.Writer.WriteBooleanValue(publicRequest.MultiRegion.Value);
            }

            if(publicRequest.IsSetOrigin())
            {
                context.Writer.WritePropertyName("Origin");
                context.Writer.WriteStringValue(publicRequest.Origin);
            }

            if(publicRequest.IsSetPolicy())
            {
                context.Writer.WritePropertyName("Policy");
                context.Writer.WriteStringValue(publicRequest.Policy);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("Tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetXksKeyId())
            {
                context.Writer.WritePropertyName("XksKeyId");
                context.Writer.WriteStringValue(publicRequest.XksKeyId);
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
        private static CreateKeyRequestMarshaller _instance = new CreateKeyRequestMarshaller();        

        internal static CreateKeyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateKeyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}