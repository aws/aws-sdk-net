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

using Amazon.WellArchitected.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.WellArchitected.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CoverageSummary Object
    /// </summary>
    public partial class CoverageSummaryUnmarshaller : IJsonUnmarshaller<CoverageSummary, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public CoverageSummary Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new CoverageSummary();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("accountsWithProfile", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.AccountsWithProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("accountsWithoutProfile", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.AccountsWithoutProfile = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("failedAccountCount", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.FailedAccountCount = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("failedAccounts", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FailedAccount, FailedAccountUnmarshaller>(FailedAccountUnmarshaller.Instance);
                    unmarshalledObject.FailedAccounts = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("failedOrganizationalUnits", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<FailedOrganizationalUnit, FailedOrganizationalUnitUnmarshaller>(FailedOrganizationalUnitUnmarshaller.Instance);
                    unmarshalledObject.FailedOrganizationalUnits = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("recommendationCountByPillar", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<PillarCount, PillarCountUnmarshaller>(PillarCountUnmarshaller.Instance);
                    unmarshalledObject.RecommendationCountByPillar = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("recommendationCountByPriority", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<PriorityCount, PriorityCountUnmarshaller>(PriorityCountUnmarshaller.Instance);
                    unmarshalledObject.RecommendationCountByPriority = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("totalAccountsInScope", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalAccountsInScope = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("totalProfiles", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalProfiles = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("totalRecommendations", targetDepth, ref reader))
                {
                    var unmarshaller = NullableLongUnmarshaller.Instance;
                    unmarshalledObject.TotalRecommendations = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static CoverageSummaryUnmarshaller _instance = new CoverageSummaryUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static CoverageSummaryUnmarshaller Instance => _instance;
    }
}
