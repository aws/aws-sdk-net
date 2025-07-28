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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.IoTSiteWise.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.IoTSiteWise.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ExecutionSummary Object
    /// </summary>  
    public class ExecutionSummaryUnmarshaller : IUnmarshaller<ExecutionSummary, XmlUnmarshallerContext>, IUnmarshaller<ExecutionSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ExecutionSummary IUnmarshaller<ExecutionSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public ExecutionSummary Unmarshall(JsonUnmarshallerContext context)
        {
            ExecutionSummary unmarshalledObject = new ExecutionSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("actionType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ActionType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionEndTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExecutionEndTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionEntityVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionEntityVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionStartTime", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStartTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionStatus", targetDepth))
                {
                    var unmarshaller = ExecutionStatusUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("resolveTo", targetDepth))
                {
                    var unmarshaller = ResolveToUnmarshaller.Instance;
                    unmarshalledObject.ResolveTo = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetResource", targetDepth))
                {
                    var unmarshaller = TargetResourceUnmarshaller.Instance;
                    unmarshalledObject.TargetResource = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("targetResourceVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TargetResourceVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static ExecutionSummaryUnmarshaller _instance = new ExecutionSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ExecutionSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}