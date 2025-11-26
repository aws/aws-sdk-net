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
 * Do not modify this file. This file is generated from the cost-optimization-hub-2022-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostOptimizationHub.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.CostOptimizationHub.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceDetails Object
    /// </summary>  
    public class ResourceDetailsUnmarshaller : IUnmarshaller<ResourceDetails, XmlUnmarshallerContext>, IUnmarshaller<ResourceDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceDetails IUnmarshaller<ResourceDetails, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceDetails Unmarshall(JsonUnmarshallerContext context)
        {
            ResourceDetails unmarshalledObject = new ResourceDetails();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("auroraDbClusterStorage", targetDepth))
                {
                    var unmarshaller = AuroraDbClusterStorageUnmarshaller.Instance;
                    unmarshalledObject.AuroraDbClusterStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("computeSavingsPlans", targetDepth))
                {
                    var unmarshaller = ComputeSavingsPlansUnmarshaller.Instance;
                    unmarshalledObject.ComputeSavingsPlans = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("dynamoDbReservedCapacity", targetDepth))
                {
                    var unmarshaller = DynamoDbReservedCapacityUnmarshaller.Instance;
                    unmarshalledObject.DynamoDbReservedCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ebsVolume", targetDepth))
                {
                    var unmarshaller = EbsVolumeUnmarshaller.Instance;
                    unmarshalledObject.EbsVolume = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2AutoScalingGroup", targetDepth))
                {
                    var unmarshaller = Ec2AutoScalingGroupUnmarshaller.Instance;
                    unmarshalledObject.Ec2AutoScalingGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2Instance", targetDepth))
                {
                    var unmarshaller = Ec2InstanceUnmarshaller.Instance;
                    unmarshalledObject.Ec2Instance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2InstanceSavingsPlans", targetDepth))
                {
                    var unmarshaller = Ec2InstanceSavingsPlansUnmarshaller.Instance;
                    unmarshalledObject.Ec2InstanceSavingsPlans = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2ReservedInstances", targetDepth))
                {
                    var unmarshaller = Ec2ReservedInstancesUnmarshaller.Instance;
                    unmarshalledObject.Ec2ReservedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecsService", targetDepth))
                {
                    var unmarshaller = EcsServiceUnmarshaller.Instance;
                    unmarshalledObject.EcsService = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("elastiCacheReservedInstances", targetDepth))
                {
                    var unmarshaller = ElastiCacheReservedInstancesUnmarshaller.Instance;
                    unmarshalledObject.ElastiCacheReservedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("lambdaFunction", targetDepth))
                {
                    var unmarshaller = LambdaFunctionUnmarshaller.Instance;
                    unmarshalledObject.LambdaFunction = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("memoryDbReservedInstances", targetDepth))
                {
                    var unmarshaller = MemoryDbReservedInstancesUnmarshaller.Instance;
                    unmarshalledObject.MemoryDbReservedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("natGateway", targetDepth))
                {
                    var unmarshaller = NatGatewayUnmarshaller.Instance;
                    unmarshalledObject.NatGateway = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("openSearchReservedInstances", targetDepth))
                {
                    var unmarshaller = OpenSearchReservedInstancesUnmarshaller.Instance;
                    unmarshalledObject.OpenSearchReservedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rdsDbInstance", targetDepth))
                {
                    var unmarshaller = RdsDbInstanceUnmarshaller.Instance;
                    unmarshalledObject.RdsDbInstance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rdsDbInstanceStorage", targetDepth))
                {
                    var unmarshaller = RdsDbInstanceStorageUnmarshaller.Instance;
                    unmarshalledObject.RdsDbInstanceStorage = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("rdsReservedInstances", targetDepth))
                {
                    var unmarshaller = RdsReservedInstancesUnmarshaller.Instance;
                    unmarshalledObject.RdsReservedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("redshiftReservedInstances", targetDepth))
                {
                    var unmarshaller = RedshiftReservedInstancesUnmarshaller.Instance;
                    unmarshalledObject.RedshiftReservedInstances = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sageMakerSavingsPlans", targetDepth))
                {
                    var unmarshaller = SageMakerSavingsPlansUnmarshaller.Instance;
                    unmarshalledObject.SageMakerSavingsPlans = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceDetailsUnmarshaller _instance = new ResourceDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}