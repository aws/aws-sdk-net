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
    /// A security control in Security Hub describes a security best practice related to
    /// a specific resource.
    /// </summary>
    public partial class SecurityControl
    {
        private string _description;
        private string _lastUpdateReason;
        private Dictionary<string, ParameterConfiguration> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, ParameterConfiguration>() : null;
        private string _remediationUrl;
        private string _securityControlArn;
        private string _securityControlId;
        private ControlStatus _securityControlStatus;
        private SeverityRating _severityRating;
        private string _title;
        private UpdateStatus _updateStatus;

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
        /// Gets and sets the property LastUpdateReason. 
        /// <para>
        ///  The most recent reason for updating the customizable properties of a security control.
        /// This differs from the <c>UpdateReason</c> field of the <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/API_BatchUpdateStandardsControlAssociations.html">
        /// <c>BatchUpdateStandardsControlAssociations</c> </a> API, which tracks the reason for
        /// updating the enablement status of a control. This field accepts alphanumeric characters
        /// in addition to white spaces, dashes, and underscores. 
        /// </para>
        /// </summary>
        public string LastUpdateReason
        {
            get { return this._lastUpdateReason; }
            set { this._lastUpdateReason = value; }
        }

        // Check to see if LastUpdateReason property is set
        internal bool IsSetLastUpdateReason()
        {
            return this._lastUpdateReason != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        ///  An object that identifies the name of a control parameter, its current value, and
        /// whether it has been customized. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, ParameterConfiguration> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property SecurityControlArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) for a security control across standards, such as <c>arn:aws:securityhub:eu-central-1:123456789012:security-control/S3.1</c>.
        /// This parameter doesn't mention a specific standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecurityControlArn
        {
            get { return this._securityControlArn; }
            set { this._securityControlArn = value; }
        }

        // Check to see if SecurityControlArn property is set
        internal bool IsSetSecurityControlArn()
        {
            return this._securityControlArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityControlId. 
        /// <para>
        ///  The unique identifier of a security control across standards. Values for this field
        /// typically consist of an Amazon Web Services service name and a number, such as APIGateway.3.
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
        /// Gets and sets the property SecurityControlStatus. 
        /// <para>
        ///  The enablement status of a security control in a specific standard. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ControlStatus SecurityControlStatus
        {
            get { return this._securityControlStatus; }
            set { this._securityControlStatus = value; }
        }

        // Check to see if SecurityControlStatus property is set
        internal bool IsSetSecurityControlStatus()
        {
            return this._securityControlStatus != null;
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
        /// The title of a security control. 
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

        /// <summary>
        /// Gets and sets the property UpdateStatus. 
        /// <para>
        ///  Identifies whether customizable properties of a security control are reflected in
        /// Security Hub findings. A status of <c>READY</c> indicates that Security Hub uses the
        /// current control parameter values when running security checks of the control. A status
        /// of <c>UPDATING</c> indicates that all security checks might not use the current parameter
        /// values. 
        /// </para>
        /// </summary>
        public UpdateStatus UpdateStatus
        {
            get { return this._updateStatus; }
            set { this._updateStatus = value; }
        }

        // Check to see if UpdateStatus property is set
        internal bool IsSetUpdateStatus()
        {
            return this._updateStatus != null;
        }

    }
}