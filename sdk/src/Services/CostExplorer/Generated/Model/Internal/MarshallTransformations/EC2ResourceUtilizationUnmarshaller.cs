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
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CostExplorer.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.CostExplorer.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for EC2ResourceUtilization Object
    /// </summary>  
    public class EC2ResourceUtilizationUnmarshaller : IJsonUnmarshaller<EC2ResourceUtilization, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public EC2ResourceUtilization Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            EC2ResourceUtilization unmarshalledObject = new EC2ResourceUtilization();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("DiskResourceUtilization", targetDepth))
                {
                    var unmarshaller = DiskResourceUtilizationUnmarshaller.Instance;
                    unmarshalledObject.DiskResourceUtilization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("EBSResourceUtilization", targetDepth))
                {
                    var unmarshaller = EBSResourceUtilizationUnmarshaller.Instance;
                    unmarshalledObject.EBSResourceUtilization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxCpuUtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxCpuUtilizationPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxMemoryUtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxMemoryUtilizationPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("MaxStorageUtilizationPercentage", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.MaxStorageUtilizationPercentage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("NetworkResourceUtilization", targetDepth))
                {
                    var unmarshaller = NetworkResourceUtilizationUnmarshaller.Instance;
                    unmarshalledObject.NetworkResourceUtilization = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static EC2ResourceUtilizationUnmarshaller _instance = new EC2ResourceUtilizationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static EC2ResourceUtilizationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}