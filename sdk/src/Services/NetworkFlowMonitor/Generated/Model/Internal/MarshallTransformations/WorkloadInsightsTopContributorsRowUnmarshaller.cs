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
 * Do not modify this file. This file is generated from the networkflowmonitor-2023-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.NetworkFlowMonitor.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.NetworkFlowMonitor.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkloadInsightsTopContributorsRow Object
    /// </summary>  
    public class WorkloadInsightsTopContributorsRowUnmarshaller : IUnmarshaller<WorkloadInsightsTopContributorsRow, XmlUnmarshallerContext>, IUnmarshaller<WorkloadInsightsTopContributorsRow, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkloadInsightsTopContributorsRow IUnmarshaller<WorkloadInsightsTopContributorsRow, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkloadInsightsTopContributorsRow Unmarshall(JsonUnmarshallerContext context)
        {
            WorkloadInsightsTopContributorsRow unmarshalledObject = new WorkloadInsightsTopContributorsRow();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("accountId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.AccountId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localAz", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalAz = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localRegion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalRegion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localSubnetArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalSubnetArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localSubnetId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalSubnetId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localVpcArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalVpcArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("localVpcId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.LocalVpcId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("remoteIdentifier", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RemoteIdentifier = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("value", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.Value = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkloadInsightsTopContributorsRowUnmarshaller _instance = new WorkloadInsightsTopContributorsRowUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkloadInsightsTopContributorsRowUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}