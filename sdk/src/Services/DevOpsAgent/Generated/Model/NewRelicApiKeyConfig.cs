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
 * Do not modify this file. This file is generated from the devops-agent-2026-01-01.normal.json service model.
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
namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// API key authentication configuration for New Relic service.
    /// </summary>
    public partial class NewRelicApiKeyConfig
    {
        private string _accountId;
        private List<string> _alertPolicyIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _apiKey;
        private List<string> _applicationIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _entityGuids = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private NewRelicRegion _region;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// New Relic Account ID
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property AlertPolicyIds. 
        /// <para>
        /// List of alert policy IDs grouping related conditions
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AlertPolicyIds
        {
            get { return this._alertPolicyIds; }
            set { this._alertPolicyIds = value; }
        }

        // Check to see if AlertPolicyIds property is set
        internal bool IsSetAlertPolicyIds()
        {
            return this._alertPolicyIds != null && (this._alertPolicyIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// New Relic User API Key
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1)]
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property ApplicationIds. 
        /// <para>
        /// List of monitored APM application IDs in New Relic
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ApplicationIds
        {
            get { return this._applicationIds; }
            set { this._applicationIds = value; }
        }

        // Check to see if ApplicationIds property is set
        internal bool IsSetApplicationIds()
        {
            return this._applicationIds != null && (this._applicationIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EntityGuids. 
        /// <para>
        /// List of globally unique IDs for New Relic resources (apps, hosts, services)
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EntityGuids
        {
            get { return this._entityGuids; }
            set { this._entityGuids = value; }
        }

        // Check to see if EntityGuids property is set
        internal bool IsSetEntityGuids()
        {
            return this._entityGuids != null && (this._entityGuids.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// New Relic region (US or EU)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public NewRelicRegion Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

    }
}