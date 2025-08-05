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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClusterInstanceGroupDetails Object
    /// </summary>  
    public class ClusterInstanceGroupDetailsUnmarshaller : IUnmarshaller<ClusterInstanceGroupDetails, XmlUnmarshallerContext>, IUnmarshaller<ClusterInstanceGroupDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClusterInstanceGroupDetails IUnmarshaller<ClusterInstanceGroupDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ClusterInstanceGroupDetails Unmarshall(JsonUnmarshallerContext context)
        {
            ClusterInstanceGroupDetails unmarshalledObject = new ClusterInstanceGroupDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CurrentCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.CurrentCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CurrentImageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CurrentImageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DesiredImageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DesiredImageId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ExecutionRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionRole = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceStorageConfigs", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ClusterInstanceStorageConfig, ClusterInstanceStorageConfigUnmarshaller>(ClusterInstanceStorageConfigUnmarshaller.Instance);
                    unmarshalledObject.InstanceStorageConfigs = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifeCycleConfig", targetDepth))
                {
                    var unmarshaller = ClusterLifeCycleConfigUnmarshaller.Instance;
                    unmarshalledObject.LifeCycleConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OnStartDeepHealthChecks", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.OnStartDeepHealthChecks = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OverrideVpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.OverrideVpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledUpdateConfig", targetDepth))
                {
                    var unmarshaller = ScheduledUpdateConfigUnmarshaller.Instance;
                    unmarshalledObject.ScheduledUpdateConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetCount", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.TargetCount = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreadsPerCore", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThreadsPerCore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingPlanArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingPlanArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingPlanStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingPlanStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ClusterInstanceGroupDetailsUnmarshaller _instance = new ClusterInstanceGroupDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterInstanceGroupDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}