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
    /// Current information about a consumable resource required by a job.
    /// </summary>
    public partial class ListJobsByConsumableResourceSummary
    {
        /// <summary>
        /// Gets and sets the property ConsumableResourceProperties. 
        /// <para>
        /// Contains a list of consumable resources required by the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ConsumableResourceProperties ConsumableResourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourceProperties property is set.
        /// </summary>
        internal bool IsSetConsumableResourceProperties() => this.ConsumableResourceProperties != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix timestamp (in milliseconds) for when the consumable resource was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job definition.
        /// </para>
        /// </summary>
        public string JobDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinitionArn property is set.
        /// </summary>
        internal bool IsSetJobDefinitionArn() => this.JobDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobQueueArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobQueueArn { get; set; }

        /// <summary>
        /// Checks to see if the JobQueueArn property is set.
        /// </summary>
        internal bool IsSetJobQueueArn() => this.JobQueueArn != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The status of the job. Can be one of:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUBMITTED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNABLE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RUNNING</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The total amount of the consumable resource that is available.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? Quantity { get; set; }

        /// <summary>
        /// Checks to see if the Quantity property is set.
        /// </summary>
        internal bool IsSetQuantity() => this.Quantity.HasValue;

        /// <summary>
        /// Gets and sets the property ShareIdentifier. 
        /// <para>
        /// The fair-share scheduling identifier for the job.
        /// </para>
        /// </summary>
        public string ShareIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ShareIdentifier property is set.
        /// </summary>
        internal bool IsSetShareIdentifier() => this.ShareIdentifier != null;

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The Unix timestamp for when the job was started. More specifically, it's when the
        /// job transitioned from the <c>STARTING</c> state to the <c>RUNNING</c> state.
        /// </para>
        /// </summary>
        public long? StartedAt { get; set; }

        /// <summary>
        /// Checks to see if the StartedAt property is set.
        /// </summary>
        internal bool IsSetStartedAt() => this.StartedAt.HasValue;

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// A short, human-readable string to provide more details for the current status of the
        /// job.
        /// </para>
        /// </summary>
        public string StatusReason { get; set; }

        /// <summary>
        /// Checks to see if the StatusReason property is set.
        /// </summary>
        internal bool IsSetStatusReason() => this.StatusReason != null;
    }
}
