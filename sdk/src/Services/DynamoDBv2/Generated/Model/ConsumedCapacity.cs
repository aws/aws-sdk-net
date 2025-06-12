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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// The capacity units consumed by an operation. The data returned includes the total
    /// provisioned throughput consumed, along with statistics for the table and any indexes
    /// involved in the operation. <c>ConsumedCapacity</c> is only returned if the request
    /// asked for it. For more information, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/provisioned-capacity-mode.html">Provisioned
    /// capacity mode</a> in the <i>Amazon DynamoDB Developer Guide</i>.
    /// </summary>
    public partial class ConsumedCapacity
    {
        private double? _capacityUnits;
        private Dictionary<string, Capacity> _globalSecondaryIndexes = AWSConfigs.InitializeCollections ? new Dictionary<string, Capacity>() : null;
        private Dictionary<string, Capacity> _localSecondaryIndexes = AWSConfigs.InitializeCollections ? new Dictionary<string, Capacity>() : null;
        private double? _readCapacityUnits;
        private Capacity _table;
        private string _tableName;
        private double? _writeCapacityUnits;

        /// <summary>
        /// Gets and sets the property CapacityUnits. 
        /// <para>
        /// The total number of capacity units consumed by the operation.
        /// </para>
        /// </summary>
        public double? CapacityUnits
        {
            get { return this._capacityUnits; }
            set { this._capacityUnits = value; }
        }

        // Check to see if CapacityUnits property is set
        internal bool IsSetCapacityUnits()
        {
            return this._capacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlobalSecondaryIndexes. 
        /// <para>
        /// The amount of throughput consumed on each global index affected by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Capacity> GlobalSecondaryIndexes
        {
            get { return this._globalSecondaryIndexes; }
            set { this._globalSecondaryIndexes = value; }
        }

        // Check to see if GlobalSecondaryIndexes property is set
        internal bool IsSetGlobalSecondaryIndexes()
        {
            return this._globalSecondaryIndexes != null && (this._globalSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LocalSecondaryIndexes. 
        /// <para>
        /// The amount of throughput consumed on each local index affected by the operation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, Capacity> LocalSecondaryIndexes
        {
            get { return this._localSecondaryIndexes; }
            set { this._localSecondaryIndexes = value; }
        }

        // Check to see if LocalSecondaryIndexes property is set
        internal bool IsSetLocalSecondaryIndexes()
        {
            return this._localSecondaryIndexes != null && (this._localSecondaryIndexes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ReadCapacityUnits. 
        /// <para>
        /// The total number of read capacity units consumed by the operation.
        /// </para>
        /// </summary>
        public double? ReadCapacityUnits
        {
            get { return this._readCapacityUnits; }
            set { this._readCapacityUnits = value; }
        }

        // Check to see if ReadCapacityUnits property is set
        internal bool IsSetReadCapacityUnits()
        {
            return this._readCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Table. 
        /// <para>
        /// The amount of throughput consumed on the table affected by the operation.
        /// </para>
        /// </summary>
        public Capacity Table
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table that was affected by the operation. If you had specified the
        /// Amazon Resource Name (ARN) of a table in the input, you'll see the table ARN in the
        /// response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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

        /// <summary>
        /// Gets and sets the property WriteCapacityUnits. 
        /// <para>
        /// The total number of write capacity units consumed by the operation.
        /// </para>
        /// </summary>
        public double? WriteCapacityUnits
        {
            get { return this._writeCapacityUnits; }
            set { this._writeCapacityUnits = value; }
        }

        // Check to see if WriteCapacityUnits property is set
        internal bool IsSetWriteCapacityUnits()
        {
            return this._writeCapacityUnits.HasValue; 
        }

    }
}