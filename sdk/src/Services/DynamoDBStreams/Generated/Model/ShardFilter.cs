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
 * Do not modify this file. This file is generated from the streams.dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// This optional field contains the filter definition for the <c>DescribeStream</c> API.
    /// </summary>
    public partial class ShardFilter
    {
        private string _shardId;
        private ShardFilterType _type;

        /// <summary>
        /// Gets and sets the property ShardId. 
        /// <para>
        /// Contains the <c>shardId</c> of the parent shard for which you are requesting child
        /// shards.
        /// </para>
        ///  
        /// <para>
        ///  <i>Sample request:</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=28, Max=65)]
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Contains the type of filter to be applied on the <c>DescribeStream</c> API. Currently,
        /// the only value this parameter accepts is <c>CHILD_SHARDS</c>.
        /// </para>
        /// </summary>
        public ShardFilterType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}