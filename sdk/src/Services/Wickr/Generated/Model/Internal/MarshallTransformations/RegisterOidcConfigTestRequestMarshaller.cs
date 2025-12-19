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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Wickr.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.Wickr.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterOidcConfigTest Request Marshaller
    /// </summary>       
    public class RegisterOidcConfigTestRequestMarshaller : IMarshaller<IRequest, RegisterOidcConfigTestRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterOidcConfigTestRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterOidcConfigTestRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Wickr");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2024-02-01";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetNetworkId())
                throw new AmazonWickrException("Request object does not have required field NetworkId set");
            request.AddPathResource("{networkId}", StringUtils.FromString(publicRequest.NetworkId));
            request.ResourcePath = "/networks/{networkId}/oidc/test";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCertificate())
                {
                    context.Writer.WritePropertyName("certificate");
                    context.Writer.Write(publicRequest.Certificate);
                }

                if(publicRequest.IsSetExtraAuthParams())
                {
                    context.Writer.WritePropertyName("extraAuthParams");
                    context.Writer.Write(publicRequest.ExtraAuthParams);
                }

                if(publicRequest.IsSetIssuer())
                {
                    context.Writer.WritePropertyName("issuer");
                    context.Writer.Write(publicRequest.Issuer);
                }

                if(publicRequest.IsSetScopes())
                {
                    context.Writer.WritePropertyName("scopes");
                    context.Writer.Write(publicRequest.Scopes);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterOidcConfigTestRequestMarshaller _instance = new RegisterOidcConfigTestRequestMarshaller();        

        internal static RegisterOidcConfigTestRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterOidcConfigTestRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}