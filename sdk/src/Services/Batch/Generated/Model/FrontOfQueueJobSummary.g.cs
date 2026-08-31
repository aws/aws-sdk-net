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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents summary details for the first 100 <c>RUNNABLE</c> jobs in
    /// a job queue.
    /// </summary>
    public partial class FrontOfQueueJobSummary
    {
        /// <summary>
        /// Gets and sets the property EarliestTimeAtPosition. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the job transitioned to its current
        /// position in the job queue.
        /// </para>
        /// </summary>
        public long? EarliestTimeAtPosition { get; set; }

        /// <summary>
        /// Checks to see if the EarliestTimeAtPosition property is set.
        /// </summary>
        internal bool IsSetEarliestTimeAtPosition() => this.EarliestTimeAtPosition.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN for a job in a named job queue.
        /// </para>
        /// </summary>
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;
    }
}
