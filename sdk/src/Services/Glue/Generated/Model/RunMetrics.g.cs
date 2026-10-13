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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Metrics for the optimizer run.
    /// 
    ///  
    /// <para>
    /// This structure is deprecated. See the individual metric members for compaction, retention,
    /// and orphan file deletion.
    /// </para>
    /// </summary>
    public partial class RunMetrics
    {
        /// <summary>
        /// Gets and sets the property JobDurationInHour. 
        /// <para>
        /// The duration of the job in hours.
        /// </para>
        /// </summary>
        public string JobDurationInHour { get; set; }

        /// <summary>
        /// Checks to see if the JobDurationInHour property is set.
        /// </summary>
        internal bool IsSetJobDurationInHour() => this.JobDurationInHour != null;

        /// <summary>
        /// Gets and sets the property NumberOfBytesCompacted. 
        /// <para>
        /// The number of bytes removed by the compaction job run.
        /// </para>
        /// </summary>
        public string NumberOfBytesCompacted { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfBytesCompacted property is set.
        /// </summary>
        internal bool IsSetNumberOfBytesCompacted() => this.NumberOfBytesCompacted != null;

        /// <summary>
        /// Gets and sets the property NumberOfDpus. 
        /// <para>
        /// The number of DPUs consumed by the job, rounded up to the nearest whole number.
        /// </para>
        /// </summary>
        public string NumberOfDpus { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfDpus property is set.
        /// </summary>
        internal bool IsSetNumberOfDpus() => this.NumberOfDpus != null;

        /// <summary>
        /// Gets and sets the property NumberOfFilesCompacted. 
        /// <para>
        /// The number of files removed by the compaction job run.
        /// </para>
        /// </summary>
        public string NumberOfFilesCompacted { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfFilesCompacted property is set.
        /// </summary>
        internal bool IsSetNumberOfFilesCompacted() => this.NumberOfFilesCompacted != null;
    }
}
