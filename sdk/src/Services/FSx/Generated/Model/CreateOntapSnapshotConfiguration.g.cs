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

namespace Amazon.FSx.Model
{
    /// <summary>
    /// Specifies the configuration of the ONTAP snapshot that you are creating.
    /// </summary>
    public partial class CreateOntapSnapshotConfiguration
    {
        /// <summary>
        /// Gets and sets the property ExpiryTime. 
        /// <para>
        /// Specifies the date and time when the snapshot expires. You can't delete the snapshot
        /// before this time.
        /// </para>
        /// </summary>
        public DateTime? ExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the ExpiryTime property is set.
        /// </summary>
        internal bool IsSetExpiryTime() => this.ExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnaplockExpiryTime. 
        /// <para>
        /// Specifies the date and time until which the snapshot is locked. This setting takes
        /// effect only if snapshot locking is enabled on the volume. Snapshot locking is separate
        /// from SnapLock, and enabling SnapLock on a volume doesn't enable snapshot locking.
        /// You can't delete the snapshot before this time.
        /// </para>
        /// </summary>
        public DateTime? SnaplockExpiryTime { get; set; }

        /// <summary>
        /// Checks to see if the SnaplockExpiryTime property is set.
        /// </summary>
        internal bool IsSetSnaplockExpiryTime() => this.SnaplockExpiryTime.HasValue;

        /// <summary>
        /// Gets and sets the property SnapmirrorLabel. 
        /// <para>
        /// Specifies the SnapMirror label to assign to the snapshot. SnapMirror policies use
        /// labels to select which snapshots to replicate to a destination volume.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 31)]
        public string SnapmirrorLabel { get; set; }

        /// <summary>
        /// Checks to see if the SnapmirrorLabel property is set.
        /// </summary>
        internal bool IsSetSnapmirrorLabel() => this.SnapmirrorLabel != null;
    }
}
