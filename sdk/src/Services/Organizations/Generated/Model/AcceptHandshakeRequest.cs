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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the AcceptHandshake operation.
    /// Accepts a handshake by sending an <c>ACCEPTED</c> response to the sender. You can
    /// view accepted handshakes in API responses for 30 days before they are deleted.
    /// 
    ///  
    /// <para>
    ///  <b>Only the management account can accept the following handshakes</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Enable all features final confirmation (<c>APPROVE_ALL_FEATURES</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Billing transfer (<c>TRANSFER_RESPONSIBILITY</c>)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/manage-begin-all-features-standard-migration.html#manage-approve-all-features-invite">Enabling
    /// all features</a> and <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_transfer_billing-respond-invitation.html">Responding
    /// to a billing transfer invitation</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Only a member account can accept the following handshakes</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Invitation to join (<c>INVITE</c>)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Approve all features request (<c>ENABLE_ALL_FEATURES</c>)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_accept-decline-invite.html">Responding
    /// to invitations</a> and <a href="https://docs.aws.amazon.com/organizations/latest/userguide/manage-begin-all-features-standard-migration.html#manage-approve-all-features-invite">Enabling
    /// all features</a> in the <i>Organizations User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AcceptHandshakeRequest : AmazonOrganizationsRequest
    {
        private string _handshakeId;

        /// <summary>
        /// Gets and sets the property HandshakeId. 
        /// <para>
        /// ID for the handshake that you want to accept.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for handshake ID string
        /// requires "h-" followed by from 8 to 32 lowercase letters or digits.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=34)]
        public string HandshakeId
        {
            get { return this._handshakeId; }
            set { this._handshakeId = value; }
        }

        // Check to see if HandshakeId property is set
        internal bool IsSetHandshakeId()
        {
            return this._handshakeId != null;
        }

    }
}