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
    /// Response Unmarshaller for AnomalyDetector Object
    /// </summary>  
    public class AnomalyDetectorUnmarshaller : IXmlUnmarshaller<AnomalyDetector, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public AnomalyDetector Unmarshall(XmlUnmarshallerContext context)
        {
            AnomalyDetector unmarshalledObject = new AnomalyDetector();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("Configuration", targetDepth))
                    {
                        var unmarshaller = AnomalyDetectorConfigurationUnmarshaller.Instance;
                        unmarshalledObject.Configuration = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Dimensions/member", targetDepth))
                    {
                        var unmarshaller = DimensionUnmarshaller.Instance;
                        if (unmarshalledObject.Dimensions == null)
                        {
                            unmarshalledObject.Dimensions = new List<Dimension>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.Dimensions.Add(item);
                        continue;
                    }
                    if (context.TestExpression("MetricCharacteristics", targetDepth))
                    {
                        var unmarshaller = MetricCharacteristicsUnmarshaller.Instance;
                        unmarshalledObject.MetricCharacteristics = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MetricMathAnomalyDetector", targetDepth))
                    {
                        var unmarshaller = MetricMathAnomalyDetectorUnmarshaller.Instance;
                        unmarshalledObject.MetricMathAnomalyDetector = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MetricName", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MetricName = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Namespace", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Namespace = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SingleMetricAnomalyDetector", targetDepth))
                    {
                        var unmarshaller = SingleMetricAnomalyDetectorUnmarshaller.Instance;
                        unmarshalledObject.SingleMetricAnomalyDetector = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("Stat", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Stat = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("StateValue", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.StateValue = unmarshaller.Unmarshall(context);
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

        private static AnomalyDetectorUnmarshaller _instance = new AnomalyDetectorUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static AnomalyDetectorUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}