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
    /// Response Unmarshaller for MetricDataResult Object
    /// </summary>  
    public class MetricDataResultUnmarshaller : IXmlUnmarshaller<MetricDataResult, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public MetricDataResult Unmarshall(XmlUnmarshallerContext context)
        {
            MetricDataResult unmarshalledObject = new MetricDataResult();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("dimension", targetDepth))
                    {
                        var unmarshaller = CapacityManagerDimensionUnmarshaller.Instance;
                        unmarshalledObject.Dimension = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("metricValueSet/item", targetDepth))
                    {
                        var unmarshaller = MetricValueUnmarshaller.Instance;
                        if (unmarshalledObject.MetricValues == null)
                        {
                            unmarshalledObject.MetricValues = new List<MetricValue>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.MetricValues.Add(item);
                        continue;
                    }
                    if (context.TestExpression("timestamp", targetDepth))
                    {
                        var unmarshaller = NullableDateTimeUnmarshaller.Instance;
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

        private static MetricDataResultUnmarshaller _instance = new MetricDataResultUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static MetricDataResultUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}