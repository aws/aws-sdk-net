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

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// An invitation to an Amazon Web Services account to create a member and join the network.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class Invitation
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the invitation. For more information about ARNs
        /// and their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the invitation was created.
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date and time that the invitation expires. This is the <c>CreationDate</c> plus
        /// the <c>ProposalDurationInHours</c> that is specified in the <c>ProposalThresholdPolicy</c>.
        /// After this date and time, the invitee can no longer create a member and join the network
        /// using this <c>InvitationId</c>.
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The unique identifier for the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string InvitationId { get; set; }

        /// <summary>
        /// Checks to see if the InvitationId property is set.
        /// </summary>
        internal bool IsSetInvitationId() => this.InvitationId != null;

        /// <summary>
        /// Gets and sets the property NetworkSummary.
        /// </summary>
        public NetworkSummary NetworkSummary { get; set; }

        /// <summary>
        /// Checks to see if the NetworkSummary property is set.
        /// </summary>
        internal bool IsSetNetworkSummary() => this.NetworkSummary != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the invitation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> - The invitee hasn't created a member to join the network, and the
        /// invitation hasn't yet expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPTING</c> - The invitee has begun creating a member, and creation hasn't yet
        /// completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPTED</c> - The invitee created a member and joined the network using the <c>InvitationID</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> - The invitee rejected the invitation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> - The invitee neither created a member nor rejected the invitation
        /// before the <c>ExpirationDate</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InvitationStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
