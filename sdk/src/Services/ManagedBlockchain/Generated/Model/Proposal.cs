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
    /// Properties of a proposal on a Managed Blockchain network.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class Proposal
    {
        private ProposalActions _actions;
        private DateTime? _creationDate;
        private string _description;
        private DateTime? _expirationDate;
        private string _networkId;
        private int? _noVoteCount;
        private int? _outstandingVoteCount;
        private string _proposalId;
        private string _proposedByMemberId;
        private string _proposedByMemberName;
        private ProposalStatus _status;
        private int? _yesVoteCount;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to perform on the network if the proposal is <code>APPROVED</code>.
        /// </para>
        /// </summary>
        public ProposalActions Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        ///  The date and time that the proposal was created. 
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
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Max=128)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpirationDate. 
        /// <para>
        ///  The date and time that the proposal expires. This is the <code>CreationDate</code>
        /// plus the <code>ProposalDurationInHours</code> that is specified in the <code>ProposalThresholdPolicy</code>.
        /// After this date and time, if members have not cast enough votes to determine the outcome
        /// according to the voting policy, the proposal is <code>EXPIRED</code> and <code>Actions</code>
        /// are not carried out. 
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
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network for which the proposal is made.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property NoVoteCount. 
        /// <para>
        ///  The current total of <code>NO</code> votes cast on the proposal by members. 
        /// </para>
        /// </summary>
        public int NoVoteCount
        {
            get { return this._noVoteCount.GetValueOrDefault(); }
            set { this._noVoteCount = value; }
        }

        // Check to see if NoVoteCount property is set
        internal bool IsSetNoVoteCount()
        {
            return this._noVoteCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutstandingVoteCount. 
        /// <para>
        ///  The number of votes remaining to be cast on the proposal by members. In other words,
        /// the number of members minus the sum of <code>YES</code> votes and <code>NO</code>
        /// votes. 
        /// </para>
        /// </summary>
        public int OutstandingVoteCount
        {
            get { return this._outstandingVoteCount.GetValueOrDefault(); }
            set { this._outstandingVoteCount = value; }
        }

        // Check to see if OutstandingVoteCount property is set
        internal bool IsSetOutstandingVoteCount()
        {
            return this._outstandingVoteCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        /// The unique identifier of the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ProposalId
        {
            get { return this._proposalId; }
            set { this._proposalId = value; }
        }

        // Check to see if ProposalId property is set
        internal bool IsSetProposalId()
        {
            return this._proposalId != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedByMemberId. 
        /// <para>
        /// The unique identifier of the member that created the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string ProposedByMemberId
        {
            get { return this._proposedByMemberId; }
            set { this._proposedByMemberId = value; }
        }

        // Check to see if ProposedByMemberId property is set
        internal bool IsSetProposedByMemberId()
        {
            return this._proposedByMemberId != null;
        }

        /// <summary>
        /// Gets and sets the property ProposedByMemberName. 
        /// <para>
        /// The name of the member that created the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ProposedByMemberName
        {
            get { return this._proposedByMemberName; }
            set { this._proposedByMemberName = value; }
        }

        // Check to see if ProposedByMemberName property is set
        internal bool IsSetProposedByMemberName()
        {
            return this._proposedByMemberName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the proposal. Values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>IN_PROGRESS</code> - The proposal is active and open for member voting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>APPROVED</code> - The proposal was approved with sufficient <code>YES</code>
        /// votes among members according to the <code>VotingPolicy</code> specified for the <code>Network</code>.
        /// The specified proposal actions are carried out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>REJECTED</code> - The proposal was rejected with insufficient <code>YES</code>
        /// votes among members according to the <code>VotingPolicy</code> specified for the <code>Network</code>.
        /// The specified <code>ProposalActions</code> are not carried out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>EXPIRED</code> - Members did not cast the number of votes required to determine
        /// the proposal outcome before the proposal expired. The specified <code>ProposalActions</code>
        /// are not carried out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ACTION_FAILED</code> - One or more of the specified <code>ProposalActions</code>
        /// in a proposal that was approved could not be completed because of an error. The <code>ACTION_FAILED</code>
        /// status occurs even if only one ProposalAction fails and other actions are successful.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProposalStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property YesVoteCount. 
        /// <para>
        ///  The current total of <code>YES</code> votes cast on the proposal by members. 
        /// </para>
        /// </summary>
        public int YesVoteCount
        {
            get { return this._yesVoteCount.GetValueOrDefault(); }
            set { this._yesVoteCount = value; }
        }

        // Check to see if YesVoteCount property is set
        internal bool IsSetYesVoteCount()
        {
            return this._yesVoteCount.HasValue; 
        }

    }
}