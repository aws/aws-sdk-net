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
    /// Container for the parameters to the CreateTable operation. Creates a new table definition
    /// in the Data Catalog.
    /// </summary>
    public partial class CreateTableRequest : AmazonGlueRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog in which to create the <c>Table</c>. If none is supplied,
        /// the Amazon Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The catalog database in which to create the new table. For Hive compatibility, this
        /// name is entirely lowercase.
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
        /// The unique identifier for the table within the specified database that will be created
        /// in the Glue Data Catalog.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OpenTableFormatInput. 
        /// <para>
        /// Specifies an <c>OpenTableFormatInput</c> structure when creating an open format table.
        /// </para>
        /// </summary>
        public OpenTableFormatInput OpenTableFormatInput { get; set; }

        /// <summary>
        /// Checks to see if the OpenTableFormatInput property is set.
        /// </summary>
        internal bool IsSetOpenTableFormatInput() => this.OpenTableFormatInput != null;

        /// <summary>
        /// Gets and sets the property PartitionIndexes. 
        /// <para>
        /// A list of partition indexes, <c>PartitionIndex</c> structures, to create in the table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PartitionIndex> PartitionIndexes { get; set; } = AWSConfigs.InitializeCollections ? new List<PartitionIndex>() : null;

        /// <summary>
        /// Checks to see if the PartitionIndexes property is set.
        /// </summary>
        internal bool IsSetPartitionIndexes() => this.PartitionIndexes != null && (this.PartitionIndexes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TableInput. 
        /// <para>
        /// The <c>TableInput</c> object that defines the metadata table to create in the catalog.
        /// </para>
        /// </summary>
        public TableInput TableInput { get; set; }

        /// <summary>
        /// Checks to see if the TableInput property is set.
        /// </summary>
        internal bool IsSetTableInput() => this.TableInput != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The ID of the transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
