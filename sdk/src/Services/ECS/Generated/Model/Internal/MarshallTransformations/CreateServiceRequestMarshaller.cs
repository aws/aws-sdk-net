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
using System.Text.Json;
using System.Buffers;
#if !NETFRAMEWORK
using ThirdParty.RuntimeBackports;
#endif
#pragma warning disable CS0612,CS0618
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
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2014-11-13";
            request.HttpMethod = "POST";

            request.ResourcePath = "/";
#if !NETFRAMEWORK
            using ArrayPoolBufferWriter<byte> arrayPoolBufferWriter = new ArrayPoolBufferWriter<byte>();
            using Utf8JsonWriter writer = new Utf8JsonWriter(arrayPoolBufferWriter);
#else
            using var memoryStream = new MemoryStream();
            using Utf8JsonWriter writer = new Utf8JsonWriter(memoryStream);
#endif
            writer.WriteStartObject();
            var context = new JsonMarshallerContext(request, writer);
            if(publicRequest.IsSetAvailabilityZoneRebalancing())
            {
                context.Writer.WritePropertyName("availabilityZoneRebalancing");
                context.Writer.WriteStringValue(publicRequest.AvailabilityZoneRebalancing);
            }

            if(publicRequest.IsSetCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("capacityProviderStrategy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestCapacityProviderStrategyListValue in publicRequest.CapacityProviderStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = CapacityProviderStrategyItemMarshaller.Instance;
                    marshaller.Marshall(publicRequestCapacityProviderStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetClientToken())
            {
                context.Writer.WritePropertyName("clientToken");
                context.Writer.WriteStringValue(publicRequest.ClientToken);
            }

            if(publicRequest.IsSetCluster())
            {
                context.Writer.WritePropertyName("cluster");
                context.Writer.WriteStringValue(publicRequest.Cluster);
            }

            if(publicRequest.IsSetDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("deploymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDeploymentController())
            {
                context.Writer.WritePropertyName("deploymentController");
                context.Writer.WriteStartObject();

                var marshaller = DeploymentControllerMarshaller.Instance;
                marshaller.Marshall(publicRequest.DeploymentController, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetDesiredCount())
            {
                context.Writer.WritePropertyName("desiredCount");
                context.Writer.WriteNumberValue(publicRequest.DesiredCount.Value);
            }

            if(publicRequest.IsSetEnableECSManagedTags())
            {
                context.Writer.WritePropertyName("enableECSManagedTags");
                context.Writer.WriteBooleanValue(publicRequest.EnableECSManagedTags.Value);
            }

            if(publicRequest.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("enableExecuteCommand");
                context.Writer.WriteBooleanValue(publicRequest.EnableExecuteCommand.Value);
            }

            if(publicRequest.IsSetHealthCheckGracePeriodSeconds())
            {
                context.Writer.WritePropertyName("healthCheckGracePeriodSeconds");
                context.Writer.WriteNumberValue(publicRequest.HealthCheckGracePeriodSeconds.Value);
            }

            if(publicRequest.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("launchType");
                context.Writer.WriteStringValue(publicRequest.LaunchType);
            }

            if(publicRequest.IsSetLoadBalancers())
            {
                context.Writer.WritePropertyName("loadBalancers");
                context.Writer.WriteStartArray();
                foreach(var publicRequestLoadBalancersListValue in publicRequest.LoadBalancers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = LoadBalancerMarshaller.Instance;
                    marshaller.Marshall(publicRequestLoadBalancersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("networkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = NetworkConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("placementConstraints");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlacementConstraintsListValue in publicRequest.PlacementConstraints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlacementConstraintMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlacementConstraintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPlacementStrategy())
            {
                context.Writer.WritePropertyName("placementStrategy");
                context.Writer.WriteStartArray();
                foreach(var publicRequestPlacementStrategyListValue in publicRequest.PlacementStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = PlacementStrategyMarshaller.Instance;
                    marshaller.Marshall(publicRequestPlacementStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("platformVersion");
                context.Writer.WriteStringValue(publicRequest.PlatformVersion);
            }

            if(publicRequest.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("propagateTags");
                context.Writer.WriteStringValue(publicRequest.PropagateTags);
            }

            if(publicRequest.IsSetRole())
            {
                context.Writer.WritePropertyName("role");
                context.Writer.WriteStringValue(publicRequest.Role);
            }

            if(publicRequest.IsSetSchedulingStrategy())
            {
                context.Writer.WritePropertyName("schedulingStrategy");
                context.Writer.WriteStringValue(publicRequest.SchedulingStrategy);
            }

            if(publicRequest.IsSetServiceConnectConfiguration())
            {
                context.Writer.WritePropertyName("serviceConnectConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = ServiceConnectConfigurationMarshaller.Instance;
                marshaller.Marshall(publicRequest.ServiceConnectConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(publicRequest.IsSetServiceName())
            {
                context.Writer.WritePropertyName("serviceName");
                context.Writer.WriteStringValue(publicRequest.ServiceName);
            }

            if(publicRequest.IsSetServiceRegistries())
            {
                context.Writer.WritePropertyName("serviceRegistries");
                context.Writer.WriteStartArray();
                foreach(var publicRequestServiceRegistriesListValue in publicRequest.ServiceRegistries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ServiceRegistryMarshaller.Instance;
                    marshaller.Marshall(publicRequestServiceRegistriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTags())
            {
                context.Writer.WritePropertyName("tags");
                context.Writer.WriteStartArray();
                foreach(var publicRequestTagsListValue in publicRequest.Tags)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = TagMarshaller.Instance;
                    marshaller.Marshall(publicRequestTagsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetTaskDefinition())
            {
                context.Writer.WritePropertyName("taskDefinition");
                context.Writer.WriteStringValue(publicRequest.TaskDefinition);
            }

            if(publicRequest.IsSetVolumeConfigurations())
            {
                context.Writer.WritePropertyName("volumeConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVolumeConfigurationsListValue in publicRequest.VolumeConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = ServiceVolumeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestVolumeConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(publicRequest.IsSetVpcLatticeConfigurations())
            {
                context.Writer.WritePropertyName("vpcLatticeConfigurations");
                context.Writer.WriteStartArray();
                foreach(var publicRequestVpcLatticeConfigurationsListValue in publicRequest.VpcLatticeConfigurations)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = VpcLatticeConfigurationMarshaller.Instance;
                    marshaller.Marshall(publicRequestVpcLatticeConfigurationsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            writer.WriteEndObject();
            writer.Flush();
            // ToArray() must be called here because aspects of sigv4 signing require a byte array
#if !NETFRAMEWORK
            request.Content = arrayPoolBufferWriter.WrittenMemory.ToArray();
#else
            request.Content = memoryStream.ToArray();
#endif
            


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