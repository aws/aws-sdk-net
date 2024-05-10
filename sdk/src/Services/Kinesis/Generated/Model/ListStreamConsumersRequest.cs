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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Kinesis.Model
{
    /// <summary>
    /// Container for the parameters to the ListStreamConsumers operation.
    /// Lists the consumers registered to receive data from a stream using enhanced fan-out,
    /// and provides information about each consumer.
    /// 
    ///  
    /// <para>
    /// This operation has a limit of 5 transactions per second per stream.
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
        /// The maximum number of consumers that you want a single call of <c>ListStreamConsumers</c>
        /// to return. The default value is 100. If you specify a value greater than 100, at most
        /// 100 results are returned. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// the default value for the <c>MaxResults</c> parameter, or if you explicitly specify
        /// a value for <c>MaxResults</c> that is less than the number of consumers that are registered
        /// with the data stream, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListStreamConsumers</c>
        /// to list the next set of registered consumers.
        /// </para>
        ///  
        /// <para>
        /// Don't specify <c>StreamName</c> or <c>StreamCreationTimestamp</c> if you specify <c>NextToken</c>
        /// because the latter unambiguously identifies the stream.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a value for the <c>MaxResults</c> parameter when you specify
        /// <c>NextToken</c>. If you specify a <c>MaxResults</c> value that is less than the number
        /// of consumers that the operation returns if you don't specify <c>MaxResults</c>, the
        /// response will contain a new <c>NextToken</c> value. You can use the new <c>NextToken</c>
        /// value in a subsequent call to the <c>ListStreamConsumers</c> operation to list the
        /// next set of consumers.
        /// </para>
        ///  <important> 
        /// <para>
        /// Tokens expire after 300 seconds. When you obtain a value for <c>NextToken</c> in the
        /// response to a call to <c>ListStreamConsumers</c>, you have 300 seconds to use that
        /// value. If you specify an expired token in a call to <c>ListStreamConsumers</c>, you
        /// get <c>ExpiredNextTokenException</c>.
        /// </para>
        ///  </important>
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

        /// <summary>
        /// Gets and sets the property StreamARN. 
        /// <para>
        /// The ARN of the Kinesis data stream for which you want to list the registered consumers.
        /// For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#arn-syntax-kinesis-streams">Amazon
        /// Resource Names (ARNs) and Amazon Web Services Service Namespaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
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
        public DateTime? StreamCreationTimestamp
        {
            get { return this._streamCreationTimestamp; }
            set { this._streamCreationTimestamp = value; }
        }

        // Check to see if StreamCreationTimestamp property is set
        internal bool IsSetStreamCreationTimestamp()
        {
            return this._streamCreationTimestamp.HasValue; 
        }

    }
}