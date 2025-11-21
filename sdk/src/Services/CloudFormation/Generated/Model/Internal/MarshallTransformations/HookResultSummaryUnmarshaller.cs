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
    /// Response Unmarshaller for HookResultSummary Object
    /// </summary>  
    public class HookResultSummaryUnmarshaller : IXmlUnmarshaller<HookResultSummary, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HookResultSummary Unmarshall(XmlUnmarshallerContext context)
        {
            HookResultSummary unmarshalledObject = new HookResultSummary();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("FailureMode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FailureMode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HookExecutionTarget", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HookExecutionTarget = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HookResultId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HookResultId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("HookStatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.HookStatusReason = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InvocationPoint", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InvocationPoint = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InvokedAt", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.InvokedAt = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TargetType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeConfigurationVersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeConfigurationVersionId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TypeVersionId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TypeVersionId = unmarshaller.Unmarshall(context);
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

        private static HookResultSummaryUnmarshaller _instance = new HookResultSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HookResultSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}