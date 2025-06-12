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
 * Do not modify this file. This file is generated from the mediaconvert-2017-08-29.normal.json service model.
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
namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// This is the response object from the ListQueues operation.
    /// </summary>
    public partial class ListQueuesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<Queue> _queues = AWSConfigs.InitializeCollections ? new List<Queue>() : null;
        private int? _totalConcurrentJobs;
        private int? _unallocatedConcurrentJobs;

        /// <summary>
        /// Gets and sets the property NextToken. Use this string to request the next batch of
        /// queues.
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
        /// Gets and sets the property Queues. List of queues.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Queue> Queues
        {
            get { return this._queues; }
            set { this._queues = value; }
        }

        // Check to see if Queues property is set
        internal bool IsSetQueues()
        {
            return this._queues != null && (this._queues.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalConcurrentJobs. The maximum number of jobs that MediaConvert
        /// can process at one time, across all of your on-demand queues in the current AWS Region.
        /// </summary>
        public int? TotalConcurrentJobs
        {
            get { return this._totalConcurrentJobs; }
            set { this._totalConcurrentJobs = value; }
        }

        // Check to see if TotalConcurrentJobs property is set
        internal bool IsSetTotalConcurrentJobs()
        {
            return this._totalConcurrentJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UnallocatedConcurrentJobs. The remaining number of concurrent
        /// jobs that are not associated with a queue and are available to allocate to a queue.
        /// You can allocate these jobs when you create or update a queue.
        /// </summary>
        public int? UnallocatedConcurrentJobs
        {
            get { return this._unallocatedConcurrentJobs; }
            set { this._unallocatedConcurrentJobs = value; }
        }

        // Check to see if UnallocatedConcurrentJobs property is set
        internal bool IsSetUnallocatedConcurrentJobs()
        {
            return this._unallocatedConcurrentJobs.HasValue; 
        }

    }
}