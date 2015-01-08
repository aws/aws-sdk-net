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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ECS.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ECS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TaskDefinition Object
    /// </summary>  
    public class TaskDefinitionUnmarshaller : IUnmarshaller<TaskDefinition, XmlUnmarshallerContext>, IUnmarshaller<TaskDefinition, JsonUnmarshallerContext>
    {
        public TaskDefinition Unmarshall(XmlUnmarshallerContext context)
        {
            TaskDefinition unmarshalledObject = new TaskDefinition();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("containerDefinitions/member", targetDepth))
                    {
                        var unmarshaller = ContainerDefinitionUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ContainerDefinitions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("family", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Family = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("revision", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Revision = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("taskDefinitionArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TaskDefinitionArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                }
                else if (context.IsEndElement && context.CurrentDepth < originalDepth)
                {
                    return unmarshalledObject;
                }
            }

            return unmarshalledObject;
        }

        public TaskDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static TaskDefinitionUnmarshaller _instance = new TaskDefinitionUnmarshaller();        

        public static TaskDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}