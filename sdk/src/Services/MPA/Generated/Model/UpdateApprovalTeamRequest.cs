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
    /// Container for the parameters to the UpdateApprovalTeam operation.
    /// Updates an approval team. You can request to update the team description, approval
    /// threshold, and approvers in the team.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Updates require team approval</b> 
    /// </para>
    ///  
    /// <para>
    /// Updates to an active team must be approved by the team.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdateApprovalTeamRequest : AmazonMPARequest
    {
        private ApprovalStrategy _approvalStrategy;
        private List<ApprovalTeamRequestApprover> _approvers = AWSConfigs.InitializeCollections ? new List<ApprovalTeamRequestApprover>() : null;
        private string _arn;
        private string _description;

        /// <summary>
        /// Gets and sets the property ApprovalStrategy. 
        /// <para>
        /// An <c>ApprovalStrategy</c> object. Contains details for how the team grants approval.
        /// </para>
        /// </summary>
        public ApprovalStrategy ApprovalStrategy
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
        /// An array of <c>ApprovalTeamRequestApprover</c> objects. Contains details for the approvers
        /// in the team.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<ApprovalTeamRequestApprover> Approvers
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// Amazon Resource Name (ARN) for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Description for the team.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=256)]
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

    }
}