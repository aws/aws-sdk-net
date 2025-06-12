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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
        private List<UsageAccountResult> _sumByAccount = AWSConfigs.InitializeCollections ? new List<UsageAccountResult>() : null;
        private List<UsageDataSourceResult> _sumByDataSource = AWSConfigs.InitializeCollections ? new List<UsageDataSourceResult>() : null;
        private List<UsageFeatureResult> _sumByFeature = AWSConfigs.InitializeCollections ? new List<UsageFeatureResult>() : null;
        private List<UsageResourceResult> _sumByResource = AWSConfigs.InitializeCollections ? new List<UsageResourceResult>() : null;
        private List<UsageTopAccountsResult> _topAccountsByFeature = AWSConfigs.InitializeCollections ? new List<UsageTopAccountsResult>() : null;
        private List<UsageResourceResult> _topResources = AWSConfigs.InitializeCollections ? new List<UsageResourceResult>() : null;

        /// <summary>
        /// Gets and sets the property SumByAccount. 
        /// <para>
        /// The usage statistic sum organized by account ID.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageAccountResult> SumByAccount
        {
            get { return this._sumByAccount; }
            set { this._sumByAccount = value; }
        }

        // Check to see if SumByAccount property is set
        internal bool IsSetSumByAccount()
        {
            return this._sumByAccount != null && (this._sumByAccount.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SumByDataSource. 
        /// <para>
        /// The usage statistic sum organized by on data source.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageDataSourceResult> SumByDataSource
        {
            get { return this._sumByDataSource; }
            set { this._sumByDataSource = value; }
        }

        // Check to see if SumByDataSource property is set
        internal bool IsSetSumByDataSource()
        {
            return this._sumByDataSource != null && (this._sumByDataSource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SumByFeature. 
        /// <para>
        /// The usage statistic sum organized by feature.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageFeatureResult> SumByFeature
        {
            get { return this._sumByFeature; }
            set { this._sumByFeature = value; }
        }

        // Check to see if SumByFeature property is set
        internal bool IsSetSumByFeature()
        {
            return this._sumByFeature != null && (this._sumByFeature.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SumByResource. 
        /// <para>
        /// The usage statistic sum organized by resource.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageResourceResult> SumByResource
        {
            get { return this._sumByResource; }
            set { this._sumByResource = value; }
        }

        // Check to see if SumByResource property is set
        internal bool IsSetSumByResource()
        {
            return this._sumByResource != null && (this._sumByResource.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

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
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageTopAccountsResult> TopAccountsByFeature
        {
            get { return this._topAccountsByFeature; }
            set { this._topAccountsByFeature = value; }
        }

        // Check to see if TopAccountsByFeature property is set
        internal bool IsSetTopAccountsByFeature()
        {
            return this._topAccountsByFeature != null && (this._topAccountsByFeature.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TopResources. 
        /// <para>
        /// Lists the top 50 resources that have generated the most GuardDuty usage, in order
        /// from most to least expensive.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<UsageResourceResult> TopResources
        {
            get { return this._topResources; }
            set { this._topResources = value; }
        }

        // Check to see if TopResources property is set
        internal bool IsSetTopResources()
        {
            return this._topResources != null && (this._topResources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}