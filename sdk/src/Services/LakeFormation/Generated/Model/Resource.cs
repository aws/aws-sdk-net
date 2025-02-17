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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// A structure for the resource.
    /// </summary>
    public partial class Resource
    {
        private CatalogResource _catalog;
        private DatabaseResource _database;
        private DataCellsFilterResource _dataCellsFilter;
        private DataLocationResource _dataLocation;
        private LFTagKeyResource _lfTag;
        private LFTagExpressionResource _lfTagExpression;
        private LFTagPolicyResource _lfTagPolicy;
        private TableResource _table;
        private TableWithColumnsResource _tableWithColumns;

        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
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
        /// Gets and sets the property DataCellsFilter. 
        /// <para>
        /// A data cell filter.
        /// </para>
        /// </summary>
        public DataCellsFilterResource DataCellsFilter
        {
            get { return this._dataCellsFilter; }
            set { this._dataCellsFilter = value; }
        }

        // Check to see if DataCellsFilter property is set
        internal bool IsSetDataCellsFilter()
        {
            return this._dataCellsFilter != null;
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
        /// Gets and sets the property LFTag. 
        /// <para>
        /// The LF-tag key and values attached to a resource.
        /// </para>
        /// </summary>
        public LFTagKeyResource LFTag
        {
            get { return this._lfTag; }
            set { this._lfTag = value; }
        }

        // Check to see if LFTag property is set
        internal bool IsSetLFTag()
        {
            return this._lfTag != null;
        }

        /// <summary>
        /// Gets and sets the property LFTagExpression. 
        /// <para>
        /// LF-Tag expression resource. A logical expression composed of one or more LF-Tag key:value
        /// pairs.
        /// </para>
        /// </summary>
        public LFTagExpressionResource LFTagExpression
        {
            get { return this._lfTagExpression; }
            set { this._lfTagExpression = value; }
        }

        // Check to see if LFTagExpression property is set
        internal bool IsSetLFTagExpression()
        {
            return this._lfTagExpression != null;
        }

        /// <summary>
        /// Gets and sets the property LFTagPolicy. 
        /// <para>
        /// A list of LF-tag conditions or saved LF-Tag expressions that define a resource's LF-tag
        /// policy.
        /// </para>
        /// </summary>
        public LFTagPolicyResource LFTagPolicy
        {
            get { return this._lfTagPolicy; }
            set { this._lfTagPolicy = value; }
        }

        // Check to see if LFTagPolicy property is set
        internal bool IsSetLFTagPolicy()
        {
            return this._lfTagPolicy != null;
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