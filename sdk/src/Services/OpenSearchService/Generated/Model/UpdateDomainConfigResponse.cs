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
    /// The results of an <code>UpdateDomain</code> request. Contains the status of the domain
    /// being updated.
    /// </summary>
    public partial class UpdateDomainConfigResponse : AmazonWebServiceResponse
    {
        private DomainConfig _domainConfig;
        private DryRunProgressStatus _dryRunProgressStatus;
        private DryRunResults _dryRunResults;

        /// <summary>
        /// Gets and sets the property DomainConfig. 
        /// <para>
        /// The status of the updated domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DomainConfig DomainConfig
        {
            get { return this._domainConfig; }
            set { this._domainConfig = value; }
        }

        // Check to see if DomainConfig property is set
        internal bool IsSetDomainConfig()
        {
            return this._domainConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DryRunProgressStatus. 
        /// <para>
        /// The status of the dry run being performed on the domain, if any.
        /// </para>
        /// </summary>
        public DryRunProgressStatus DryRunProgressStatus
        {
            get { return this._dryRunProgressStatus; }
            set { this._dryRunProgressStatus = value; }
        }

        // Check to see if DryRunProgressStatus property is set
        internal bool IsSetDryRunProgressStatus()
        {
            return this._dryRunProgressStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DryRunResults. 
        /// <para>
        /// Results of the dry run performed in the update domain request.
        /// </para>
        /// </summary>
        public DryRunResults DryRunResults
        {
            get { return this._dryRunResults; }
            set { this._dryRunResults = value; }
        }

        // Check to see if DryRunResults property is set
        internal bool IsSetDryRunResults()
        {
            return this._dryRunResults != null;
        }

    }
}