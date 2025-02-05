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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudFormation.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ResourceChange Object
    /// </summary>  
    public class ResourceChangeUnmarshaller : IXmlUnmarshaller<ResourceChange, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceChange Unmarshall(XmlUnmarshallerContext context)
        {
            ResourceChange unmarshalledObject = new ResourceChange();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Action", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Action = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("AfterContext", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AfterContext = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("BeforeContext", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.BeforeContext = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ChangeSetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ChangeSetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Details/member", targetDepth))
                    {
                        var unmarshaller = ResourceChangeDetailUnmarshaller.Instance;
                        if (unmarshalledObject.Details == null)
                        {
                            unmarshalledObject.Details = new List<ResourceChangeDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Details.Add(item);
                        continue;
                    }
                    if (context.TestExpression("LogicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ModuleInfo", targetDepth))
                    {
                        var unmarshaller = ModuleInfoUnmarshaller.Instance;
                        unmarshalledObject.ModuleInfo = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PhysicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PolicyAction", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PolicyAction = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Replacement", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Replacement = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Scope/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.Scope == null)
                        {
                            unmarshalledObject.Scope = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Scope.Add(item);
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

        private static ResourceChangeUnmarshaller _instance = new ResourceChangeUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceChangeUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}