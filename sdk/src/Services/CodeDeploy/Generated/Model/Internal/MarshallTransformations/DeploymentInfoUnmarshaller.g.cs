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
    /// Response Unmarshaller for DeploymentInfo Object
    /// </summary>
    public partial class DeploymentInfoUnmarshaller : ICborUnmarshaller<DeploymentInfo, CborUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public DeploymentInfo Unmarshall(CborUnmarshallerContext context)
        {
            var unmarshalledObject = new DeploymentInfo();
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
                    case "additionalDeploymentStatusInfo":
                        context.AddPathSegment("AdditionalDeploymentStatusInfo");
                        unmarshalledObject.AdditionalDeploymentStatusInfo = CborStringUnmarshaller.Instance.Unmarshall(context);
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

                    case "blueGreenDeploymentConfiguration":
                        context.AddPathSegment("BlueGreenDeploymentConfiguration");
                        unmarshalledObject.BlueGreenDeploymentConfiguration = BlueGreenDeploymentConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "completeTime":
                        context.AddPathSegment("CompleteTime");
                        unmarshalledObject.CompleteTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "computePlatform":
                        context.AddPathSegment("ComputePlatform");
                        unmarshalledObject.ComputePlatform = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "createTime":
                        context.AddPathSegment("CreateTime");
                        unmarshalledObject.CreateTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "creator":
                        context.AddPathSegment("Creator");
                        unmarshalledObject.Creator = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentConfigName":
                        context.AddPathSegment("DeploymentConfigName");
                        unmarshalledObject.DeploymentConfigName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentGroupName":
                        context.AddPathSegment("DeploymentGroupName");
                        unmarshalledObject.DeploymentGroupName = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentId":
                        context.AddPathSegment("DeploymentId");
                        unmarshalledObject.DeploymentId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentMode":
                        context.AddPathSegment("DeploymentMode");
                        unmarshalledObject.DeploymentMode = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentOverview":
                        context.AddPathSegment("DeploymentOverview");
                        unmarshalledObject.DeploymentOverview = DeploymentOverviewUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentStatusMessages":
                        context.AddPathSegment("DeploymentStatusMessages");
                        unmarshalledObject.DeploymentStatusMessages = new CborListUnmarshaller<string, CborStringUnmarshaller>(CborStringUnmarshaller.Instance).Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "deploymentStyle":
                        context.AddPathSegment("DeploymentStyle");
                        unmarshalledObject.DeploymentStyle = DeploymentStyleUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "description":
                        context.AddPathSegment("Description");
                        unmarshalledObject.Description = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ec2DeploymentOptions":
                        context.AddPathSegment("Ec2DeploymentOptions");
                        unmarshalledObject.Ec2DeploymentOptions = EC2DeploymentOptionsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "errorInformation":
                        context.AddPathSegment("ErrorInformation");
                        unmarshalledObject.ErrorInformation = ErrorInformationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "externalId":
                        context.AddPathSegment("ExternalId");
                        unmarshalledObject.ExternalId = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "fileExistsBehavior":
                        context.AddPathSegment("FileExistsBehavior");
                        unmarshalledObject.FileExistsBehavior = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "ignoreApplicationStopFailures":
                        context.AddPathSegment("IgnoreApplicationStopFailures");
                        unmarshalledObject.IgnoreApplicationStopFailures = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "instanceTerminationWaitTimeStarted":
                        context.AddPathSegment("InstanceTerminationWaitTimeStarted");
                        unmarshalledObject.InstanceTerminationWaitTimeStarted = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "loadBalancerInfo":
                        context.AddPathSegment("LoadBalancerInfo");
                        unmarshalledObject.LoadBalancerInfo = LoadBalancerInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "overrideAlarmConfiguration":
                        context.AddPathSegment("OverrideAlarmConfiguration");
                        unmarshalledObject.OverrideAlarmConfiguration = AlarmConfigurationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "previousRevision":
                        context.AddPathSegment("PreviousRevision");
                        unmarshalledObject.PreviousRevision = RevisionLocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "relatedDeployments":
                        context.AddPathSegment("RelatedDeployments");
                        unmarshalledObject.RelatedDeployments = RelatedDeploymentsUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "revision":
                        context.AddPathSegment("Revision");
                        unmarshalledObject.Revision = RevisionLocationUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "rollbackInfo":
                        context.AddPathSegment("RollbackInfo");
                        unmarshalledObject.RollbackInfo = RollbackInfoUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "startTime":
                        context.AddPathSegment("StartTime");
                        unmarshalledObject.StartTime = CborNullableDateTimeUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "status":
                        context.AddPathSegment("Status");
                        unmarshalledObject.Status = CborStringUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "targetInstances":
                        context.AddPathSegment("TargetInstances");
                        unmarshalledObject.TargetInstances = TargetInstancesUnmarshaller.Instance.Unmarshall(context);
                        context.PopPathSegment();
                        break;

                    case "updateOutdatedInstancesOnly":
                        context.AddPathSegment("UpdateOutdatedInstancesOnly");
                        unmarshalledObject.UpdateOutdatedInstancesOnly = CborNullableBoolUnmarshaller.Instance.Unmarshall(context);
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

        private static DeploymentInfoUnmarshaller _instance = new DeploymentInfoUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DeploymentInfoUnmarshaller Instance => _instance;
    }
}
