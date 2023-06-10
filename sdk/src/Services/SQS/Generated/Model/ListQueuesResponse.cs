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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// A list of your queues.
    /// </summary>
    public partial class ListQueuesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _queueUrls = new List<string>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to include in the next request. Token value is <code>null</code>
        /// if there are no additional results to request, or if you did not set <code>MaxResults</code>
        /// in the request.
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
        /// Gets and sets the property QueueUrls. 
        /// <para>
        /// A list of queue URLs, up to 1,000 entries, or the value of <code>MaxResults</code>
        /// that you sent in the request.
        /// </para>
        /// </summary>
        public List<string> QueueUrls
        {
            get { return this._queueUrls; }
            set { this._queueUrls = value; }
        }

        // Check to see if QueueUrls property is set
        internal bool IsSetQueueUrls()
        {
            return this._queueUrls != null && this._queueUrls.Count > 0; 
        }

    }
}