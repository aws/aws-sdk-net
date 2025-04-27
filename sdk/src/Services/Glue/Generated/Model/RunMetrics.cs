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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
        private string _jobDurationInHour;
        private string _numberOfBytesCompacted;
        private string _numberOfDpus;
        private string _numberOfFilesCompacted;

        /// <summary>
        /// Gets and sets the property JobDurationInHour. 
        /// <para>
        /// The duration of the job in hours.
        /// </para>
        /// </summary>
        public string JobDurationInHour
        {
            get { return this._jobDurationInHour; }
            set { this._jobDurationInHour = value; }
        }

        // Check to see if JobDurationInHour property is set
        internal bool IsSetJobDurationInHour()
        {
            return this._jobDurationInHour != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfBytesCompacted. 
        /// <para>
        /// The number of bytes removed by the compaction job run.
        /// </para>
        /// </summary>
        public string NumberOfBytesCompacted
        {
            get { return this._numberOfBytesCompacted; }
            set { this._numberOfBytesCompacted = value; }
        }

        // Check to see if NumberOfBytesCompacted property is set
        internal bool IsSetNumberOfBytesCompacted()
        {
            return this._numberOfBytesCompacted != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfDpus. 
        /// <para>
        /// The number of DPUs consumed by the job, rounded up to the nearest whole number.
        /// </para>
        /// </summary>
        public string NumberOfDpus
        {
            get { return this._numberOfDpus; }
            set { this._numberOfDpus = value; }
        }

        // Check to see if NumberOfDpus property is set
        internal bool IsSetNumberOfDpus()
        {
            return this._numberOfDpus != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfFilesCompacted. 
        /// <para>
        /// The number of files removed by the compaction job run.
        /// </para>
        /// </summary>
        public string NumberOfFilesCompacted
        {
            get { return this._numberOfFilesCompacted; }
            set { this._numberOfFilesCompacted = value; }
        }

        // Check to see if NumberOfFilesCompacted property is set
        internal bool IsSetNumberOfFilesCompacted()
        {
            return this._numberOfFilesCompacted != null;
        }

    }
}