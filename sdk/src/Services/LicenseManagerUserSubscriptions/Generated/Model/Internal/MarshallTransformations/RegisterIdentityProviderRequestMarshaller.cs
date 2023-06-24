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
 * Do not modify this file. This file is generated from the license-manager-user-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManagerUserSubscriptions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManagerUserSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// RegisterIdentityProvider Request Marshaller
    /// </summary>       
    public class RegisterIdentityProviderRequestMarshaller : IMarshaller<IRequest, RegisterIdentityProviderRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((RegisterIdentityProviderRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(RegisterIdentityProviderRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManagerUserSubscriptions");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/identity-provider/RegisterIdentityProvider";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetIdentityProvider())
                {
                    context.Writer.WritePropertyName("IdentityProvider");
                    context.Writer.WriteObjectStart();

                    var marshaller = IdentityProviderMarshaller.Instance;
                    marshaller.Marshall(publicRequest.IdentityProvider, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetProduct())
                {
                    context.Writer.WritePropertyName("Product");
                    context.Writer.Write(publicRequest.Product);
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("Settings");
                    context.Writer.WriteObjectStart();

                    var marshaller = SettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Settings, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static RegisterIdentityProviderRequestMarshaller _instance = new RegisterIdentityProviderRequestMarshaller();        

        internal static RegisterIdentityProviderRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static RegisterIdentityProviderRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}