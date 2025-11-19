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
using ThirdParty.Json.LitJson;

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
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificateArn())
                {
                    context.Writer.WritePropertyName("certificateArn");
                    context.Writer.Write(publicRequest.CertificateArn);
                }

                if(publicRequest.IsSetCertificateBody())
                {
                    context.Writer.WritePropertyName("certificateBody");
                    context.Writer.Write(publicRequest.CertificateBody);
                }

                if(publicRequest.IsSetCertificateChain())
                {
                    context.Writer.WritePropertyName("certificateChain");
                    context.Writer.Write(publicRequest.CertificateChain);
                }

                if(publicRequest.IsSetCertificateName())
                {
                    context.Writer.WritePropertyName("certificateName");
                    context.Writer.Write(publicRequest.CertificateName);
                }

                if(publicRequest.IsSetCertificatePrivateKey())
                {
                    context.Writer.WritePropertyName("certificatePrivateKey");
                    context.Writer.Write(publicRequest.CertificatePrivateKey);
                }

                if(publicRequest.IsSetDomainName())
                {
                    context.Writer.WritePropertyName("domainName");
                    context.Writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetEndpointAccessMode())
                {
                    context.Writer.WritePropertyName("endpointAccessMode");
                    context.Writer.Write(publicRequest.EndpointAccessMode);
                }

                if(publicRequest.IsSetEndpointConfiguration())
                {
                    context.Writer.WritePropertyName("endpointConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = EndpointConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.EndpointConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetMutualTlsAuthentication())
                {
                    context.Writer.WritePropertyName("mutualTlsAuthentication");
                    context.Writer.WriteObjectStart();

                    var marshaller = MutualTlsAuthenticationInputMarshaller.Instance;
                    marshaller.Marshall(publicRequest.MutualTlsAuthentication, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetOwnershipVerificationCertificateArn())
                {
                    context.Writer.WritePropertyName("ownershipVerificationCertificateArn");
                    context.Writer.Write(publicRequest.OwnershipVerificationCertificateArn);
                }

                if(publicRequest.IsSetPolicy())
                {
                    context.Writer.WritePropertyName("policy");
                    context.Writer.Write(publicRequest.Policy);
                }

                if(publicRequest.IsSetRegionalCertificateArn())
                {
                    context.Writer.WritePropertyName("regionalCertificateArn");
                    context.Writer.Write(publicRequest.RegionalCertificateArn);
                }

                if(publicRequest.IsSetRegionalCertificateName())
                {
                    context.Writer.WritePropertyName("regionalCertificateName");
                    context.Writer.Write(publicRequest.RegionalCertificateName);
                }

                if(publicRequest.IsSetRoutingMode())
                {
                    context.Writer.WritePropertyName("routingMode");
                    context.Writer.Write(publicRequest.RoutingMode);
                }

                if(publicRequest.IsSetSecurityPolicy())
                {
                    context.Writer.WritePropertyName("securityPolicy");
                    context.Writer.Write(publicRequest.SecurityPolicy);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteObjectStart();
                    foreach (var publicRequestTagsKvp in publicRequest.Tags)
                    {
                        context.Writer.WritePropertyName(publicRequestTagsKvp.Key);
                        var publicRequestTagsValue = publicRequestTagsKvp.Value;

                            context.Writer.Write(publicRequestTagsValue);
                    }
                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


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