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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using Amazon.SageMakerTrainingSessionRuntime.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.SageMakerTrainingSessionRuntime.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for OperationResult Object
    /// </summary>
    public partial class OperationResultUnmarshaller : IJsonUnmarshaller<OperationResult, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public OperationResult Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new OperationResult();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("forward", targetDepth, ref reader))
                {
                    var unmarshaller = ForwardResultUnmarshaller.Instance;
                    unmarshalledObject.Forward = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("forwardBackward", targetDepth, ref reader))
                {
                    var unmarshaller = ForwardBackwardResultUnmarshaller.Instance;
                    unmarshalledObject.ForwardBackward = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("loadState", targetDepth, ref reader))
                {
                    var unmarshaller = LoadStateResultUnmarshaller.Instance;
                    unmarshalledObject.LoadState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("optimizerStep", targetDepth, ref reader))
                {
                    var unmarshaller = OptimizerStepResultUnmarshaller.Instance;
                    unmarshalledObject.OptimizerStep = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("saveState", targetDepth, ref reader))
                {
                    var unmarshaller = SaveStateResultUnmarshaller.Instance;
                    unmarshalledObject.SaveState = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("saveWeights", targetDepth, ref reader))
                {
                    var unmarshaller = SaveWeightsResultUnmarshaller.Instance;
                    unmarshalledObject.SaveWeights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static OperationResultUnmarshaller _instance = new OperationResultUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static OperationResultUnmarshaller Instance => _instance;
    }
}
