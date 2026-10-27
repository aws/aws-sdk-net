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
    /// Information about the coverage statistics of the features for the entire Amazon Web
    /// Services organization.
    /// 
    ///  
    /// <para>
    /// When you create a new Amazon Web Services organization, it might take up to 24 hours
    /// to generate the statistics summary for this organization.
    /// </para>
    /// </summary>
    public partial class OrganizationStatistics
    {
        /// <summary>
        /// Gets and sets the property ActiveAccountsCount. 
        /// <para>
        /// Total number of active accounts in your Amazon Web Services organization that are
        /// associated with GuardDuty.
        /// </para>
        /// </summary>
        public int? ActiveAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the ActiveAccountsCount property is set.
        /// </summary>
        internal bool IsSetActiveAccountsCount() => this.ActiveAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property CountByFeature. 
        /// <para>
        /// Retrieves the coverage statistics for each feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrganizationFeatureStatistics> CountByFeature { get; set; } = AWSConfigs.InitializeCollections ? new List<OrganizationFeatureStatistics>() : null;

        /// <summary>
        /// Checks to see if the CountByFeature property is set.
        /// </summary>
        internal bool IsSetCountByFeature() => this.CountByFeature != null && (this.CountByFeature.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnabledAccountsCount. 
        /// <para>
        /// Total number of accounts that have enabled GuardDuty.
        /// </para>
        /// </summary>
        public int? EnabledAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the EnabledAccountsCount property is set.
        /// </summary>
        internal bool IsSetEnabledAccountsCount() => this.EnabledAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property MemberAccountsCount. 
        /// <para>
        /// Total number of accounts in your Amazon Web Services organization that are associated
        /// with GuardDuty.
        /// </para>
        /// </summary>
        public int? MemberAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the MemberAccountsCount property is set.
        /// </summary>
        internal bool IsSetMemberAccountsCount() => this.MemberAccountsCount.HasValue;

        /// <summary>
        /// Gets and sets the property TotalAccountsCount. 
        /// <para>
        /// Total number of accounts in your Amazon Web Services organization.
        /// </para>
        /// </summary>
        public int? TotalAccountsCount { get; set; }

        /// <summary>
        /// Checks to see if the TotalAccountsCount property is set.
        /// </summary>
        internal bool IsSetTotalAccountsCount() => this.TotalAccountsCount.HasValue;
    }
}
