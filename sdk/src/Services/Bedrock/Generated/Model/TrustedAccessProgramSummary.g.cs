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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Program details and participation resolved for the calling account and optional named
    /// project.
    /// </summary>
    public partial class TrustedAccessProgramSummary
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description of the program and its effects on model access or data handling.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DetailsUrl. 
        /// <para>
        /// URL with program details, terms, and instructions for obtaining access.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 4096)]
        public string DetailsUrl { get; set; }

        /// <summary>
        /// Checks to see if the DetailsUrl property is set.
        /// </summary>
        internal bool IsSetDetailsUrl() => this.DetailsUrl != null;

        /// <summary>
        /// Gets and sets the property EligibilityScope. 
        /// <para>
        /// Scope supplying the applicable approval or most-specific revocation. Omitted when
        /// no approval or revocation applies.
        /// </para>
        /// </summary>
        public TrustedAccessProgramScope EligibilityScope { get; set; }

        /// <summary>
        /// Checks to see if the EligibilityScope property is set.
        /// </summary>
        internal bool IsSetEligibilityScope() => this.EligibilityScope != null;

        /// <summary>
        /// Gets and sets the property EnrollmentUrl. 
        /// <para>
        /// Provider application intake URL. Omitted when the program has no customer-facing intake
        /// URL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string EnrollmentUrl { get; set; }

        /// <summary>
        /// Checks to see if the EnrollmentUrl property is set.
        /// </summary>
        internal bool IsSetEnrollmentUrl() => this.EnrollmentUrl != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Display name of the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OptIn. 
        /// <para>
        /// Resolved customer preference, preserved independently of eligibility, including while
        /// revoked.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAccessProgramOptIn OptIn { get; set; }

        /// <summary>
        /// Checks to see if the OptIn property is set.
        /// </summary>
        internal bool IsSetOptIn() => this.OptIn != null;

        /// <summary>
        /// Gets and sets the property ProgramId. 
        /// <para>
        /// Identifier of the trusted access program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 64)]
        public string ProgramId { get; set; }

        /// <summary>
        /// Checks to see if the ProgramId property is set.
        /// </summary>
        internal bool IsSetProgramId() => this.ProgramId != null;

        /// <summary>
        /// Gets and sets the property ProviderName. 
        /// <para>
        /// Name of the model provider offering the program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 20)]
        public string ProviderName { get; set; }

        /// <summary>
        /// Checks to see if the ProviderName property is set.
        /// </summary>
        internal bool IsSetProviderName() => this.ProviderName != null;

        /// <summary>
        /// Gets and sets the property ResolvedFor. 
        /// <para>
        /// Account and optional project context for which participation was resolved.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAccessResolutionContext ResolvedFor { get; set; }

        /// <summary>
        /// Checks to see if the ResolvedFor property is set.
        /// </summary>
        internal bool IsSetResolvedFor() => this.ResolvedFor != null;

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// Scope deciding the status. This can differ from the scope supplying the resolved opt-in
        /// preference and enrollment timestamps.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAccessProgramScope Source { get; set; }

        /// <summary>
        /// Checks to see if the Source property is set.
        /// </summary>
        internal bool IsSetSource() => this.Source != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Participation status resolved for the account and optional project context.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAccessProgramStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Nonempty explanation for requestable or revoked status. Omitted for other statuses.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// Last change to the enrollment supplying the resolved opt-in. Present for enabled or
        /// disabled, including while revoked; omitted for inherit.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the UpdatedAt property is set.
        /// </summary>
        internal bool IsSetUpdatedAt() => this.UpdatedAt.HasValue;
    }
}
