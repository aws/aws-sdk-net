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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.SageMaker.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for HyperParameterTuningJobConfig Object
    /// </summary>  
    public class HyperParameterTuningJobConfigUnmarshaller : IUnmarshaller<HyperParameterTuningJobConfig, XmlUnmarshallerContext>, IUnmarshaller<HyperParameterTuningJobConfig, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        HyperParameterTuningJobConfig IUnmarshaller<HyperParameterTuningJobConfig, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public HyperParameterTuningJobConfig Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            HyperParameterTuningJobConfig unmarshalledObject = new HyperParameterTuningJobConfig();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("HyperParameterTuningJobObjective", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobObjectiveUnmarshaller.Instance;
                    unmarshalledObject.HyperParameterTuningJobObjective = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ParameterRanges", targetDepth))
                {
                    var unmarshaller = ParameterRangesUnmarshaller.Instance;
                    unmarshalledObject.ParameterRanges = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("RandomSeed", targetDepth))
                {
                    var unmarshaller = IntUnmarshaller.Instance;
                    unmarshalledObject.RandomSeed = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("ResourceLimits", targetDepth))
                {
                    var unmarshaller = ResourceLimitsUnmarshaller.Instance;
                    unmarshalledObject.ResourceLimits = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("Strategy", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Strategy = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("StrategyConfig", targetDepth))
                {
                    var unmarshaller = HyperParameterTuningJobStrategyConfigUnmarshaller.Instance;
                    unmarshalledObject.StrategyConfig = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TrainingJobEarlyStoppingType", targetDepth))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TrainingJobEarlyStoppingType = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("TuningJobCompletionCriteria", targetDepth))
                {
                    var unmarshaller = TuningJobCompletionCriteriaUnmarshaller.Instance;
                    unmarshalledObject.TuningJobCompletionCriteria = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static HyperParameterTuningJobConfigUnmarshaller _instance = new HyperParameterTuningJobConfigUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static HyperParameterTuningJobConfigUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}