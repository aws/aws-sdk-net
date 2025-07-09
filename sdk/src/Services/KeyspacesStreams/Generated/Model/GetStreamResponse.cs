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
 * Do not modify this file. This file is generated from the keyspacesstreams-2024-09-09.normal.json service model.
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
namespace Amazon.KeyspacesStreams.Model
{
    /// <summary>
    /// This is the response object from the GetStream operation.
    /// </summary>
    public partial class GetStreamResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationRequestDateTime;
        private string _keyspaceName;
        private string _nextToken;
        private List<Shard> _shards = AWSConfigs.InitializeCollections ? new List<Shard>() : null;
        private string _streamArn;
        private string _streamLabel;
        private StreamStatus _streamStatus;
        private StreamViewType _streamViewType;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property CreationRequestDateTime. 
        /// <para>
        ///  The date and time when the request to create this stream was issued. The value is
        /// represented in ISO 8601 format. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property KeyspaceName. 
        /// <para>
        ///  The name of the keyspace containing the table associated with this stream. The keyspace
        /// name is part of the table's hierarchical identifier in Amazon Keyspaces. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
        public string KeyspaceName
        {
            get { return this._keyspaceName; }
            set { this._keyspaceName = value; }
        }

        // Check to see if KeyspaceName property is set
        internal bool IsSetKeyspaceName()
        {
            return this._keyspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        ///  A pagination token that can be used in a subsequent <c>GetStream</c> request. This
        /// token is returned if the response contains more shards than can be returned in a single
        /// response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=80, Max=3000)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        ///  An array of shard objects associated with this stream. Each shard contains a subset
        /// of the stream's data records and has its own unique identifier. The collection of
        /// shards represents the complete stream data. 
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
        ///  The Amazon Resource Name (ARN) that uniquely identifies the stream within Amazon
        /// Keyspaces. This ARN can be used in other API operations to reference this specific
        /// stream. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=37, Max=1024)]
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
        ///  A timestamp that serves as a unique identifier for this stream, used for debugging
        /// and monitoring purposes. The stream label represents the point in time when the stream
        /// was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The current status of the stream. Values can be <c>ENABLING</c>, <c>ENABLED</c>,
        /// <c>DISABLING</c>, or <c>DISABLED</c>. Operations on the stream depend on its current
        /// status. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The format of the data records in this stream. Currently, this can be one of the
        /// following options:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NEW_AND_OLD_IMAGES</c> - both versions of the row, before and after the change.
        /// This is the default.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NEW_IMAGE</c> - the version of the row after the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OLD_IMAGE</c> - the version of the row before the change.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>KEYS_ONLY</c> - the partition and clustering keys of the row that was changed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
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
        ///  The name of the table associated with this stream. The stream captures changes to
        /// rows in this Amazon Keyspaces table. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=48)]
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