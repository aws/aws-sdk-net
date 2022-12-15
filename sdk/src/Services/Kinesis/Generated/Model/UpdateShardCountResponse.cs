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

namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// This is the response object from the UpdateShardCount operation.
    /// </summary>
    public partial class UpdateShardCountResponse : AmazonWebServiceResponse
    {
        private int? _currentShardCount;
        private string _streamARN;
        private string _streamName;
        private int? _targetShardCount;

        /// <summary>
        /// Gets and sets the property CurrentShardCount. 
        /// <para>
        /// The current number of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int CurrentShardCount
        {
            get { return this._currentShardCount.GetValueOrDefault(); }
            set { this._currentShardCount = value; }
        }

        // Check to see if CurrentShardCount property is set
        internal bool IsSetCurrentShardCount()
        {
            return this._currentShardCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// The name of the stream.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// Gets and sets the property TargetShardCount. 
        /// <para>
        /// The updated number of shards.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int TargetShardCount
        {
            get { return this._targetShardCount.GetValueOrDefault(); }
            set { this._targetShardCount = value; }
        }

        // Check to see if TargetShardCount property is set
        internal bool IsSetTargetShardCount()
        {
            return this._targetShardCount.HasValue; 
        }

    }
}