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
    /// A structure for the resource.
    /// </summary>
    public partial class Resource
    {
        /// <summary>
        /// Gets and sets the property Catalog. 
        /// <para>
        /// The identifier for the Data Catalog. By default, the account ID. The Data Catalog
        /// is the persistent metadata store. It contains database definitions, table definitions,
        /// and other control information to manage your Lake Formation environment. 
        /// </para>
        /// </summary>
        public CatalogResource Catalog { get; set; }

        /// <summary>
        /// Checks to see if the Catalog property is set.
        /// </summary>
        internal bool IsSetCatalog() => this.Catalog != null;

        /// <summary>
        /// Gets and sets the property DataCellsFilter. 
        /// <para>
        /// A data cell filter.
        /// </para>
        /// </summary>
        public DataCellsFilterResource DataCellsFilter { get; set; }

        /// <summary>
        /// Checks to see if the DataCellsFilter property is set.
        /// </summary>
        internal bool IsSetDataCellsFilter() => this.DataCellsFilter != null;

        /// <summary>
        /// Gets and sets the property DataLocation. 
        /// <para>
        /// The location of an Amazon S3 path where permissions are granted or revoked. 
        /// </para>
        /// </summary>
        public DataLocationResource DataLocation { get; set; }

        /// <summary>
        /// Checks to see if the DataLocation property is set.
        /// </summary>
        internal bool IsSetDataLocation() => this.DataLocation != null;

        /// <summary>
        /// Gets and sets the property Database. 
        /// <para>
        /// The database for the resource. Unique to the Data Catalog. A database is a set of
        /// associated table definitions organized into a logical group. You can Grant and Revoke
        /// database permissions to a principal. 
        /// </para>
        /// </summary>
        public DatabaseResource Database { get; set; }

        /// <summary>
        /// Checks to see if the Database property is set.
        /// </summary>
        internal bool IsSetDatabase() => this.Database != null;

        /// <summary>
        /// Gets and sets the property LFTag. 
        /// <para>
        /// The LF-Tag key and values attached to a resource.
        /// </para>
        /// </summary>
        public LFTagKeyResource LFTag { get; set; }

        /// <summary>
        /// Checks to see if the LFTag property is set.
        /// </summary>
        internal bool IsSetLFTag() => this.LFTag != null;

        /// <summary>
        /// Gets and sets the property LFTagExpression. 
        /// <para>
        /// LF-Tag expression resource. A logical expression composed of one or more LF-Tag key:value
        /// pairs.
        /// </para>
        /// </summary>
        public LFTagExpressionResource LFTagExpression { get; set; }

        /// <summary>
        /// Checks to see if the LFTagExpression property is set.
        /// </summary>
        internal bool IsSetLFTagExpression() => this.LFTagExpression != null;

        /// <summary>
        /// Gets and sets the property LFTagPolicy. 
        /// <para>
        /// A list of LF-tag conditions or saved LF-Tag expressions that define a resource's LF-tag
        /// policy.
        /// </para>
        /// </summary>
        public LFTagPolicyResource LFTagPolicy { get; set; }

        /// <summary>
        /// Checks to see if the LFTagPolicy property is set.
        /// </summary>
        internal bool IsSetLFTagPolicy() => this.LFTagPolicy != null;

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The table for the resource. A table is a metadata definition that represents your
        /// data. You can Grant and Revoke table privileges to a principal. 
        /// </para>
        /// </summary>
        public TableResource Table { get; set; }

        /// <summary>
        /// Checks to see if the Table property is set.
        /// </summary>
        internal bool IsSetTable() => this.Table != null;

        /// <summary>
        /// Gets and sets the property TableWithColumns. 
        /// <para>
        /// The table with columns for the resource. A principal with permissions to this resource
        /// can select metadata from the columns of a table in the Data Catalog and the underlying
        /// data in Amazon S3.
        /// </para>
        /// </summary>
        public TableWithColumnsResource TableWithColumns { get; set; }

        /// <summary>
        /// Checks to see if the TableWithColumns property is set.
        /// </summary>
        internal bool IsSetTableWithColumns() => this.TableWithColumns != null;
    }
}
