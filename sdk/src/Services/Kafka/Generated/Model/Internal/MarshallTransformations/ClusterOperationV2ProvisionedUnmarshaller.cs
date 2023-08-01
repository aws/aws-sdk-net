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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Kafka.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Kafka.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ClusterOperationV2Provisioned Object
    /// </summary>  
    public class ClusterOperationV2ProvisionedUnmarshaller : IUnmarshaller<ClusterOperationV2Provisioned, XmlUnmarshallerContext>, IUnmarshaller<ClusterOperationV2Provisioned, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ClusterOperationV2Provisioned IUnmarshaller<ClusterOperationV2Provisioned, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ClusterOperationV2Provisioned Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ClusterOperationV2Provisioned unmarshalledObject = new ClusterOperationV2Provisioned();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("operationSteps", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<ClusterOperationStep, ClusterOperationStepUnmarshaller>(ClusterOperationStepUnmarshaller.Instance);
                    unmarshalledObject.OperationSteps = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("sourceClusterInfo", targetDepth))
                {
                    var unmarshaller = MutableClusterInfoUnmarshaller.Instance;
                    unmarshalledObject.SourceClusterInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetClusterInfo", targetDepth))
                {
                    var unmarshaller = MutableClusterInfoUnmarshaller.Instance;
                    unmarshalledObject.TargetClusterInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("vpcConnectionInfo", targetDepth))
                {
                    var unmarshaller = VpcConnectionInfoUnmarshaller.Instance;
                    unmarshalledObject.VpcConnectionInfo = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ClusterOperationV2ProvisionedUnmarshaller _instance = new ClusterOperationV2ProvisionedUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ClusterOperationV2ProvisionedUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}