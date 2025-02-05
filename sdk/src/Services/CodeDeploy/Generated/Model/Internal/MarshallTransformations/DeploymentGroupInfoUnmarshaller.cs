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
 * Do not modify this file. This file is generated from the codedeploy-2014-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CodeDeploy.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeploymentGroupInfo Object
    /// </summary>  
    public class DeploymentGroupInfoUnmarshaller : IJsonUnmarshaller<DeploymentGroupInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public DeploymentGroupInfo Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            DeploymentGroupInfo unmarshalledObject = new DeploymentGroupInfo();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("alarmConfiguration", targetDepth))
                {
                    var unmarshaller = AlarmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AlarmConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("applicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autoRollbackConfiguration", targetDepth))
                {
                    var unmarshaller = AutoRollbackConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AutoRollbackConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("autoScalingGroups", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<AutoScalingGroup, AutoScalingGroupUnmarshaller>(AutoScalingGroupUnmarshaller.Instance);
                    unmarshalledObject.AutoScalingGroups = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("blueGreenDeploymentConfiguration", targetDepth))
                {
                    var unmarshaller = BlueGreenDeploymentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BlueGreenDeploymentConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("computePlatform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputePlatform = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deploymentConfigName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentConfigName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deploymentGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentGroupId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deploymentGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentGroupName = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("deploymentStyle", targetDepth))
                {
                    var unmarshaller = DeploymentStyleUnmarshaller.Instance;
                    unmarshalledObject.DeploymentStyle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2TagFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<EC2TagFilter, EC2TagFilterUnmarshaller>(EC2TagFilterUnmarshaller.Instance);
                    unmarshalledObject.Ec2TagFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2TagSet", targetDepth))
                {
                    var unmarshaller = EC2TagSetUnmarshaller.Instance;
                    unmarshalledObject.Ec2TagSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecsServices", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ECSService, ECSServiceUnmarshaller>(ECSServiceUnmarshaller.Instance);
                    unmarshalledObject.EcsServices = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastAttemptedDeployment", targetDepth))
                {
                    var unmarshaller = LastDeploymentInfoUnmarshaller.Instance;
                    unmarshalledObject.LastAttemptedDeployment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lastSuccessfulDeployment", targetDepth))
                {
                    var unmarshaller = LastDeploymentInfoUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulDeployment = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("loadBalancerInfo", targetDepth))
                {
                    var unmarshaller = LoadBalancerInfoUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancerInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("onPremisesInstanceTagFilters", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<TagFilter, TagFilterUnmarshaller>(TagFilterUnmarshaller.Instance);
                    unmarshalledObject.OnPremisesInstanceTagFilters = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("onPremisesTagSet", targetDepth))
                {
                    var unmarshaller = OnPremisesTagSetUnmarshaller.Instance;
                    unmarshalledObject.OnPremisesTagSet = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("outdatedInstancesStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.OutdatedInstancesStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("serviceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRoleArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("targetRevision", targetDepth))
                {
                    var unmarshaller = RevisionLocationUnmarshaller.Instance;
                    unmarshalledObject.TargetRevision = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("terminationHookEnabled", targetDepth))
                {
                    var unmarshaller = NullableBoolUnmarshaller.Instance;
                    unmarshalledObject.TerminationHookEnabled = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("triggerConfigurations", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<TriggerConfig, TriggerConfigUnmarshaller>(TriggerConfigUnmarshaller.Instance);
                    unmarshalledObject.TriggerConfigurations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static DeploymentGroupInfoUnmarshaller _instance = new DeploymentGroupInfoUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DeploymentGroupInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}