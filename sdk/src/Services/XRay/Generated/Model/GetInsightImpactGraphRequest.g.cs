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

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.XRay.Model
{
    /// <summary>
    /// Container for the parameters to the GetInsightImpactGraph operation. Retrieves a service
    /// graph structure filtered by the specified insight. The service graph is limited to
    /// only structural information. For a complete service graph, use this API with the GetServiceGraph
    /// API.
    /// </summary>
    public partial class GetInsightImpactGraphRequest : AmazonXRayRequest
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The estimated end time of the insight, in Unix time seconds. The EndTime is exclusive
        /// of the value provided. The time range between the start time and end time can't be
        /// more than six hours. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property InsightId. 
        /// <para>
        /// The insight's unique identifier. Use the GetInsightSummaries action to retrieve an
        /// InsightId.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InsightId { get; set; }

        /// <summary>
        /// Checks to see if the InsightId property is set.
        /// </summary>
        internal bool IsSetInsightId() => this.InsightId != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token returned by a previous request to retrieve the next page
        /// of results. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The estimated start time of the insight, in Unix time seconds. The StartTime is inclusive
        /// of the value provided and can't be more than 30 days old.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;
    }
}
