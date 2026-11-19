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
    /// Identifies the Glue Data Catalog tables that a data quality evaluation configuration
    /// applies to.
    /// </summary>
    public partial class DataQualityEvaluationConfigListGlueTables
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// A unique identifier for the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// A database name in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property TableNamePattern. 
        /// <para>
        /// For the <c>CATALOG</c> and <c>DATABASE</c> levels, a glob pattern, such as <c>orders_*</c>,
        /// that selects tables. If you don't specify a pattern, every table at the level is in
        /// scope. For the <c>TABLE</c> level, the name of the table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TableNamePattern { get; set; }

        /// <summary>
        /// Checks to see if the TableNamePattern property is set.
        /// </summary>
        internal bool IsSetTableNamePattern() => this.TableNamePattern != null;
    }
}
