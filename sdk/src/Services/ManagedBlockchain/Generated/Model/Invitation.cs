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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// An invitation to an AWS account to create a member and join the network.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class Invitation
    {
        private DateTime? _creationDate;
        private DateTime? _expirationDate;
        private string _invitationId;
        private NetworkSummary _networkSummary;
        private InvitationStatus _status;

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        /// The date and time that the invitation was created.
        /// </para>
        /// </summary>
        public DateTime CreationDate
        {
            get { return this._creationDate.GetValueOrDefault(); }
            set { this._creationDate = value; }
        }

        // Check to see if CreationDate property is set
        internal bool IsSetCreationDate()
        {
            return this._creationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        /// The date and time that the invitation expires. This is the <code>CreationDate</code>
        /// plus the <code>ProposalDurationInHours</code> that is specified in the <code>ProposalThresholdPolicy</code>.
        /// After this date and time, the invitee can no longer create a member and join the network
        /// using this <code>InvitationId</code>.
        /// </para>
        /// </summary>
        public DateTime ExpirationDate
        {
            get { return this._expirationDate.GetValueOrDefault(); }
            set { this._expirationDate = value; }
        }

        // Check to see if ExpirationDate property is set
        internal bool IsSetExpirationDate()
        {
            return this._expirationDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InvitationId. 
        /// <para>
        /// The unique identifier for the invitation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
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

        /// <summary>
        /// Gets and sets the property NetworkSummary.
        /// </summary>
        public NetworkSummary NetworkSummary
        {
            get { return this._networkSummary; }
            set { this._networkSummary = value; }
        }

        // Check to see if NetworkSummary property is set
        internal bool IsSetNetworkSummary()
        {
            return this._networkSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the invitation:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> - The invitee has not created a member to join the network,
        /// and the invitation has not yet expired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACCEPTING</code> - The invitee has begun creating a member, and creation has
        /// not yet completed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACCEPTED</code> - The invitee created a member and joined the network using
        /// the <code>InvitationID</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REJECTED</code> - The invitee rejected the invitation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXPIRED</code> - The invitee neither created a member nor rejected the invitation
        /// before the <code>ExpirationDate</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public InvitationStatus Status
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