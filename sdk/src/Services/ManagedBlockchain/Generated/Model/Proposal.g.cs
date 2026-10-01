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
    /// Properties of a proposal on a Managed Blockchain network.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class Proposal
    {
        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        /// The actions to perform on the network if the proposal is <c>APPROVED</c>.
        /// </para>
        /// </summary>
        public ProposalActions Actions { get; set; }

        /// <summary>
        /// Checks to see if the Actions property is set.
        /// </summary>
        internal bool IsSetActions() => this.Actions != null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the proposal. For more information about ARNs and
        /// their format, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
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
        ///  The date and time that the proposal was created. 
        /// </para>
        /// </summary>
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Checks to see if the CreationDate property is set.
        /// </summary>
        internal bool IsSetCreationDate() => this.CreationDate.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

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
        public DateTime? ExpirationDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpirationDate property is set.
        /// </summary>
        internal bool IsSetExpirationDate() => this.ExpirationDate.HasValue;

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The unique identifier of the network for which the proposal is made.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string NetworkId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkId property is set.
        /// </summary>
        internal bool IsSetNetworkId() => this.NetworkId != null;

        /// <summary>
        /// Gets and sets the property NoVoteCount. 
        /// <para>
        ///  The current total of <c>NO</c> votes cast on the proposal by members. 
        /// </para>
        /// </summary>
        public int? NoVoteCount { get; set; }

        /// <summary>
        /// Checks to see if the NoVoteCount property is set.
        /// </summary>
        internal bool IsSetNoVoteCount() => this.NoVoteCount.HasValue;

        /// <summary>
        /// Gets and sets the property OutstandingVoteCount. 
        /// <para>
        ///  The number of votes remaining to be cast on the proposal by members. In other words,
        /// the number of members minus the sum of <c>YES</c> votes and <c>NO</c> votes. 
        /// </para>
        /// </summary>
        public int? OutstandingVoteCount { get; set; }

        /// <summary>
        /// Checks to see if the OutstandingVoteCount property is set.
        /// </summary>
        internal bool IsSetOutstandingVoteCount() => this.OutstandingVoteCount.HasValue;

        /// <summary>
        /// Gets and sets the property ProposalId. 
        /// <para>
        /// The unique identifier of the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string ProposalId { get; set; }

        /// <summary>
        /// Checks to see if the ProposalId property is set.
        /// </summary>
        internal bool IsSetProposalId() => this.ProposalId != null;

        /// <summary>
        /// Gets and sets the property ProposedByMemberId. 
        /// <para>
        /// The unique identifier of the member that created the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string ProposedByMemberId { get; set; }

        /// <summary>
        /// Checks to see if the ProposedByMemberId property is set.
        /// </summary>
        internal bool IsSetProposedByMemberId() => this.ProposedByMemberId != null;

        /// <summary>
        /// Gets and sets the property ProposedByMemberName. 
        /// <para>
        /// The name of the member that created the proposal.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ProposedByMemberName { get; set; }

        /// <summary>
        /// Checks to see if the ProposedByMemberName property is set.
        /// </summary>
        internal bool IsSetProposedByMemberName() => this.ProposedByMemberName != null;

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
        public ProposalStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property YesVoteCount. 
        /// <para>
        ///  The current total of <c>YES</c> votes cast on the proposal by members. 
        /// </para>
        /// </summary>
        public int? YesVoteCount { get; set; }

        /// <summary>
        /// Checks to see if the YesVoteCount property is set.
        /// </summary>
        internal bool IsSetYesVoteCount() => this.YesVoteCount.HasValue;
    }
}
