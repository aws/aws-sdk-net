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
    /// Response Unmarshaller for StartChildWorkflowExecutionInitiatedEventAttributes Object
    /// </summary>  
    public class StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller : IUnmarshaller<StartChildWorkflowExecutionInitiatedEventAttributes, XmlUnmarshallerContext>, IUnmarshaller<StartChildWorkflowExecutionInitiatedEventAttributes, JsonUnmarshallerContext>
    {
        StartChildWorkflowExecutionInitiatedEventAttributes IUnmarshaller<StartChildWorkflowExecutionInitiatedEventAttributes, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public StartChildWorkflowExecutionInitiatedEventAttributes Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            StartChildWorkflowExecutionInitiatedEventAttributes unmarshalledObject = new StartChildWorkflowExecutionInitiatedEventAttributes();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("childPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ChildPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("control", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Control = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("decisionTaskCompletedEventId", targetDepth))
                {
                    var unmarshaller = LongUnmarshaller.Instance;
                    unmarshalledObject.DecisionTaskCompletedEventId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("executionStartToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ExecutionStartToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("input", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Input = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("tagList", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.TagList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskList", targetDepth))
                {
                    var unmarshaller = TaskListUnmarshaller.Instance;
                    unmarshalledObject.TaskList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("taskStartToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TaskStartToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("workflowId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.WorkflowId = unmarshaller.Unmarshall(context);
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


        private static StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller _instance = new StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller();        

        public static StartChildWorkflowExecutionInitiatedEventAttributesUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}