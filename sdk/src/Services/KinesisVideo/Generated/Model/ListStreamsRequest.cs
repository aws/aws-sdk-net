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
 * Do not modify this file. This file is generated from the kinesisvideo-2017-09-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.KinesisVideo.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreams operation.
    /// Returns an array of <code>StreamInfo</code> objects. Each object describes a stream.
    /// To retrieve only streams that satisfy a specific condition, you can specify a <code>StreamNameCondition</code>.
    /// </summary>
    public partial class ListStreamsRequest : AmazonKinesisVideoRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private StreamNameCondition _streamNameCondition;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of streams to return in the response. The default is 10,000.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify this parameter, when the result of a <code>ListStreams</code> operation
        /// is truncated, the call returns the <code>NextToken</code> in the response. To get
        /// another batch of streams, provide this token in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=512)]
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
        /// Gets and sets the property StreamNameCondition. 
        /// <para>
        /// Optional: Returns only streams that satisfy a specific condition. Currently, you can
        /// specify only the prefix of a stream name as a condition. 
        /// </para>
        /// </summary>
        public StreamNameCondition StreamNameCondition
        {
            get { return this._streamNameCondition; }
            set { this._streamNameCondition = value; }
        }

        // Check to see if StreamNameCondition property is set
        internal bool IsSetStreamNameCondition()
        {
            return this._streamNameCondition != null;
        }

    }
}