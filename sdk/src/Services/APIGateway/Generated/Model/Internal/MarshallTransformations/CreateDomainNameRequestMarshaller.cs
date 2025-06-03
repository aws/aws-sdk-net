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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.APIGateway.Model;
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
namespace Amazon.APIGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateDomainName Request Marshaller
    /// </summary>       
    public class CreateDomainNameRequestMarshaller : IMarshaller<IRequest, CreateDomainNameRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateDomainNameRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateDomainNameRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.APIGateway");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-07-09";
            request.HttpMethod = "POST";

            request.ResourcePath = "/domainnames";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetCertificateArn())
            {
                context.Writer.WritePropertyName("certificateArn");
                context.Writer.WriteStringValue(publicRequest.CertificateArn);
            }

            if(publicRequest.IsSetCertificateBody())
            {
                context.Writer.WritePropertyName("certificateBody");
                context.Writer.WriteStringValue(publicRequest.CertificateBody);
            }

            if(publicRequest.IsSetCertificateChain())
            {
                context.Writer.WritePropertyName("certificateChain");
                context.Writer.WriteStringValue(publicRequest.CertificateChain);
            }

            if(publicRequest.IsSetCertificateName())
            {
                context.Writer.WritePropertyName("certificateName");
                context.Writer.WriteStringValue(publicRequest.CertificateName);
            }

            if(publicRequest.IsSetCertificatePrivateKey())
            {
                context.Writer.WritePropertyName("certificatePrivateKey");
                context.Writer.WriteStringValue(publicRequest.CertificatePrivateKey);
            }

            if(publicRequest.IsSetDomainName())
            {
                context.Writer.WritePropertyName("domainName");
                context.Writer.WriteStringValue(publicRequest.DomainName);
            }

            if(publicRequest.IsSetEndpointConfiguration())
            {
                context.Writer.WritePropertyName("endpointConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = EndpointConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.EndpointConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetMutualTlsAuthentication())
            {
                context.Writer.WritePropertyName("mutualTlsAuthentication");
                context.Writer.WriteStartObject();

                var marshaller = MutualTlsAuthenticationInputMarshaller.Instance;
                marshaller.Marshall(publicRequest.MutualTlsAuthentication, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetOwnershipVerificationCertificateArn())
            {
                context.Writer.WritePropertyName("ownershipVerificationCertificateArn");
                context.Writer.WriteStringValue(publicRequest.OwnershipVerificationCertificateArn);
            }

            if(publicRequest.IsSetPolicy())
            {
                context.Writer.WritePropertyName("policy");
                context.Writer.WriteStringValue(publicRequest.Policy);
            }

            if(publicRequest.IsSetRegionalCertificateArn())
            {
                context.Writer.WritePropertyName("regionalCertificateArn");
                context.Writer.WriteStringValue(publicRequest.RegionalCertificateArn);
            }

            if(publicRequest.IsSetRegionalCertificateName())
            {
                context.Writer.WritePropertyName("regionalCertificateName");
                context.Writer.WriteStringValue(publicRequest.RegionalCertificateName);
            }

            if(publicRequest.IsSetRoutingMode())
            {
                context.Writer.WritePropertyName("routingMode");
                context.Writer.WriteStringValue(publicRequest.RoutingMode);
            }

            if(publicRequest.IsSetSecurityPolicy())
            {
                context.Writer.WritePropertyName("securityPolicy");
                context.Writer.WriteStringValue(publicRequest.SecurityPolicy);
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartObject();
                foreach (var publicRequestTagsKvp in publicRequest.Tags)
                {
                    context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                    var publicRequestTagsValue = publicRequestTagsKvp.Value;

                        context.Writer.WriteStringValue(publicRequestTagsValue);
                }
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
        private static CreateDomainNameRequestMarshaller _instance = new CreateDomainNameRequestMarshaller();        

        internal static CreateDomainNameRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateDomainNameRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}