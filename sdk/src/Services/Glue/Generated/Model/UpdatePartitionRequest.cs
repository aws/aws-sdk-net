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
    /// Container for the parameters to the UpdatePartition operation.
    /// Updates a partition.
    /// </summary>
    public partial class UpdatePartitionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private PartitionInput _partitionInput;
        private List<string> _partitionValueList = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partition to be updated resides. If none is provided,
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
        /// The name of the catalog database in which the table in question resides.
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
        /// Gets and sets the property PartitionInput. 
        /// <para>
        /// The new partition object to update the partition to.
        /// </para>
        ///  
        /// <para>
        /// The <c>Values</c> property can't be changed. If you want to change the partition key
        /// values for a partition, delete and recreate the partition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PartitionInput PartitionInput
        {
            get { return this._partitionInput; }
            set { this._partitionInput = value; }
        }

        // Check to see if PartitionInput property is set
        internal bool IsSetPartitionInput()
        {
            return this._partitionInput != null;
        }

        /// <summary>
        /// Gets and sets the property PartitionValueList. 
        /// <para>
        /// List of partition key values that define the partition to update.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<string> PartitionValueList
        {
            get { return this._partitionValueList; }
            set { this._partitionValueList = value; }
        }

        // Check to see if PartitionValueList property is set
        internal bool IsSetPartitionValueList()
        {
            return this._partitionValueList != null && (this._partitionValueList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table in which the partition to be updated is located.
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

    }
}