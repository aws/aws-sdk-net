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
    /// Container for the parameters to the AcceptAdministratorInvitation operation.
    /// <note> 
    /// <para>
    /// We recommend using Organizations instead of Security Hub invitations to manage your
    /// member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
    /// Security Hub administrator and member accounts with Organizations</a> in the <i>Security
    /// Hub User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Accepts the invitation to be a member account and be monitored by the Security Hub
    /// administrator account that the invitation was sent from.
    /// </para>
    ///  
    /// <para>
    /// This operation is only used by member accounts that are not added through Organizations.
    /// </para>
    ///  
    /// <para>
    /// When the member account accepts the invitation, permission is granted to the administrator
    /// account to view findings generated in the member account.
    /// </para>
    /// </summary>
    public partial class AcceptAdministratorInvitationRequest : AmazonSecurityHubRequest
    {
        private string _administratorId;
        private string _invitationId;

        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The account ID of the Security Hub administrator account that sent the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdministratorId
        {
            get { return this._administratorId; }
            set { this._administratorId = value; }
        }

        // Check to see if AdministratorId property is set
        internal bool IsSetAdministratorId()
        {
            return this._administratorId != null;
        }

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The identifier of the invitation sent from the Security Hub administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string InvitationId
        {
            get { return this._invitationId; }
            set { this._invitationId = value; }
        }

        // Check to see if InvitationId property is set
        internal bool IsSetInvitationId()
        {
            return this._invitationId != null;
        }

    }
}