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

namespace Amazon.HealthLake.Model
{
    /// <summary>
    /// Contains summary information about a data transformation job. To retrieve full job
    /// details, call <c>DescribeDataTransformationJob</c>.
    /// </summary>
    public partial class TransformationJobSummary
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The timestamp when the job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The unique identifier of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string JobId { get; set; }

        /// <summary>
        /// Checks to see if the JobId property is set.
        /// </summary>
        internal bool IsSetJobId() => this.JobId != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property JobStatus. 
        /// <para>
        /// The current status of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TransformationJobStatus JobStatus { get; set; }

        /// <summary>
        /// Checks to see if the JobStatus property is set.
        /// </summary>
        internal bool IsSetJobStatus() => this.JobStatus != null;

        /// <summary>
        /// Gets and sets the property SourceFormat. 
        /// <para>
        /// The source data format for this job.
        /// </para>
        /// </summary>
        public SourceFormat SourceFormat { get; set; }

        /// <summary>
        /// Checks to see if the SourceFormat property is set.
        /// </summary>
        internal bool IsSetSourceFormat() => this.SourceFormat != null;

        /// <summary>
        /// Gets and sets the property SubmitTime. 
        /// <para>
        /// The timestamp when the job was submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? SubmitTime { get; set; }

        /// <summary>
        /// Checks to see if the SubmitTime property is set.
        /// </summary>
        internal bool IsSetSubmitTime() => this.SubmitTime.HasValue;
    }
}
