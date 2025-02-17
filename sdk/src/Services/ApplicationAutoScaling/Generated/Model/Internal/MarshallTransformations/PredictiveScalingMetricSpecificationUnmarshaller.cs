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
    /// Response Unmarshaller for PredictiveScalingMetricSpecification Object
    /// </summary>  
    public class PredictiveScalingMetricSpecificationUnmarshaller : IUnmarshaller<PredictiveScalingMetricSpecification, XmlUnmarshallerContext>, IUnmarshaller<PredictiveScalingMetricSpecification, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        PredictiveScalingMetricSpecification IUnmarshaller<PredictiveScalingMetricSpecification, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns>The unmarshalled object</returns>
        public PredictiveScalingMetricSpecification Unmarshall(JsonUnmarshallerContext context)
        {
            PredictiveScalingMetricSpecification unmarshalledObject = new PredictiveScalingMetricSpecification();
            if (context.IsEmptyResponse)
                return null;
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomizedCapacityMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredictiveScalingCustomizedMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CustomizedCapacityMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomizedLoadMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredictiveScalingCustomizedMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CustomizedLoadMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("CustomizedScalingMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredictiveScalingCustomizedMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CustomizedScalingMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredefinedLoadMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredictiveScalingPredefinedLoadMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PredefinedLoadMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredefinedMetricPairSpecification", targetDepth))
                {
                    var unmarshaller = PredictiveScalingPredefinedMetricPairSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PredefinedMetricPairSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredefinedScalingMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredictiveScalingPredefinedScalingMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PredefinedScalingMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetValue", targetDepth))
                {
                    var unmarshaller = DoubleUnmarshaller.Instance;
                    unmarshalledObject.TargetValue = unmarshaller.Unmarshall(context);
                    continue;
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