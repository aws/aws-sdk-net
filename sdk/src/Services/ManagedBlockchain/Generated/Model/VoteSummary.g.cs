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
    /// Properties of an individual vote that a member cast for a proposal. 
    /// 
    ///  
    /// <para>
    /// Applies only to Hyperledger Fabric.
    /// </para>
    /// </summary>
    public partial class VoteSummary
    {
        /// <summary>
        /// Gets and sets the property MemberId. 
        /// <para>
        ///  The unique identifier of the member that cast the vote. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 32)]
        public string MemberId { get; set; }

        /// <summary>
        /// Checks to see if the MemberId property is set.
        /// </summary>
        internal bool IsSetMemberId() => this.MemberId != null;

        /// <summary>
        /// Gets and sets the property MemberName. 
        /// <para>
        ///  The name of the member that cast the vote. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string MemberName { get; set; }

        /// <summary>
        /// Checks to see if the MemberName property is set.
        /// </summary>
        internal bool IsSetMemberName() => this.MemberName != null;

        /// <summary>
        /// Gets and sets the property Vote. 
        /// <para>
        ///  The vote value, either <c>YES</c> or <c>NO</c>. 
        /// </para>
        /// </summary>
        public VoteValue Vote { get; set; }

        /// <summary>
        /// Checks to see if the Vote property is set.
        /// </summary>
        internal bool IsSetVote() => this.Vote != null;
    }
}
