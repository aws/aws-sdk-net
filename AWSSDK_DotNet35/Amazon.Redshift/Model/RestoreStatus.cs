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
    /// <summary>Restore Status
    /// </summary>
    public class RestoreStatus
    {
        
        private string status;
        private double? currentRestoreRateInMegaBytesPerSecond;
        private long? snapshotSizeInMegaBytes;
        private long? progressInMegaBytes;
        private long? elapsedTimeInSeconds;
        private long? estimatedTimeToCompletionInSeconds;
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
