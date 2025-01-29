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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.PaymentCryptographyData.Model;
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
namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeneratePinData Request Marshaller
    /// </summary>       
    public class GeneratePinDataRequestMarshaller : IMarshaller<IRequest, GeneratePinDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GeneratePinDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GeneratePinDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/pindata/generate";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEncryptionKeyIdentifier())
            {
                context.Writer.WritePropertyName("EncryptionKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyIdentifier);
            }

            if(publicRequest.IsSetEncryptionWrappedKey())
            {
                context.Writer.WritePropertyName("EncryptionWrappedKey");
                context.Writer.WriteStartObject();

                var marshaller = WrappedKeyMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionWrappedKey, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGenerationAttributes())
            {
                context.Writer.WritePropertyName("GenerationAttributes");
                context.Writer.WriteStartObject();

                var marshaller = PinGenerationAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.GenerationAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetGenerationKeyIdentifier())
            {
                context.Writer.WritePropertyName("GenerationKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.GenerationKeyIdentifier);
            }

            if(publicRequest.IsSetPinBlockFormat())
            {
                context.Writer.WritePropertyName("PinBlockFormat");
                context.Writer.WriteStringValue(publicRequest.PinBlockFormat);
            }

            if(publicRequest.IsSetPinDataLength())
            {
                context.Writer.WritePropertyName("PinDataLength");
                context.Writer.WriteNumberValue(publicRequest.PinDataLength.Value);
            }

            if(publicRequest.IsSetPrimaryAccountNumber())
            {
                context.Writer.WritePropertyName("PrimaryAccountNumber");
                context.Writer.WriteStringValue(publicRequest.PrimaryAccountNumber);
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
        private static GeneratePinDataRequestMarshaller _instance = new GeneratePinDataRequestMarshaller();        

        internal static GeneratePinDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GeneratePinDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}