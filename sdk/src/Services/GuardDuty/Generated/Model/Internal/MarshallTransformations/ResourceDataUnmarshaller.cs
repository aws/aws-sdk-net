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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.GuardDuty.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceData Object
    /// </summary>  
    public class ResourceDataUnmarshaller : IUnmarshaller<ResourceData, XmlUnmarshallerContext>, IUnmarshaller<ResourceData, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ResourceData IUnmarshaller<ResourceData, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ResourceData Unmarshall(JsonUnmarshallerContext context)
        {
            ResourceData unmarshalledObject = new ResourceData();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accessKey", targetDepth))
                {
                    var unmarshaller = AccessKeyUnmarshaller.Instance;
                    unmarshalledObject.AccessKey = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("autoscalingAutoScalingGroup", targetDepth))
                {
                    var unmarshaller = AutoscalingAutoScalingGroupUnmarshaller.Instance;
                    unmarshalledObject.AutoscalingAutoScalingGroup = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("cloudformationStack", targetDepth))
                {
                    var unmarshaller = CloudformationStackUnmarshaller.Instance;
                    unmarshalledObject.CloudformationStack = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("container", targetDepth))
                {
                    var unmarshaller = ContainerFindingResourceUnmarshaller.Instance;
                    unmarshalledObject.Container = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2Image", targetDepth))
                {
                    var unmarshaller = Ec2ImageUnmarshaller.Instance;
                    unmarshalledObject.Ec2Image = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2Instance", targetDepth))
                {
                    var unmarshaller = Ec2InstanceUnmarshaller.Instance;
                    unmarshalledObject.Ec2Instance = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2LaunchTemplate", targetDepth))
                {
                    var unmarshaller = Ec2LaunchTemplateUnmarshaller.Instance;
                    unmarshalledObject.Ec2LaunchTemplate = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2NetworkInterface", targetDepth))
                {
                    var unmarshaller = Ec2NetworkInterfaceUnmarshaller.Instance;
                    unmarshalledObject.Ec2NetworkInterface = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ec2Vpc", targetDepth))
                {
                    var unmarshaller = Ec2VpcUnmarshaller.Instance;
                    unmarshalledObject.Ec2Vpc = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecsCluster", targetDepth))
                {
                    var unmarshaller = EcsClusterUnmarshaller.Instance;
                    unmarshalledObject.EcsCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ecsTask", targetDepth))
                {
                    var unmarshaller = EcsTaskUnmarshaller.Instance;
                    unmarshalledObject.EcsTask = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("eksCluster", targetDepth))
                {
                    var unmarshaller = EksClusterUnmarshaller.Instance;
                    unmarshalledObject.EksCluster = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("iamInstanceProfile", targetDepth))
                {
                    var unmarshaller = IamInstanceProfileV2Unmarshaller.Instance;
                    unmarshalledObject.IamInstanceProfile = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("kubernetesWorkload", targetDepth))
                {
                    var unmarshaller = KubernetesWorkloadUnmarshaller.Instance;
                    unmarshalledObject.KubernetesWorkload = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Bucket", targetDepth))
                {
                    var unmarshaller = S3BucketUnmarshaller.Instance;
                    unmarshalledObject.S3Bucket = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("s3Object", targetDepth))
                {
                    var unmarshaller = S3ObjectUnmarshaller.Instance;
                    unmarshalledObject.S3Object = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceDataUnmarshaller _instance = new ResourceDataUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDataUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}