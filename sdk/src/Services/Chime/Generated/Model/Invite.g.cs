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

namespace Amazon.Chime.Model
{
    /// <summary>
    /// Invitation object returned after emailing users to invite them to join the Amazon
    /// Chime <c>Team</c> account.
    /// </summary>
    public partial class Invite
    {
        /// <summary>
        /// Gets and sets the property EmailAddress. 
        /// <para>
        /// The email address to which the invite is sent.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Checks to see if the EmailAddress property is set.
        /// </summary>
        internal bool IsSetEmailAddress() => this.EmailAddress != null;

        /// <summary>
        /// Gets and sets the property EmailStatus. 
        /// <para>
        /// The status of the invite email.
        /// </para>
        /// </summary>
        public EmailStatus EmailStatus { get; set; }

        /// <summary>
        /// Checks to see if the EmailStatus property is set.
        /// </summary>
        internal bool IsSetEmailStatus() => this.EmailStatus != null;

        /// <summary>
        /// Gets and sets the property InviteId. 
        /// <para>
        /// The invite ID.
        /// </para>
        /// </summary>
        public string InviteId { get; set; }

        /// <summary>
        /// Checks to see if the InviteId property is set.
        /// </summary>
        internal bool IsSetInviteId() => this.InviteId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the invite.
        /// </para>
        /// </summary>
        public InviteStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
