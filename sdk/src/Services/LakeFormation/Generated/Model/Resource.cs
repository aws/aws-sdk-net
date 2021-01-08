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
    /// A structure for the resource.
    /// </summary>
    public partial class Resource
    {
        private CatalogResource _catalog;
        private DatabaseResource _database;
        private DataLocationResource _dataLocation;
        private TableResource _table;
        private TableWithColumnsResource _tableWithColumns;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your AWS Lake Formation environment. 
        /// </para>
        /// </summary>
        public CatalogResource Catalog
        {
            get { return this._catalog; }
            set { this._catalog = value; }
        }

        // Check to see if Catalog property is set
        internal bool IsSetCatalog()
        {
            return this._catalog != null;
        }

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database for the resource. Unique to the Data Catalog. A database is a set of
        /// associated table definitions organized into a logical group. You can Grant and Revoke
        /// database permissions to a principal. 
        /// </para>
        /// </summary>
        public DatabaseResource Database
        {
            get { return this._database; }
            set { this._database = value; }
        }

        // Check to see if Database property is set
        internal bool IsSetDatabase()
        {
            return this._database != null;
        }

        /// <summary>
        /// Gets and sets the property DataLocation. 
        /// <para>
        /// The location of an Amazon S3 path where permissions are granted or revoked. 
        /// </para>
        /// </summary>
        public DataLocationResource DataLocation
        {
            get { return this._dataLocation; }
            set { this._dataLocation = value; }
        }

        // Check to see if DataLocation property is set
        internal bool IsSetDataLocation()
        {
            return this._dataLocation != null;
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The table for the resource. A table is a metadata definition that represents your
        /// data. You can Grant and Revoke table privileges to a principal. 
        /// </para>
        /// </summary>
        public TableResource Table
        {
            get { return this._table; }
            set { this._table = value; }
        }

        // Check to see if Table property is set
        internal bool IsSetTable()
        {
            return this._table != null;
        }

        /// <summary>
        /// Gets and sets the property TableWithColumns. 
        /// <para>
        /// The table with columns for the resource. A principal with permissions to this resource
        /// can select metadata from the columns of a table in the Data Catalog and the underlying
        /// data in Amazon S3.
        /// </para>
        /// </summary>
        public TableWithColumnsResource TableWithColumns
        {
            get { return this._tableWithColumns; }
            set { this._tableWithColumns = value; }
        }

        // Check to see if TableWithColumns property is set
        internal bool IsSetTableWithColumns()
        {
            return this._tableWithColumns != null;
        }

    }
}