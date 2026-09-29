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
    /// Properties of a proposal.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class ProposalSummary
    {
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
        ///  The description of the proposal. 
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
        /// Gets and sets the property ProposalId. 
        /// <para>
        ///  The unique identifier of the proposal. 
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
        ///  The unique identifier of the member that created the proposal. 
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
        ///  The name of the member that created the proposal. 
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
        /// that was approved couldn't be completed because of an error.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ProposalStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
