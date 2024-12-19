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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.CloudWatch.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
#pragma warning disable CS0612,CS0618
namespace Amazon.CloudWatch.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Datapoint Object
    /// </summary>  
    public class DatapointUnmarshaller : IXmlUnmarshaller<Datapoint, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public Datapoint Unmarshall(XmlUnmarshallerContext context)
        {
            Datapoint unmarshalledObject = new Datapoint();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Average", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.Average = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("ExtendedStatistics/entry", targetDepth))
                    {
                        var unmarshaller = new XmlKeyValueUnmarshaller<string, double, StringUnmarshaller, DoubleUnmarshaller>(StringUnmarshaller.Instance, DoubleUnmarshaller.Instance);
                        if (unmarshalledObject.ExtendedStatistics == null)
                        {
                            unmarshalledObject.ExtendedStatistics = new Dictionary<string, double>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.ExtendedStatistics.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Maximum", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.Maximum = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Minimum", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.Minimum = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SampleCount", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.SampleCount = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Sum", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.Sum = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Timestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
                        unmarshalledObject.Timestamp = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Unit", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Unit = unmarshaller.Unmarshall(context);
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

        private static DatapointUnmarshaller _instance = new DatapointUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static DatapointUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}