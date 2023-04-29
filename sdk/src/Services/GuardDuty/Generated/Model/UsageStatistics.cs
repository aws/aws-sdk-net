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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains the result of GuardDuty usage. If a UsageStatisticType is provided the result
    /// for other types will be null.
    /// </summary>
    public partial class UsageStatistics
    {
        private List<UsageAccountResult> _sumByAccount = new List<UsageAccountResult>();
        private List<UsageDataSourceResult> _sumByDataSource = new List<UsageDataSourceResult>();
        private List<UsageFeatureResult> _sumByFeature = new List<UsageFeatureResult>();
        private List<UsageResourceResult> _sumByResource = new List<UsageResourceResult>();
        private List<UsageResourceResult> _topResources = new List<UsageResourceResult>();

        /// <summary>
        /// Gets and sets the property SumByAccount. 
        /// <para>
        /// The usage statistic sum organized by account ID.
        /// </para>
        /// </summary>
        public List<UsageAccountResult> SumByAccount
        {
            get { return this._sumByAccount; }
            set { this._sumByAccount = value; }
        }

        // Check to see if SumByAccount property is set
        internal bool IsSetSumByAccount()
        {
            return this._sumByAccount != null && this._sumByAccount.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SumByDataSource. 
        /// <para>
        /// The usage statistic sum organized by on data source.
        /// </para>
        /// </summary>
        public List<UsageDataSourceResult> SumByDataSource
        {
            get { return this._sumByDataSource; }
            set { this._sumByDataSource = value; }
        }

        // Check to see if SumByDataSource property is set
        internal bool IsSetSumByDataSource()
        {
            return this._sumByDataSource != null && this._sumByDataSource.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SumByFeature. 
        /// <para>
        /// The usage statistic sum organized by feature.
        /// </para>
        /// </summary>
        public List<UsageFeatureResult> SumByFeature
        {
            get { return this._sumByFeature; }
            set { this._sumByFeature = value; }
        }

        // Check to see if SumByFeature property is set
        internal bool IsSetSumByFeature()
        {
            return this._sumByFeature != null && this._sumByFeature.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SumByResource. 
        /// <para>
        /// The usage statistic sum organized by resource.
        /// </para>
        /// </summary>
        public List<UsageResourceResult> SumByResource
        {
            get { return this._sumByResource; }
            set { this._sumByResource = value; }
        }

        // Check to see if SumByResource property is set
        internal bool IsSetSumByResource()
        {
            return this._sumByResource != null && this._sumByResource.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TopResources. 
        /// <para>
        /// Lists the top 50 resources that have generated the most GuardDuty usage, in order
        /// from most to least expensive.
        /// </para>
        /// </summary>
        public List<UsageResourceResult> TopResources
        {
            get { return this._topResources; }
            set { this._topResources = value; }
        }

        // Check to see if TopResources property is set
        internal bool IsSetTopResources()
        {
            return this._topResources != null && this._topResources.Count > 0; 
        }

    }
}