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
    /// Container for the parameters to the ListStreams operation.
    /// Lists your Kinesis data streams.
    /// 
    ///  
    /// <para>
    /// The number of streams may be too large to return from a single call to <code>ListStreams</code>.
    /// You can limit the number of returned streams using the <code>Limit</code> parameter.
    /// If you do not specify a value for the <code>Limit</code> parameter, Kinesis Data Streams
    /// uses the default limit, which is currently 100.
    /// </para>
    ///  
    /// <para>
    /// You can detect if there are more streams available to list by using the <code>HasMoreStreams</code>
    /// flag from the returned output. If there are more streams available, you can request
    /// more streams by using the name of the last stream returned by the <code>ListStreams</code>
    /// request in the <code>ExclusiveStartStreamName</code> parameter in a subsequent request
    /// to <code>ListStreams</code>. The group of stream names returned by the subsequent
    /// request is then added to the list. You can continue this process until all the stream
    /// names have been collected in the list. 
    /// </para>
    ///  
    /// <para>
    ///  <a>ListStreams</a> has a limit of five transactions per second per account.
    /// </para>
    /// </summary>
    public partial class ListStreamsRequest : AmazonKinesisRequest
    {
        private string _exclusiveStartStreamName;
        private int? _limit;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ExclusiveStartStreamName. 
        /// <para>
        /// The name of the stream to start the list with.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ExclusiveStartStreamName
        {
            get { return this._exclusiveStartStreamName; }
            set { this._exclusiveStartStreamName = value; }
        }

        // Check to see if ExclusiveStartStreamName property is set
        internal bool IsSetExclusiveStartStreamName()
        {
            return this._exclusiveStartStreamName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of streams to list. The default value is 100. If you specify a
        /// value greater than 100, at most 100 results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
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
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=1048576)]
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

    }
}