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
    /// Specifies a schedule for an Amazon FSx for NetApp ONTAP snapshot policy.
    /// </summary>
    public partial class SnapshotPolicySchedule
    {
        /// <summary>
        /// Gets and sets the property Count. 
        /// <para>
        /// The number of snapshots to retain for the schedule.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1023)]
        public int? Count { get; set; }

        /// <summary>
        /// Checks to see if the Count property is set.
        /// </summary>
        internal bool IsSetCount() => this.Count.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the ONTAP schedule that determines when snapshots are created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Prefix. 
        /// <para>
        /// The prefix for the schedule to use when creating snapshots.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Prefix { get; set; }

        /// <summary>
        /// Checks to see if the Prefix property is set.
        /// </summary>
        internal bool IsSetPrefix() => this.Prefix != null;

        /// <summary>
        /// Gets and sets the property RetentionPeriod. 
        /// <para>
        /// The length of time that the snapshots that the schedule creates are locked. This setting
        /// applies only to volumes that have snapshot locking enabled.
        /// </para>
        /// </summary>
        public SnapshotPolicyRetentionPeriod RetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the RetentionPeriod property is set.
        /// </summary>
        internal bool IsSetRetentionPeriod() => this.RetentionPeriod != null;

        /// <summary>
        /// Gets and sets the property SnapmirrorLabel. 
        /// <para>
        /// The SnapMirror label to assign to the snapshots that the schedule creates. SnapMirror
        /// policies use labels to select which snapshots to replicate to a destination volume.
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
