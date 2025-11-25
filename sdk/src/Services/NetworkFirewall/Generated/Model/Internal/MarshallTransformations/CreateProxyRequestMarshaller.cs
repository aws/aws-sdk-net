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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFirewall.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFirewall.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateProxy Request Marshaller
    /// </summary>       
    public class CreateProxyRequestMarshaller : IMarshaller<IRequest, CreateProxyRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateProxyRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateProxyRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.NetworkFirewall");
            string target = "NetworkFirewall_20201112.CreateProxy";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.0";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2020-11-12";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.Validate = false;
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetListenerProperties())
                {
                    context.Writer.WritePropertyName("ListenerProperties");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestListenerPropertiesListValue in publicRequest.ListenerProperties)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ListenerPropertyRequestMarshaller.Instance;
                        marshaller.Marshall(publicRequestListenerPropertiesListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNatGatewayId())
                {
                    context.Writer.WritePropertyName("NatGatewayId");
                    context.Writer.Write(publicRequest.NatGatewayId);
                }

                if(publicRequest.IsSetProxyConfigurationArn())
                {
                    context.Writer.WritePropertyName("ProxyConfigurationArn");
                    context.Writer.Write(publicRequest.ProxyConfigurationArn);
                }

                if(publicRequest.IsSetProxyConfigurationName())
                {
                    context.Writer.WritePropertyName("ProxyConfigurationName");
                    context.Writer.Write(publicRequest.ProxyConfigurationName);
                }

                if(publicRequest.IsSetProxyName())
                {
                    context.Writer.WritePropertyName("ProxyName");
                    context.Writer.Write(publicRequest.ProxyName);
                }

                if(publicRequest.IsSetTags())
                {
                    context.Writer.WritePropertyName("Tags");
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

                if(publicRequest.IsSetTlsInterceptProperties())
                {
                    context.Writer.WritePropertyName("TlsInterceptProperties");
                    context.Writer.WriteObjectStart();

                    var marshaller = TlsInterceptPropertiesRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.TlsInterceptProperties, context);

                    context.Writer.WriteObjectEnd();
                }

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateProxyRequestMarshaller _instance = new CreateProxyRequestMarshaller();        

        internal static CreateProxyRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateProxyRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}