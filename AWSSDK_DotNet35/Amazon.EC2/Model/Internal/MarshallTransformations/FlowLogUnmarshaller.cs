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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.EC2.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for FlowLog Object
    /// </summary>  
    public class FlowLogUnmarshaller : IUnmarshaller<FlowLog, XmlUnmarshallerContext>, IUnmarshaller<FlowLog, JsonUnmarshallerContext>
    {
        public FlowLog Unmarshall(XmlUnmarshallerContext context)
        {
            FlowLog unmarshalledObject = new FlowLog();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("creationTime", targetDepth))
                    {
                        var unmarshaller = DateTimeUnmarshaller.Instance;
                        unmarshalledObject.CreationTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deliverLogsErrorMessage", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverLogsErrorMessage = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deliverLogsPermissionArn", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverLogsPermissionArn = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("deliverLogsStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.DeliverLogsStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("flowLogId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlowLogId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("flowLogStatus", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.FlowLogStatus = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("logGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.LogGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("resourceId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("trafficType", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.TrafficType = unmarshaller.Unmarshall(context);
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

        public FlowLog Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static FlowLogUnmarshaller _instance = new FlowLogUnmarshaller();        

        public static FlowLogUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}