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
using ThirdParty.Json.LitJson;

namespace Amazon.CodeDeploy.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeploymentGroupInfo Object
    /// </summary>  
    public class DeploymentGroupInfoUnmarshaller : IUnmarshaller<DeploymentGroupInfo, XmlUnmarshallerContext>, IUnmarshaller<DeploymentGroupInfo, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        DeploymentGroupInfo IUnmarshaller<DeploymentGroupInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public DeploymentGroupInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            DeploymentGroupInfo unmarshalledObject = new DeploymentGroupInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("alarmConfiguration", targetDepth))
                {
                    var unmarshaller = AlarmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AlarmConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("applicationName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ApplicationName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoRollbackConfiguration", targetDepth))
                {
                    var unmarshaller = AutoRollbackConfigurationUnmarshaller.Instance;
                    unmarshalledObject.AutoRollbackConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoScalingGroups", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<AutoScalingGroup, AutoScalingGroupUnmarshaller>(AutoScalingGroupUnmarshaller.Instance);
                    unmarshalledObject.AutoScalingGroups = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("blueGreenDeploymentConfiguration", targetDepth))
                {
                    var unmarshaller = BlueGreenDeploymentConfigurationUnmarshaller.Instance;
                    unmarshalledObject.BlueGreenDeploymentConfiguration = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computePlatform", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ComputePlatform = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentConfigName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentConfigName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentGroupId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentGroupId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DeploymentGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("deploymentStyle", targetDepth))
                {
                    var unmarshaller = DeploymentStyleUnmarshaller.Instance;
                    unmarshalledObject.DeploymentStyle = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2TagFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<EC2TagFilter, EC2TagFilterUnmarshaller>(EC2TagFilterUnmarshaller.Instance);
                    unmarshalledObject.Ec2TagFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2TagSet", targetDepth))
                {
                    var unmarshaller = EC2TagSetUnmarshaller.Instance;
                    unmarshalledObject.Ec2TagSet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastAttemptedDeployment", targetDepth))
                {
                    var unmarshaller = LastDeploymentInfoUnmarshaller.Instance;
                    unmarshalledObject.LastAttemptedDeployment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lastSuccessfulDeployment", targetDepth))
                {
                    var unmarshaller = LastDeploymentInfoUnmarshaller.Instance;
                    unmarshalledObject.LastSuccessfulDeployment = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("loadBalancerInfo", targetDepth))
                {
                    var unmarshaller = LoadBalancerInfoUnmarshaller.Instance;
                    unmarshalledObject.LoadBalancerInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onPremisesInstanceTagFilters", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TagFilter, TagFilterUnmarshaller>(TagFilterUnmarshaller.Instance);
                    unmarshalledObject.OnPremisesInstanceTagFilters = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("onPremisesTagSet", targetDepth))
                {
                    var unmarshaller = OnPremisesTagSetUnmarshaller.Instance;
                    unmarshalledObject.OnPremisesTagSet = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("serviceRoleArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceRoleArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetRevision", targetDepth))
                {
                    var unmarshaller = RevisionLocationUnmarshaller.Instance;
                    unmarshalledObject.TargetRevision = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("triggerConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TriggerConfig, TriggerConfigUnmarshaller>(TriggerConfigUnmarshaller.Instance);
                    unmarshalledObject.TriggerConfigurations = unmarshaller.Unmarshall(context);
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