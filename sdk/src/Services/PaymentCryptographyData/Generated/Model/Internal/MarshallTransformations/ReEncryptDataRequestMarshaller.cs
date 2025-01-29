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
    /// ReEncryptData Request Marshaller
    /// </summary>       
    public class ReEncryptDataRequestMarshaller : IMarshaller<IRequest, ReEncryptDataRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((ReEncryptDataRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(ReEncryptDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetIncomingKeyIdentifier())
                throw new AmazonPaymentCryptographyDataException("Request object does not have required field IncomingKeyIdentifier set");
            request.AddPathResource("{IncomingKeyIdentifier}", StringUtils.FromString(publicRequest.IncomingKeyIdentifier));
            request.ResourcePath = "/keys/{IncomingKeyIdentifier}/reencrypt";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCipherText())
            {
                context.Writer.WritePropertyName("CipherText");
                context.Writer.WriteStringValue(publicRequest.CipherText);
            }

            if(publicRequest.IsSetIncomingEncryptionAttributes())
            {
                context.Writer.WritePropertyName("IncomingEncryptionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = ReEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.IncomingEncryptionAttributes, context);

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

            if(publicRequest.IsSetOutgoingEncryptionAttributes())
            {
                context.Writer.WritePropertyName("OutgoingEncryptionAttributes");
                context.Writer.WriteStartObject();

                var marshaller = ReEncryptionAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.OutgoingEncryptionAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOutgoingKeyIdentifier())
            {
                context.Writer.WritePropertyName("OutgoingKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.OutgoingKeyIdentifier);
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
        private static ReEncryptDataRequestMarshaller _instance = new ReEncryptDataRequestMarshaller();        

        internal static ReEncryptDataRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ReEncryptDataRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}