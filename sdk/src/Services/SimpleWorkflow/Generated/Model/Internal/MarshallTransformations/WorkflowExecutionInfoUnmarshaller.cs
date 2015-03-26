/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the swf-2012-01-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SimpleWorkflow.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SimpleWorkflow.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for WorkflowExecutionInfo Object
    /// </summary>  
    public class WorkflowExecutionInfoUnmarshaller : IUnmarshaller<WorkflowExecutionInfo, XmlUnmarshallerContext>, IUnmarshaller<WorkflowExecutionInfo, JsonUnmarshallerContext>
    {
        WorkflowExecutionInfo IUnmarshaller<WorkflowExecutionInfo, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public WorkflowExecutionInfo Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            WorkflowExecutionInfo unmarshalledObject = new WorkflowExecutionInfo();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("cancelRequested", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.CancelRequested = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("closeStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CloseStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("closeTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.CloseTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("execution", targetDepth))
                {
                    var unmarshaller = WorkflowExecutionUnmarshaller.Instance;
                    unmarshalledObject.Execution = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionStatus", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStatus = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("parent", targetDepth))
                {
                    var unmarshaller = WorkflowExecutionUnmarshaller.Instance;
                    unmarshalledObject.Parent = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("startTimestamp", targetDepth))
                {
                    var unmarshaller = DateTimeUnmarshaller.Instance;
                    unmarshalledObject.StartTimestamp = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tagList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TagList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("workflowType", targetDepth))
                {
                    var unmarshaller = WorkflowTypeUnmarshaller.Instance;
                    unmarshalledObject.WorkflowType = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static WorkflowExecutionInfoUnmarshaller _instance = new WorkflowExecutionInfoUnmarshaller();        

        public static WorkflowExecutionInfoUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}