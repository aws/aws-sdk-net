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
    /// Information about the number of accounts that have enabled a specific feature.
    /// </summary>
    public partial class OrganizationFeatureStatistics
    {
        private List<OrganizationFeatureStatisticsAdditionalConfiguration> _additionalConfiguration = AWSConfigs.InitializeCollections ? new List<OrganizationFeatureStatisticsAdditionalConfiguration>() : null;
        private int? _enabledAccountsCount;
        private OrgFeature _name;

        /// <summary>
        /// Gets and sets the property AdditionalConfiguration. 
        /// <para>
        /// Name of the additional configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<OrganizationFeatureStatisticsAdditionalConfiguration> AdditionalConfiguration
        {
            get { return this._additionalConfiguration; }
            set { this._additionalConfiguration = value; }
        }

        // Check to see if AdditionalConfiguration property is set
        internal bool IsSetAdditionalConfiguration()
        {
            return this._additionalConfiguration != null && (this._additionalConfiguration.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnabledAccountsCount. 
        /// <para>
        /// Total number of accounts that have enabled a specific feature.
        /// </para>
        /// </summary>
        public int? EnabledAccountsCount
        {
            get { return this._enabledAccountsCount; }
            set { this._enabledAccountsCount = value; }
        }

        // Check to see if EnabledAccountsCount property is set
        internal bool IsSetEnabledAccountsCount()
        {
            return this._enabledAccountsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Name of the feature.
        /// </para>
        /// </summary>
        public OrgFeature Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

    }
}