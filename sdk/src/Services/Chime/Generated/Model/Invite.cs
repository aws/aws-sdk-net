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
 * Do not modify this file. This file is generated from the chime-2018-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Invitation object returned after emailing users to invite them to join the Amazon
    /// Chime <code>Team</code> account.
    /// </summary>
    public partial class Invite
    {
        private string _emailAddress;
        private EmailStatus _emailStatus;
        private string _inviteId;
        private InviteStatus _status;

        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address to which the invite is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string EmailAddress
        {
            get { return this._emailAddress; }
            set { this._emailAddress = value; }
        }

        // Check to see if EmailAddress property is set
        internal bool IsSetEmailAddress()
        {
            return this._emailAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EmailStatus. 
        /// <para>
        /// The status of the invite email.
        /// </para>
        /// </summary>
        public EmailStatus EmailStatus
        {
            get { return this._emailStatus; }
            set { this._emailStatus = value; }
        }

        // Check to see if EmailStatus property is set
        internal bool IsSetEmailStatus()
        {
            return this._emailStatus != null;
        }

        /// <summary>
        /// Gets and sets the property InviteId. 
        /// <para>
        /// The invite ID.
        /// </para>
        /// </summary>
        public string InviteId
        {
            get { return this._inviteId; }
            set { this._inviteId = value; }
        }

        // Check to see if InviteId property is set
        internal bool IsSetInviteId()
        {
            return this._inviteId != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the invite.
        /// </para>
        /// </summary>
        public InviteStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}