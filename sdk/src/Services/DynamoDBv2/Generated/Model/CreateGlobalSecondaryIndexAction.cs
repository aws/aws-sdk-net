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
    /// Represents a new global secondary index to be added to an existing table.
    /// </summary>
    public partial class CreateGlobalSecondaryIndexAction
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
        /// The name of the global secondary index to be created.
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
        /// The key schema for the global secondary index.
        /// </para>
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
        /// The maximum number of read and write units for the global secondary index being created.
        /// If you use this parameter, you must specify <c>MaxReadRequestUnits</c>, <c>MaxWriteRequestUnits</c>,
        /// or both. You must use either <c>OnDemand Throughput</c> or <c>ProvisionedThroughput</c>
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
        /// Represents attributes that are copied (projected) from the table into an index. These
        /// are in addition to the primary key attributes and index key attributes, which are
        /// automatically projected.
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
        /// index.
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
        /// second) when creating a secondary index.
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