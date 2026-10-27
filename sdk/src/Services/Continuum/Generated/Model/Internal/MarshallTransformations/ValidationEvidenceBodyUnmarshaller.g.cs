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
    /// Response Unmarshaller for ValidationEvidenceBody Object
    /// </summary>
    public partial class ValidationEvidenceBodyUnmarshaller : IJsonUnmarshaller<ValidationEvidenceBody, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ValidationEvidenceBody Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ValidationEvidenceBody();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("attackFlowsConfirmed", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<string, StringUnmarshaller>(StringUnmarshaller.Instance);
                    unmarshalledObject.AttackFlowsConfirmed = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("executedProof", targetDepth, ref reader))
                {
                    var unmarshaller = ValidationExecutedProofUnmarshaller.Instance;
                    unmarshalledObject.ExecutedProof = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("exploitArtifact", targetDepth, ref reader))
                {
                    var unmarshaller = ValidationExploitArtifactUnmarshaller.Instance;
                    unmarshalledObject.ExploitArtifact = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("exploitable", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Exploitable = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("flowVerdicts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FlowVerdict, FlowVerdictUnmarshaller>(FlowVerdictUnmarshaller.Instance);
                    unmarshalledObject.FlowVerdicts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("perFindingResults", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<PerFindingResult, PerFindingResultUnmarshaller>(PerFindingResultUnmarshaller.Instance);
                    unmarshalledObject.PerFindingResults = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("sourceAnalysis", targetDepth, ref reader))
                {
                    var unmarshaller = ValidationSourceAnalysisUnmarshaller.Instance;
                    unmarshalledObject.SourceAnalysis = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("terminalStatus", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.TerminalStatus = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ValidationEvidenceBodyUnmarshaller _instance = new ValidationEvidenceBodyUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ValidationEvidenceBodyUnmarshaller Instance => _instance;
    }
}
