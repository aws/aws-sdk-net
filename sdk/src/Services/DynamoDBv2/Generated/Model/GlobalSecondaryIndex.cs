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
    /// Represents the properties of a global secondary index.
    /// </summary>
    public partial class GlobalSecondaryIndex
    {
        private string _indexName;
        private List<KeySchemaElement> _keySchema = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;
        private OnDemandThroughput _onDemandThroughput;
        private Projection _projection;
        private ProvisionedThroughput _provisionedThroughput;
        private WarmThroughput _warmThroughput;

        /// <summary>
        /// Gets and sets the property IndexName. 
        /// <para>
        /// The name of the global secondary index. The name must be unique among all other indexes
        /// on this table.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=255)]
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
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The complete key schema for a global secondary index, which consists of one or more
        /// pairs of attribute names and key types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>HASH</c> - partition key
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RANGE</c> - sort key
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The partition key of an item is also known as its <i>hash attribute</i>. The term
        /// "hash attribute" derives from DynamoDB's usage of an internal hash function to evenly
        /// distribute data items across partitions, based on their partition key values.
        /// </para>
        ///  
        /// <para>
        /// The sort key of an item is also known as its <i>range attribute</i>. The term "range
        /// attribute" derives from the way DynamoDB stores items with the same partition key
        /// physically close together, in sorted order by the sort key value.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<KeySchemaElement> KeySchema
        {
            get { return this._keySchema; }
            set { this._keySchema = value; }
        }

        // Check to see if KeySchema property is set
        internal bool IsSetKeySchema()
        {
            return this._keySchema != null && (this._keySchema.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnDemandThroughput. 
        /// <para>
        /// The maximum number of read and write units for the specified global secondary index.
        /// If you use this parameter, you must specify <c>MaxReadRequestUnits</c>, <c>MaxWriteRequestUnits</c>,
        /// or both. You must use either <c>OnDemandThroughput</c> or <c>ProvisionedThroughput</c>
        /// based on your table's capacity mode.
        /// </para>
        /// </summary>
        public OnDemandThroughput OnDemandThroughput
        {
            get { return this._onDemandThroughput; }
            set { this._onDemandThroughput = value; }
        }

        // Check to see if OnDemandThroughput property is set
        internal bool IsSetOnDemandThroughput()
        {
            return this._onDemandThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property Projection. 
        /// <para>
        /// Represents attributes that are copied (projected) from the table into the global secondary
        /// index. These are in addition to the primary key attributes and index key attributes,
        /// which are automatically projected. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Projection Projection
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
        /// Represents the provisioned throughput settings for the specified global secondary
        /// index. You must use either <c>OnDemandThroughput</c> or <c>ProvisionedThroughput</c>
        /// based on your table's capacity mode.
        /// </para>
        ///  
        /// <para>
        /// For current minimum and maximum provisioned throughput values, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/Limits.html">Service,
        /// Account, and Table Quotas</a> in the <i>Amazon DynamoDB Developer Guide</i>.
        /// </para>
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get { return this._provisionedThroughput; }
            set { this._provisionedThroughput = value; }
        }

        // Check to see if ProvisionedThroughput property is set
        internal bool IsSetProvisionedThroughput()
        {
            return this._provisionedThroughput != null;
        }

        /// <summary>
        /// Gets and sets the property WarmThroughput. 
        /// <para>
        /// Represents the warm throughput value (in read units per second and write units per
        /// second) for the specified secondary index. If you use this parameter, you must specify
        /// <c>ReadUnitsPerSecond</c>, <c>WriteUnitsPerSecond</c>, or both.
        /// </para>
        /// </summary>
        public WarmThroughput WarmThroughput
        {
            get { return this._warmThroughput; }
            set { this._warmThroughput = value; }
        }

        // Check to see if WarmThroughput property is set
        internal bool IsSetWarmThroughput()
        {
            return this._warmThroughput != null;
        }

    }
}