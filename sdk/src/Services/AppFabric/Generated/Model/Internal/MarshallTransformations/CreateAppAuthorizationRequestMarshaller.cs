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
 * Do not modify this file. This file is generated from the appfabric-2023-05-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.AppFabric.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AppFabric.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateAppAuthorization Request Marshaller
    /// </summary>       
    public class CreateAppAuthorizationRequestMarshaller : IMarshaller<IRequest, CreateAppAuthorizationRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateAppAuthorizationRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateAppAuthorizationRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.AppFabric");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-05-19";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetAppBundleIdentifier())
                throw new AmazonAppFabricException("Request object does not have required field AppBundleIdentifier set");
            request.AddPathResource("{appBundleIdentifier}", StringUtils.FromString(publicRequest.AppBundleIdentifier));
            request.ResourcePath = "/appbundles/{appBundleIdentifier}/appauthorizations";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetApp())
                {
                    context.Writer.WritePropertyName("app");
                    context.Writer.Write(publicRequest.App);
                }

                if(publicRequest.IsSetAuthType())
                {
                    context.Writer.WritePropertyName("authType");
                    context.Writer.Write(publicRequest.AuthType);
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                else if(!(publicRequest.IsSetClientToken()))
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(Guid.NewGuid().ToString());
                }
                if(publicRequest.IsSetCredential())
                {
                    context.Writer.WritePropertyName("credential");
                    context.Writer.WriteObjectStart();

                    var marshaller = CredentialMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Credential, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("tags");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestTagsListValue in publicRequest.Tags)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = TagMarshaller.Instance;
                        marshaller.Marshall(publicRequestTagsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetTenant())
                {
                    context.Writer.WritePropertyName("tenant");
                    context.Writer.WriteObjectStart();

                    var marshaller = TenantMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Tenant, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateAppAuthorizationRequestMarshaller _instance = new CreateAppAuthorizationRequestMarshaller();        

        internal static CreateAppAuthorizationRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateAppAuthorizationRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}