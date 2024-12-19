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
    /// Response Unmarshaller for CustomizedMetricSpecification Object
    /// </summary>  
    public class CustomizedMetricSpecificationUnmarshaller : IXmlUnmarshaller<CustomizedMetricSpecification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CustomizedMetricSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            CustomizedMetricSpecification unmarshalledObject = new CustomizedMetricSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Dimensions/member", targetDepth))
                    {
                        var unmarshaller = MetricDimensionUnmarshaller.Instance;
                        if (unmarshalledObject.Dimensions == null)
                        {
                            unmarshalledObject.Dimensions = new List<MetricDimension>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Dimensions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MetricName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Metrics/member", targetDepth))
                    {
                        var unmarshaller = TargetTrackingMetricDataQueryUnmarshaller.Instance;
                        if (unmarshalledObject.Metrics == null)
                        {
                            unmarshalledObject.Metrics = new List<TargetTrackingMetricDataQuery>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Metrics.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Namespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Statistic", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Statistic = unmarshaller.Unmarshall(context);
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

        private static CustomizedMetricSpecificationUnmarshaller _instance = new CustomizedMetricSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CustomizedMetricSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}