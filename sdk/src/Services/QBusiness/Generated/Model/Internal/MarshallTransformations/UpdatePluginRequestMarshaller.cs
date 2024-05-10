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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.QBusiness.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.QBusiness.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdatePlugin Request Marshaller
    /// </summary>       
    public class UpdatePluginRequestMarshaller : IMarshaller<IRequest, UpdatePluginRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdatePluginRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdatePluginRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.QBusiness");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-11-27";
            request.HttpMethod = "PUT";

            if (!publicRequest.IsSetApplicationId())
                throw new AmazonQBusinessException("Request object does not have required field ApplicationId set");
            request.AddPathResource("{applicationId}", StringUtils.FromString(publicRequest.ApplicationId));
            if (!publicRequest.IsSetPluginId())
                throw new AmazonQBusinessException("Request object does not have required field PluginId set");
            request.AddPathResource("{pluginId}", StringUtils.FromString(publicRequest.PluginId));
            request.ResourcePath = "/applications/{applicationId}/plugins/{pluginId}";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAuthConfiguration())
                {
                    context.Writer.WritePropertyName("authConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = PluginAuthConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.AuthConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetCustomPluginConfiguration())
                {
                    context.Writer.WritePropertyName("customPluginConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = CustomPluginConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.CustomPluginConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDisplayName())
                {
                    context.Writer.WritePropertyName("displayName");
                    context.Writer.Write(publicRequest.DisplayName);
                }

                if(publicRequest.IsSetServerUrl())
                {
                    context.Writer.WritePropertyName("serverUrl");
                    context.Writer.Write(publicRequest.ServerUrl);
                }

                if(publicRequest.IsSetState())
                {
                    context.Writer.WritePropertyName("state");
                    context.Writer.Write(publicRequest.State);
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdatePluginRequestMarshaller _instance = new UpdatePluginRequestMarshaller();        

        internal static UpdatePluginRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdatePluginRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}