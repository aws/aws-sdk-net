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

namespace Amazon.DynamoDBStreams.Model
{
    /// <summary>
    /// Represents all of the data describing a particular stream.
    /// </summary>
    public partial class StreamDescription
    {
        /// <summary>
        /// Gets and sets the property CreationRequestDateTime. 
        /// <para>
        /// The date and time when the request to create this stream was issued.
        /// </para>
        /// </summary>
        public DateTime? CreationRequestDateTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationRequestDateTime property is set.
        /// </summary>
        internal bool IsSetCreationRequestDateTime() => this.CreationRequestDateTime.HasValue;

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The key attribute(s) of the stream's DynamoDB table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1)]
        public List<KeySchemaElement> KeySchema { get; set; } = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;

        /// <summary>
        /// Checks to see if the KeySchema property is set.
        /// </summary>
        internal bool IsSetKeySchema() => this.KeySchema != null && (this.KeySchema.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LastEvaluatedShardId. 
        /// <para>
        /// The shard ID of the item where the operation stopped, inclusive of the previous result
        /// set. Use this value to start a new operation, excluding this value in the new request.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedShardId</c> is empty, then the "last page" of results has been
        /// processed and there is currently no more data to be retrieved.
        /// </para>
        ///  
        /// <para>
        /// If <c>LastEvaluatedShardId</c> is not empty, it does not necessarily mean that there
        /// is more data in the result set. The only way to know when you have reached the end
        /// of the result set is when <c>LastEvaluatedShardId</c> is empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 28, Max = 65)]
        public string LastEvaluatedShardId { get; set; }

        /// <summary>
        /// Checks to see if the LastEvaluatedShardId property is set.
        /// </summary>
        internal bool IsSetLastEvaluatedShardId() => this.LastEvaluatedShardId != null;

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// The shards that comprise the stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Shard> Shards { get; set; } = AWSConfigs.InitializeCollections ? new List<Shard>() : null;

        /// <summary>
        /// Checks to see if the Shards property is set.
        /// </summary>
        internal bool IsSetShards() => this.Shards != null && (this.Shards.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 37, Max = 1024)]
        public string StreamArn { get; set; }

        /// <summary>
        /// Checks to see if the StreamArn property is set.
        /// </summary>
        internal bool IsSetStreamArn() => this.StreamArn != null;

        /// <summary>
        /// Gets and sets the property StreamLabel. 
        /// <para>
        /// A timestamp, in ISO 8601 format, for this stream.
        /// </para>
        ///  
        /// <para>
        /// Note that <c>LatestStreamLabel</c> is not a unique identifier for the stream, because
        /// it is possible that a stream from another table might have the same timestamp. However,
        /// the combination of the following three elements is guaranteed to be unique:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// the Amazon Web Services customer ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// the table name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// the <c>StreamLabel</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StreamLabel { get; set; }

        /// <summary>
        /// Checks to see if the StreamLabel property is set.
        /// </summary>
        internal bool IsSetStreamLabel() => this.StreamLabel != null;

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// Indicates the current status of the stream:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLING</c> - Streams is currently being enabled on the DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENABLED</c> - the stream is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLING</c> - Streams is currently being disabled on the DynamoDB table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - the stream is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamStatus StreamStatus { get; set; }

        /// <summary>
        /// Checks to see if the StreamStatus property is set.
        /// </summary>
        internal bool IsSetStreamStatus() => this.StreamStatus != null;

        /// <summary>
        /// Gets and sets the property StreamViewType. 
        /// <para>
        /// Indicates the format of the records within this stream:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - only the key attributes of items that were modified in the DynamoDB
        /// table.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_IMAGE</c> - entire items from the table, as they appeared after they were
        /// modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OLD_IMAGE</c> - entire items from the table, as they appeared before they were
        /// modified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_AND_OLD_IMAGES</c> - both the new and the old images of the items from the
        /// table.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StreamViewType StreamViewType { get; set; }

        /// <summary>
        /// Checks to see if the StreamViewType property is set.
        /// </summary>
        internal bool IsSetStreamViewType() => this.StreamViewType != null;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The DynamoDB table with which the stream is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;
    }
}
