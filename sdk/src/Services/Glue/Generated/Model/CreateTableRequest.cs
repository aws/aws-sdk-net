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
    /// Container for the parameters to the CreateTable operation.
    /// Creates a new table definition in the Data Catalog.
    /// </summary>
    public partial class CreateTableRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private string _name;
        private OpenTableFormatInput _openTableFormatInput;
        private List<PartitionIndex> _partitionIndexes = AWSConfigs.InitializeCollections ? new List<PartitionIndex>() : null;
        private TableInput _tableInput;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which to create the <c>Table</c>. If none is supplied,
        /// the Amazon Web Services account ID is used by default.
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
        /// The catalog database in which to create the new table. For Hive compatibility, this
        /// name is entirely lowercase.
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
        /// The unique identifier for the table within the specified database that will be created
        /// in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property OpenTableFormatInput. 
        /// <para>
        /// Specifies an <c>OpenTableFormatInput</c> structure when creating an open format table.
        /// </para>
        /// </summary>
        public OpenTableFormatInput OpenTableFormatInput
        {
            get { return this._openTableFormatInput; }
            set { this._openTableFormatInput = value; }
        }

        // Check to see if OpenTableFormatInput property is set
        internal bool IsSetOpenTableFormatInput()
        {
            return this._openTableFormatInput != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionIndexes. 
        /// <para>
        /// A list of partition indexes, <c>PartitionIndex</c> structures, to create in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=3)]
        public List<PartitionIndex> PartitionIndexes
        {
            get { return this._partitionIndexes; }
            set { this._partitionIndexes = value; }
        }

        // Check to see if PartitionIndexes property is set
        internal bool IsSetPartitionIndexes()
        {
            return this._partitionIndexes != null && (this._partitionIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableInput. 
        /// <para>
        /// The <c>TableInput</c> object that defines the metadata table to create in the catalog.
        /// </para>
        /// </summary>
        public TableInput TableInput
        {
            get { return this._tableInput; }
            set { this._tableInput = value; }
        }

        // Check to see if TableInput property is set
        internal bool IsSetTableInput()
        {
            return this._tableInput != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The ID of the transaction.
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