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
    /// Container for the parameters to the ListQueues operation.
    /// Returns a list of your queues in the current region. The response includes a maximum
    /// of 1,000 results. If you specify a value for the optional <c>QueueNamePrefix</c> parameter,
    /// only queues with a name that begins with the specified value are returned.
    /// 
    ///  
    /// <para>
    ///  The <c>listQueues</c> methods supports pagination. Set parameter <c>MaxResults</c>
    /// in the request to specify the maximum number of results to be returned in the response.
    /// If you do not set <c>MaxResults</c>, the response includes a maximum of 1,000 results.
    /// If you set <c>MaxResults</c> and there are additional results to display, the response
    /// includes a value for <c>NextToken</c>. Use <c>NextToken</c> as a parameter in your
    /// next request to <c>listQueues</c> to receive the next page of results. 
    /// </para>
    ///  <note> 
    /// <para>
    /// Cross-account permissions don't apply to this action. For more information, see <a
    /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
    /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
    /// Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class ListQueuesRequest : AmazonSQSRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _queueNamePrefix;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListQueuesRequest() { }

        /// <summary>
        /// Instantiates ListQueuesRequest with the parameterized properties
        /// </summary>
        /// <param name="queueNamePrefix">A string to use for filtering the list results. Only those queues whose name begins with the specified string are returned. Queue URLs and names are case-sensitive.</param>
        public ListQueuesRequest(string queueNamePrefix)
        {
            _queueNamePrefix = queueNamePrefix;
        }

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
        /// Gets and sets the property QueueNamePrefix. 
        /// <para>
        /// A string to use for filtering the list results. Only those queues whose name begins
        /// with the specified string are returned.
        /// </para>
        ///  
        /// <para>
        /// Queue URLs and names are case-sensitive.
        /// </para>
        /// </summary>
        public string QueueNamePrefix
        {
            get { return this._queueNamePrefix; }
            set { this._queueNamePrefix = value; }
        }

        // Check to see if QueueNamePrefix property is set
        internal bool IsSetQueueNamePrefix()
        {
            return this._queueNamePrefix != null;
        }

    }
}