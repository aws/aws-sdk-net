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
 * Do not modify this file. This file is generated from the mwaa-serverless-2024-07-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.MWAAServerless.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.MWAAServerless.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkflowRunSummary Object
    /// </summary>  
    public class WorkflowRunSummaryUnmarshaller : IUnmarshaller<WorkflowRunSummary, XmlUnmarshallerContext>, IUnmarshaller<WorkflowRunSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        WorkflowRunSummary IUnmarshaller<WorkflowRunSummary, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public WorkflowRunSummary Unmarshall(JsonUnmarshallerContext context)
        {
            WorkflowRunSummary unmarshalledObject = new WorkflowRunSummary();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("RunDetailSummary", targetDepth))
                {
                    var unmarshaller = RunDetailSummaryUnmarshaller.Instance;
                    unmarshalledObject.RunDetailSummary = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RunType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RunType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkflowArn", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkflowArn = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("WorkflowVersion", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkflowVersion = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static WorkflowRunSummaryUnmarshaller _instance = new WorkflowRunSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static WorkflowRunSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}