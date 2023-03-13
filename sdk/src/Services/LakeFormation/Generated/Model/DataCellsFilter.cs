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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure that describes certain columns on certain rows.
    /// </summary>
    public partial class DataCellsFilter
    {
        private List<string> _columnNames = new List<string>();
        private ColumnWildcard _columnWildcard;
        private string _databaseName;
        private string _name;
        private RowFilter _rowFilter;
        private string _tableCatalogId;
        private string _tableName;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property ColumnNames. 
        /// <para>
        /// A list of column names.
        /// </para>
        /// </summary>
        public List<string> ColumnNames
        {
            get { return this._columnNames; }
            set { this._columnNames = value; }
        }

        // Check to see if ColumnNames property is set
        internal bool IsSetColumnNames()
        {
            return this._columnNames != null && this._columnNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ColumnWildcard. 
        /// <para>
        /// A wildcard with exclusions.
        /// </para>
        ///  
        /// <para>
        /// You must specify either a <code>ColumnNames</code> list or the <code>ColumnWildCard</code>.
        /// 
        /// </para>
        /// </summary>
        public ColumnWildcard ColumnWildcard
        {
            get { return this._columnWildcard; }
            set { this._columnWildcard = value; }
        }

        // Check to see if ColumnWildcard property is set
        internal bool IsSetColumnWildcard()
        {
            return this._columnWildcard != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// A database in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name given by the user to the data filter cell.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RowFilter. 
        /// <para>
        /// A PartiQL predicate.
        /// </para>
        /// </summary>
        public RowFilter RowFilter
        {
            get { return this._rowFilter; }
            set { this._rowFilter = value; }
        }

        // Check to see if RowFilter property is set
        internal bool IsSetRowFilter()
        {
            return this._rowFilter != null;
        }

        /// <summary>
        /// Gets and sets the property TableCatalogId. 
        /// <para>
        /// The ID of the catalog to which the table belongs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableCatalogId
        {
            get { return this._tableCatalogId; }
            set { this._tableCatalogId = value; }
        }

        // Check to see if TableCatalogId property is set
        internal bool IsSetTableCatalogId()
        {
            return this._tableCatalogId != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// A table in the database.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// The ID of the data cells filter version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}