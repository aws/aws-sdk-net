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
    /// Response Unmarshaller for PredictiveScalingConfiguration Object
    /// </summary>  
    public class PredictiveScalingConfigurationUnmarshaller : IXmlUnmarshaller<PredictiveScalingConfiguration, XmlUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public PredictiveScalingConfiguration Unmarshall(XmlUnmarshallerContext context)
        {
            PredictiveScalingConfiguration unmarshalledObject = new PredictiveScalingConfiguration();
            int originalDepth = context.CurrentDepth;
            int targetDepth = originalDepth + 1;
            
            if (context.IsStartOfDocument) 
               targetDepth += 2;
            
            while (context.ReadAtDepth(originalDepth))
            {
                if (context.IsStartElement || context.IsAttribute)
                {
                    if (context.TestExpression("MaxCapacityBreachBehavior", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.MaxCapacityBreachBehavior = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MaxCapacityBuffer", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.MaxCapacityBuffer = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("MetricSpecifications/member", targetDepth))
                    {
                        var unmarshaller = PredictiveScalingMetricSpecificationUnmarshaller.Instance;
                        if (unmarshalledObject.MetricSpecifications == null)
                        {
                            unmarshalledObject.MetricSpecifications = new List<PredictiveScalingMetricSpecification>();
                        }
                        var item = unmarshaller.Unmarshall(context);
                        unmarshalledObject.MetricSpecifications.Add(item);
                        continue;
                    }
                    if (context.TestExpression("Mode", targetDepth))
                    {
                        var unmarshaller = StringUnmarshaller.Instance;
                        unmarshalledObject.Mode = unmarshaller.Unmarshall(context);
                        continue;
                    }
                    if (context.TestExpression("SchedulingBufferTime", targetDepth))
                    {
                        var unmarshaller = NullableIntUnmarshaller.Instance;
                        unmarshalledObject.SchedulingBufferTime = unmarshaller.Unmarshall(context);
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

        private static PredictiveScalingConfigurationUnmarshaller _instance = new PredictiveScalingConfigurationUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PredictiveScalingConfigurationUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}