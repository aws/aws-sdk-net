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
 * Do not modify this file. This file is generated from the license-manager-linux-subscriptions-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.LicenseManagerLinuxSubscriptions.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.LicenseManagerLinuxSubscriptions.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateServiceSettings Request Marshaller
    /// </summary>       
    public class UpdateServiceSettingsRequestMarshaller : IMarshaller<IRequest, UpdateServiceSettingsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateServiceSettingsRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(UpdateServiceSettingsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.LicenseManagerLinuxSubscriptions");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2018-05-10";
            request.HttpMethod = "POST";

            request.ResourcePath = "/subscription/UpdateServiceSettings";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetAllowUpdate())
                {
                    context.Writer.WritePropertyName("AllowUpdate");
                    context.Writer.Write(publicRequest.AllowUpdate);
                }

                if(publicRequest.IsSetLinuxSubscriptionsDiscovery())
                {
                    context.Writer.WritePropertyName("LinuxSubscriptionsDiscovery");
                    context.Writer.Write(publicRequest.LinuxSubscriptionsDiscovery);
                }

                if(publicRequest.IsSetLinuxSubscriptionsDiscoverySettings())
                {
                    context.Writer.WritePropertyName("LinuxSubscriptionsDiscoverySettings");
                    context.Writer.WriteObjectStart();

                    var marshaller = LinuxSubscriptionsDiscoverySettingsMarshaller.Instance;
                    marshaller.Marshall(publicRequest.LinuxSubscriptionsDiscoverySettings, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static UpdateServiceSettingsRequestMarshaller _instance = new UpdateServiceSettingsRequestMarshaller();        

        internal static UpdateServiceSettingsRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static UpdateServiceSettingsRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}