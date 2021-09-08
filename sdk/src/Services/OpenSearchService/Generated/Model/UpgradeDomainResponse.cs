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

namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// Container for response returned by <code> <a>UpgradeDomain</a> </code> operation.
    /// </summary>
    public partial class UpgradeDomainResponse : AmazonWebServiceResponse
    {
        private Dictionary<string, string> _advancedOptions = new Dictionary<string, string>();
        private string _domainName;
        private bool? _performCheckOnly;
        private string _targetVersion;
        private string _upgradeId;

        /// <summary>
        /// Gets and sets the property AdvancedOptions.
        /// </summary>
        public Dictionary<string, string> AdvancedOptions
        {
            get { return this._advancedOptions; }
            set { this._advancedOptions = value; }
        }

        // Check to see if AdvancedOptions property is set
        internal bool IsSetAdvancedOptions()
        {
            return this._advancedOptions != null && this._advancedOptions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DomainName.
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
        ///  When true, indicates that an upgrade eligibility check needs to be performed. Does
        /// not actually perform the upgrade. 
        /// </para>
        /// </summary>
        public bool PerformCheckOnly
        {
            get { return this._performCheckOnly.GetValueOrDefault(); }
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
        /// The version of OpenSearch that you intend to upgrade the domain to.
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