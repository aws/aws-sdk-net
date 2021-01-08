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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information abut a global secondary index for the table.
    /// </summary>
    public partial class AwsDynamoDbTableGlobalSecondaryIndex
    {
        private bool? _backfilling;
        private string _indexArn;
        private string _indexName;
        private long? _indexSizeBytes;
        private string _indexStatus;
        private int? _itemCount;
        private List<AwsDynamoDbTableKeySchema> _keySchema = new List<AwsDynamoDbTableKeySchema>();
        private AwsDynamoDbTableProjection _projection;
        private AwsDynamoDbTableProvisionedThroughput _provisionedThroughput;

        /// <summary>
        /// Gets and sets the property Backfilling. 
        /// <para>
        /// Whether the index is currently backfilling.
        /// </para>
        /// </summary>
        public bool Backfilling
        {
            get { return this._backfilling.GetValueOrDefault(); }
            set { this._backfilling = value; }
        }

        // Check to see if Backfilling property is set
        internal bool IsSetBackfilling()
        {
            return this._backfilling.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexArn. 
        /// <para>
        /// The ARN of the index.
        /// </para>
        /// </summary>
        public string IndexArn
        {
            get { return this._indexArn; }
            set { this._indexArn = value; }
        }

        // Check to see if IndexArn property is set
        internal bool IsSetIndexArn()
        {
            return this._indexArn != null;
        }

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the index.
        /// </para>
        /// </summary>
        public string IndexName
        {
            get { return this._indexName; }
            set { this._indexName = value; }
        }

        // Check to see if IndexName property is set
        internal bool IsSetIndexName()
        {
            return this._indexName != null;
        }

        /// <summary>
        /// Gets and sets the property IndexSizeBytes. 
        /// <para>
        /// The total size in bytes of the index.
        /// </para>
        /// </summary>
        public long IndexSizeBytes
        {
            get { return this._indexSizeBytes.GetValueOrDefault(); }
            set { this._indexSizeBytes = value; }
        }

        // Check to see if IndexSizeBytes property is set
        internal bool IsSetIndexSizeBytes()
        {
            return this._indexSizeBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IndexStatus. 
        /// <para>
        /// The current status of the index.
        /// </para>
        /// </summary>
        public string IndexStatus
        {
            get { return this._indexStatus; }
            set { this._indexStatus = value; }
        }

        // Check to see if IndexStatus property is set
        internal bool IsSetIndexStatus()
        {
            return this._indexStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ItemCount. 
        /// <para>
        /// The number of items in the index.
        /// </para>
        /// </summary>
        public int ItemCount
        {
            get { return this._itemCount.GetValueOrDefault(); }
            set { this._itemCount = value; }
        }

        // Check to see if ItemCount property is set
        internal bool IsSetItemCount()
        {
            return this._itemCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The key schema for the index.
        /// </para>
        /// </summary>
        public List<AwsDynamoDbTableKeySchema> KeySchema
        {
            get { return this._keySchema; }
            set { this._keySchema = value; }
        }

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this._keySchema != null && this._keySchema.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Attributes that are copied from the table into an index.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProjection Projection
        {
            get { return this._projection; }
            set { this._projection = value; }
        }

        // Check to see if Projection property is set
        internal bool IsSetProjection()
        {
            return this._projection != null;
        }

        /// <summary>
        /// Gets and sets the property ProvisionedThroughput. 
        /// <para>
        /// Information about the provisioned throughput settings for the indexes.
        /// </para>
        /// </summary>
        public AwsDynamoDbTableProvisionedThroughput ProvisionedThroughput
        {
            get { return this._provisionedThroughput; }
            set { this._provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this._provisionedThroughput != null;
        }

    }
}