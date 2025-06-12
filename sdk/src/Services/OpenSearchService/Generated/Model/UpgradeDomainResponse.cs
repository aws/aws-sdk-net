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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for the response returned by <c>UpgradeDomain</c> operation.
    /// </summary>
    public partial class UpgradeDomainResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _advancedOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private ChangeProgressDetails _changeProgressDetails;
        private string _domainName;
        private bool? _performCheckOnly;
        private string _targetVersion;
        private string _upgradeId;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// The advanced options configuration for the domain.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null && (this._advancedOptions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ChangeProgressDetails. 
        /// <para>
        /// Container for information about a configuration change happening on a domain.
        /// </para>
        /// </summary>
        public ChangeProgressDetails ChangeProgressDetails
        {
            get { return this._changeProgressDetails; }
            set { this._changeProgressDetails = value; }
        }

        // Check to see if ChangeProgressDetails property is set
        internal bool IsSetChangeProgressDetails()
        {
            return this._changeProgressDetails != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that was upgraded.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=28)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property PerformCheckOnly. 
        /// <para>
        /// When true, indicates that an upgrade eligibility check was performed.
        /// </para>
        /// </summary>
        public bool? PerformCheckOnly
        {
            get { return this._performCheckOnly; }
            set { this._performCheckOnly = value; }
        }

        // Check to see if PerformCheckOnly property is set
        internal bool IsSetPerformCheckOnly()
        {
            return this._performCheckOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetVersion. 
        /// <para>
        /// OpenSearch or Elasticsearch version that the domain was upgraded to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=14, Max=18)]
        public string TargetVersion
        {
            get { return this._targetVersion; }
            set { this._targetVersion = value; }
        }

        // Check to see if TargetVersion property is set
        internal bool IsSetTargetVersion()
        {
            return this._targetVersion != null;
        }

        /// <summary>
        /// Gets and sets the property UpgradeId. 
        /// <para>
        /// The unique identifier of the domain upgrade.
        /// </para>
        /// </summary>
        public string UpgradeId
        {
            get { return this._upgradeId; }
            set { this._upgradeId = value; }
        }

        // Check to see if UpgradeId property is set
        internal bool IsSetUpgradeId()
        {
            return this._upgradeId != null;
        }

    }
}