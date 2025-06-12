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
    /// Container for the parameters to the InviteMembers operation.
    /// Invites Amazon Web Services accounts to become members of an organization administered
    /// by the Amazon Web Services account that invokes this API. If you are using Amazon
    /// Web Services Organizations to manage your GuardDuty environment, this step is not
    /// needed. For more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_organizations.html">Managing
    /// accounts with organizations</a>.
    /// 
    ///  
    /// <para>
    /// To invite Amazon Web Services accounts, the first step is to ensure that GuardDuty
    /// has been enabled in the potential member accounts. You can now invoke this API to
    /// add accounts by invitation. The invited accounts can either accept or decline the
    /// invitation from their GuardDuty accounts. Each invited Amazon Web Services account
    /// can choose to accept the invitation from only one Amazon Web Services account. For
    /// more information, see <a href="https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_invitations.html">Managing
    /// GuardDuty accounts by invitation</a>.
    /// </para>
    ///  
    /// <para>
    /// After the invite has been accepted and you choose to disassociate a member account
    /// (by using <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DisassociateMembers.html">DisassociateMembers</a>)
    /// from your account, the details of the member account obtained by invoking <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>,
    /// including the associated email addresses, will be retained. This is done so that you
    /// can invoke InviteMembers without the need to invoke <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_CreateMembers.html">CreateMembers</a>
    /// again. To remove the details associated with a member account, you must also invoke
    /// <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>.
    /// 
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
    public partial class InviteMembersRequest : AmazonGuardDutyRequest
    {
        private List<string> _accountIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _detectorId;
        private bool? _disableEmailNotification;
        private string _message;

        /// <summary>
        /// Gets and sets the property AccountIds. 
        /// <para>
        /// A list of account IDs of the accounts that you want to invite to GuardDuty as members.
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
        /// The unique ID of the detector of the GuardDuty account with which you want to invite
        /// members.
        /// </para>
        ///  
        /// <para>
        /// To find the <c>detectorId</c> in the current Region, see the Settings page in the
        /// GuardDuty console, or run the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_ListDetectors.html">ListDetectors</a>
        /// API.
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

        /// <summary>
        /// Gets and sets the property DisableEmailNotification. 
        /// <para>
        /// A Boolean value that specifies whether you want to disable email notification to the
        /// accounts that you are inviting to GuardDuty as members.
        /// </para>
        /// </summary>
        public bool? DisableEmailNotification
        {
            get { return this._disableEmailNotification; }
            set { this._disableEmailNotification = value; }
        }

        // Check to see if DisableEmailNotification property is set
        internal bool IsSetDisableEmailNotification()
        {
            return this._disableEmailNotification.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The invitation message that you want to send to the accounts that you're inviting
        /// to GuardDuty as members.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}