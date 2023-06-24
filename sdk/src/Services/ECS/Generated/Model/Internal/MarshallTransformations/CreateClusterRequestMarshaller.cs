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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// CreateCluster Request Marshaller
    /// </summary>       
    public class CreateClusterRequestMarshaller : IMarshaller<IRequest, CreateClusterRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateClusterRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateClusterRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.CreateCluster";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacityProviders())
                {
                    context.Writer.WritePropertyName("capacityProviders");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapacityProvidersListValue in publicRequest.CapacityProviders)
                    {
                            context.Writer.Write(publicRequestCapacityProvidersListValue);
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClusterName())
                {
                    context.Writer.WritePropertyName("clusterName");
                    context.Writer.Write(publicRequest.ClusterName);
                }

                if(publicRequest.IsSetConfiguration())
                {
                    context.Writer.WritePropertyName("configuration");
                    context.Writer.WriteObjectStart();

                    var marshaller = ClusterConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Configuration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDefaultCapacityProviderStrategy())
                {
                    context.Writer.WritePropertyName("defaultCapacityProviderStrategy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestDefaultCapacityProviderStrategyListValue in publicRequest.DefaultCapacityProviderStrategy)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestDefaultCapacityProviderStrategyListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetServiceConnectDefaults())
                {
                    context.Writer.WritePropertyName("serviceConnectDefaults");
                    context.Writer.WriteObjectStart();

                    var marshaller = ClusterServiceConnectDefaultsRequestMarshaller.Instance;
                    marshaller.Marshall(publicRequest.ServiceConnectDefaults, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetSettings())
                {
                    context.Writer.WritePropertyName("settings");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestSettingsListValue in publicRequest.Settings)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ClusterSettingMarshaller.Instance;
                        marshaller.Marshall(publicRequestSettingsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
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

                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateClusterRequestMarshaller _instance = new CreateClusterRequestMarshaller();        

        internal static CreateClusterRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateClusterRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}