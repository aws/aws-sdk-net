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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details for an individual security standard control.
    /// </summary>
    public partial class StandardsControl
    {
        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// The identifier of the security standard control.
        /// </para>
        /// </summary>
        public string ControlId { get; set; }

        /// <summary>
        /// Checks to see if the ControlId property is set.
        /// </summary>
        internal bool IsSetControlId() => this.ControlId != null;

        /// <summary>
        /// Gets and sets the property ControlStatus. 
        /// <para>
        /// The current status of the security standard control. Indicates whether the control
        /// is enabled or disabled. Security Hub CSPM does not check against disabled controls.
        /// </para>
        /// </summary>
        public ControlStatus ControlStatus { get; set; }

        /// <summary>
        /// Checks to see if the ControlStatus property is set.
        /// </summary>
        internal bool IsSetControlStatus() => this.ControlStatus != null;

        /// <summary>
        /// Gets and sets the property ControlStatusUpdatedAt. 
        /// <para>
        /// The date and time that the status of the security standard control was most recently
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? ControlStatusUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ControlStatusUpdatedAt property is set.
        /// </summary>
        internal bool IsSetControlStatusUpdatedAt() => this.ControlStatusUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The longer description of the security standard control. Provides information about
        /// what the control is checking for.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// The reason provided for the most recent change in status for the control.
        /// </para>
        /// </summary>
        public string DisabledReason { get; set; }

        /// <summary>
        /// Checks to see if the DisabledReason property is set.
        /// </summary>
        internal bool IsSetDisabledReason() => this.DisabledReason != null;

        /// <summary>
        /// Gets and sets the property RelatedRequirements. 
        /// <para>
        /// The list of requirements that are related to this control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelatedRequirements { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RelatedRequirements property is set.
        /// </summary>
        internal bool IsSetRelatedRequirements() => this.RelatedRequirements != null && (this.RelatedRequirements.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RemediationUrl. 
        /// <para>
        /// A link to remediation information for the control in the Security Hub CSPM user documentation.
        /// </para>
        /// </summary>
        public string RemediationUrl { get; set; }

        /// <summary>
        /// Checks to see if the RemediationUrl property is set.
        /// </summary>
        internal bool IsSetRemediationUrl() => this.RemediationUrl != null;

        /// <summary>
        /// Gets and sets the property SeverityRating. 
        /// <para>
        /// The severity of findings generated from this security standard control.
        /// </para>
        ///  
        /// <para>
        /// The finding severity is based on an assessment of how easy it would be to compromise
        /// Amazon Web Services resources if the issue is detected.
        /// </para>
        /// </summary>
        public SeverityRating SeverityRating { get; set; }

        /// <summary>
        /// Checks to see if the SeverityRating property is set.
        /// </summary>
        internal bool IsSetSeverityRating() => this.SeverityRating != null;

        /// <summary>
        /// Gets and sets the property StandardsControlArn. 
        /// <para>
        /// The ARN of the security standard control.
        /// </para>
        /// </summary>
        public string StandardsControlArn { get; set; }

        /// <summary>
        /// Checks to see if the StandardsControlArn property is set.
        /// </summary>
        internal bool IsSetStandardsControlArn() => this.StandardsControlArn != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the security standard control.
        /// </para>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
