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

namespace Amazon.Resiliencehubv2.Model
{
    /// <summary>
    /// Contains summary information about a finding.
    /// </summary>
    public partial class FindingSummary
    {
        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max = 500)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property FailureCategory. 
        /// <para>
        /// The failure category of the finding.
        /// </para>
        /// </summary>
        public FailureCategory FailureCategory { get; set; }

        /// <summary>
        /// Checks to see if the FailureCategory property is set.
        /// </summary>
        internal bool IsSetFailureCategory() => this.FailureCategory != null;

        /// <summary>
        /// Gets and sets the property FindingId. 
        /// <para>
        /// The unique identifier of the finding.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 36, Max = 36)]
        public string FindingId { get; set; }

        /// <summary>
        /// Checks to see if the FindingId property is set.
        /// </summary>
        internal bool IsSetFindingId() => this.FindingId != null;

        /// <summary>
        /// Gets and sets the property InvestigationDeepLink. 
        /// <para>
        /// A deep link to an interactive DevOps Agent investigation seeded with this finding.
        /// This value is null until DevOps Agent creates an investigation.
        /// </para>
        /// </summary>
        public string InvestigationDeepLink { get; set; }

        /// <summary>
        /// Checks to see if the InvestigationDeepLink property is set.
        /// </summary>
        internal bool IsSetInvestigationDeepLink() => this.InvestigationDeepLink != null;

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
        /// Gets and sets the property PolicyComponent. 
        /// <para>
        /// The policy component associated with the finding.
        /// </para>
        /// </summary>
        public PolicyComponent PolicyComponent { get; set; }

        /// <summary>
        /// Checks to see if the PolicyComponent property is set.
        /// </summary>
        internal bool IsSetPolicyComponent() => this.PolicyComponent != null;

        /// <summary>
        /// Gets and sets the property ServiceArn.
        /// </summary>
        [AWSProperty(Min = 31)]
        public string ServiceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceArn property is set.
        /// </summary>
        internal bool IsSetServiceArn() => this.ServiceArn != null;

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity of the finding.
        /// </para>
        /// </summary>
        public FindingSeverity Severity { get; set; }

        /// <summary>
        /// Checks to see if the Severity property is set.
        /// </summary>
        internal bool IsSetSeverity() => this.Severity != null;

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
        /// The timestamp when the finding was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
