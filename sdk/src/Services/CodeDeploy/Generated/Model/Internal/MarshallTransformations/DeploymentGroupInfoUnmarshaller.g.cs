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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Formats.Cbor;
using Amazon.Extensions.CborProtocol.Internal.Transform;

#pragma warning disable CS0612,CS0618

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeploymentGroupInfo Object
    /// </summary>
    public partial class DeploymentGroupInfoUnmarshaller : ICborUnmarshaller<DeploymentGroupInfo, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DeploymentGroupInfo Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DeploymentGroupInfo();
            if (context.IsEmptyResponse) return null;

            var reader = context.Reader;
            if (reader.PeekState() == CborReaderState.Null)
            {
                reader.ReadNull();
                return null;
            }

            reader.ReadStartMap();
            while (reader.PeekState() != CborReaderState.EndMap)
            {
                var propertyName = reader.ReadTextString();
                switch (propertyName)
                {
                    case "alarmConfiguration":
                        context.AddPathSegment("AlarmConfiguration");
                        unmarshalledObject.AlarmConfiguration = AlarmConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "applicationName":
                        context.AddPathSegment("ApplicationName");
                        unmarshalledObject.ApplicationName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "autoRollbackConfiguration":
                        context.AddPathSegment("AutoRollbackConfiguration");
                        unmarshalledObject.AutoRollbackConfiguration = AutoRollbackConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "autoScalingGroups":
                        context.AddPathSegment("AutoScalingGroups");
                        unmarshalledObject.AutoScalingGroups = new CborListUnmarshaller<AutoScalingGroup, AutoScalingGroupUnmarshaller>(AutoScalingGroupUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "blueGreenDeploymentConfiguration":
                        context.AddPathSegment("BlueGreenDeploymentConfiguration");
                        unmarshalledObject.BlueGreenDeploymentConfiguration = BlueGreenDeploymentConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "computePlatform":
                        context.AddPathSegment("ComputePlatform");
                        unmarshalledObject.ComputePlatform = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentConfigName":
                        context.AddPathSegment("DeploymentConfigName");
                        unmarshalledObject.DeploymentConfigName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentGroupId":
                        context.AddPathSegment("DeploymentGroupId");
                        unmarshalledObject.DeploymentGroupId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentGroupName":
                        context.AddPathSegment("DeploymentGroupName");
                        unmarshalledObject.DeploymentGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentStyle":
                        context.AddPathSegment("DeploymentStyle");
                        unmarshalledObject.DeploymentStyle = DeploymentStyleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ec2DeploymentOptions":
                        context.AddPathSegment("Ec2DeploymentOptions");
                        unmarshalledObject.Ec2DeploymentOptions = EC2DeploymentOptionsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ec2TagFilters":
                        context.AddPathSegment("Ec2TagFilters");
                        unmarshalledObject.Ec2TagFilters = new CborListUnmarshaller<EC2TagFilter, EC2TagFilterUnmarshaller>(EC2TagFilterUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ec2TagSet":
                        context.AddPathSegment("Ec2TagSet");
                        unmarshalledObject.Ec2TagSet = EC2TagSetUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ecsServices":
                        context.AddPathSegment("EcsServices");
                        unmarshalledObject.EcsServices = new CborListUnmarshaller<ECSService, ECSServiceUnmarshaller>(ECSServiceUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastAttemptedDeployment":
                        context.AddPathSegment("LastAttemptedDeployment");
                        unmarshalledObject.LastAttemptedDeployment = LastDeploymentInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "lastSuccessfulDeployment":
                        context.AddPathSegment("LastSuccessfulDeployment");
                        unmarshalledObject.LastSuccessfulDeployment = LastDeploymentInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "loadBalancerInfo":
                        context.AddPathSegment("LoadBalancerInfo");
                        unmarshalledObject.LoadBalancerInfo = LoadBalancerInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "onPremisesInstanceTagFilters":
                        context.AddPathSegment("OnPremisesInstanceTagFilters");
                        unmarshalledObject.OnPremisesInstanceTagFilters = new CborListUnmarshaller<TagFilter, TagFilterUnmarshaller>(TagFilterUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "onPremisesTagSet":
                        context.AddPathSegment("OnPremisesTagSet");
                        unmarshalledObject.OnPremisesTagSet = OnPremisesTagSetUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "outdatedInstancesStrategy":
                        context.AddPathSegment("OutdatedInstancesStrategy");
                        unmarshalledObject.OutdatedInstancesStrategy = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "serviceRoleArn":
                        context.AddPathSegment("ServiceRoleArn");
                        unmarshalledObject.ServiceRoleArn = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "targetRevision":
                        context.AddPathSegment("TargetRevision");
                        unmarshalledObject.TargetRevision = RevisionLocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "terminationHookEnabled":
                        context.AddPathSegment("TerminationHookEnabled");
                        unmarshalledObject.TerminationHookEnabled = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "triggerConfigurations":
                        context.AddPathSegment("TriggerConfigurations");
                        unmarshalledObject.TriggerConfigurations = new CborListUnmarshaller<TriggerConfig, TriggerConfigUnmarshaller>(TriggerConfigUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    default:
                        reader.SkipValue();
                        break;
                }
            }
            reader.ReadEndMap();
            return unmarshalledObject;
        }

        private static DeploymentGroupInfoUnmarshaller _instance = new DeploymentGroupInfoUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeploymentGroupInfoUnmarshaller Instance => _instance;
    }
}
