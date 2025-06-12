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
    /// Container for the parameters to the BatchDeleteTable operation.
    /// Deletes multiple tables at once.
    /// 
    ///  <note> 
    /// <para>
    /// After completing this operation, you no longer have access to the table versions and
    /// partitions that belong to the deleted table. Glue deletes these "orphaned" resources
    /// asynchronously in a timely manner, at the discretion of the service.
    /// </para>
    ///  
    /// <para>
    /// To ensure the immediate deletion of all related resources, before calling <c>BatchDeleteTable</c>,
    /// use <c>DeleteTableVersion</c> or <c>BatchDeleteTableVersion</c>, and <c>DeletePartition</c>
    /// or <c>BatchDeletePartition</c>, to delete any resources that belong to the table.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class BatchDeleteTableRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private List<string> _tablesToDelete = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the table resides. If none is provided, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The name of the catalog database in which the tables to delete reside. For Hive compatibility,
        /// this name is entirely lowercase.
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
        /// Gets and sets the property TablesToDelete. 
        /// <para>
        /// A list of the table to delete.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> TablesToDelete
        {
            get { return this._tablesToDelete; }
            set { this._tablesToDelete = value; }
        }

        // Check to see if TablesToDelete property is set
        internal bool IsSetTablesToDelete()
        {
            return this._tablesToDelete != null && (this._tablesToDelete.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to delete the table contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}