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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
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
namespace Amazon.SQS.Model
{
    /// <summary>
    /// Container for the parameters to the ListDeadLetterSourceQueues operation.
    /// Returns a list of your queues that have the <c>RedrivePolicy</c> queue attribute configured
    /// with a dead-letter queue.
    /// 
    ///  
    /// <para>
    ///  The <c>ListDeadLetterSourceQueues</c> methods supports pagination. Set parameter
    /// <c>MaxResults</c> in the request to specify the maximum number of results to be returned
    /// in the response. If you do not set <c>MaxResults</c>, the response includes a maximum
    /// of 1,000 results. If you set <c>MaxResults</c> and there are additional results to
    /// display, the response includes a value for <c>NextToken</c>. Use <c>NextToken</c>
    /// as a parameter in your next request to <c>ListDeadLetterSourceQueues</c> to receive
    /// the next page of results. 
    /// </para>
    ///  
    /// <para>
    /// For more information about using dead-letter queues, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
    /// Amazon SQS Dead-Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class ListDeadLetterSourceQueuesRequest : AmazonSQSRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _queueUrl;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to include in the response. Value range is 1 to 1000. You
        /// must set <c>MaxResults</c> to receive a value for <c>NextToken</c> in the response.
        /// </para>
        /// </summary>
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
        /// Pagination token to request the next set of results.
        /// </para>
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
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of a dead-letter queue.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }

    }
}