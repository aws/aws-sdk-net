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
    /// CreateService Request Marshaller
    /// </summary>       
    public class CreateServiceRequestMarshaller : IMarshaller<IRequest, CreateServiceRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((CreateServiceRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(CreateServiceRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.ECS");
            string target = "AmazonEC2ContainerServiceV20141113.CreateService";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
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

                if(publicRequest.IsSetDeploymentConfiguration())
                {
                    context.Writer.WritePropertyName("deploymentConfiguration");
                    context.Writer.WriteObjectStart();

                    var marshaller = DeploymentConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequest.DeploymentConfiguration, context);

                    context.Writer.WriteObjectEnd();
                }

                if(publicRequest.IsSetDesiredCount())
                {
                    context.Writer.WritePropertyName("desiredCount");
                    context.Writer.Write(publicRequest.DesiredCount);
                }

                if(publicRequest.IsSetHealthCheckGracePeriodSeconds())
                {
                    context.Writer.WritePropertyName("healthCheckGracePeriodSeconds");
                    context.Writer.Write(publicRequest.HealthCheckGracePeriodSeconds);
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

                if(publicRequest.IsSetPlacementConstraints())
                {
                    context.Writer.WritePropertyName("placementConstraints");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlacementConstraintsListValue in publicRequest.PlacementConstraints)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PlacementConstraintMarshaller.Instance;
                        marshaller.Marshall(publicRequestPlacementConstraintsListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPlacementStrategy())
                {
                    context.Writer.WritePropertyName("placementStrategy");
                    context.Writer.WriteArrayStart();
                    foreach(var publicRequestPlacementStrategyListValue in publicRequest.PlacementStrategy)
                    {
                        context.Writer.WriteObjectStart();

                        var marshaller = PlacementStrategyMarshaller.Instance;
                        marshaller.Marshall(publicRequestPlacementStrategyListValue, context);

                        context.Writer.WriteObjectEnd();
                    }
                    context.Writer.WriteArrayEnd();
                }

                if(publicRequest.IsSetPlatformVersion())
                {
                    context.Writer.WritePropertyName("platformVersion");
                    context.Writer.Write(publicRequest.PlatformVersion);
                }

                if(publicRequest.IsSetRole())
                {
                    context.Writer.WritePropertyName("role");
                    context.Writer.Write(publicRequest.Role);
                }

                if(publicRequest.IsSetServiceName())
                {
                    context.Writer.WritePropertyName("serviceName");
                    context.Writer.Write(publicRequest.ServiceName);
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
        private static CreateServiceRequestMarshaller _instance = new CreateServiceRequestMarshaller();        

        internal static CreateServiceRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CreateServiceRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}