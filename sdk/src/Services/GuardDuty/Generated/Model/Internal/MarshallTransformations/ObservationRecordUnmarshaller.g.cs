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
    /// Response Unmarshaller for ObservationRecord Object
    /// </summary>
    public partial class ObservationRecordUnmarshaller : IJsonUnmarshaller<ObservationRecord, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public ObservationRecord Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new ObservationRecord();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountOverview", targetDepth, ref reader))
                {
                    var unmarshaller = AccountOverviewUnmarshaller.Instance;
                    unmarshalledObject.AccountOverview = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("detectionCoverage", targetDepth, ref reader))
                {
                    var unmarshaller = DetectionCoverageUnmarshaller.Instance;
                    unmarshalledObject.DetectionCoverage = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("distribution", targetDepth, ref reader))
                {
                    var unmarshaller = DistributionUnmarshaller.Instance;
                    unmarshalledObject.Distribution = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("findingDetail", targetDepth, ref reader))
                {
                    var unmarshaller = FindingDetailUnmarshaller.Instance;
                    unmarshalledObject.FindingDetail = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("indicators", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<InvestigationIndicator, InvestigationIndicatorUnmarshaller>(InvestigationIndicatorUnmarshaller.Instance);
                    unmarshalledObject.Indicators = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("kubernetesActivity", targetDepth, ref reader))
                {
                    var unmarshaller = KubernetesActivityUnmarshaller.Instance;
                    unmarshalledObject.KubernetesActivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("malwareScan", targetDepth, ref reader))
                {
                    var unmarshaller = InvestigationMalwareScanUnmarshaller.Instance;
                    unmarshalledObject.MalwareScan = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("networkActivity", targetDepth, ref reader))
                {
                    var unmarshaller = NetworkActivityUnmarshaller.Instance;
                    unmarshalledObject.NetworkActivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("observationType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.ObservationType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("rdsLoginActivity", targetDepth, ref reader))
                {
                    var unmarshaller = RdsLoginActivityUnmarshaller.Instance;
                    unmarshalledObject.RdsLoginActivity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("recommendations", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<Recommendation, RecommendationUnmarshaller>(RecommendationUnmarshaller.Instance);
                    unmarshalledObject.Recommendations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("relatedFindings", targetDepth, ref reader))
                {
                    var unmarshaller = RelatedFindingsUnmarshaller.Instance;
                    unmarshalledObject.RelatedFindings = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("representativeResources", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<RepresentativeFinding, RepresentativeFindingUnmarshaller>(RepresentativeFindingUnmarshaller.Instance);
                    unmarshalledObject.RepresentativeResources = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("resource", targetDepth, ref reader))
                {
                    var unmarshaller = InvestigationResourceUnmarshaller.Instance;
                    unmarshalledObject.Resource = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("runtimeSignals", targetDepth, ref reader))
                {
                    var unmarshaller = RuntimeSignalsUnmarshaller.Instance;
                    unmarshalledObject.RuntimeSignals = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("s3Activity", targetDepth, ref reader))
                {
                    var unmarshaller = S3ActivityUnmarshaller.Instance;
                    unmarshalledObject.S3Activity = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static ObservationRecordUnmarshaller _instance = new ObservationRecordUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static ObservationRecordUnmarshaller Instance => _instance;
    }
}
