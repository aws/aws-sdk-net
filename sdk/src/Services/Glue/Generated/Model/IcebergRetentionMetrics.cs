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
    /// Snapshot retention metrics for Iceberg for the optimizer run.
    /// </summary>
    public partial class IcebergRetentionMetrics
    {
        private double? _dpuHours;
        private double? _jobDurationInHour;
        private long? _numberOfDataFilesDeleted;
        private int? _numberOfDpus;
        private long? _numberOfManifestFilesDeleted;
        private long? _numberOfManifestListsDeleted;

        /// <summary>
        /// Gets and sets the property DpuHours. 
        /// <para>
        /// The number of DPU hours consumed by the job.
        /// </para>
        /// </summary>
        public double? DpuHours
        {
            get { return this._dpuHours; }
            set { this._dpuHours = value; }
        }

        // Check to see if DpuHours property is set
        internal bool IsSetDpuHours()
        {
            return this._dpuHours.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobDurationInHour. 
        /// <para>
        /// The duration of the job in hours.
        /// </para>
        /// </summary>
        public double? JobDurationInHour
        {
            get { return this._jobDurationInHour; }
            set { this._jobDurationInHour = value; }
        }

        // Check to see if JobDurationInHour property is set
        internal bool IsSetJobDurationInHour()
        {
            return this._jobDurationInHour.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDataFilesDeleted. 
        /// <para>
        /// The number of data files deleted by the retention job run.
        /// </para>
        /// </summary>
        public long? NumberOfDataFilesDeleted
        {
            get { return this._numberOfDataFilesDeleted; }
            set { this._numberOfDataFilesDeleted = value; }
        }

        // Check to see if NumberOfDataFilesDeleted property is set
        internal bool IsSetNumberOfDataFilesDeleted()
        {
            return this._numberOfDataFilesDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfDpus. 
        /// <para>
        /// The number of DPUs consumed by the job, rounded up to the nearest whole number.
        /// </para>
        /// </summary>
        public int? NumberOfDpus
        {
            get { return this._numberOfDpus; }
            set { this._numberOfDpus = value; }
        }

        // Check to see if NumberOfDpus property is set
        internal bool IsSetNumberOfDpus()
        {
            return this._numberOfDpus.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfManifestFilesDeleted. 
        /// <para>
        /// The number of manifest files deleted by the retention job run.
        /// </para>
        /// </summary>
        public long? NumberOfManifestFilesDeleted
        {
            get { return this._numberOfManifestFilesDeleted; }
            set { this._numberOfManifestFilesDeleted = value; }
        }

        // Check to see if NumberOfManifestFilesDeleted property is set
        internal bool IsSetNumberOfManifestFilesDeleted()
        {
            return this._numberOfManifestFilesDeleted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfManifestListsDeleted. 
        /// <para>
        /// The number of manifest lists deleted by the retention job run.
        /// </para>
        /// </summary>
        public long? NumberOfManifestListsDeleted
        {
            get { return this._numberOfManifestListsDeleted; }
            set { this._numberOfManifestListsDeleted = value; }
        }

        // Check to see if NumberOfManifestListsDeleted property is set
        internal bool IsSetNumberOfManifestListsDeleted()
        {
            return this._numberOfManifestListsDeleted.HasValue; 
        }

    }
}