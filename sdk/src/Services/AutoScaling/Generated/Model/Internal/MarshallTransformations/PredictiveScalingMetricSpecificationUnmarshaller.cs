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
    /// Response Unmarshaller for PredictiveScalingMetricSpecification Object
    /// </summary>  
    public class PredictiveScalingMetricSpecificationUnmarshaller : IXmlUnmarshaller<PredictiveScalingMetricSpecification, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PredictiveScalingMetricSpecification Unmarshall(XmlUnmarshallerContext context)
        {
            PredictiveScalingMetricSpecification unmarshalledObject = new PredictiveScalingMetricSpecification();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("CustomizedCapacityMetricSpecification", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingCustomizedCapacityMetricUnmarshaller.Instance;
                        unmarshalledObject.CustomizedCapacityMetricSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomizedLoadMetricSpecification", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingCustomizedLoadMetricUnmarshaller.Instance;
                        unmarshalledObject.CustomizedLoadMetricSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("CustomizedScalingMetricSpecification", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingCustomizedScalingMetricUnmarshaller.Instance;
                        unmarshalledObject.CustomizedScalingMetricSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PredefinedLoadMetricSpecification", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingPredefinedLoadMetricUnmarshaller.Instance;
                        unmarshalledObject.PredefinedLoadMetricSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PredefinedMetricPairSpecification", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingPredefinedMetricPairUnmarshaller.Instance;
                        unmarshalledObject.PredefinedMetricPairSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("PredefinedScalingMetricSpecification", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingPredefinedScalingMetricUnmarshaller.Instance;
                        unmarshalledObject.PredefinedScalingMetricSpecification = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("TargetValue", targetDepth))
                    {
                        var unmarshaller = NullableDoubleUnmarshaller.Instance;
                        unmarshalledObject.TargetValue = unmarshaller.Unmarshall(context);
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

        private static PredictiveScalingMetricSpecificationUnmarshaller _instance = new PredictiveScalingMetricSpecificationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PredictiveScalingMetricSpecificationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}