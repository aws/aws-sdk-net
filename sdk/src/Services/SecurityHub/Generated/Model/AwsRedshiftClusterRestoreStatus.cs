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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about the status of a cluster restore action. It only applies if the cluster
    /// was created by restoring a snapshot.
    /// </summary>
    public partial class AwsRedshiftClusterRestoreStatus
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
        /// The number of megabytes per second being transferred from the backup storage. Returns
        /// the average rate for a completed backup.
        /// </para>
        ///  
        /// <para>
        /// This field is only updated when you restore to DC2 and DS2 node types.
        /// </para>
        /// </summary>
        public double? CurrentRestoreRateInMegaBytesPerSecond
        {
            get { return this._currentRestoreRateInMegaBytesPerSecond; }
            set { this._currentRestoreRateInMegaBytesPerSecond = value; }
        }

        // Check to see if CurrentRestoreRateInMegaBytesPerSecond property is set
        internal bool IsSetCurrentRestoreRateInMegaBytesPerSecond()
        {
            return this._currentRestoreRateInMegaBytesPerSecond.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of time an in-progress restore has been running, or the amount of time
        /// it took a completed restore to finish.
        /// </para>
        ///  
        /// <para>
        /// This field is only updated when you restore to DC2 and DS2 node types.
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds
        {
            get { return this._elapsedTimeInSeconds; }
            set { this._elapsedTimeInSeconds = value; }
        }

        // Check to see if ElapsedTimeInSeconds property is set
        internal bool IsSetElapsedTimeInSeconds()
        {
            return this._elapsedTimeInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        /// The estimate of the time remaining before the restore is complete. Returns 0 for a
        /// completed restore.
        /// </para>
        ///  
        /// <para>
        /// This field is only updated when you restore to DC2 and DS2 node types.
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompletionInSeconds
        {
            get { return this._estimatedTimeToCompletionInSeconds; }
            set { this._estimatedTimeToCompletionInSeconds = value; }
        }

        // Check to see if EstimatedTimeToCompletionInSeconds property is set
        internal bool IsSetEstimatedTimeToCompletionInSeconds()
        {
            return this._estimatedTimeToCompletionInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        /// The number of megabytes that were transferred from snapshot storage.
        /// </para>
        ///  
        /// <para>
        /// This field is only updated when you restore to DC2 and DS2 node types.
        /// </para>
        /// </summary>
        public long? ProgressInMegaBytes
        {
            get { return this._progressInMegaBytes; }
            set { this._progressInMegaBytes = value; }
        }

        // Check to see if ProgressInMegaBytes property is set
        internal bool IsSetProgressInMegaBytes()
        {
            return this._progressInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SnapshotSizeInMegaBytes. 
        /// <para>
        /// The size of the set of snapshot data that was used to restore the cluster.
        /// </para>
        ///  
        /// <para>
        /// This field is only updated when you restore to DC2 and DS2 node types.
        /// </para>
        /// </summary>
        public long? SnapshotSizeInMegaBytes
        {
            get { return this._snapshotSizeInMegaBytes; }
            set { this._snapshotSizeInMegaBytes = value; }
        }

        // Check to see if SnapshotSizeInMegaBytes property is set
        internal bool IsSetSnapshotSizeInMegaBytes()
        {
            return this._snapshotSizeInMegaBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the restore action.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>starting</c> | <c>restoring</c> | <c>completed</c> | <c>failed</c>
        /// 
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}