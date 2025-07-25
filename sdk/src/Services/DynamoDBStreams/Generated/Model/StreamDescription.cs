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
    /// Represents all of the data describing a particular stream.
    /// </summary>
    public partial class StreamDescription
    {
        private DateTime? _creationRequestDateTime;
        private List<KeySchemaElement> _keySchema = AWSConfigs.InitializeCollections ? new List<KeySchemaElement>() : null;
        private string _lastEvaluatedShardId;
        private List<Shard> _shards = AWSConfigs.InitializeCollections ? new List<Shard>() : null;
        private string _streamArn;
        private string _streamLabel;
        private StreamStatus _streamStatus;
        private StreamViewType _streamViewType;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CreationRequestDateTime. 
        /// <para>
        /// The date and time when the request to create this stream was issued.
        /// </para>
        /// </summary>
        public DateTime? CreationRequestDateTime
        {
            get { return this._creationRequestDateTime; }
            set { this._creationRequestDateTime = value; }
        }

        // Check to see if CreationRequestDateTime property is set
        internal bool IsSetCreationRequestDateTime()
        {
            return this._creationRequestDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeySchema. 
        /// <para>
        /// The key attribute(s) of the stream's DynamoDB table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=2)]
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
        [AWSProperty(Min=28, Max=65)]
        public string LastEvaluatedShardId
        {
            get { return this._lastEvaluatedShardId; }
            set { this._lastEvaluatedShardId = value; }
        }

        // Check to see if LastEvaluatedShardId property is set
        internal bool IsSetLastEvaluatedShardId()
        {
            return this._lastEvaluatedShardId != null;
        }

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// The shards that comprise the stream.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Shard> Shards
        {
            get { return this._shards; }
            set { this._shards = value; }
        }

        // Check to see if Shards property is set
        internal bool IsSetShards()
        {
            return this._shards != null && (this._shards.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property StreamArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=37, Max=1024)]
        public string StreamArn
        {
            get { return this._streamArn; }
            set { this._streamArn = value; }
        }

        // Check to see if StreamArn property is set
        internal bool IsSetStreamArn()
        {
            return this._streamArn != null;
        }

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
        public string StreamLabel
        {
            get { return this._streamLabel; }
            set { this._streamLabel = value; }
        }

        // Check to see if StreamLabel property is set
        internal bool IsSetStreamLabel()
        {
            return this._streamLabel != null;
        }

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
        public StreamStatus StreamStatus
        {
            get { return this._streamStatus; }
            set { this._streamStatus = value; }
        }

        // Check to see if StreamStatus property is set
        internal bool IsSetStreamStatus()
        {
            return this._streamStatus != null;
        }

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
        public StreamViewType StreamViewType
        {
            get { return this._streamViewType; }
            set { this._streamViewType = value; }
        }

        // Check to see if StreamViewType property is set
        internal bool IsSetStreamViewType()
        {
            return this._streamViewType != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The DynamoDB table with which the stream is associated.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
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