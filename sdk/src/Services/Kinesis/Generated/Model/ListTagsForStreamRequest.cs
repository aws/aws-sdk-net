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
    /// Container for the parameters to the ListTagsForStream operation.
    /// Lists the tags for the specified Kinesis data stream. This operation has a limit of
    /// five transactions per second per account.
    /// 
    ///  <note> 
    /// <para>
    /// When invoking this API, it is recommended you use the <code>StreamARN</code> input
    /// parameter rather than the <code>StreamName</code> input parameter.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListTagsForStreamRequest : AmazonKinesisRequest
    {
        private string _exclusiveStartTagKey;
        private int? _limit;
        private string _streamARN;
        private string _streamName;

        /// <summary>
        /// Gets and sets the property ExclusiveStartTagKey. 
        /// <para>
        /// The key to use as the starting point for the list of tags. If this parameter is set,
        /// <code>ListTagsForStream</code> gets all tags that occur after <code>ExclusiveStartTagKey</code>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ExclusiveStartTagKey
        {
            get { return this._exclusiveStartTagKey; }
            set { this._exclusiveStartTagKey = value; }
        }

        // Check to see if ExclusiveStartTagKey property is set
        internal bool IsSetExclusiveStartTagKey()
        {
            return this._exclusiveStartTagKey != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The number of tags to return. If this number is less than the total number of tags
        /// associated with the stream, <code>HasMoreTags</code> is set to <code>true</code>.
        /// To list additional tags, set <code>ExclusiveStartTagKey</code> to the last key in
        /// the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
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

    }
}