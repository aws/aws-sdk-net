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
    /// Response Unmarshaller for ContainerDefinition Object
    /// </summary>  
    public class ContainerDefinitionUnmarshaller : IUnmarshaller<ContainerDefinition, XmlUnmarshallerContext>, IUnmarshaller<ContainerDefinition, JsonUnmarshallerContext>
    {
        public ContainerDefinition Unmarshall(XmlUnmarshallerContext context)
        {
            ContainerDefinition unmarshalledObject = new ContainerDefinition();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("command/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Command.Add(item);
                        continue;
                    }
                    if (context.TestExpression("cpu", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Cpu = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("entryPoint/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.EntryPoint.Add(item);
                        continue;
                    }
                    if (context.TestExpression("environment/member", targetDepth))
                    {
                        var unmarshaller = KeyValuePairUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Environment.Add(item);
                        continue;
                    }
                    if (context.TestExpression("essential", targetDepth))
                    {
                        var unmarshaller = BoolUnmarshaller.Instance;
                        unmarshalledObject.Essential = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("image", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Image = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("links/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Links.Add(item);
                        continue;
                    }
                    if (context.TestExpression("memory", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Memory = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("name", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Name = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("portMappings/member", targetDepth))
                    {
                        var unmarshaller = PortMappingUnmarshaller.Instance;
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PortMappings.Add(item);
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

        public ContainerDefinition Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ContainerDefinitionUnmarshaller _instance = new ContainerDefinitionUnmarshaller();        

        public static ContainerDefinitionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}