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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMembers operation.
    /// Creates member accounts of the current Amazon Web Services account by specifying a
    /// list of Amazon Web Services account IDs. This step is a prerequisite for managing
    /// the associated member accounts either by invitation or through an organization.
    /// 
    ///  
    /// <para>
    /// As a delegated administrator, using <code>CreateMembers</code> will enable GuardDuty
    /// in the added member accounts, with the exception of the organization delegated administrator
    /// account. A delegated administrator must enable GuardDuty prior to being added as a
    /// member.
    /// </para>
    ///  
    /// <para>
    /// If you are adding accounts by invitation, before using <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>,
    /// use <code>CreateMembers</code> after GuardDuty has been enabled in potential member
    /// accounts.
    /// </para>
    ///  
    /// <para>
    /// If you disassociate a member from a GuardDuty delegated administrator, the member
    /// account details obtained from this API, including the associated email addresses,
    /// will be retained. This is done so that the delegated administrator can invoke the
    /// <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_InviteMembers.html">InviteMembers</a>
    /// API without the need to invoke the CreateMembers API again. To remove the details
    /// associated with a member account, the delegated administrator must invoke the <a href="https://docs.aws.amazon.com/guardduty/latest/APIReference/API_DeleteMembers.html">DeleteMembers</a>
    /// API. 
    /// </para>
    /// </summary>
    public partial class CreateMembersRequest : AmazonGuardDutyRequest
    {
        private List<AccountDetail> _accountDetails = new List<AccountDetail>();
        private string _detectorId;

        /// <summary>
        /// Gets and sets the property AccountDetails. 
        /// <para>
        /// A list of account ID and email address pairs of the accounts that you want to associate
        /// with the GuardDuty administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<AccountDetail> AccountDetails
        {
            get { return this._accountDetails; }
            set { this._accountDetails = value; }
        }

        // Check to see if AccountDetails property is set
        internal bool IsSetAccountDetails()
        {
            return this._accountDetails != null && this._accountDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The unique ID of the detector of the GuardDuty account that you want to associate
        /// member accounts with.
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