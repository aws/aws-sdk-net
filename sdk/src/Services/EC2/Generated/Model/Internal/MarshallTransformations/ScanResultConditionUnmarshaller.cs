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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
#pragma warning disable CS0612,CS0618
namespace Amazon.EC2.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScanResultCondition Object
    /// </summary>  
    public class ScanResultConditionUnmarshaller : IXmlUnmarshaller<ScanResultCondition, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScanResultCondition Unmarshall(XmlUnmarshallerContext context)
        {
            ScanResultCondition unmarshalledObject = new ScanResultCondition();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("maxDaysSinceCriticalFixAvailable", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxDaysSinceCriticalFixAvailable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxDaysSinceHighFixAvailable", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxDaysSinceHighFixAvailable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxDaysSinceInformationalFixAvailable", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxDaysSinceInformationalFixAvailable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxDaysSinceLastFindingScan", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxDaysSinceLastFindingScan = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxDaysSinceLowFixAvailable", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxDaysSinceLowFixAvailable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maxDaysSinceMediumFixAvailable", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxDaysSinceMediumFixAvailable = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("maximumSeverityLabel", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MaximumSeverityLabel = unmarshaller.Unmarshall(context);
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

        private static ScanResultConditionUnmarshaller _instance = new ScanResultConditionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScanResultConditionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}