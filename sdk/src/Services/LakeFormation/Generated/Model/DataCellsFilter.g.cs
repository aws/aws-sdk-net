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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure that describes certain columns on certain rows.
    /// </summary>
    public partial class DataCellsFilter
    {
        /// <summary>
        /// Gets and sets the property ColumnNames. 
        /// <para>
        /// A list of column names and/or nested column attributes. When specifying nested attributes,
        /// use a qualified dot (.) delimited format such as "address"."zip". Nested attributes
        /// within this list may not exceed a depth of 5.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ColumnNames { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ColumnNames property is set.
        /// </summary>
        internal bool IsSetColumnNames() => this.ColumnNames != null && (this.ColumnNames.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ColumnWildcard. 
        /// <para>
        /// A wildcard with exclusions.
        /// </para>
        ///  
        /// <para>
        /// You must specify either a <c>ColumnNames</c> list or the <c>ColumnWildCard</c>. 
        /// </para>
        /// </summary>
        public ColumnWildcard ColumnWildcard { get; set; }

        /// <summary>
        /// Checks to see if the ColumnWildcard property is set.
        /// </summary>
        internal bool IsSetColumnWildcard() => this.ColumnWildcard != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// A database in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name given by the user to the data filter cell.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RowFilter. 
        /// <para>
        /// A PartiQL predicate.
        /// </para>
        /// </summary>
        public RowFilter RowFilter { get; set; }

        /// <summary>
        /// Checks to see if the RowFilter property is set.
        /// </summary>
        internal bool IsSetRowFilter() => this.RowFilter != null;

        /// <summary>
        /// Gets and sets the property TableCatalogId. 
        /// <para>
        /// The ID of the catalog to which the table belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableCatalogId { get; set; }

        /// <summary>
        /// Checks to see if the TableCatalogId property is set.
        /// </summary>
        internal bool IsSetTableCatalogId() => this.TableCatalogId != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// A table in the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the data cells filter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string VersionId { get; set; }

        /// <summary>
        /// Checks to see if the VersionId property is set.
        /// </summary>
        internal bool IsSetVersionId() => this.VersionId != null;
    }
}
