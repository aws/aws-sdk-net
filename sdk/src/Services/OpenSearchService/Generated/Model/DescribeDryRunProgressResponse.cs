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
    /// This is the response object from the DescribeDryRunProgress operation.
    /// </summary>
    public partial class DescribeDryRunProgressResponse : AmazonWebServiceResponse
    {
        private DomainStatus _dryRunConfig;
        private DryRunProgressStatus _dryRunProgressStatus;
        private DryRunResults _dryRunResults;

        /// <summary>
        /// Gets and sets the property DryRunConfig. 
        /// <para>
        /// Details about the changes you're planning to make on the domain.
        /// </para>
        /// </summary>
        public DomainStatus DryRunConfig
        {
            get { return this._dryRunConfig; }
            set { this._dryRunConfig = value; }
        }

        // Check to see if DryRunConfig property is set
        internal bool IsSetDryRunConfig()
        {
            return this._dryRunConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DryRunProgressStatus. 
        /// <para>
        /// The current status of the dry run, including any validation errors.
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
        /// The results of the dry run. 
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