/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a cluster restore action. Returns null if the cluster was
    /// not created by restoring a snapshot.
    /// </summary>
    public partial class RestoreStatus
    {
        private double? _currentRestoreRateInMegaBytesPerSecond;
        private long? _elapsedTimeInSeconds;
        private long? _estimatedTimeToCompletionInSeconds;
        private long? _progressInMegaBytes;
        private long? _snapshotSizeInMegaBytes;
        private string _status;


        /// <summary>
        /// Gets and sets the property CurrentRestoreRateInMegaBytesPerSecond. 
        /// <para>
        ///             The number of megabytes per second being transferred from the backup storage.
        /// Returns the average rate for a completed backup.        
        /// </para>
        /// </summary>
        public double CurrentRestoreRateInMegaBytesPerSecond
        {
            get { return this._currentRestoreRateInMegaBytesPerSecond.GetValueOrDefault(); }
            set { this._currentRestoreRateInMegaBytesPerSecond = value; }
        }


        /// <summary>
        /// Sets the CurrentRestoreRateInMegaBytesPerSecond property
        /// </summary>
        /// <param name="currentRestoreRateInMegaBytesPerSecond">The value to set for the CurrentRestoreRateInMegaBytesPerSecond property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreStatus WithCurrentRestoreRateInMegaBytesPerSecond(double currentRestoreRateInMegaBytesPerSecond)
        {
            this._currentRestoreRateInMegaBytesPerSecond = currentRestoreRateInMegaBytesPerSecond;
            return this;
        }

        // Check to see if CurrentRestoreRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentRestoreRateInMegaBytesPerSecond()
        {
            return this._currentRestoreRateInMegaBytesPerSecond.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        ///             The amount of time an in-progress restore has been running, or the amount
        /// of time it took a completed restore to finish.        
        /// </para>
        /// </summary>
        public long ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds.GetValueOrDefault(); }
            set { this._elapsedTimeInSeconds = value; }
        }


        /// <summary>
        /// Sets the ElapsedTimeInSeconds property
        /// </summary>
        /// <param name="elapsedTimeInSeconds">The value to set for the ElapsedTimeInSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreStatus WithElapsedTimeInSeconds(long elapsedTimeInSeconds)
        {
            this._elapsedTimeInSeconds = elapsedTimeInSeconds;
            return this;
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this._elapsedTimeInSeconds.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        ///             The estimate of the time remaining before the restore will complete. Returns
        /// 0 for a completed restore.        
        /// </para>
        /// </summary>
        public long EstimatedTimeToCompletionInSeconds
        {
            get { return this._estimatedTimeToCompletionInSeconds.GetValueOrDefault(); }
            set { this._estimatedTimeToCompletionInSeconds = value; }
        }


        /// <summary>
        /// Sets the EstimatedTimeToCompletionInSeconds property
        /// </summary>
        /// <param name="estimatedTimeToCompletionInSeconds">The value to set for the EstimatedTimeToCompletionInSeconds property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreStatus WithEstimatedTimeToCompletionInSeconds(long estimatedTimeToCompletionInSeconds)
        {
            this._estimatedTimeToCompletionInSeconds = estimatedTimeToCompletionInSeconds;
            return this;
        }

        // Check to see if EstimatedTimeToCompletionInSeconds property is set
        internal bool IsSetEstimatedTimeToCompletionInSeconds()
        {
            return this._estimatedTimeToCompletionInSeconds.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        ///             The number of megabytes that have been transferred from snapshot storage.
        ///        
        /// </para>
        /// </summary>
        public long ProgressInMegaBytes
        {
            get { return this._progressInMegaBytes.GetValueOrDefault(); }
            set { this._progressInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the ProgressInMegaBytes property
        /// </summary>
        /// <param name="progressInMegaBytes">The value to set for the ProgressInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreStatus WithProgressInMegaBytes(long progressInMegaBytes)
        {
            this._progressInMegaBytes = progressInMegaBytes;
            return this;
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this._progressInMegaBytes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property SnapshotSizeInMegaBytes. 
        /// <para>
        ///             The size of the set of snapshot data used to restore the cluster.    
        ///    
        /// </para>
        /// </summary>
        public long SnapshotSizeInMegaBytes
        {
            get { return this._snapshotSizeInMegaBytes.GetValueOrDefault(); }
            set { this._snapshotSizeInMegaBytes = value; }
        }


        /// <summary>
        /// Sets the SnapshotSizeInMegaBytes property
        /// </summary>
        /// <param name="snapshotSizeInMegaBytes">The value to set for the SnapshotSizeInMegaBytes property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreStatus WithSnapshotSizeInMegaBytes(long snapshotSizeInMegaBytes)
        {
            this._snapshotSizeInMegaBytes = snapshotSizeInMegaBytes;
            return this;
        }

        // Check to see if SnapshotSizeInMegaBytes property is set
        internal bool IsSetSnapshotSizeInMegaBytes()
        {
            return this._snapshotSizeInMegaBytes.HasValue; 
        }


        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        ///             The status of the restore action. Returns starting, restoring, completed,
        /// or failed.        
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }


        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RestoreStatus WithStatus(string status)
        {
            this._status = status;
            return this;
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}