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
    /// A structure for a table with columns object. This object is only used when granting
    /// a SELECT permission.
    /// 
    ///  
    /// <para>
    /// This object must take a value for at least one of <c>ColumnsNames</c>, <c>ColumnsIndexes</c>,
    /// or <c>ColumnsWildcard</c>.
    /// </para>
    /// </summary>
    public partial class TableWithColumnsResource
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The identifier for the Data Catalog. By default, it is the account ID of the caller.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property ColumnNames. 
        /// <para>
        /// The list of column names for the table. At least one of <c>ColumnNames</c> or <c>ColumnWildcard</c>
        /// is required.
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
        /// A wildcard specified by a <c>ColumnWildcard</c> object. At least one of <c>ColumnNames</c>
        /// or <c>ColumnWildcard</c> is required.
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
        /// The name of the database for the table with columns resource. Unique to the Data Catalog.
        /// A database is a set of associated table definitions organized into a logical group.
        /// You can Grant and Revoke database privileges to a principal. 
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
        /// The name of the table resource. A table is a metadata definition that represents your
        /// data. You can Grant and Revoke table privileges to a principal. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;
    }
}
