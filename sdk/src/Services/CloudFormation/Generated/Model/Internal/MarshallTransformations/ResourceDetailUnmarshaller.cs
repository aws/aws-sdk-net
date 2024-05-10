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
    /// Response Unmarshaller for ResourceDetail Object
    /// </summary>  
    public class ResourceDetailUnmarshaller : IUnmarshaller<ResourceDetail, XmlUnmarshallerContext>, IUnmarshaller<ResourceDetail, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceDetail Unmarshall(XmlUnmarshallerContext context)
        {
            ResourceDetail unmarshalledObject = new ResourceDetail();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("LogicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceIdentifier/entry", targetDepth))
                    {
                        var unmarshaller = new KeyValueUnmarshaller<string, string, StringUnmarshaller, StringUnmarshaller>(StringUnmarshaller.Instance, StringUnmarshaller.Instance);
                        if (unmarshalledObject.ResourceIdentifier == null)
                        {
                            unmarshalledObject.ResourceIdentifier = new Dictionary<string, string>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ResourceIdentifier.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ResourceStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceStatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceStatusReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Warnings/member", targetDepth))
                    {
                        var unmarshaller = WarningDetailUnmarshaller.Instance;
                        if (unmarshalledObject.Warnings == null)
                        {
                            unmarshalledObject.Warnings = new List<WarningDetail>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Warnings.Add(item);
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

        /// <summary>
        /// Unmarshaller error response to exception.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ResourceDetail Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ResourceDetailUnmarshaller _instance = new ResourceDetailUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ResourceDetailUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}