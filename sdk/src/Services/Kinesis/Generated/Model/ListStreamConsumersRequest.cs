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
    /// Container for the parameters to the ListStreamConsumers operation.
    /// Lists the consumers registered to receive data from a stream using enhanced fan-out,
    /// and provides information about each consumer.
    /// 
    ///  
    /// <para>
    /// This operation has a limit of 10 transactions per second per account.
    /// </para>
    /// </summary>
    public partial class ListStreamConsumersRequest : AmazonKinesisRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _streamARN;
        private DateTime? _streamCreationTimestamp;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of consumers that you want a single call of <code>ListStreamConsumers</code>
        /// to return.
        /// </para>
        /// </summary>
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
        /// When the number of consumers that are registered with the data stream is greater than
        /// the default value for the <code>MaxResults</code> parameter, or if you explicitly
        /// specify a value for <code>MaxResults</code> that is less than the number of consumers
        /// that are registered with the data stream, the response includes a pagination token
        /// named <code>NextToken</code>. You can specify this <code>NextToken</code> value in
        /// a subsequent call to <code>ListStreamConsumers</code> to list the next set of registered
        /// consumers.
        /// </para>
        ///  
        /// <para>
        /// Don't specify <code>StreamName</code> or <code>StreamCreationTimestamp</code> if you
        /// specify <code>NextToken</code> because the latter unambiguously identifies the stream.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a value for the <code>MaxResults</code> parameter when
        /// you specify <code>NextToken</code>. If you specify a <code>MaxResults</code> value
        /// that is less than the number of consumers that the operation returns if you don't
        /// specify <code>MaxResults</code>, the response will contain a new <code>NextToken</code>
        /// value. You can use the new <code>NextToken</code> value in a subsequent call to the
        /// <code>ListStreamConsumers</code> operation to list the next set of consumers.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens expire after 300 seconds. When you obtain a value for <code>NextToken</code>
        /// in the response to a call to <code>ListStreamConsumers</code>, you have 300 seconds
        /// to use that value. If you specify an expired token in a call to <code>ListStreamConsumers</code>,
        /// you get <code>ExpiredNextTokenException</code>.
        /// </para>
        ///  </important>
        /// </summary>
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
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the Kinesis data stream for which you want to list the registered consumers.
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kinesis-streams">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a>.
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
        /// Gets and sets the property StreamCreationTimestamp. 
        /// <para>
        /// Specify this input parameter to distinguish data streams that have the same name.
        /// For example, if you create a data stream and then delete it, and you later create
        /// another data stream with the same name, you can use this input parameter to specify
        /// which of the two streams you want to list the consumers for. 
        /// </para>
        ///  
        /// <para>
        /// You can't specify this parameter if you specify the NextToken parameter. 
        /// </para>
        /// </summary>
        public DateTime StreamCreationTimestamp
        {
            get { return this._streamCreationTimestamp.GetValueOrDefault(); }
            set { this._streamCreationTimestamp = value; }
        }

        // Check to see if StreamCreationTimestamp property is set
        internal bool IsSetStreamCreationTimestamp()
        {
            return this._streamCreationTimestamp.HasValue; 
        }

    }
}