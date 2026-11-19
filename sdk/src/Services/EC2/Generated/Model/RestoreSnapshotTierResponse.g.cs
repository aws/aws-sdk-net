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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the RestoreSnapshotTier operation.
    /// </summary>
    public partial class RestoreSnapshotTierResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property IsPermanentRestore. 
        /// <para>
        /// Indicates whether the snapshot is permanently restored. <c>true</c> indicates a permanent
        /// restore. <c>false</c> indicates a temporary restore.
        /// </para>
        /// </summary>
        public bool? IsPermanentRestore { get; set; }

        /// <summary>
        /// Checks to see if the IsPermanentRestore property is set.
        /// </summary>
        internal bool IsSetIsPermanentRestore() => this.IsPermanentRestore.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreDuration. 
        /// <para>
        /// For temporary restores only. The number of days for which the archived snapshot is
        /// temporarily restored.
        /// </para>
        /// </summary>
        public int? RestoreDuration { get; set; }

        /// <summary>
        /// Checks to see if the RestoreDuration property is set.
        /// </summary>
        internal bool IsSetRestoreDuration() => this.RestoreDuration.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreStartTime. 
        /// <para>
        /// The date and time when the snapshot restore process started.
        /// </para>
        /// </summary>
        public DateTime? RestoreStartTime { get; set; }

        /// <summary>
        /// Checks to see if the RestoreStartTime property is set.
        /// </summary>
        internal bool IsSetRestoreStartTime() => this.RestoreStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;
    }
}
