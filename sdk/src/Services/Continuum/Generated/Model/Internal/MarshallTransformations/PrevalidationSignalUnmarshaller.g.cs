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

using Amazon.Continuum.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.Continuum.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for PrevalidationSignal Object
    /// </summary>
    public partial class PrevalidationSignalUnmarshaller : IJsonUnmarshaller<PrevalidationSignal, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public PrevalidationSignal Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new PrevalidationSignal();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("computed", targetDepth, ref reader))
                {
                    var unmarshaller = SignalComputationUnmarshaller.Instance;
                    unmarshalledObject.Computed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("conclusion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Conclusion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("confidence", targetDepth, ref reader))
                {
                    var unmarshaller = NullableDoubleUnmarshaller.Instance;
                    unmarshalledObject.Confidence = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("confidenceReasoning", targetDepth, ref reader))
                {
                    var unmarshaller = SignalConfidenceReasoningUnmarshaller.Instance;
                    unmarshalledObject.ConfidenceReasoning = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dimension", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Dimension = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("exploitability", targetDepth, ref reader))
                {
                    var unmarshaller = SignalExploitabilityUnmarshaller.Instance;
                    unmarshalledObject.Exploitability = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("impactDimensions", targetDepth, ref reader))
                {
                    var unmarshaller = SignalImpactDimensionsUnmarshaller.Instance;
                    unmarshalledObject.ImpactDimensions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("preconditions", targetDepth, ref reader))
                {
                    var unmarshaller = SignalPreconditionsUnmarshaller.Instance;
                    unmarshalledObject.Preconditions = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("producerId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProducerId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("producerVersion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ProducerVersion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("signalStrength", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SignalStrength = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("subjectRef", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.SubjectRef = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static PrevalidationSignalUnmarshaller _instance = new PrevalidationSignalUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static PrevalidationSignalUnmarshaller Instance => _instance;
    }
}
