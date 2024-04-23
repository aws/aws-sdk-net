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
    /// Response Unmarshaller for StackInstanceResourceDriftsSummary Object
    /// </summary>  
    public class StackInstanceResourceDriftsSummaryUnmarshaller : IUnmarshaller<StackInstanceResourceDriftsSummary, XmlUnmarshallerContext>, IUnmarshaller<StackInstanceResourceDriftsSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public StackInstanceResourceDriftsSummary Unmarshall(XmlUnmarshallerContext context)
        {
            StackInstanceResourceDriftsSummary unmarshalledObject = new StackInstanceResourceDriftsSummary();
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
                    if (context.TestExpression("PhysicalResourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.PhysicalResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PhysicalResourceIdContext/member", targetDepth))
                    {
                        var unmarshaller = PhysicalResourceIdContextKeyValuePairUnmarshaller.Instance;
                        if (unmarshalledObject.PhysicalResourceIdContext == null)
                        {
                            unmarshalledObject.PhysicalResourceIdContext = new List<PhysicalResourceIdContextKeyValuePair>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PhysicalResourceIdContext.Add(item);
                        continue;
                    }
                    if (context.TestExpression("PropertyDifferences/member", targetDepth))
                    {
                        var unmarshaller = PropertyDifferenceUnmarshaller.Instance;
                        if (unmarshalledObject.PropertyDifferences == null)
                        {
                            unmarshalledObject.PropertyDifferences = new List<PropertyDifference>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.PropertyDifferences.Add(item);
                        continue;
                    }
                    if (context.TestExpression("ResourceType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceType = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StackResourceDriftStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StackResourceDriftStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
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
        public StackInstanceResourceDriftsSummary Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static StackInstanceResourceDriftsSummaryUnmarshaller _instance = new StackInstanceResourceDriftsSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static StackInstanceResourceDriftsSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
#pragma warning restore CS0612,CS0618