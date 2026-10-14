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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CatalogTableConfig. 
        /// <para>
        /// The Glue Data Catalog table configuration for storing the distribution results.
        /// </para>
        /// </summary>
        public CatalogTableConfigOptions CatalogTableConfig { get; set; }

        /// <summary>
        /// Checks to see if the CatalogTableConfig property is set.
        /// </summary>
        internal bool IsSetCatalogTableConfig() => this.CatalogTableConfig != null;

        /// <summary>
        /// Gets and sets the property WriteDistributionResultsEnabled. 
        /// <para>
        /// Set to true to write distribution results.
        /// </para>
        /// </summary>
        public bool? WriteDistributionResultsEnabled { get; set; }

        /// <summary>
        /// Checks to see if the WriteDistributionResultsEnabled property is set.
        /// </summary>
        internal bool IsSetWriteDistributionResultsEnabled() => this.WriteDistributionResultsEnabled.HasValue;
    }
}
