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
    /// Container for the parameters to the VoteOnProposal operation. Casts a vote for a specified
    /// <c>ProposalId</c> on behalf of a member. The member to vote as, specified by <c>VoterMemberId</c>,
    /// must be in the same Amazon Web Services account as the principal that calls the action.
    /// <para> Applies only to Hyperledger Fabric. </para>
    /// </summary>
    public partial class VoteOnProposalRequest : AmazonManagedBlockchainRequest
    {
        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        ///  The unique identifier of the network. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        ///  The unique identifier of the proposal. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string ProposalId { get; set; }

        /// <summary>
        /// Checks to see if the ProposalId property is set.
        /// </summary>
        internal bool IsSetProposalId() => this.ProposalId != null;

        /// <summary>
        /// Gets and sets the property Vote. 
        /// <para>
        ///  The value of the vote. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VoteValue Vote { get; set; }

        /// <summary>
        /// Checks to see if the Vote property is set.
        /// </summary>
        internal bool IsSetVote() => this.Vote != null;

        /// <summary>
        /// Gets and sets the property VoterMemberId. 
        /// <para>
        /// The unique identifier of the member casting the vote. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string VoterMemberId { get; set; }

        /// <summary>
        /// Checks to see if the VoterMemberId property is set.
        /// </summary>
        internal bool IsSetVoterMemberId() => this.VoterMemberId != null;
    }
}
