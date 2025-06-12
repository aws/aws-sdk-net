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
 * Do not modify this file. This file is generated from the kinesis-2013-12-02.normal.json service model.
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
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Output parameter of the GetRecords API. The existing child shard of the current shard.
    /// </summary>
    public partial class ChildShard
    {
        private HashKeyRange _hashKeyRange;
        private List<string> _parentShards = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _shardId;

        /// <summary>
        /// Gets and sets the property HashKeyRange.
        /// </summary>
        [AWSProperty(Required=true)]
        public HashKeyRange HashKeyRange
        {
            get { return this._hashKeyRange; }
            set { this._hashKeyRange = value; }
        }

        // Check to see if HashKeyRange property is set
        internal bool IsSetHashKeyRange()
        {
            return this._hashKeyRange != null;
        }

        /// <summary>
        /// Gets and sets the property ParentShards. 
        /// <para>
        /// The current shard that is the parent of the existing child shard.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ParentShards
        {
            get { return this._parentShards; }
            set { this._parentShards = value; }
        }

        // Check to see if ParentShards property is set
        internal bool IsSetParentShards()
        {
            return this._parentShards != null && (this._parentShards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// The shard ID of the existing child shard of the current shard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ShardId
        {
            get { return this._shardId; }
            set { this._shardId = value; }
        }

        // Check to see if ShardId property is set
        internal bool IsSetShardId()
        {
            return this._shardId != null;
        }

    }
}