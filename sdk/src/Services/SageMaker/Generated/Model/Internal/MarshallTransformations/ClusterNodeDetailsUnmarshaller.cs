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
    /// Response Unmarshaller for ClusterNodeDetails Object
    /// </summary>  
    public class ClusterNodeDetailsUnmarshaller : IUnmarshaller<ClusterNodeDetails, XmlUnmarshallerContext>, IUnmarshaller<ClusterNodeDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClusterNodeDetails IUnmarshaller<ClusterNodeDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ClusterNodeDetails Unmarshall(JsonUnmarshallerContext context)
        {
            ClusterNodeDetails unmarshalledObject = new ClusterNodeDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CapacityType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CapacityType = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("InstanceGroupName", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceGroupName = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("InstanceStatus", targetDepth))
                {
                    var unmarshaller = ClusterInstanceStatusDetailsUnmarshaller.Instance;
                    unmarshalledObject.InstanceStatus = unmarshaller.Unmarshall(context);
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
                if (context.TestExpression("KubernetesConfig", targetDepth))
                {
                    var unmarshaller = ClusterKubernetesConfigNodeDetailsUnmarshaller.Instance;
                    unmarshalledObject.KubernetesConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LastSoftwareUpdateTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LastSoftwareUpdateTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LaunchTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.LaunchTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("LifeCycleConfig", targetDepth))
                {
                    var unmarshaller = ClusterLifeCycleConfigUnmarshaller.Instance;
                    unmarshalledObject.LifeCycleConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("NodeLogicalId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.NodeLogicalId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("OverrideVpcConfig", targetDepth))
                {
                    var unmarshaller = VpcConfigUnmarshaller.Instance;
                    unmarshalledObject.OverrideVpcConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Placement", targetDepth))
                {
                    var unmarshaller = ClusterInstancePlacementUnmarshaller.Instance;
                    unmarshalledObject.Placement = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivateDnsHostname", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivateDnsHostname = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivatePrimaryIp", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivatePrimaryIp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PrivatePrimaryIpv6", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PrivatePrimaryIpv6 = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ThreadsPerCore", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ThreadsPerCore = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("UltraServerInfo", targetDepth))
                {
                    var unmarshaller = UltraServerInfoUnmarshaller.Instance;
                    unmarshalledObject.UltraServerInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ClusterNodeDetailsUnmarshaller _instance = new ClusterNodeDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterNodeDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}