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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the ListFindings operation. Lists the security findings
    /// for a pentest job.
    /// </summary>
    public partial class ListFindingsRequest : AmazonSecurityAgentRequest
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property CodeReviewJobId. 
        /// <para>
        /// The unique identifier of the code review job to list findings for. Mutually exclusive
        /// with pentestJobId.
        /// </para>
        /// </summary>
        public string CodeReviewJobId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewJobId property is set.
        /// </summary>
        internal bool IsSetCodeReviewJobId() => this.CodeReviewJobId != null;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// Filter findings by confidence level.
        /// </para>
        /// </summary>
        public ConfidenceLevel Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in a single call.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Filter findings by name.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token to use for paginating results that are returned in the response. Set the value
        /// of this parameter to null for the first request. For subsequent calls, use the nextToken
        /// value returned from the previous request.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// The unique identifier of the pentest job to list findings for.
        /// </para>
        /// </summary>
        public string PentestJobId { get; set; }

        /// <summary>
        /// Checks to see if the PentestJobId property is set.
        /// </summary>
        internal bool IsSetPentestJobId() => this.PentestJobId != null;

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// Filter findings by risk level.
        /// </para>
        /// </summary>
        public RiskLevel RiskLevel { get; set; }

        /// <summary>
        /// Checks to see if the RiskLevel property is set.
        /// </summary>
        internal bool IsSetRiskLevel() => this.RiskLevel != null;

        /// <summary>
        /// Gets and sets the property RiskType. 
        /// <para>
        /// Filter findings by risk type.
        /// </para>
        /// </summary>
        public string RiskType { get; set; }

        /// <summary>
        /// Checks to see if the RiskType property is set.
        /// </summary>
        internal bool IsSetRiskType() => this.RiskType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter findings by status.
        /// </para>
        /// </summary>
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
