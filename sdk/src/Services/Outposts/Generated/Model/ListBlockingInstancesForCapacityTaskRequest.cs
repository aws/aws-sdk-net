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
 * Do not modify this file. This file is generated from the outposts-2019-12-03.normal.json service model.
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
namespace Amazon.Outposts.Model
{
    /// <summary>
    /// Container for the parameters to the ListBlockingInstancesForCapacityTask operation.
    /// A list of Amazon EC2 instances running on the Outpost and belonging to the account
    /// that initiated the capacity task. Use this list to specify the instances you cannot
    /// stop to free up capacity to run the capacity task.
    /// </summary>
    public partial class ListBlockingInstancesForCapacityTaskRequest : AmazonOutpostsRequest
    {
        private string _capacityTaskId;
        private int? _maxResults;
        private string _nextToken;
        private string _outpostIdentifier;

        /// <summary>
        /// Gets and sets the property CapacityTaskId. 
        /// <para>
        /// The ID of the capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=21, Max=21)]
        public string CapacityTaskId
        {
            get { return this._capacityTaskId; }
            set { this._capacityTaskId = value; }
        }

        // Check to see if CapacityTaskId property is set
        internal bool IsSetCapacityTaskId()
        {
            return this._capacityTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property OutpostIdentifier. 
        /// <para>
        /// The ID or ARN of the Outpost associated with the specified capacity task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=180)]
        public string OutpostIdentifier
        {
            get { return this._outpostIdentifier; }
            set { this._outpostIdentifier = value; }
        }

        // Check to see if OutpostIdentifier property is set
        internal bool IsSetOutpostIdentifier()
        {
            return this._outpostIdentifier != null;
        }

    }
}