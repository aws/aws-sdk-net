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
    /// Contains overview information about an account, including its findings and, for an
    /// organization, its member accounts.
    /// </summary>
    public partial class AccountOverview
    {
        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account ID.
        /// </para>
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Checks to see if the AccountId property is set.
        /// </summary>
        internal bool IsSetAccountId() => this.AccountId != null;

        /// <summary>
        /// Gets and sets the property AccountRankings. 
        /// <para>
        /// A ranking of member accounts.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<MemberAccountRanking> AccountRankings { get; set; } = AWSConfigs.InitializeCollections ? new List<MemberAccountRanking>() : null;

        /// <summary>
        /// Checks to see if the AccountRankings property is set.
        /// </summary>
        internal bool IsSetAccountRankings() => this.AccountRankings != null && (this.AccountRankings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AccountStatus. 
        /// <para>
        /// The status of the account.
        /// </para>
        /// </summary>
        public string AccountStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountStatus property is set.
        /// </summary>
        internal bool IsSetAccountStatus() => this.AccountStatus != null;

        /// <summary>
        /// Gets and sets the property AffectedAccountCount. 
        /// <para>
        /// The number of accounts that have findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? AffectedAccountCount { get; set; }

        /// <summary>
        /// Checks to see if the AffectedAccountCount property is set.
        /// </summary>
        internal bool IsSetAffectedAccountCount() => this.AffectedAccountCount.HasValue;

        /// <summary>
        /// Gets and sets the property DelegatedAdminAccountId. 
        /// <para>
        /// The account ID of the GuardDuty delegated administrator account.
        /// </para>
        /// </summary>
        public string DelegatedAdminAccountId { get; set; }

        /// <summary>
        /// Checks to see if the DelegatedAdminAccountId property is set.
        /// </summary>
        internal bool IsSetDelegatedAdminAccountId() => this.DelegatedAdminAccountId != null;

        /// <summary>
        /// Gets and sets the property DetectorId. 
        /// <para>
        /// The ID of the detector of the account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 300)]
        public string DetectorId { get; set; }

        /// <summary>
        /// Checks to see if the DetectorId property is set.
        /// </summary>
        internal bool IsSetDetectorId() => this.DetectorId != null;

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The Amazon Web Services Region of the detector.
        /// </para>
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// Checks to see if the Region property is set.
        /// </summary>
        internal bool IsSetRegion() => this.Region != null;

        /// <summary>
        /// Gets and sets the property TotalFindings. 
        /// <para>
        /// The total number of findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalFindings { get; set; }

        /// <summary>
        /// Checks to see if the TotalFindings property is set.
        /// </summary>
        internal bool IsSetTotalFindings() => this.TotalFindings.HasValue;

        /// <summary>
        /// Gets and sets the property TotalMemberAccounts. 
        /// <para>
        /// The total number of member accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? TotalMemberAccounts { get; set; }

        /// <summary>
        /// Checks to see if the TotalMemberAccounts property is set.
        /// </summary>
        internal bool IsSetTotalMemberAccounts() => this.TotalMemberAccounts.HasValue;
    }
}
