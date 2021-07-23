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
using ThirdParty.Json.LitJson;

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
            if(requestObject.IsSetCapacityProviderStrategy())
            {
                context.Writer.WritePropertyName("CapacityProviderStrategy");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectCapacityProviderStrategyListValue in requestObject.CapacityProviderStrategy)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsServiceCapacityProviderStrategyDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectCapacityProviderStrategyListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetCluster())
            {
                context.Writer.WritePropertyName("Cluster");
                context.Writer.Write(requestObject.Cluster);
            }

            if(requestObject.IsSetDeploymentConfiguration())
            {
                context.Writer.WritePropertyName("DeploymentConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsServiceDeploymentConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeploymentConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDeploymentController())
            {
                context.Writer.WritePropertyName("DeploymentController");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsServiceDeploymentControllerDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.DeploymentController, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetDesiredCount())
            {
                context.Writer.WritePropertyName("DesiredCount");
                context.Writer.Write(requestObject.DesiredCount);
            }

            if(requestObject.IsSetEnableEcsManagedTags())
            {
                context.Writer.WritePropertyName("EnableEcsManagedTags");
                context.Writer.Write(requestObject.EnableEcsManagedTags);
            }

            if(requestObject.IsSetEnableExecuteCommand())
            {
                context.Writer.WritePropertyName("EnableExecuteCommand");
                context.Writer.Write(requestObject.EnableExecuteCommand);
            }

            if(requestObject.IsSetHealthCheckGracePeriodSeconds())
            {
                context.Writer.WritePropertyName("HealthCheckGracePeriodSeconds");
                context.Writer.Write(requestObject.HealthCheckGracePeriodSeconds);
            }

            if(requestObject.IsSetLaunchType())
            {
                context.Writer.WritePropertyName("LaunchType");
                context.Writer.Write(requestObject.LaunchType);
            }

            if(requestObject.IsSetLoadBalancers())
            {
                context.Writer.WritePropertyName("LoadBalancers");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectLoadBalancersListValue in requestObject.LoadBalancers)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsServiceLoadBalancersDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectLoadBalancersListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetName())
            {
                context.Writer.WritePropertyName("Name");
                context.Writer.Write(requestObject.Name);
            }

            if(requestObject.IsSetNetworkConfiguration())
            {
                context.Writer.WritePropertyName("NetworkConfiguration");
                context.Writer.WriteObjectStart();

                var marshaller = AwsEcsServiceNetworkConfigurationDetailsMarshaller.Instance;
                marshaller.Marshall(requestObject.NetworkConfiguration, context);

                context.Writer.WriteObjectEnd();
            }

            if(requestObject.IsSetPlacementConstraints())
            {
                context.Writer.WritePropertyName("PlacementConstraints");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPlacementConstraintsListValue in requestObject.PlacementConstraints)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsServicePlacementConstraintsDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementConstraintsListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlacementStrategies())
            {
                context.Writer.WritePropertyName("PlacementStrategies");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectPlacementStrategiesListValue in requestObject.PlacementStrategies)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsServicePlacementStrategiesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectPlacementStrategiesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetPlatformVersion())
            {
                context.Writer.WritePropertyName("PlatformVersion");
                context.Writer.Write(requestObject.PlatformVersion);
            }

            if(requestObject.IsSetPropagateTags())
            {
                context.Writer.WritePropertyName("PropagateTags");
                context.Writer.Write(requestObject.PropagateTags);
            }

            if(requestObject.IsSetRole())
            {
                context.Writer.WritePropertyName("Role");
                context.Writer.Write(requestObject.Role);
            }

            if(requestObject.IsSetSchedulingStrategy())
            {
                context.Writer.WritePropertyName("SchedulingStrategy");
                context.Writer.Write(requestObject.SchedulingStrategy);
            }

            if(requestObject.IsSetServiceArn())
            {
                context.Writer.WritePropertyName("ServiceArn");
                context.Writer.Write(requestObject.ServiceArn);
            }

            if(requestObject.IsSetServiceName())
            {
                context.Writer.WritePropertyName("ServiceName");
                context.Writer.Write(requestObject.ServiceName);
            }

            if(requestObject.IsSetServiceRegistries())
            {
                context.Writer.WritePropertyName("ServiceRegistries");
                context.Writer.WriteArrayStart();
                foreach(var requestObjectServiceRegistriesListValue in requestObject.ServiceRegistries)
                {
                    context.Writer.WriteObjectStart();

                    var marshaller = AwsEcsServiceServiceRegistriesDetailsMarshaller.Instance;
                    marshaller.Marshall(requestObjectServiceRegistriesListValue, context);

                    context.Writer.WriteObjectEnd();
                }
                context.Writer.WriteArrayEnd();
            }

            if(requestObject.IsSetTaskDefinition())
            {
                context.Writer.WritePropertyName("TaskDefinition");
                context.Writer.Write(requestObject.TaskDefinition);
            }

        }

        /// <summary>
        /// Singleton Marshaller.
        /// </summary>  
        public readonly static AwsEcsServiceDetailsMarshaller Instance = new AwsEcsServiceDetailsMarshaller();

    }
}