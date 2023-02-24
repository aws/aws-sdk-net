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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides metadata for a security control, including its unique standard-agnostic
    /// identifier, title, description, severity, availability in Amazon Web Services Regions,
    /// and a link to remediation steps.
    /// </summary>
    public partial class SecurityControlDefinition
    {
        private RegionAvailabilityStatus _currentRegionAvailability;
        private string _description;
        private string _remediationUrl;
        private string _securityControlId;
        private SeverityRating _severityRating;
        private string _title;

        /// <summary>
        /// Gets and sets the property CurrentRegionAvailability. 
        /// <para>
        ///  Specifies whether a security control is available in the current Amazon Web Services
        /// Region. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RegionAvailabilityStatus CurrentRegionAvailability
        {
            get { return this._currentRegionAvailability; }
            set { this._currentRegionAvailability = value; }
        }

        // Check to see if CurrentRegionAvailability property is set
        internal bool IsSetCurrentRegionAvailability()
        {
            return this._currentRegionAvailability != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of a security control across standards. This typically summarizes
        /// how Security Hub evaluates the control and the conditions under which it produces
        /// a failed finding. This parameter doesn't reference a specific standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RemediationUrl. 
        /// <para>
        ///  A link to Security Hub documentation that explains how to remediate a failed finding
        /// for a security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The unique identifier of a security control across standards. Values for this field
        /// typically consist of an Amazon Web Service name and a number (for example, APIGateway.3).
        /// This parameter differs from <code>SecurityControlArn</code>, which is a unique Amazon
        /// Resource Name (ARN) assigned to a control. The ARN references the security control
        /// ID (for example, arn:aws:securityhub:eu-central-1:123456789012:security-control/APIGateway.3).
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlId
        {
            get { return this._securityControlId; }
            set { this._securityControlId = value; }
        }

        // Check to see if SecurityControlId property is set
        internal bool IsSetSecurityControlId()
        {
            return this._securityControlId != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityRating. 
        /// <para>
        ///  The severity of a security control. For more information about how Security Hub determines
        /// control severity, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/controls-findings-create-update.html#control-findings-severity">Assigning
        /// severity to control findings</a> in the <i>Security Hub User Guide</i>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Title. 
        /// <para>
        ///  The title of a security control. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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