/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Represents the output for <code>DescribeStream</code>.
    /// </summary>
    public partial class StreamDescription
    {
        private bool? _hasMoreShards;
        private List<Shard> _shards = new List<Shard>();
        private string _streamARN;
        private string _streamName;
        private StreamStatus _streamStatus;

        /// <summary>
        /// Gets and sets the property HasMoreShards. 
        /// <para>
        /// If set to <code>true</code>, more shards in the stream are available to describe.
        /// </para>
        /// </summary>
        public bool HasMoreShards
        {
            get { return this._hasMoreShards.GetValueOrDefault(); }
            set { this._hasMoreShards = value; }
        }

        // Check to see if HasMoreShards property is set
        internal bool IsSetHasMoreShards()
        {
            return this._hasMoreShards.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Shards. 
        /// <para>
        /// The shards that comprise the stream.
        /// </para>
        /// </summary>
        public List<Shard> Shards
        {
            get { return this._shards; }
            set { this._shards = value; }
        }

        // Check to see if Shards property is set
        internal bool IsSetShards()
        {
            return this._shards != null && this._shards.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the stream being described.
        /// </para>
        /// </summary>
        public string StreamARN
        {
            get { return this._streamARN; }
            set { this._streamARN = value; }
        }

        // Check to see if StreamARN property is set
        internal bool IsSetStreamARN()
        {
            return this._streamARN != null;
        }

        /// <summary>
        /// Gets and sets the property StreamName. 
        /// <para>
        /// The name of the stream being described.
        /// </para>
        /// </summary>
        public string StreamName
        {
            get { return this._streamName; }
            set { this._streamName = value; }
        }

        // Check to see if StreamName property is set
        internal bool IsSetStreamName()
        {
            return this._streamName != null;
        }

        /// <summary>
        /// Gets and sets the property StreamStatus. 
        /// <para>
        /// The current status of the stream being described.
        /// </para>
        ///  
        /// <para>
        /// The stream status is one of the following states:
        /// </para>
        ///  <ul> <li> <code>CREATING</code> - The stream is being created. Amazon Kinesis immediately
        /// returns and sets <code>StreamStatus</code> to <code>CREATING</code>.</li> <li> <code>DELETING</code>
        /// - The stream is being deleted. The specified stream is in the <code>DELETING</code>
        /// state until Amazon Kinesis completes the deletion.</li> <li> <code>ACTIVE</code> -
        /// The stream exists and is ready for read and write operations or deletion. You should
        /// perform read and write operations only on an <code>ACTIVE</code> stream.</li> <li>
        /// <code>UPDATING</code> - Shards in the stream are being merged or split. Read and write
        /// operations continue to work while the stream is in the <code>UPDATING</code> state.</li>
        /// </ul>
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

    }
}