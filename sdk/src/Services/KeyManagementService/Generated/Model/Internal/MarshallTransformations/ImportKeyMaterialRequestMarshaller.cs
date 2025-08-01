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
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ImportKeyMaterial Request Marshaller
    /// </summary>       
    public class ImportKeyMaterialRequestMarshaller : IMarshaller<IRequest, ImportKeyMaterialRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ImportKeyMaterialRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ImportKeyMaterialRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.ImportKeyMaterial";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-01";
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
            if(publicRequest.IsSetEncryptedKeyMaterial())
            {
                context.Writer.WritePropertyName("EncryptedKeyMaterial");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.EncryptedKeyMaterial));
            }

            if(publicRequest.IsSetExpirationModel())
            {
                context.Writer.WritePropertyName("ExpirationModel");
                context.Writer.WriteStringValue(publicRequest.ExpirationModel);
            }

            if(publicRequest.IsSetImportToken())
            {
                context.Writer.WritePropertyName("ImportToken");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.ImportToken));
            }

            if(publicRequest.IsSetImportType())
            {
                context.Writer.WritePropertyName("ImportType");
                context.Writer.WriteStringValue(publicRequest.ImportType);
            }

            if(publicRequest.IsSetKeyId())
            {
                context.Writer.WritePropertyName("KeyId");
                context.Writer.WriteStringValue(publicRequest.KeyId);
            }

            if(publicRequest.IsSetKeyMaterialDescription())
            {
                context.Writer.WritePropertyName("KeyMaterialDescription");
                context.Writer.WriteStringValue(publicRequest.KeyMaterialDescription);
            }

            if(publicRequest.IsSetKeyMaterialId())
            {
                context.Writer.WritePropertyName("KeyMaterialId");
                context.Writer.WriteStringValue(publicRequest.KeyMaterialId);
            }

            if(publicRequest.IsSetValidTo())
            {
                context.Writer.WritePropertyName("ValidTo");
                context.Writer.WriteNumberValue(Convert.ToInt64(StringUtils.FromDateTimeToUnixTimestamp(publicRequest.ValidTo.Value)));
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
        private static ImportKeyMaterialRequestMarshaller _instance = new ImportKeyMaterialRequestMarshaller();        

        internal static ImportKeyMaterialRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ImportKeyMaterialRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}