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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateMembers operation.
    /// Disassociates GuardDuty member accounts (from the current administrator account) specified
    /// by the account IDs.
    /// 
    ///  
    /// <para>
    /// When you disassociate an invited member from a GuardDuty delegated administrator,
    /// the member account details obtained from the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>
    /// API, including the associated email addresses, are retained. This is done so that
    /// the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
    /// API without the need to invoke the CreateMembers API again. To remove the details
    /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
    /// API. 
    /// </para>
    ///  
    /// <para>
    /// With <c>autoEnableOrganizationMembers</c> configuration for your organization set
    /// to <c>ALL</c>, you'll receive an error if you attempt to disassociate a member account
    /// before removing them from your organization.
    /// </para>
    ///  
    /// <para>
    /// If you disassociate a member account that was added by invitation, the member account
    /// details obtained from this API, including the associated email addresses, will be
    /// retained. This is done so that the delegated administrator can invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
    /// API without the need to invoke the CreateMembers API again. To remove the details
    /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
    /// API. 
    /// </para>
    ///  
    /// <para>
    /// When the member accounts added through Organizations are later disassociated, you
    /// (administrator) can't invite them by calling the InviteMembers API. You can create
    /// an association with these member accounts again only by calling the CreateMembers
    /// API.
    /// </para>
    /// </summary>
    public partial class DisassociateMembersRequest : AmazonGuardDutyRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// A list of account IDs of the GuardDuty member accounts that you want to disassociate
        /// from the administrator account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> AccountIds
        {
            get { return this._accountIds; }
            set { this._accountIds = value; }
        }

        // Check to see if AccountIds property is set
        internal bool IsSetAccountIds()
        {
            return this._accountIds != null && (this._accountIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector of the GuardDuty account whose members you want to disassociate
        /// from the administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=300)]
        public string DetectorId
        {
            get { return this._detectorId; }
            set { this._detectorId = value; }
        }

        // Check to see if DetectorId property is set
        internal bool IsSetDetectorId()
        {
            return this._detectorId != null;
        }

    }
}