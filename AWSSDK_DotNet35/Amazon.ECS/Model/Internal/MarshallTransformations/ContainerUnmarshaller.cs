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
    /// Response Unmarshaller for Container Object
    /// </summary>  
    public class ContainerUnmarshaller : IUnmarshaller<Container, XmlUnmarshallerContext>, IUnmarshaller<Container, JsonUnmarshallerContext>
    {
        public Container Unmarshall(XmlUnmarshallerContext context)
        {
            Container unmarshalledObject = new Container();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("containerArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ContainerArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("exitCode", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.ExitCode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("lastStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LastStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("networkBindings/member", targetDepth))
                    {
                        var unmarshaller = NetworkBindingUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.NetworkBindings.Add(item);
                        continue;
                    }
                    if (context.TestExpression("reason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Reason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("taskArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TaskArn = unmarshaller.Unmarshall(context);
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

        public Container Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ContainerUnmarshaller _instance = new ContainerUnmarshaller();        

        public static ContainerUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}