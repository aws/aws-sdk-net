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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Resource Object
    /// </summary>  
    public class ResourceUnmarshaller : IJsonUnmarshaller<Resource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public Resource Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            Resource unmarshalledObject = new Resource();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accessKeyDetails", targetDepth))
                {
                    var unmarshaller = AccessKeyDetailsUnmarshaller.Instance;
                    unmarshalledObject.AccessKeyDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("containerDetails", targetDepth))
                {
                    var unmarshaller = ContainerUnmarshaller.Instance;
                    unmarshalledObject.ContainerDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ebsVolumeDetails", targetDepth))
                {
                    var unmarshaller = EbsVolumeDetailsUnmarshaller.Instance;
                    unmarshalledObject.EbsVolumeDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ecsClusterDetails", targetDepth))
                {
                    var unmarshaller = EcsClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.EcsClusterDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("eksClusterDetails", targetDepth))
                {
                    var unmarshaller = EksClusterDetailsUnmarshaller.Instance;
                    unmarshalledObject.EksClusterDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceDetails", targetDepth))
                {
                    var unmarshaller = InstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.InstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("kubernetesDetails", targetDepth))
                {
                    var unmarshaller = KubernetesDetailsUnmarshaller.Instance;
                    unmarshalledObject.KubernetesDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("lambdaDetails", targetDepth))
                {
                    var unmarshaller = LambdaDetailsUnmarshaller.Instance;
                    unmarshalledObject.LambdaDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rdsDbInstanceDetails", targetDepth))
                {
                    var unmarshaller = RdsDbInstanceDetailsUnmarshaller.Instance;
                    unmarshalledObject.RdsDbInstanceDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rdsDbUserDetails", targetDepth))
                {
                    var unmarshaller = RdsDbUserDetailsUnmarshaller.Instance;
                    unmarshalledObject.RdsDbUserDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("rdsLimitlessDbDetails", targetDepth))
                {
                    var unmarshaller = RdsLimitlessDbDetailsUnmarshaller.Instance;
                    unmarshalledObject.RdsLimitlessDbDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("resourceType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("s3BucketDetails", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<S3BucketDetail, S3BucketDetailUnmarshaller>(S3BucketDetailUnmarshaller.Instance);
                    unmarshalledObject.S3BucketDetails = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ResourceUnmarshaller _instance = new ResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}