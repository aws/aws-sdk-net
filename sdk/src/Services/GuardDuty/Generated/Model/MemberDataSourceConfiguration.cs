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
    /// Contains information on which data sources are enabled for a member account.
    /// </summary>
    public partial class MemberDataSourceConfiguration
    {
        private string _accountId;
        private DataSourceConfigurationsResult _dataSources;
        private List<MemberFeaturesConfigurationResult> _features = AWSConfigs.InitializeCollections ? new List<MemberFeaturesConfigurationResult>() : null;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The account ID for the member account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Contains information on the status of data sources for the account.
        /// </para>
        /// </summary>
        [Obsolete("This parameter is deprecated, use Features instead")]
        public DataSourceConfigurationsResult DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null;
        }

        /// <summary>
        /// Gets and sets the property Features. 
        /// <para>
        /// Contains information about the status of the features for the member account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<MemberFeaturesConfigurationResult> Features
        {
            get { return this._features; }
            set { this._features = value; }
        }

        // Check to see if Features property is set
        internal bool IsSetFeatures()
        {
            return this._features != null && (this._features.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}