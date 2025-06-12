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

#pragma warning disable CS0612,CS0618,CS1570
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
        private string _arn;
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
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private int? _yesVoteCount;

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to perform on the network if the proposal is <c>APPROVED</c>.
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
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the proposal. For more information about ARNs and
        /// their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1011)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationDate. 
        /// <para>
        ///  The date and time that the proposal was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationDate
        {
            get { return this._creationDate; }
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
        ///  The date and time that the proposal expires. This is the <c>CreationDate</c> plus
        /// the <c>ProposalDurationInHours</c> that is specified in the <c>ProposalThresholdPolicy</c>.
        /// After this date and time, if members haven't cast enough votes to determine the outcome
        /// according to the voting policy, the proposal is <c>EXPIRED</c> and <c>Actions</c>
        /// aren't carried out. 
        /// </para>
        /// </summary>
        public DateTime? ExpirationDate
        {
            get { return this._expirationDate; }
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
        ///  The current total of <c>NO</c> votes cast on the proposal by members. 
        /// </para>
        /// </summary>
        public int? NoVoteCount
        {
            get { return this._noVoteCount; }
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
        /// the number of members minus the sum of <c>YES</c> votes and <c>NO</c> votes. 
        /// </para>
        /// </summary>
        public int? OutstandingVoteCount
        {
            get { return this._outstandingVoteCount; }
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
        ///  <c>IN_PROGRESS</c> - The proposal is active and open for member voting.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>APPROVED</c> - The proposal was approved with sufficient <c>YES</c> votes among
        /// members according to the <c>VotingPolicy</c> specified for the <c>Network</c>. The
        /// specified proposal actions are carried out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> - The proposal was rejected with insufficient <c>YES</c> votes among
        /// members according to the <c>VotingPolicy</c> specified for the <c>Network</c>. The
        /// specified <c>ProposalActions</c> aren't carried out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRED</c> - Members didn't cast the number of votes required to determine the
        /// proposal outcome before the proposal expired. The specified <c>ProposalActions</c>
        /// aren't carried out.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTION_FAILED</c> - One or more of the specified <c>ProposalActions</c> in a proposal
        /// that was approved couldn't be completed because of an error. The <c>ACTION_FAILED</c>
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Tags assigned to the proposal. Each tag consists of a key and optional value.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/managed-blockchain/latest/ethereum-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Ethereum Developer Guide</i>, or
        /// <a href="https://docs.aws.amazon.com/managed-blockchain/latest/hyperledger-fabric-dev/tagging-resources.html">Tagging
        /// Resources</a> in the <i>Amazon Managed Blockchain Hyperledger Fabric Developer Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property YesVoteCount. 
        /// <para>
        ///  The current total of <c>YES</c> votes cast on the proposal by members. 
        /// </para>
        /// </summary>
        public int? YesVoteCount
        {
            get { return this._yesVoteCount; }
            set { this._yesVoteCount = value; }
        }

        // Check to see if YesVoteCount property is set
        internal bool IsSetYesVoteCount()
        {
            return this._yesVoteCount.HasValue; 
        }

    }
}