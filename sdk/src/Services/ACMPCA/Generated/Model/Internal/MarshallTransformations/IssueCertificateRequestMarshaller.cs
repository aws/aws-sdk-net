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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ACMPCA.Model;
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
namespace Amazon.ACMPCA.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// IssueCertificate Request Marshaller
    /// </summary>       
    public class IssueCertificateRequestMarshaller : IMarshaller<IRequest, IssueCertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((IssueCertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(IssueCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ACMPCA");
            string target = "ACMPrivateCA.IssueCertificate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2017-08-22";
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
            if(publicRequest.IsSetApiPassthrough())
            {
                context.Writer.WritePropertyName("ApiPassthrough");
                context.Writer.WriteStartObject();

                var marshaller = ApiPassthroughMarshaller.Instance;
                marshaller.Marshall(publicRequest.ApiPassthrough, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetCertificateAuthorityArn())
            {
                context.Writer.WritePropertyName("CertificateAuthorityArn");
                context.Writer.WriteStringValue(publicRequest.CertificateAuthorityArn);
            }

            if(publicRequest.IsSetCsr())
            {
                context.Writer.WritePropertyName("Csr");
                context.Writer.WriteStringValue(StringUtils.FromMemoryStream(publicRequest.Csr));
            }

            if(publicRequest.IsSetIdempotencyToken())
            {
                context.Writer.WritePropertyName("IdempotencyToken");
                context.Writer.WriteStringValue(publicRequest.IdempotencyToken);
            }

            if(publicRequest.IsSetSigningAlgorithm())
            {
                context.Writer.WritePropertyName("SigningAlgorithm");
                context.Writer.WriteStringValue(publicRequest.SigningAlgorithm);
            }

            if(publicRequest.IsSetTemplateArn())
            {
                context.Writer.WritePropertyName("TemplateArn");
                context.Writer.WriteStringValue(publicRequest.TemplateArn);
            }

            if(publicRequest.IsSetValidity())
            {
                context.Writer.WritePropertyName("Validity");
                context.Writer.WriteStartObject();

                var marshaller = ValidityMarshaller.Instance;
                marshaller.Marshall(publicRequest.Validity, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetValidityNotBefore())
            {
                context.Writer.WritePropertyName("ValidityNotBefore");
                context.Writer.WriteStartObject();

                var marshaller = ValidityMarshaller.Instance;
                marshaller.Marshall(publicRequest.ValidityNotBefore, context);

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
        private static IssueCertificateRequestMarshaller _instance = new IssueCertificateRequestMarshaller();        

        internal static IssueCertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static IssueCertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}