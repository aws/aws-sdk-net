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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Batch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.Batch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComputeResource Object
    /// </summary>  
    public class ComputeResourceUnmarshaller : IJsonUnmarshaller<ComputeResource, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ComputeResource Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ComputeResource unmarshalledObject = new ComputeResource();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("allocationStrategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AllocationStrategy = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("bidPercentage", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.BidPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("desiredvCpus", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.DesiredvCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2Configuration", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<Ec2Configuration, Ec2ConfigurationUnmarshaller>(Ec2ConfigurationUnmarshaller.Instance);
                    unmarshalledObject.Ec2Configuration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ec2KeyPair", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Ec2KeyPair = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("imageId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ImageId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InstanceRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceTypes", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.InstanceTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("launchTemplate", targetDepth))
                {
                    var unmarshaller = LaunchTemplateSpecificationUnmarshaller.Instance;
                    unmarshalledObject.LaunchTemplate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("maxvCpus", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MaxvCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("minvCpus", targetDepth))
                {
                    var unmarshaller = NullableIntUnmarshaller.Instance;
                    unmarshalledObject.MinvCpus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("placementGroup", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PlacementGroup = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("securityGroupIds", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SecurityGroupIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("spotIamFleetRole", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SpotIamFleetRole = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subnets", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.Subnets = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("tags", targetDepth))
                {
                    var unmarshaller = new JsonDictionaryUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                    unmarshalledObject.Tags = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("type", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Type = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ComputeResourceUnmarshaller _instance = new ComputeResourceUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComputeResourceUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}