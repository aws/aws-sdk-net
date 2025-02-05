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
    /// TranslatePinData Request Marshaller
    /// </summary>       
    public class TranslatePinDataRequestMarshaller : IMarshaller<IRequest, TranslatePinDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((TranslatePinDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(TranslatePinDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/pindata/translate";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetEncryptedPinBlock())
            {
                context.Writer.WritePropertyName("EncryptedPinBlock");
                context.Writer.WriteStringValue(publicRequest.EncryptedPinBlock);
            }

            if(publicRequest.IsSetIncomingDukptAttributes())
            {
                context.Writer.WritePropertyName("IncomingDukptAttributes");
                context.Writer.WriteStartObject();

                var marshaller = DukptDerivationAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.IncomingDukptAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIncomingKeyIdentifier())
            {
                context.Writer.WritePropertyName("IncomingKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.IncomingKeyIdentifier);
            }

            if(publicRequest.IsSetIncomingTranslationAttributes())
            {
                context.Writer.WritePropertyName("IncomingTranslationAttributes");
                context.Writer.WriteStartObject();

                var marshaller = TranslationIsoFormatsMarshaller.Instance;
                marshaller.Marshall(publicRequest.IncomingTranslationAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetIncomingWrappedKey())
            {
                context.Writer.WritePropertyName("IncomingWrappedKey");
                context.Writer.WriteStartObject();

                var marshaller = WrappedKeyMarshaller.Instance;
                marshaller.Marshall(publicRequest.IncomingWrappedKey, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutgoingDukptAttributes())
            {
                context.Writer.WritePropertyName("OutgoingDukptAttributes");
                context.Writer.WriteStartObject();

                var marshaller = DukptDerivationAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutgoingDukptAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutgoingKeyIdentifier())
            {
                context.Writer.WritePropertyName("OutgoingKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.OutgoingKeyIdentifier);
            }

            if(publicRequest.IsSetOutgoingTranslationAttributes())
            {
                context.Writer.WritePropertyName("OutgoingTranslationAttributes");
                context.Writer.WriteStartObject();

                var marshaller = TranslationIsoFormatsMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutgoingTranslationAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutgoingWrappedKey())
            {
                context.Writer.WritePropertyName("OutgoingWrappedKey");
                context.Writer.WriteStartObject();

                var marshaller = WrappedKeyMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutgoingWrappedKey, context);

                context.Writer.WriteEndObject();
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
        private static TranslatePinDataRequestMarshaller _instance = new TranslatePinDataRequestMarshaller();        

        internal static TranslatePinDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TranslatePinDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}