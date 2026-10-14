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

namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// The custom parameters to be used when the target is an Batch job.
    /// </summary>
    public partial class BatchParameters
    {
        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties for the submitted job, such as the size of the array. The array
        /// size can be between 2 and 10,000. If you specify array properties for a job, it becomes
        /// an array job. This parameter is used only if the target is an Batch job.
        /// </para>
        /// </summary>
        public BatchArrayProperties ArrayProperties { get; set; }

        /// <summary>
        /// Checks to see if the ArrayProperties property is set.
        /// </summary>
        internal bool IsSetArrayProperties() => this.ArrayProperties != null;

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The ARN or name of the job definition to use if the event target is an Batch job.
        /// This job definition must already exist.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobDefinition { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinition property is set.
        /// </summary>
        internal bool IsSetJobDefinition() => this.JobDefinition != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name to use for this execution of the job, if the target is an Batch job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs, if the target is an Batch job. The retry
        /// strategy is the number of times to retry the failed job execution. Valid values are
        /// 1–10. When you specify a retry strategy here, it overrides the retry strategy defined
        /// in the job definition.
        /// </para>
        /// </summary>
        public BatchRetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;
    }
}
