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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about the position of a member account in a ranking.
    /// </summary>
    public partial class MemberAccountRanking
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID of the member account.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property FindingCount. 
        /// <para>
        /// The number of findings in the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? FindingCount { get; set; }

        /// <summary>
        /// Checks to see if the FindingCount property is set.
        /// </summary>
        internal bool IsSetFindingCount() => this.FindingCount.HasValue;

        /// <summary>
        /// Gets and sets the property Rank. 
        /// <para>
        /// The position of the account in the ranking.
        /// </para>
        /// </summary>
        public int? Rank { get; set; }

        /// <summary>
        /// Checks to see if the Rank property is set.
        /// </summary>
        internal bool IsSetRank() => this.Rank.HasValue;

        /// <summary>
        /// Gets and sets the property RiskLevel. 
        /// <para>
        /// The assessed risk level of the account. Possible values are <c>Info</c>, <c>Low</c>,
        /// <c>Medium</c>, <c>High</c>, and <c>Critical</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public RiskLevel RiskLevel { get; set; }

        /// <summary>
        /// Checks to see if the RiskLevel property is set.
        /// </summary>
        internal bool IsSetRiskLevel() => this.RiskLevel != null;

        /// <summary>
        /// Gets and sets the property RiskRationale. 
        /// <para>
        /// The reason for the assessed risk level.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string RiskRationale { get; set; }

        /// <summary>
        /// Checks to see if the RiskRationale property is set.
        /// </summary>
        internal bool IsSetRiskRationale() => this.RiskRationale != null;
    }
}
