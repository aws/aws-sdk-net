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
namespace Amazon.CloudFormation.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ChangeSetHookTargetDetails Object
    /// </summary>  
    public class ChangeSetHookTargetDetailsUnmarshaller : IUnmarshaller<ChangeSetHookTargetDetails, XmlUnmarshallerContext>, IUnmarshaller<ChangeSetHookTargetDetails, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ChangeSetHookTargetDetails Unmarshall(XmlUnmarshallerContext context)
        {
            ChangeSetHookTargetDetails unmarshalledObject = new ChangeSetHookTargetDetails();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("ResourceTargetDetails", targetDepth))
                    {
                        var unmarshaller = ChangeSetHookResourceTargetDetailsUnmarshaller.Instance;
                        unmarshalledObject.ResourceTargetDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetType = unmarshaller.Unmarshall(context);
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
        public ChangeSetHookTargetDetails Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static ChangeSetHookTargetDetailsUnmarshaller _instance = new ChangeSetHookTargetDetailsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ChangeSetHookTargetDetailsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}