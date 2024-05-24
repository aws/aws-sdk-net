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
    /// Container for the parameters to the VoteOnProposal operation.
    /// Casts a vote for a specified <c>ProposalId</c> on behalf of a member. The member to
    /// vote as, specified by <c>VoterMemberId</c>, must be in the same Amazon Web Services
    /// account as the principal that calls the action.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class VoteOnProposalRequest : AmazonManagedBlockchainRequest
    {
        private string _networkId;
        private string _proposalId;
        private VoteValue _vote;
        private string _voterMemberId;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        ///  The unique identifier of the network. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property ProposalId. 
        /// <para>
        ///  The unique identifier of the proposal. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
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
        /// Gets and sets the property Vote. 
        /// <para>
        ///  The value of the vote. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VoteValue Vote
        {
            get { return this._vote; }
            set { this._vote = value; }
        }

        // Check to see if Vote property is set
        internal bool IsSetVote()
        {
            return this._vote != null;
        }

        /// <summary>
        /// Gets and sets the property VoterMemberId. 
        /// <para>
        /// The unique identifier of the member casting the vote. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string VoterMemberId
        {
            get { return this._voterMemberId; }
            set { this._voterMemberId = value; }
        }

        // Check to see if VoterMemberId property is set
        internal bool IsSetVoterMemberId()
        {
            return this._voterMemberId != null;
        }

    }
}