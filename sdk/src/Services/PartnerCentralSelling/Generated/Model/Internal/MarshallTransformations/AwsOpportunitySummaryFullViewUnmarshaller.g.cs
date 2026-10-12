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

using Amazon.PartnerCentralSelling.Model;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using System.Text.Json;
#pragma warning disable CS0612,CS0618

namespace Amazon.PartnerCentralSelling.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for AwsOpportunitySummaryFullView Object
    /// </summary>
    public partial class AwsOpportunitySummaryFullViewUnmarshaller : IJsonUnmarshaller<AwsOpportunitySummaryFullView, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshall the response from the service to the response class.
        /// </summary>
        /// <returns>The unmarshalled object</returns>
        public AwsOpportunitySummaryFullView Unmarshall(JsonUnmarshallerContext context, ref StreamingUtf8JsonReader reader)
        {
            var unmarshalledObject = new AwsOpportunitySummaryFullView();
            if (context.IsEmptyResponse) return null;

            context.Read(ref reader);
            if (context.CurrentTokenType == JsonTokenType.Null) return null;

            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth, ref reader))
            {
                if (context.TestExpression("CosellMotion", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.CosellMotion = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Customer", targetDepth, ref reader))
                {
                    var unmarshaller = AwsOpportunityCustomerUnmarshaller.Instance;
                    unmarshalledObject.Customer = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Insights", targetDepth, ref reader))
                {
                    var unmarshaller = AwsOpportunityInsightsUnmarshaller.Instance;
                    unmarshalledObject.Insights = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InvolvementType", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvolvementType = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("InvolvementTypeChangeReason", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.InvolvementTypeChangeReason = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("LifeCycle", targetDepth, ref reader))
                {
                    var unmarshaller = AwsOpportunityLifeCycleUnmarshaller.Instance;
                    unmarshalledObject.LifeCycle = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("OpportunityTeam", targetDepth, ref reader))
                {
                    var unmarshaller = new JsonListUnmarshaller<AwsTeamMember, AwsTeamMemberUnmarshaller>(AwsTeamMemberUnmarshaller.Instance);
                    unmarshalledObject.OpportunityTeam = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Origin", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Origin = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Project", targetDepth, ref reader))
                {
                    var unmarshaller = AwsOpportunityProjectUnmarshaller.Instance;
                    unmarshalledObject.Project = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RelatedEntityIds", targetDepth, ref reader))
                {
                    var unmarshaller = AwsOpportunityRelatedEntitiesUnmarshaller.Instance;
                    unmarshalledObject.RelatedEntityIds = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("RelatedOpportunityId", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.RelatedOpportunityId = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("SoftwareRevenue", targetDepth, ref reader))
                {
                    var unmarshaller = AwsSoftwareRevenueUnmarshaller.Instance;
                    unmarshalledObject.SoftwareRevenue = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }

                if (context.TestExpression("Visibility", targetDepth, ref reader))
                {
                    var unmarshaller = StringUnmarshaller.Instance;
                    unmarshalledObject.Visibility = unmarshaller.Unmarshall(context, ref reader);
                    continue;
                }
            }
            return unmarshalledObject;
        }

        private static AwsOpportunitySummaryFullViewUnmarshaller _instance = new AwsOpportunitySummaryFullViewUnmarshaller();

        /// <summary>
        /// Gets the singleton.
        /// </summary>
        public static AwsOpportunitySummaryFullViewUnmarshaller Instance => _instance;
    }
}
