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
    /// A policy type that defines the voting rules for the network. The rules decide if a
    /// proposal is approved. Approval may be based on criteria such as the percentage of
    /// <c>YES</c> votes and the duration of the proposal. The policy applies to all proposals
    /// and is specified when the network is created.
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class ApprovalThresholdPolicy
    {
        private int? _proposalDurationInHours;
        private ThresholdComparator _thresholdComparator;
        private int? _thresholdPercentage;

        /// <summary>
        /// Gets and sets the property ProposalDurationInHours. 
        /// <para>
        /// The duration from the time that a proposal is created until it expires. If members
        /// cast neither the required number of <c>YES</c> votes to approve the proposal nor the
        /// number of <c>NO</c> votes required to reject it before the duration expires, the proposal
        /// is <c>EXPIRED</c> and <c>ProposalActions</c> aren't carried out.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=168)]
        public int? ProposalDurationInHours
        {
            get { return this._proposalDurationInHours; }
            set { this._proposalDurationInHours = value; }
        }

        // Check to see if ProposalDurationInHours property is set
        internal bool IsSetProposalDurationInHours()
        {
            return this._proposalDurationInHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdComparator. 
        /// <para>
        /// Determines whether the vote percentage must be greater than the <c>ThresholdPercentage</c>
        /// or must be greater than or equal to the <c>ThresholdPercentage</c> to be approved.
        /// </para>
        /// </summary>
        public ThresholdComparator ThresholdComparator
        {
            get { return this._thresholdComparator; }
            set { this._thresholdComparator = value; }
        }

        // Check to see if ThresholdComparator property is set
        internal bool IsSetThresholdComparator()
        {
            return this._thresholdComparator != null;
        }

        /// <summary>
        /// Gets and sets the property ThresholdPercentage. 
        /// <para>
        /// The percentage of votes among all members that must be <c>YES</c> for a proposal to
        /// be approved. For example, a <c>ThresholdPercentage</c> value of <c>50</c> indicates
        /// 50%. The <c>ThresholdComparator</c> determines the precise comparison. If a <c>ThresholdPercentage</c>
        /// value of <c>50</c> is specified on a network with 10 members, along with a <c>ThresholdComparator</c>
        /// value of <c>GREATER_THAN</c>, this indicates that 6 <c>YES</c> votes are required
        /// for the proposal to be approved.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public int? ThresholdPercentage
        {
            get { return this._thresholdPercentage; }
            set { this._thresholdPercentage = value; }
        }

        // Check to see if ThresholdPercentage property is set
        internal bool IsSetThresholdPercentage()
        {
            return this._thresholdPercentage.HasValue; 
        }

    }
}