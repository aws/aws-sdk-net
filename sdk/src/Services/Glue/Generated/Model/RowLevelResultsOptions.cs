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
    /// The configuration for writing row-level evaluation results.
    /// </summary>
    public partial class RowLevelResultsOptions
    {
        private CatalogTableConfigOptions _catalogTableConfig;
        private int? _maxRowsToWrite;
        private ResultTypeEnum _resultType;

        /// <summary>
        /// Gets and sets the property CatalogTableConfig. 
        /// <para>
        /// The Glue Data Catalog table configuration for storing the results.
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
        /// Gets and sets the property MaxRowsToWrite. 
        /// <para>
        /// The maximum number of rows to write in the results.
        /// </para>
        /// </summary>
        public int? MaxRowsToWrite
        {
            get { return this._maxRowsToWrite; }
            set { this._maxRowsToWrite = value; }
        }

        // Check to see if MaxRowsToWrite property is set
        internal bool IsSetMaxRowsToWrite()
        {
            return this._maxRowsToWrite.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ResultType. 
        /// <para>
        /// The result type to include in the row-level results output.
        /// </para>
        /// </summary>
        public ResultTypeEnum ResultType
        {
            get { return this._resultType; }
            set { this._resultType = value; }
        }

        // Check to see if ResultType property is set
        internal bool IsSetResultType()
        {
            return this._resultType != null;
        }

    }
}