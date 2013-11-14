/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para>Describes the status of a cluster restore action. Returns null if the cluster was not created by restoring a snapshot.</para>
    /// </summary>
    public class RestoreStatus
    {
        
        private string status;
        private double? currentRestoreRateInMegaBytesPerSecond;
        private long? snapshotSizeInMegaBytes;
        private long? progressInMegaBytes;
        private long? elapsedTimeInSeconds;
        private long? estimatedTimeToCompletionInSeconds;


        /// <summary>
        /// The status of the restore action. Returns starting, restoring, completed, or failed.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }

        /// <summary>
        /// The number of megabytes per second being transferred from the backup storage. Returns the average rate for a completed backup.
        ///  
        /// </summary>
        public double CurrentRestoreRateInMegaBytesPerSecond
        {
            get { return this.currentRestoreRateInMegaBytesPerSecond ?? default(double); }
            set { this.currentRestoreRateInMegaBytesPerSecond = value; }
        }

        // Check to see if CurrentRestoreRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentRestoreRateInMegaBytesPerSecond()
        {
            return this.currentRestoreRateInMegaBytesPerSecond.HasValue;
        }

        /// <summary>
        /// The size of the set of snapshot data used to restore the cluster.
        ///  
        /// </summary>
        public long SnapshotSizeInMegaBytes
        {
            get { return this.snapshotSizeInMegaBytes ?? default(long); }
            set { this.snapshotSizeInMegaBytes = value; }
        }

        // Check to see if SnapshotSizeInMegaBytes property is set
        internal bool IsSetSnapshotSizeInMegaBytes()
        {
            return this.snapshotSizeInMegaBytes.HasValue;
        }

        /// <summary>
        /// The number of megabytes that have been transferred from snapshot storage.
        ///  
        /// </summary>
        public long ProgressInMegaBytes
        {
            get { return this.progressInMegaBytes ?? default(long); }
            set { this.progressInMegaBytes = value; }
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this.progressInMegaBytes.HasValue;
        }

        /// <summary>
        /// The amount of time an in-progress restore has been running, or the amount of time it took a completed restore to finish.
        ///  
        /// </summary>
        public long ElapsedTimeInSeconds
        {
            get { return this.elapsedTimeInSeconds ?? default(long); }
            set { this.elapsedTimeInSeconds = value; }
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this.elapsedTimeInSeconds.HasValue;
        }

        /// <summary>
        /// The estimate of the time remaining before the restore will complete. Returns 0 for a completed restore.
        ///  
        /// </summary>
        public long EstimatedTimeToCompletionInSeconds
        {
            get { return this.estimatedTimeToCompletionInSeconds ?? default(long); }
            set { this.estimatedTimeToCompletionInSeconds = value; }
        }

        // Check to see if EstimatedTimeToCompletionInSeconds property is set
        internal bool IsSetEstimatedTimeToCompletionInSeconds()
        {
            return this.estimatedTimeToCompletionInSeconds.HasValue;
        }
    }
}
