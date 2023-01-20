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
    /// Container for the parameters to the DescribeDryRunProgress operation.
    /// Describes the progress of a pre-update dry run analysis on an Amazon OpenSearch Service
    /// domain. For more information, see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/managedomains-configuration-changes#dryrun">Determining
    /// whether a change will cause a blue/green deployment</a>.
    /// </summary>
    public partial class DescribeDryRunProgressRequest : AmazonOpenSearchServiceRequest
    {
        private string _domainName;
        private string _dryRunId;
        private bool? _loadDryRunConfig;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain.
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
        /// Gets and sets the property DryRunId. 
        /// <para>
        /// The unique identifier of the dry run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
        public string DryRunId
        {
            get { return this._dryRunId; }
            set { this._dryRunId = value; }
        }

        // Check to see if DryRunId property is set
        internal bool IsSetDryRunId()
        {
            return this._dryRunId != null;
        }

        /// <summary>
        /// Gets and sets the property LoadDryRunConfig. 
        /// <para>
        /// Whether to include the configuration of the dry run in the response. The configuration
        /// specifies the updates that you're planning to make on the domain.
        /// </para>
        /// </summary>
        public bool LoadDryRunConfig
        {
            get { return this._loadDryRunConfig.GetValueOrDefault(); }
            set { this._loadDryRunConfig = value; }
        }

        // Check to see if LoadDryRunConfig property is set
        internal bool IsSetLoadDryRunConfig()
        {
            return this._loadDryRunConfig.HasValue; 
        }

    }
}