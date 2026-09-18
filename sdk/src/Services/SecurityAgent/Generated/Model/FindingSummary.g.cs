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
    /// Contains summary information about a security finding.
    /// </summary>
    public partial class FindingSummary
    {
        /// <summary>
        /// Gets and sets the property AgentSpaceId. 
        /// <para>
        /// The unique identifier of the agent space associated with the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AgentSpaceId { get; set; }

        /// <summary>
        /// Checks to see if the AgentSpaceId property is set.
        /// </summary>
        internal bool IsSetAgentSpaceId() => this.AgentSpaceId != null;

        /// <summary>
        /// Gets and sets the property CodeReviewId. 
        /// <para>
        /// The unique identifier of the code review associated with the finding.
        /// </para>
        /// </summary>
        public string CodeReviewId { get; set; }

        /// <summary>
        /// Checks to see if the CodeReviewId property is set.
        /// </summary>
        internal bool IsSetCodeReviewId() => this.CodeReviewId != null;

        /// <summary>
        /// Gets and sets the property CodeReviewJobId. 
        /// <para>
        /// The unique identifier of the code review job that produced the finding.
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
        /// The confidence level of the finding.
        /// </para>
        /// </summary>
        public ConfidenceLevel Confidence { get; set; }

        /// <summary>
        /// Checks to see if the Confidence property is set.
        /// </summary>
        internal bool IsSetConfidence() => this.Confidence != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time the finding was created, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the finding.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property PentestId. 
        /// <para>
        /// The unique identifier of the pentest associated with the finding.
        /// </para>
        /// </summary>
        public string PentestId { get; set; }

        /// <summary>
        /// Checks to see if the PentestId property is set.
        /// </summary>
        internal bool IsSetPentestId() => this.PentestId != null;

        /// <summary>
        /// Gets and sets the property PentestJobId. 
        /// <para>
        /// The unique identifier of the pentest job that produced the finding.
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
        /// The risk level of the finding.
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
        /// The type of security risk identified by the finding.
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
        /// The current status of the finding.
        /// </para>
        /// </summary>
        public FindingStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The date and time the finding was last updated, in UTC format.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ValidationStatus. 
        /// <para>
        /// The simulated validation status of the finding.
        /// </para>
        /// </summary>
        public ValidationStatus ValidationStatus { get; set; }

        /// <summary>
        /// Checks to see if the ValidationStatus property is set.
        /// </summary>
        internal bool IsSetValidationStatus() => this.ValidationStatus != null;
    }
}
