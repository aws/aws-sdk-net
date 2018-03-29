/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Route53Domains.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Route53Domains.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterDomain Request Marshaller
    /// </summary>       
    public class RegisterDomainRequestMarshaller : IMarshaller<IRequest, RegisterDomainRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterDomainRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterDomainRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Route53Domains");
            string target = "Route53Domains_v20140515.RegisterDomain";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAdminContact())
                {
                    context.Writer.WritePropertyName("AdminContact");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AdminContact, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetAutoRenew())
                {
                    context.Writer.WritePropertyName("AutoRenew");
                    context.Writer.Write(publicRequest.AutoRenew);
                }

                if(publicRequest.IsSetDomainName())
                {
                    context.Writer.WritePropertyName("DomainName");
                    context.Writer.Write(publicRequest.DomainName);
                }

                if(publicRequest.IsSetDurationInYears())
                {
                    context.Writer.WritePropertyName("DurationInYears");
                    context.Writer.Write(publicRequest.DurationInYears);
                }

                if(publicRequest.IsSetIdnLangCode())
                {
                    context.Writer.WritePropertyName("IdnLangCode");
                    context.Writer.Write(publicRequest.IdnLangCode);
                }

                if(publicRequest.IsSetPrivacyProtectAdminContact())
                {
                    context.Writer.WritePropertyName("PrivacyProtectAdminContact");
                    context.Writer.Write(publicRequest.PrivacyProtectAdminContact);
                }

                if(publicRequest.IsSetPrivacyProtectRegistrantContact())
                {
                    context.Writer.WritePropertyName("PrivacyProtectRegistrantContact");
                    context.Writer.Write(publicRequest.PrivacyProtectRegistrantContact);
                }

                if(publicRequest.IsSetPrivacyProtectTechContact())
                {
                    context.Writer.WritePropertyName("PrivacyProtectTechContact");
                    context.Writer.Write(publicRequest.PrivacyProtectTechContact);
                }

                if(publicRequest.IsSetRegistrantContact())
                {
                    context.Writer.WritePropertyName("RegistrantContact");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.RegistrantContact, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTechContact())
                {
                    context.Writer.WritePropertyName("TechContact");
                    context.Writer.WriteObjectStart();

                    var marshaller = ContactDetailMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TechContact, context);

                    context.Writer.WriteObjectEnd();
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterDomainRequestMarshaller _instance = new RegisterDomainRequestMarshaller();        

        internal static RegisterDomainRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterDomainRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}