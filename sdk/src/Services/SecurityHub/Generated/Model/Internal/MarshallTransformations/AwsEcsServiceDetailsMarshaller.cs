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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.SecurityHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.SecurityHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// AwsEcsServiceDetails Marshaller
    /// </summary>
    public class AwsEcsServiceDetailsMarshaller : IRequestMarshaller<AwsEcsServiceDetails, JsonMarshallerContext> 
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="requestObject"></param>
        /// <param name="context"></param>
        /// <returns></returns>
        public void Marshall(AwsEcsServiceDetails requestObject, JsonMarshallerContext context)
        {
            if(requestObject == null)
                return;
            if(requestObject.IsSetCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("CapacityProviderStrategy");
                context.Writer.WriteStartArray();
                foreach(var requestObjectCapacityProviderStrategyListValue in requestObject.CapacityProviderStrategy)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsServiceCapacityProviderStrategyDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCapacityProviderStrategyListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetCluster())
            {
                context.Writer.WritePropertyName("Cluster");
                context.Writer.WriteStringValue(requestObject.Cluster);
            }

            if(requestObject.IsSetDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("DeploymentConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsServiceDeploymentConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeploymentConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDeploymentController())
            {
                context.Writer.WritePropertyName("DeploymentController");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsServiceDeploymentControllerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeploymentController, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetDesiredCount())
            {
                context.Writer.WritePropertyName("DesiredCount");
                context.Writer.WriteNumberValue(requestObject.DesiredCount.Value);
            }

            if(requestObject.IsSetEnableEcsManagedTags())
            {
                context.Writer.WritePropertyName("EnableEcsManagedTags");
                context.Writer.WriteBooleanValue(requestObject.EnableEcsManagedTags.Value);
            }

            if(requestObject.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("EnableExecuteCommand");
                context.Writer.WriteBooleanValue(requestObject.EnableExecuteCommand.Value);
            }

            if(requestObject.IsSetHealthCheckGracePeriodSeconds())
            {
                context.Writer.WritePropertyName("HealthCheckGracePeriodSeconds");
                context.Writer.WriteNumberValue(requestObject.HealthCheckGracePeriodSeconds.Value);
            }

            if(requestObject.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("LaunchType");
                context.Writer.WriteStringValue(requestObject.LaunchType);
            }

            if(requestObject.IsSetLoadBalancers())
            {
                context.Writer.WritePropertyName("LoadBalancers");
                context.Writer.WriteStartArray();
                foreach(var requestObjectLoadBalancersListValue in requestObject.LoadBalancers)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsServiceLoadBalancersDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectLoadBalancersListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.WriteStringValue(requestObject.Name);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteStartObject();

                var marshaller = AwsEcsServiceNetworkConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteEndObject();
            }

            if(requestObject.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("PlacementConstraints");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPlacementConstraintsListValue in requestObject.PlacementConstraints)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsServicePlacementConstraintsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementConstraintsListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlacementStrategies())
            {
                context.Writer.WritePropertyName("PlacementStrategies");
                context.Writer.WriteStartArray();
                foreach(var requestObjectPlacementStrategiesListValue in requestObject.PlacementStrategies)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsServicePlacementStrategiesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementStrategiesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("PlatformVersion");
                context.Writer.WriteStringValue(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("PropagateTags");
                context.Writer.WriteStringValue(requestObject.PropagateTags);
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.WriteStringValue(requestObject.Role);
            }

            if(requestObject.IsSetSchedulingStrategy())
            {
                context.Writer.WritePropertyName("SchedulingStrategy");
                context.Writer.WriteStringValue(requestObject.SchedulingStrategy);
            }

            if(requestObject.IsSetServiceArn())
            {
                context.Writer.WritePropertyName("ServiceArn");
                context.Writer.WriteStringValue(requestObject.ServiceArn);
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.WriteStringValue(requestObject.ServiceName);
            }

            if(requestObject.IsSetServiceRegistries())
            {
                context.Writer.WritePropertyName("ServiceRegistries");
                context.Writer.WriteStartArray();
                foreach(var requestObjectServiceRegistriesListValue in requestObject.ServiceRegistries)
                {
                    context.Writer.WriteStartObject();

                    var marshaller = AwsEcsServiceServiceRegistriesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectServiceRegistriesListValue, context);

                    context.Writer.WriteEndObject();
                }
                context.Writer.WriteEndArray();
            }

            if(requestObject.IsSetTaskDefinition())
            {
                context.Writer.WritePropertyName("TaskDefinition");
                context.Writer.WriteStringValue(requestObject.TaskDefinition);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>
        public readonly static AwsEcsServiceDetailsMarshaller Instance = new AwsEcsServiceDetailsMarshaller();

    }
}