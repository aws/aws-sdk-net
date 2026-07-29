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
    /// The configuration for writing distribution results.
    /// </summary>
    public partial class DistributionResultsOptions
    {
        private CatalogTableConfigOptions _catalogTableConfig;
        private bool? _writeDistributionResultsEnabled;

        /// <summary>
        /// Gets and sets the property CatalogTableConfig. 
        /// <para>
        /// The Glue Data Catalog table configuration for storing the distribution results.
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
        /// Gets and sets the property WriteDistributionResultsEnabled. 
        /// <para>
        /// Set to true to write distribution results.
        /// </para>
        /// </summary>
        public bool? WriteDistributionResultsEnabled
        {
            get { return this._writeDistributionResultsEnabled; }
            set { this._writeDistributionResultsEnabled = value; }
        }

        // Check to see if WriteDistributionResultsEnabled property is set
        internal bool IsSetWriteDistributionResultsEnabled()
        {
            return this._writeDistributionResultsEnabled.HasValue; 
        }

    }
}