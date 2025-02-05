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
 * Do not modify this file. This file is generated from the pcs-2023-02-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.PCS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.PCS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ComputeNodeGroup Object
    /// </summary>  
    public class ComputeNodeGroupUnmarshaller : IJsonUnmarshaller<ComputeNodeGroup, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public ComputeNodeGroup Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            ComputeNodeGroup unmarshalledObject = new ComputeNodeGroup();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("amiId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AmiId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("arn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Arn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("clusterId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ClusterId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("createdAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.CreatedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("customLaunchTemplate", targetDepth))
                {
                    var unmarshaller = CustomLaunchTemplateUnmarshaller.Instance;
                    unmarshalledObject.CustomLaunchTemplate = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("errorInfo", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<ErrorInfo, ErrorInfoUnmarshaller>(ErrorInfoUnmarshaller.Instance);
                    unmarshalledObject.ErrorInfo = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("iamInstanceProfileArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.IamInstanceProfileArn = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("id", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Id = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("instanceConfigs", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<InstanceConfig, InstanceConfigUnmarshaller>(InstanceConfigUnmarshaller.Instance);
                    unmarshalledObject.InstanceConfigs = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("modifiedAt", targetDepth))
                {
                    var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                    unmarshalledObject.ModifiedAt = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("name", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Name = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("purchaseOption", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PurchaseOption = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("scalingConfiguration", targetDepth))
                {
                    var unmarshaller = ScalingConfigurationUnmarshaller.Instance;
                    unmarshalledObject.ScalingConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("slurmConfiguration", targetDepth))
                {
                    var unmarshaller = ComputeNodeGroupSlurmConfigurationUnmarshaller.Instance;
                    unmarshalledObject.SlurmConfiguration = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("spotOptions", targetDepth))
                {
                    var unmarshaller = SpotOptionsUnmarshaller.Instance;
                    unmarshalledObject.SpotOptions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("status", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Status = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("subnetIds", targetDepth))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.SubnetIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ComputeNodeGroupUnmarshaller _instance = new ComputeNodeGroupUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ComputeNodeGroupUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}