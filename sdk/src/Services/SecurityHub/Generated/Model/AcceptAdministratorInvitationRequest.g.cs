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
    /// Container for the parameters to the AcceptAdministratorInvitation operation. <note>
    /// <para> We recommend using Organizations instead of Security Hub CSPM invitations to
    /// manage your member accounts. For information, see <a href="https://docs.aws.amazon.com/securityhub/latest/userguide/securityhub-accounts-orgs.html">Managing
    /// Security Hub CSPM administrator and member accounts with Organizations</a> in the
    /// <i>Security Hub CSPM User Guide</i>. </para> </note> <para> Accepts the invitation
    /// to be a member account and be monitored by the Security Hub CSPM administrator account
    /// that the invitation was sent from. </para> <para> This operation is only used by member
    /// accounts that are not added through Organizations. </para> <para> When the member
    /// account accepts the invitation, permission is granted to the administrator account
    /// to view findings generated in the member account. </para>
    /// </summary>
    public partial class AcceptAdministratorInvitationRequest : AmazonSecurityHubRequest
    {
        /// <summary>
        /// Gets and sets the property AdministratorId. 
        /// <para>
        /// The account ID of the Security Hub CSPM administrator account that sent the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AdministratorId { get; set; }

        /// <summary>
        /// Checks to see if the AdministratorId property is set.
        /// </summary>
        internal bool IsSetAdministratorId() => this.AdministratorId != null;

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The identifier of the invitation sent from the Security Hub CSPM administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string InvitationId { get; set; }

        /// <summary>
        /// Checks to see if the InvitationId property is set.
        /// </summary>
        internal bool IsSetInvitationId() => this.InvitationId != null;
    }
}
