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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The configuration for writing profiling results.
    /// </summary>
    public partial class ProfilingResultsOptions
    {
        private CatalogTableConfigOptions _catalogTableConfig;
        private DistributionResultsOptions _distributionResults;
        private bool? _writeProfilingResultsEnabled;

        /// <summary>
        /// Gets and sets the property CatalogTableConfig. 
        /// <para>
        /// The Glue Data Catalog table configuration for storing the profiling results.
        /// </para>
        /// </summary>
        public CatalogTableConfigOptions CatalogTableConfig
        {
            get { return this._catalogTableConfig; }
            set { this._catalogTableConfig = value; }
        }

        // Check to see if CatalogTableConfig property is set
        internal bool IsSetCatalogTableConfig()
        {
            return this._catalogTableConfig != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionResults. 
        /// <para>
        /// The configuration for writing distribution results.
        /// </para>
        /// </summary>
        public DistributionResultsOptions DistributionResults
        {
            get { return this._distributionResults; }
            set { this._distributionResults = value; }
        }

        // Check to see if DistributionResults property is set
        internal bool IsSetDistributionResults()
        {
            return this._distributionResults != null;
        }

        /// <summary>
        /// Gets and sets the property WriteProfilingResultsEnabled. 
        /// <para>
        /// Set to true to write profiling results.
        /// </para>
        /// </summary>
        public bool? WriteProfilingResultsEnabled
        {
            get { return this._writeProfilingResultsEnabled; }
            set { this._writeProfilingResultsEnabled = value; }
        }

        // Check to see if WriteProfilingResultsEnabled property is set
        internal bool IsSetWriteProfilingResultsEnabled()
        {
            return this._writeProfilingResultsEnabled.HasValue; 
        }

    }
}