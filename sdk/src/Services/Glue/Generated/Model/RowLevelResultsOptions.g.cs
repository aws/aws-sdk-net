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
    /// The configuration for writing row-level evaluation results.
    /// </summary>
    public partial class RowLevelResultsOptions
    {
        /// <summary>
        /// Gets and sets the property CatalogTableConfig. 
        /// <para>
        /// The Glue Data Catalog table configuration for storing the results.
        /// </para>
        /// </summary>
        public CatalogTableConfigOptions CatalogTableConfig { get; set; }

        /// <summary>
        /// Checks to see if the CatalogTableConfig property is set.
        /// </summary>
        internal bool IsSetCatalogTableConfig() => this.CatalogTableConfig != null;

        /// <summary>
        /// Gets and sets the property MaxRowsToWrite. 
        /// <para>
        /// The maximum number of rows to write in the results.
        /// </para>
        /// </summary>
        public int? MaxRowsToWrite { get; set; }

        /// <summary>
        /// Checks to see if the MaxRowsToWrite property is set.
        /// </summary>
        internal bool IsSetMaxRowsToWrite() => this.MaxRowsToWrite.HasValue;

        /// <summary>
        /// Gets and sets the property ResultType. 
        /// <para>
        /// The result type to include in the row-level results output.
        /// </para>
        /// </summary>
        public ResultTypeEnum ResultType { get; set; }

        /// <summary>
        /// Checks to see if the ResultType property is set.
        /// </summary>
        internal bool IsSetResultType() => this.ResultType != null;
    }
}
