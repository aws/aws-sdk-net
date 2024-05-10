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
 * Do not modify this file. This file is generated from the kms-2014-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.KeyManagementService.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.KeyManagementService.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCustomKeyStore Request Marshaller
    /// </summary>       
    public class CreateCustomKeyStoreRequestMarshaller : IMarshaller<IRequest, CreateCustomKeyStoreRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateCustomKeyStoreRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateCustomKeyStoreRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.KeyManagementService");
            string target = "TrentService.CreateCustomKeyStore";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-01";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCloudHsmClusterId())
                {
                    context.Writer.WritePropertyName("CloudHsmClusterId");
                    context.Writer.Write(publicRequest.CloudHsmClusterId);
                }

                if(publicRequest.IsSetCustomKeyStoreName())
                {
                    context.Writer.WritePropertyName("CustomKeyStoreName");
                    context.Writer.Write(publicRequest.CustomKeyStoreName);
                }

                if(publicRequest.IsSetCustomKeyStoreType())
                {
                    context.Writer.WritePropertyName("CustomKeyStoreType");
                    context.Writer.Write(publicRequest.CustomKeyStoreType);
                }

                if(publicRequest.IsSetKeyStorePassword())
                {
                    context.Writer.WritePropertyName("KeyStorePassword");
                    context.Writer.Write(publicRequest.KeyStorePassword);
                }

                if(publicRequest.IsSetTrustAnchorCertificate())
                {
                    context.Writer.WritePropertyName("TrustAnchorCertificate");
                    context.Writer.Write(publicRequest.TrustAnchorCertificate);
                }

                if(publicRequest.IsSetXksProxyAuthenticationCredential())
                {
                    context.Writer.WritePropertyName("XksProxyAuthenticationCredential");
                    context.Writer.WriteObjectStart();

                    var marshaller = XksProxyAuthenticationCredentialTypeMarshaller.Instance;
                    marshaller.Marshall(publicRequest.XksProxyAuthenticationCredential, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetXksProxyConnectivity())
                {
                    context.Writer.WritePropertyName("XksProxyConnectivity");
                    context.Writer.Write(publicRequest.XksProxyConnectivity);
                }

                if(publicRequest.IsSetXksProxyUriEndpoint())
                {
                    context.Writer.WritePropertyName("XksProxyUriEndpoint");
                    context.Writer.Write(publicRequest.XksProxyUriEndpoint);
                }

                if(publicRequest.IsSetXksProxyUriPath())
                {
                    context.Writer.WritePropertyName("XksProxyUriPath");
                    context.Writer.Write(publicRequest.XksProxyUriPath);
                }

                if(publicRequest.IsSetXksProxyVpcEndpointServiceName())
                {
                    context.Writer.WritePropertyName("XksProxyVpcEndpointServiceName");
                    context.Writer.Write(publicRequest.XksProxyVpcEndpointServiceName);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateCustomKeyStoreRequestMarshaller _instance = new CreateCustomKeyStoreRequestMarshaller();        

        internal static CreateCustomKeyStoreRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateCustomKeyStoreRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}