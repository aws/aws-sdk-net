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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.IO;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
using System.Buffers;

using Amazon.PaymentCryptographyData.Model;
using System.Globalization;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618

namespace Amazon.PaymentCryptographyData.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// GeneratePinData Request Marshaller
    /// </summary>
    public partial class GeneratePinDataRequestMarshaller : IMarshaller<IRequest, GeneratePinDataRequest>, IMarshaller<IRequest, AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((GeneratePinDataRequest)input);
        }

        /// <summary>
        /// Marshall the request object to the HTTP request.
        /// </summary>
        public IRequest Marshall(GeneratePinDataRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.PaymentCryptographyData");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2022-02-03";
            request.HttpMethod = "POST";

            request.ResourcePath = "/pindata/generate";
#if !NETFRAMEWORK
            request.ContentStream = new PooledContentStream();
            using var writer = new Utf8JsonWriter(((PooledContentStream)request.ContentStream).BufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using var writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if (publicRequest.IsSetEncryptionKeyIdentifier())
            {
                context.Writer.WritePropertyName("EncryptionKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.EncryptionKeyIdentifier);
            }
            if (publicRequest.IsSetEncryptionWrappedKey())
            {
                context.Writer.WritePropertyName("EncryptionWrappedKey");
                context.Writer.WriteStartObject();

                var marshaller = WrappedKeyMarshaller.Instance;
                marshaller.Marshall(publicRequest.EncryptionWrappedKey, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetGenerationAttributes())
            {
                context.Writer.WritePropertyName("GenerationAttributes");
                context.Writer.WriteStartObject();

                var marshaller = PinGenerationAttributesMarshaller.Instance;
                marshaller.Marshall(publicRequest.GenerationAttributes, context);

                context.Writer.WriteEndObject();
            }
            if (publicRequest.IsSetGenerationKeyIdentifier())
            {
                context.Writer.WritePropertyName("GenerationKeyIdentifier");
                context.Writer.WriteStringValue(publicRequest.GenerationKeyIdentifier);
            }
            if (publicRequest.IsSetPinBlockFormat())
            {
                context.Writer.WritePropertyName("PinBlockFormat");
                context.Writer.WriteStringValue(publicRequest.PinBlockFormat);
            }
            if (publicRequest.IsSetPinDataLength())
            {
                context.Writer.WritePropertyName("PinDataLength");
                context.Writer.WriteNumberValue(publicRequest.PinDataLength.Value);
            }
            if (publicRequest.IsSetPrimaryAccountNumber())
            {
                context.Writer.WritePropertyName("PrimaryAccountNumber");
                context.Writer.WriteStringValue(publicRequest.PrimaryAccountNumber);
            }

            writer.WriteEndObject();
            writer.Flush();
#if NETFRAMEWORK
            request.Content = memoryStream.ToArray();
#endif

            return request;
        }

        private static readonly GeneratePinDataRequestMarshaller _instance = new();

        internal static GeneratePinDataRequestMarshaller GetInstance() => _instance;

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static GeneratePinDataRequestMarshaller Instance => _instance;
    }
}
