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

using Amazon.GuardDuty.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.GuardDuty.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for Distribution Object
    /// </summary>
    public partial class DistributionUnmarshaller : IJsonUnmarshaller<Distribution, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public Distribution Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new Distribution();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("archive", targetDepth, ref reader))
                {
                    var unmarshaller = ArchiveDistributionUnmarshaller.Instance;
                    unmarshalledObject.Archive = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("attackVectors", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TacticCoverage, TacticCoverageUnmarshaller>(TacticCoverageUnmarshaller.Instance);
                    unmarshalledObject.AttackVectors = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("dimension", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Dimension = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("findingTypes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<TypeDistribution, TypeDistributionUnmarshaller>(TypeDistributionUnmarshaller.Instance);
                    unmarshalledObject.FindingTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("resources", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<ResourceDistribution, ResourceDistributionUnmarshaller>(ResourceDistributionUnmarshaller.Instance);
                    unmarshalledObject.Resources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("severityBreakdown", targetDepth, ref reader))
                {
                    var unmarshaller = SeverityBreakdownUnmarshaller.Instance;
                    unmarshalledObject.SeverityBreakdown = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("topFindingTypes", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FindingTypeCount, FindingTypeCountUnmarshaller>(FindingTypeCountUnmarshaller.Instance);
                    unmarshalledObject.TopFindingTypes = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("totalFindings", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalFindings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static DistributionUnmarshaller _instance = new DistributionUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static DistributionUnmarshaller Instance => _instance;
    }
}
