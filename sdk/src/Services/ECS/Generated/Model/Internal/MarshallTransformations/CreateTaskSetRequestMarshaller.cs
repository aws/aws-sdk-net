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
    /// CreateTaskSet Request Marshaller
    /// </summary>       
    public class CreateTaskSetRequestMarshaller : IMarshaller<IRequest, CreateTaskSetRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateTaskSetRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateTaskSetRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.CreateTaskSet";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-13";            
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
            request.MarshallerVersion = 2;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetCapacityProviderStrategy())
                {
                    context.Writer.WritePropertyName("capacityProviderStrategy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestCapacityProviderStrategyListValue in publicRequest.CapacityProviderStrategy)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                        marshaller.Marshall(publicRequestCapacityProviderStrategyListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetClientToken())
                {
                    context.Writer.WritePropertyName("clientToken");
                    context.Writer.Write(publicRequest.ClientToken);
                }

                if(publicRequest.IsSetCluster())
                {
                    context.Writer.WritePropertyName("cluster");
                    context.Writer.Write(publicRequest.Cluster);
                }

                if(publicRequest.IsSetExternalId())
                {
                    context.Writer.WritePropertyName("externalId");
                    context.Writer.Write(publicRequest.ExternalId);
                }

                if(publicRequest.IsSetLaunchType())
                {
                    context.Writer.WritePropertyName("launchType");
                    context.Writer.Write(publicRequest.LaunchType);
                }

                if(publicRequest.IsSetLoadBalancers())
                {
                    context.Writer.WritePropertyName("loadBalancers");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestLoadBalancersListValue in publicRequest.LoadBalancers)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = LoadBalancerMarshaller.Instance;
                        marshaller.Marshall(publicRequestLoadBalancersListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetNetworkConfiguration())
                {
                    context.Writer.WritePropertyName("networkConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = NetworkConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetPlatformVersion())
                {
                    context.Writer.WritePropertyName("platformVersion");
                    context.Writer.Write(publicRequest.PlatformVersion);
                }

                if(publicRequest.IsSetScale())
                {
                    context.Writer.WritePropertyName("scale");
                    context.Writer.WriteObjectStart();

                    var marshaller = ScaleMarshaller.Instance;
                    marshaller.Marshall(publicRequest.Scale, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetService())
                {
                    context.Writer.WritePropertyName("service");
                    context.Writer.Write(publicRequest.Service);
                }

                if(publicRequest.IsSetServiceRegistries())
                {
                    context.Writer.WritePropertyName("serviceRegistries");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestServiceRegistriesListValue in publicRequest.ServiceRegistries)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = ServiceRegistryMarshaller.Instance;
                        marshaller.Marshall(publicRequestServiceRegistriesListValue, context);

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

                if(publicRequest.IsSetTaskDefinition())
                {
                    context.Writer.WritePropertyName("taskDefinition");
                    context.Writer.Write(publicRequest.TaskDefinition);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }
        private static CreateTaskSetRequestMarshaller _instance = new CreateTaskSetRequestMarshaller();        

        internal static CreateTaskSetRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateTaskSetRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}