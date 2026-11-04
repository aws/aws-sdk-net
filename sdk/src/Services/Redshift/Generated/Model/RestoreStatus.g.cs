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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes the status of a cluster restore action. Returns null if the cluster was
    /// not created by restoring a snapshot.
    /// </summary>
    public partial class RestoreStatus
    {
        /// <summary>
        /// Gets and sets the property CurrentRestoreRateInMegaBytesPerSecond. 
        /// <para>
        /// The number of megabytes per second being transferred from the backup storage. Returns
        /// the average rate for a completed backup. This field is only updated when you restore
        /// to DC2 node types. 
        /// </para>
        /// </summary>
        public double? CurrentRestoreRateInMegaBytesPerSecond { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRestoreRateInMegaBytesPerSecond property is set.
        /// </summary>
        internal bool IsSetCurrentRestoreRateInMegaBytesPerSecond() => this.CurrentRestoreRateInMegaBytesPerSecond.HasValue;

        /// <summary>
        /// Gets and sets the property ElapsedTimeInSeconds. 
        /// <para>
        /// The amount of time an in-progress restore has been running, or the amount of time
        /// it took a completed restore to finish. This field is only updated when you restore
        /// to DC2 node types. 
        /// </para>
        /// </summary>
        public long? ElapsedTimeInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ElapsedTimeInSeconds property is set.
        /// </summary>
        internal bool IsSetElapsedTimeInSeconds() => this.ElapsedTimeInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property EstimatedTimeToCompletionInSeconds. 
        /// <para>
        /// The estimate of the time remaining before the restore will complete. Returns 0 for
        /// a completed restore. This field is only updated when you restore to DC2 node types.
        /// 
        /// </para>
        /// </summary>
        public long? EstimatedTimeToCompletionInSeconds { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeToCompletionInSeconds property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeToCompletionInSeconds() => this.EstimatedTimeToCompletionInSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ProgressInMegaBytes. 
        /// <para>
        /// The number of megabytes that have been transferred from snapshot storage. This field
        /// is only updated when you restore to DC2 node types. 
        /// </para>
        /// </summary>
        public long? ProgressInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the ProgressInMegaBytes property is set.
        /// </summary>
        internal bool IsSetProgressInMegaBytes() => this.ProgressInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotSizeInMegaBytes. 
        /// <para>
        /// The size of the set of snapshot data used to restore the cluster. This field is only
        /// updated when you restore to DC2 node types. 
        /// </para>
        /// </summary>
        public long? SnapshotSizeInMegaBytes { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotSizeInMegaBytes property is set.
        /// </summary>
        internal bool IsSetSnapshotSizeInMegaBytes() => this.SnapshotSizeInMegaBytes.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the restore action. Returns starting, restoring, completed, or failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
