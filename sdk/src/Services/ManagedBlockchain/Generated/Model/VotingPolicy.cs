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
    /// The voting rules for the network to decide if a proposal is accepted 
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class VotingPolicy
    {
        private ApprovalThresholdPolicy _approvalThresholdPolicy;

        /// <summary>
        /// Gets and sets the property ApprovalThresholdPolicy. 
        /// <para>
        /// Defines the rules for the network for voting on proposals, such as the percentage
        /// of <c>YES</c> votes required for the proposal to be approved and the duration of the
        /// proposal. The policy applies to all proposals and is specified when the network is
        /// created.
        /// </para>
        /// </summary>
        public ApprovalThresholdPolicy ApprovalThresholdPolicy
        {
            get { return this._approvalThresholdPolicy; }
            set { this._approvalThresholdPolicy = value; }
        }

        // Check to see if ApprovalThresholdPolicy property is set
        internal bool IsSetApprovalThresholdPolicy()
        {
            return this._approvalThresholdPolicy != null;
        }

    }
}