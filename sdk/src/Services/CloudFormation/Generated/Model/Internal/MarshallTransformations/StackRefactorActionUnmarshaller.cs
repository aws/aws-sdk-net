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
    /// Response Unmarshaller for StackRefactorAction Object
    /// </summary>  
    public class StackRefactorActionUnmarshaller : IXmlUnmarshaller<StackRefactorAction, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StackRefactorAction Unmarshall(XmlUnmarshallerContext context)
        {
            StackRefactorAction unmarshalledObject = new StackRefactorAction();
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
                    if (context.TestExpression("Description", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Description = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Detection", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Detection = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DetectionReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DetectionReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Entity", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Entity = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PhysicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceIdentifier", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceIdentifier = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceMapping", targetDepth))
                    {
                        var unmarshaller = ResourceMappingUnmarshaller.Instance;
                        unmarshalledObject.ResourceMapping = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TagResources/member", targetDepth))
                    {
                        var unmarshaller = TagUnmarshaller.Instance;
                        if (unmarshalledObject.TagResources == null)
                        {
                            unmarshalledObject.TagResources = new List<Tag>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.TagResources.Add(item);
                        continue;
                    }
                    if (context.TestExpression("UntagResources/member", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        if (unmarshalledObject.UntagResources == null)
                        {
                            unmarshalledObject.UntagResources = new List<string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.UntagResources.Add(item);
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

        private static StackRefactorActionUnmarshaller _instance = new StackRefactorActionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StackRefactorActionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}