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
    /// Response Unmarshaller for WorkflowTypeConfiguration Object
    /// </summary>  
    public class WorkflowTypeConfigurationUnmarshaller : IUnmarshaller<WorkflowTypeConfiguration, XmlUnmarshallerContext>, IUnmarshaller<WorkflowTypeConfiguration, JsonUnmarshallerContext>
    {
        WorkflowTypeConfiguration IUnmarshaller<WorkflowTypeConfiguration, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        public WorkflowTypeConfiguration Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            WorkflowTypeConfiguration unmarshalledObject = new WorkflowTypeConfiguration();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("defaultChildPolicy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultChildPolicy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultExecutionStartToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultExecutionStartToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskList", targetDepth))
                {
                    var unmarshaller = TaskListUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskList = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("defaultTaskStartToCloseTimeout", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.DefaultTaskStartToCloseTimeout = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static WorkflowTypeConfigurationUnmarshaller _instance = new WorkflowTypeConfigurationUnmarshaller();        

        public static WorkflowTypeConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}