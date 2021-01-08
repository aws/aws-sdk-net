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
 * Do not modify this file. This file is generated from the es-2015-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Elasticsearch.Model
{
    /// <summary>
    /// Container for the parameters to the UpgradeElasticsearchDomain operation.
    /// Allows you to either upgrade your domain or perform an Upgrade eligibility check to
    /// a compatible Elasticsearch version.
    /// </summary>
    public partial class UpgradeElasticsearchDomainRequest : AmazonElasticsearchRequest
    {
        private string _domainName;
        private bool? _performCheckOnly;
        private string _targetVersion;

        /// <summary>
        /// Gets and sets the property DomainName.
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
        ///  This flag, when set to True, indicates that an Upgrade Eligibility Check needs to
        /// be performed. This will not actually perform the Upgrade. 
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
        /// The version of Elasticsearch that you intend to upgrade the domain to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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