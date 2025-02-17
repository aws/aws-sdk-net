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
 * Do not modify this file. This file is generated from the application-autoscaling-2016-02-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.ApplicationAutoScaling.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

#pragma warning disable CS0612,CS0618
namespace Amazon.ApplicationAutoScaling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PredictiveScalingMetric Object
    /// </summary>  
    public class PredictiveScalingMetricUnmarshaller : IUnmarshaller<PredictiveScalingMetric, XmlUnmarshallerContext>, IUnmarshaller<PredictiveScalingMetric, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PredictiveScalingMetric IUnmarshaller<PredictiveScalingMetric, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PredictiveScalingMetric Unmarshall(JsonUnmarshallerContext context)
        {
            PredictiveScalingMetric unmarshalledObject = new PredictiveScalingMetric();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("Dimensions", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<PredictiveScalingMetricDimension, PredictiveScalingMetricDimensionUnmarshaller>(PredictiveScalingMetricDimensionUnmarshaller.Instance);
                    unmarshalledObject.Dimensions = unmarshaller.Unmarshall(context);
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
            }
            return unmarshalledObject;
        }


        private static PredictiveScalingMetricUnmarshaller _instance = new PredictiveScalingMetricUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static PredictiveScalingMetricUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}