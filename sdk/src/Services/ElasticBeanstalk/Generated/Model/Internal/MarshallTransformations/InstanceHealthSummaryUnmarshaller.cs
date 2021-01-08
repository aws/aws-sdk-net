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
 * Do not modify this file. This file is generated from the elasticbeanstalk-2010-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ElasticBeanstalk.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
namespace Amazon.ElasticBeanstalk.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for InstanceHealthSummary Object
    /// </summary>  
    public class InstanceHealthSummaryUnmarshaller : IUnmarshaller<InstanceHealthSummary, XmlUnmarshallerContext>, IUnmarshaller<InstanceHealthSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public InstanceHealthSummary Unmarshall(XmlUnmarshallerContext context)
        {
            InstanceHealthSummary unmarshalledObject = new InstanceHealthSummary();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Degraded", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Degraded = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Info", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Info = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("NoData", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.NoData = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Ok", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Ok = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Pending", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Pending = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Severe", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Severe = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Unknown", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Unknown = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Warning", targetDepth))
                    {
                        var unmarshaller = IntUnmarshaller.Instance;
                        unmarshalledObject.Warning = unmarshaller.Unmarshall(context);
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
        public InstanceHealthSummary Unmarshall(JsonUnmarshallerContext context)
        {
            return null;
        }


        private static InstanceHealthSummaryUnmarshaller _instance = new InstanceHealthSummaryUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InstanceHealthSummaryUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}