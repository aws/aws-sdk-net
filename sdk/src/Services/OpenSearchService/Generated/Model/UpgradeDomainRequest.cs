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
    /// Container for the parameters to the UpgradeDomain operation.
    /// Allows you to either upgrade your Amazon OpenSearch Service domain or perform an upgrade
    /// eligibility check to a compatible version of OpenSearch or Elasticsearch.
    /// </summary>
    public partial class UpgradeDomainRequest : AmazonOpenSearchServiceRequest
    {
        private Dictionary<string, string> _advancedOptions = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _domainName;
        private bool? _performCheckOnly;
        private string _targetVersion;

        /// <summary>
        /// Gets and sets the property AdvancedOptions. 
        /// <para>
        /// Only supports the <c>override_main_response_version</c> parameter and not other advanced
        /// options. You can only include this option when upgrading to an OpenSearch version.
        /// Specifies whether the domain reports its version as 7.10 so that it continues to work
        /// with Elasticsearch OSS clients and plugins.
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
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Name of the OpenSearch Service domain that you want to upgrade.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=28)]
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
        /// When true, indicates that an upgrade eligibility check needs to be performed. Does
        /// not actually perform the upgrade.
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
        /// OpenSearch or Elasticsearch version to which you want to upgrade, in the format Opensearch_X.Y
        /// or Elasticsearch_X.Y.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=14, Max=18)]
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

    }
}