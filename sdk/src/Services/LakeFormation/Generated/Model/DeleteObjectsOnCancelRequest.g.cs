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
    /// Container for the parameters to the DeleteObjectsOnCancel operation. For a specific
    /// governed table, provides a list of Amazon S3 objects that will be written during the
    /// current transaction and that can be automatically deleted if the transaction is canceled.
    /// Without this call, no Amazon S3 objects are automatically deleted when a transaction
    /// cancels. <para> The Glue ETL library function <c>write_dynamic_frame.from_catalog()</c>
    /// includes an option to automatically call <c>DeleteObjectsOnCancel</c> before writes.
    /// For more information, see <a href="https://docs.aws.amazon.com/lake-formation/latest/dg/transactions-data-operations.html#rolling-back-writes">Rolling
    /// Back Amazon S3 Writes</a>. </para>
    /// </summary>
    public partial class DeleteObjectsOnCancelRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The Glue data catalog that contains the governed table. Defaults to the current account
        /// ID.
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
        /// The database that contains the governed table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property Objects. 
        /// <para>
        /// A list of VirtualObject structures, which indicates the Amazon S3 objects to be deleted
        /// if the transaction cancels.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public List<VirtualObject> Objects { get; set; } = AWSConfigs.InitializeCollections ? new List<VirtualObject>() : null;

        /// <summary>
        /// Checks to see if the Objects property is set.
        /// </summary>
        internal bool IsSetObjects() => this.Objects != null && (this.Objects.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the governed table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// ID of the transaction that the writes occur in.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
