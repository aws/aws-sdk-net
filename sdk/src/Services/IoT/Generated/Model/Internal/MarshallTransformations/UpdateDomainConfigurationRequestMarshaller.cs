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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoT.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.IoT.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateDomainConfiguration Request Marshaller
    /// </summary>       
    public class UpdateDomainConfigurationRequestMarshaller : IMarshaller<IRequest, UpdateDomainConfigurationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateDomainConfigurationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateDomainConfigurationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.IoT");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2015-05-28";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetDomainConfigurationName())
                throw new AmazonIoTException("Request object does not have required field DomainConfigurationName set");
            request.AddPathResource("{domainConfigurationName}", StringUtils.FromString(publicRequest.DomainConfigurationName));
            request.ResourcePath = "/domainConfigurations/{domainConfigurationName}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthorizerConfig())
                {
                    context.Writer.WritePropertyName("authorizerConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = AuthorizerConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuthorizerConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDomainConfigurationStatus())
                {
                    context.Writer.WritePropertyName("domainConfigurationStatus");
                    context.Writer.Write(publicRequest.DomainConfigurationStatus);
                }

                if(publicRequest.IsSetRemoveAuthorizerConfig())
                {
                    context.Writer.WritePropertyName("removeAuthorizerConfig");
                    context.Writer.Write(publicRequest.RemoveAuthorizerConfig);
                }

                if(publicRequest.IsSetTlsConfig())
                {
                    context.Writer.WritePropertyName("tlsConfig");
                    context.Writer.WriteObjectStart();

                    var marshaller = TlsConfigMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TlsConfig, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateDomainConfigurationRequestMarshaller _instance = new UpdateDomainConfigurationRequestMarshaller();        

        internal static UpdateDomainConfigurationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateDomainConfigurationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}