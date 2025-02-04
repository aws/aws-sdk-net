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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.AutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceRefresh Object
    /// </summary>  
    public class InstanceRefreshUnmarshaller : IXmlUnmarshaller<InstanceRefresh, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceRefresh Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceRefresh unmarshalledObject = new InstanceRefresh();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("AutoScalingGroupName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.AutoScalingGroupName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("DesiredConfiguration", targetDepth))
                    {
                        var unmarshaller = DesiredConfigurationUnmarshaller.Instance;
                        unmarshalledObject.DesiredConfiguration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("EndTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.EndTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstanceRefreshId", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.InstanceRefreshId = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("InstancesToUpdate", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.InstancesToUpdate = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PercentageComplete", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.PercentageComplete = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Preferences", targetDepth))
                    {
                        var unmarshaller = RefreshPreferencesUnmarshaller.Instance;
                        unmarshalledObject.Preferences = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ProgressDetails", targetDepth))
                    {
                        var unmarshaller = InstanceRefreshProgressDetailsUnmarshaller.Instance;
                        unmarshalledObject.ProgressDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("RollbackDetails", targetDepth))
                    {
                        var unmarshaller = RollbackDetailsUnmarshaller.Instance;
                        unmarshalledObject.RollbackDetails = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StartTime", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.StartTime = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Status", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Status = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StatusReason", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StatusReason = unmarshaller.Unmarshall(context);
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

        private static InstanceRefreshUnmarshaller _instance = new InstanceRefreshUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceRefreshUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}