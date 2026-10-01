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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property NextToken. Use this string to request the next batch of
        /// queues.
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Queues. List of queues.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Queue> Queues { get; set; } = AWSConfigs.InitializeCollections ? new List<Queue>() : null;

        /// <summary>
        /// Checks to see if the Queues property is set.
        /// </summary>
        internal bool IsSetQueues() => this.Queues != null && (this.Queues.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TotalConcurrentJobs. The maximum number of jobs that MediaConvert
        /// can process at one time, across all of your on-demand queues in the current AWS Region.
        /// </summary>
        public int? TotalConcurrentJobs { get; set; }

        /// <summary>
        /// Checks to see if the TotalConcurrentJobs property is set.
        /// </summary>
        internal bool IsSetTotalConcurrentJobs() => this.TotalConcurrentJobs.HasValue;

        /// <summary>
        /// Gets and sets the property UnallocatedConcurrentJobs. The remaining number of concurrent
        /// jobs that are not associated with a queue and are available to allocate to a queue.
        /// You can allocate these jobs when you create or update a queue.
        /// </summary>
        public int? UnallocatedConcurrentJobs { get; set; }

        /// <summary>
        /// Checks to see if the UnallocatedConcurrentJobs property is set.
        /// </summary>
        internal bool IsSetUnallocatedConcurrentJobs() => this.UnallocatedConcurrentJobs.HasValue;
    }
}
