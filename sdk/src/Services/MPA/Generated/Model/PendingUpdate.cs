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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
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
namespace Amazon.MPA.Model
{
    /// <summary>
    /// Contains details for the pending updates for an approval team, if applicable.
    /// </summary>
    public partial class PendingUpdate
    {
        private ApprovalStrategyResponse _approvalStrategy;
        private List<GetApprovalTeamResponseApprover> _approvers = AWSConfigs.InitializeCollections ? new List<GetApprovalTeamResponseApprover>() : null;
        private string _description;
        private int? _numberOfApprovers;
        private ApprovalTeamStatus _status;
        private ApprovalTeamStatusCode _statusCode;
        private string _statusMessage;
        private DateTime? _updateInitiationTime;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property ApprovalStrategy. 
        /// <para>
        /// An <c>ApprovalStrategyResponse</c> object. Contains details for how the team grants
        /// approval.
        /// </para>
        /// </summary>
        public ApprovalStrategyResponse ApprovalStrategy
        {
            get { return this._approvalStrategy; }
            set { this._approvalStrategy = value; }
        }

        // Check to see if ApprovalStrategy property is set
        internal bool IsSetApprovalStrategy()
        {
            return this._approvalStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Approvers. 
        /// <para>
        /// An array of <c>GetApprovalTeamResponseApprover </c> objects. Contains details for
        /// the approvers in the team.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<GetApprovalTeamResponseApprover> Approvers
        {
            get { return this._approvers; }
            set { this._approvers = value; }
        }

        // Check to see if Approvers property is set
        internal bool IsSetApprovers()
        {
            return this._approvers != null && (this._approvers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
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
        /// Gets and sets the property NumberOfApprovers. 
        /// <para>
        /// Total number of approvers in the team.
        /// </para>
        /// </summary>
        public int? NumberOfApprovers
        {
            get { return this._numberOfApprovers; }
            set { this._numberOfApprovers = value; }
        }

        // Check to see if NumberOfApprovers property is set
        internal bool IsSetNumberOfApprovers()
        {
            return this._numberOfApprovers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status for the team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
        /// health</a> in the <i>Multi-party approval User Guide</i>.
        /// </para>
        /// </summary>
        public ApprovalTeamStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// Status code for the update. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
        /// health</a> in the <i>Multi-party approval User Guide</i>.
        /// </para>
        /// </summary>
        public ApprovalTeamStatusCode StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode != null;
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// Message describing the status for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property UpdateInitiationTime. 
        /// <para>
        /// Timestamp when the update request was initiated.
        /// </para>
        /// </summary>
        public DateTime? UpdateInitiationTime
        {
            get { return this._updateInitiationTime; }
            set { this._updateInitiationTime = value; }
        }

        // Check to see if UpdateInitiationTime property is set
        internal bool IsSetUpdateInitiationTime()
        {
            return this._updateInitiationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}