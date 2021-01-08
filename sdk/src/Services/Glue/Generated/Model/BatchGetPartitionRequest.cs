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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetPartition operation.
    /// Retrieves partitions in a batch request.
    /// </summary>
    public partial class BatchGetPartitionRequest : AmazonGlueRequest
    {
        private string _catalogId;
        private string _databaseName;
        private List<PartitionValueList> _partitionsToGet = new List<PartitionValueList>();
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the partitions in question reside. If none is supplied,
        /// the AWS account ID is used by default.
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
        /// The name of the catalog database where the partitions reside.
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
        /// Gets and sets the property PartitionsToGet. 
        /// <para>
        /// A list of partition values identifying the partitions to retrieve.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1000)]
        public List<PartitionValueList> PartitionsToGet
        {
            get { return this._partitionsToGet; }
            set { this._partitionsToGet = value; }
        }

        // Check to see if PartitionsToGet property is set
        internal bool IsSetPartitionsToGet()
        {
            return this._partitionsToGet != null && this._partitionsToGet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the partitions' table.
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