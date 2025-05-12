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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.CertificateManager.Model;
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
namespace Amazon.CertificateManager.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RequestCertificate Request Marshaller
    /// </summary>       
    public class RequestCertificateRequestMarshaller : IMarshaller<IRequest, RequestCertificateRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RequestCertificateRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RequestCertificateRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.CertificateManager");
            string target = "CertificateManager.RequestCertificate";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-12-08";
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
            if(publicRequest.IsSetCertificateAuthorityArn())
            {
                context.Writer.WritePropertyName("CertificateAuthorityArn");
                context.Writer.WriteStringValue(publicRequest.CertificateAuthorityArn);
            }

            if(publicRequest.IsSetDomainName())
            {
                context.Writer.WritePropertyName("DomainName");
                context.Writer.WriteStringValue(publicRequest.DomainName);
            }

            if(publicRequest.IsSetDomainValidationOptions())
            {
                context.Writer.WritePropertyName("DomainValidationOptions");
                context.Writer.WriteStartArray();
                foreach(var publicRequestDomainValidationOptionsListValue in publicRequest.DomainValidationOptions)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = DomainValidationOptionMarshaller.Instance;
                    marshaller.Marshall(publicRequestDomainValidationOptionsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetIdempotencyToken())
            {
                context.Writer.WritePropertyName("IdempotencyToken");
                context.Writer.WriteStringValue(publicRequest.IdempotencyToken);
            }

            if(publicRequest.IsSetKeyAlgorithm())
            {
                context.Writer.WritePropertyName("KeyAlgorithm");
                context.Writer.WriteStringValue(publicRequest.KeyAlgorithm);
            }

            if(publicRequest.IsSetManagedBy())
            {
                context.Writer.WritePropertyName("ManagedBy");
                context.Writer.WriteStringValue(publicRequest.ManagedBy);
            }

            if(publicRequest.IsSetOptions())
            {
                context.Writer.WritePropertyName("Options");
                context.Writer.WriteStartObject();

                var marshaller = CertificateOptionsMarshaller.Instance;
                marshaller.Marshall(publicRequest.Options, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetSubjectAlternativeNames())
            {
                context.Writer.WritePropertyName("SubjectAlternativeNames");
                context.Writer.WriteStartArray();
                foreach(var publicRequestSubjectAlternativeNamesListValue in publicRequest.SubjectAlternativeNames)
                {
                        context.Writer.WriteStringValue(publicRequestSubjectAlternativeNamesListValue);
                }
                context.Writer.WriteEndArray();
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

            if(publicRequest.IsSetValidationMethod())
            {
                context.Writer.WritePropertyName("ValidationMethod");
                context.Writer.WriteStringValue(publicRequest.ValidationMethod);
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
        private static RequestCertificateRequestMarshaller _instance = new RequestCertificateRequestMarshaller();        

        internal static RequestCertificateRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RequestCertificateRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}