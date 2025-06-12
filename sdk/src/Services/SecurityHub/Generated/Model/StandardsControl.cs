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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _controlId;
        private ControlStatus _controlStatus;
        private DateTime? _controlStatusUpdatedAt;
        private string _description;
        private string _disabledReason;
        private List<string> _relatedRequirements = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _remediationUrl;
        private SeverityRating _severityRating;
        private string _standardsControlArn;
        private string _title;

        /// <summary>
        /// Gets and sets the property ControlId. 
        /// <para>
        /// The identifier of the security standard control.
        /// </para>
        /// </summary>
        public string ControlId
        {
            get { return this._controlId; }
            set { this._controlId = value; }
        }

        // Check to see if ControlId property is set
        internal bool IsSetControlId()
        {
            return this._controlId != null;
        }

        /// <summary>
        /// Gets and sets the property ControlStatus. 
        /// <para>
        /// The current status of the security standard control. Indicates whether the control
        /// is enabled or disabled. Security Hub does not check against disabled controls.
        /// </para>
        /// </summary>
        public ControlStatus ControlStatus
        {
            get { return this._controlStatus; }
            set { this._controlStatus = value; }
        }

        // Check to see if ControlStatus property is set
        internal bool IsSetControlStatus()
        {
            return this._controlStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ControlStatusUpdatedAt. 
        /// <para>
        /// The date and time that the status of the security standard control was most recently
        /// updated.
        /// </para>
        /// </summary>
        public DateTime? ControlStatusUpdatedAt
        {
            get { return this._controlStatusUpdatedAt; }
            set { this._controlStatusUpdatedAt = value; }
        }

        // Check to see if ControlStatusUpdatedAt property is set
        internal bool IsSetControlStatusUpdatedAt()
        {
            return this._controlStatusUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The longer description of the security standard control. Provides information about
        /// what the control is checking for.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DisabledReason. 
        /// <para>
        /// The reason provided for the most recent change in status for the control.
        /// </para>
        /// </summary>
        public string DisabledReason
        {
            get { return this._disabledReason; }
            set { this._disabledReason = value; }
        }

        // Check to see if DisabledReason property is set
        internal bool IsSetDisabledReason()
        {
            return this._disabledReason != null;
        }

        /// <summary>
        /// Gets and sets the property RelatedRequirements. 
        /// <para>
        /// The list of requirements that are related to this control.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RelatedRequirements
        {
            get { return this._relatedRequirements; }
            set { this._relatedRequirements = value; }
        }

        // Check to see if RelatedRequirements property is set
        internal bool IsSetRelatedRequirements()
        {
            return this._relatedRequirements != null && (this._relatedRequirements.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RemediationUrl. 
        /// <para>
        /// A link to remediation information for the control in the Security Hub user documentation.
        /// </para>
        /// </summary>
        public string RemediationUrl
        {
            get { return this._remediationUrl; }
            set { this._remediationUrl = value; }
        }

        // Check to see if RemediationUrl property is set
        internal bool IsSetRemediationUrl()
        {
            return this._remediationUrl != null;
        }

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
        public SeverityRating SeverityRating
        {
            get { return this._severityRating; }
            set { this._severityRating = value; }
        }

        // Check to see if SeverityRating property is set
        internal bool IsSetSeverityRating()
        {
            return this._severityRating != null;
        }

        /// <summary>
        /// Gets and sets the property StandardsControlArn. 
        /// <para>
        /// The ARN of the security standard control.
        /// </para>
        /// </summary>
        public string StandardsControlArn
        {
            get { return this._standardsControlArn; }
            set { this._standardsControlArn = value; }
        }

        // Check to see if StandardsControlArn property is set
        internal bool IsSetStandardsControlArn()
        {
            return this._standardsControlArn != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the security standard control.
        /// </para>
        /// </summary>
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}