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
using System.Text.Json;
#pragma warning disable CS0612,CS0618
namespace Amazon.SageMaker.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for TuningJobCompletionCriteria Object
    /// </summary>  
    public class TuningJobCompletionCriteriaUnmarshaller : IJsonUnmarshaller<TuningJobCompletionCriteria, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <param name="reader"></param>
        /// <returns>The unmarshalled object</returns>
        public TuningJobCompletionCriteria Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            TuningJobCompletionCriteria unmarshalledObject = new TuningJobCompletionCriteria();
            if (context.IsEmptyResponse)
                return null;
            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) 
                return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("BestObjectiveNotImproving", targetDepth))
                {
                    var unmarshaller = BestObjectiveNotImprovingUnmarshaller.Instance;
                    unmarshalledObject.BestObjectiveNotImproving = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("ConvergenceDetected", targetDepth))
                {
                    var unmarshaller = ConvergenceDetectedUnmarshaller.Instance;
                    unmarshalledObject.ConvergenceDetected = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
                if (context.TestExpression("TargetObjectiveMetricValue", targetDepth))
                {
                    var unmarshaller = NullableFloatUnmarshaller.Instance;
                    unmarshalledObject.TargetObjectiveMetricValue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }


        private static TuningJobCompletionCriteriaUnmarshaller _instance = new TuningJobCompletionCriteriaUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static TuningJobCompletionCriteriaUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}