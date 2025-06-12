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
    /// A list of your dead letter source queues.
    /// </summary>
    public partial class ListDeadLetterSourceQueuesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<string> _queueUrls = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token to include in the next request. Token value is <c>null</c> if there
        /// are no additional results to request, or if you did not set <c>MaxResults</c> in the
        /// request.
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
        /// A list of source queue URLs that have the <c>RedrivePolicy</c> queue attribute configured
        /// with a dead-letter queue.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> QueueUrls
        {
            get { return this._queueUrls; }
            set { this._queueUrls = value; }
        }

        // Check to see if QueueUrls property is set
        internal bool IsSetQueueUrls()
        {
            return this._queueUrls != null && (this._queueUrls.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}