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
    /// GenerateMacEmvPinChange Request Marshaller
    /// </summary>       
    public class GenerateMacEmvPinChangeRequestMarshaller : IMarshaller<IRequest, GenerateMacEmvPinChangeRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GenerateMacEmvPinChangeRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(GenerateMacEmvPinChangeRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/macemvpinchange/generate";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetDerivationMethodAttributes())
            {
                context.Writer.WritePropertyName("DerivationMethodAttributes");
                context.Writer.WriteStartObject();

                var marshaller = DerivationMethodAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.DerivationMethodAttributes, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMessageData())
            {
                context.Writer.WritePropertyName("MessageData");
                context.Writer.WriteStringValue(publicRequest.MessageData);
            }

            if(publicRequest.IsSetNewEncryptedPinBlock())
            {
                context.Writer.WritePropertyName("NewEncryptedPinBlock");
                context.Writer.WriteStringValue(publicRequest.NewEncryptedPinBlock);
            }

            if(publicRequest.IsSetNewPinPekIdentifier())
            {
                context.Writer.WritePropertyName("NewPinPekIdentifier");
                context.Writer.WriteStringValue(publicRequest.NewPinPekIdentifier);
            }

            if(publicRequest.IsSetPinBlockFormat())
            {
                context.Writer.WritePropertyName("PinBlockFormat");
                context.Writer.WriteStringValue(publicRequest.PinBlockFormat);
            }

            if(publicRequest.IsSetSecureMessagingConfidentialityKeyIdentifier())
            {
                context.Writer.WritePropertyName("SecureMessagingConfidentialityKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.SecureMessagingConfidentialityKeyIdentifier);
            }

            if(publicRequest.IsSetSecureMessagingIntegrityKeyIdentifier())
            {
                context.Writer.WritePropertyName("SecureMessagingIntegrityKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.SecureMessagingIntegrityKeyIdentifier);
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
        private static GenerateMacEmvPinChangeRequestMarshaller _instance = new GenerateMacEmvPinChangeRequestMarshaller();        

        internal static GenerateMacEmvPinChangeRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static GenerateMacEmvPinChangeRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}