/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the autoscaling-plans-2018-01-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.AutoScalingPlans.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.AutoScalingPlans.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ScalingInstruction Object
    /// </summary>  
    public class ScalingInstructionUnmarshaller : IUnmarshaller<ScalingInstruction, XmlUnmarshallerContext>, IUnmarshaller<ScalingInstruction, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        ScalingInstruction IUnmarshaller<ScalingInstruction, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public ScalingInstruction Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            ScalingInstruction unmarshalledObject = new ScalingInstruction();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CustomizedLoadMetricSpecification", targetDepth))
                {
                    var unmarshaller = CustomizedLoadMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.CustomizedLoadMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DisableDynamicScaling", targetDepth))
                {
                    var unmarshaller = BoolUnmarshaller.Instance;
                    unmarshalledObject.DisableDynamicScaling = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MaxCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MaxCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MinCapacity", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.MinCapacity = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredefinedLoadMetricSpecification", targetDepth))
                {
                    var unmarshaller = PredefinedLoadMetricSpecificationUnmarshaller.Instance;
                    unmarshalledObject.PredefinedLoadMetricSpecification = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictiveScalingMaxCapacityBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PredictiveScalingMaxCapacityBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictiveScalingMaxCapacityBuffer", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.PredictiveScalingMaxCapacityBuffer = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("PredictiveScalingMode", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.PredictiveScalingMode = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceId", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ResourceId = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalableDimension", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalableDimension = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScalingPolicyUpdateBehavior", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ScalingPolicyUpdateBehavior = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ScheduledActionBufferTime", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.ScheduledActionBufferTime = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ServiceNamespace", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ServiceNamespace = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TargetTrackingConfigurations", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<TargetTrackingConfiguration, TargetTrackingConfigurationUnmarshaller>(TargetTrackingConfigurationUnmarshaller.Instance);
                    unmarshalledObject.TargetTrackingConfigurations = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static ScalingInstructionUnmarshaller _instance = new ScalingInstructionUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static ScalingInstructionUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}