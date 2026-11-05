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
    /// Contains the result of GuardDuty usage. If a UsageStatisticType is provided the result
    /// for other types will be null.
    /// </summary>
    public partial class UsageStatistics
    {
        /// <summary>
        /// Gets and sets the property SumByAccount. 
        /// <para>
        /// The usage statistic sum organized by account ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageAccountResult> SumByAccount { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageAccountResult>() : null;

        /// <summary>
        /// Checks to see if the SumByAccount property is set.
        /// </summary>
        internal bool IsSetSumByAccount() => this.SumByAccount != null && (this.SumByAccount.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SumByDataSource. 
        /// <para>
        /// The usage statistic sum organized by on data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageDataSourceResult> SumByDataSource { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageDataSourceResult>() : null;

        /// <summary>
        /// Checks to see if the SumByDataSource property is set.
        /// </summary>
        internal bool IsSetSumByDataSource() => this.SumByDataSource != null && (this.SumByDataSource.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SumByFeature. 
        /// <para>
        /// The usage statistic sum organized by feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageFeatureResult> SumByFeature { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageFeatureResult>() : null;

        /// <summary>
        /// Checks to see if the SumByFeature property is set.
        /// </summary>
        internal bool IsSetSumByFeature() => this.SumByFeature != null && (this.SumByFeature.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SumByResource. 
        /// <para>
        /// The usage statistic sum organized by resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageResourceResult> SumByResource { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageResourceResult>() : null;

        /// <summary>
        /// Checks to see if the SumByResource property is set.
        /// </summary>
        internal bool IsSetSumByResource() => this.SumByResource != null && (this.SumByResource.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopAccountsByFeature. 
        /// <para>
        /// Lists the top 50 accounts by feature that have generated the most GuardDuty usage,
        /// in the order from most to least expensive.
        /// </para>
        ///  
        /// <para>
        /// Currently, this doesn't support <c>RDS_LOGIN_EVENTS</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageTopAccountsResult> TopAccountsByFeature { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageTopAccountsResult>() : null;

        /// <summary>
        /// Checks to see if the TopAccountsByFeature property is set.
        /// </summary>
        internal bool IsSetTopAccountsByFeature() => this.TopAccountsByFeature != null && (this.TopAccountsByFeature.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TopResources. 
        /// <para>
        /// Lists the top 50 resources that have generated the most GuardDuty usage, in order
        /// from most to least expensive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageResourceResult> TopResources { get; set; } = AWSConfigs.InitializeCollections ? new List<UsageResourceResult>() : null;

        /// <summary>
        /// Checks to see if the TopResources property is set.
        /// </summary>
        internal bool IsSetTopResources() => this.TopResources != null && (this.TopResources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
