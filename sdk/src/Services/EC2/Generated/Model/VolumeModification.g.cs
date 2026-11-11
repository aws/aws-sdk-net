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
    /// Describes the modification status of an EBS volume.
    /// </summary>
    public partial class VolumeModification
    {
        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The modification completion or failure time.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModificationState. 
        /// <para>
        /// The current modification state.
        /// </para>
        /// </summary>
        public VolumeModificationState ModificationState { get; set; }

        /// <summary>
        /// Checks to see if the ModificationState property is set.
        /// </summary>
        internal bool IsSetModificationState() => this.ModificationState != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The service provider that manages the resource.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property OriginalIops. 
        /// <para>
        /// The original IOPS rate of the volume.
        /// </para>
        /// </summary>
        public int? OriginalIops { get; set; }

        /// <summary>
        /// Checks to see if the OriginalIops property is set.
        /// </summary>
        internal bool IsSetOriginalIops() => this.OriginalIops.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalMultiAttachEnabled. 
        /// <para>
        /// The original setting for Amazon EBS Multi-Attach.
        /// </para>
        /// </summary>
        public bool? OriginalMultiAttachEnabled { get; set; }

        /// <summary>
        /// Checks to see if the OriginalMultiAttachEnabled property is set.
        /// </summary>
        internal bool IsSetOriginalMultiAttachEnabled() => this.OriginalMultiAttachEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalSize. 
        /// <para>
        /// The original size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? OriginalSize { get; set; }

        /// <summary>
        /// Checks to see if the OriginalSize property is set.
        /// </summary>
        internal bool IsSetOriginalSize() => this.OriginalSize.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalThroughput. 
        /// <para>
        /// The original throughput of the volume, in MiB/s.
        /// </para>
        /// </summary>
        public int? OriginalThroughput { get; set; }

        /// <summary>
        /// Checks to see if the OriginalThroughput property is set.
        /// </summary>
        internal bool IsSetOriginalThroughput() => this.OriginalThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property OriginalVolumeType. 
        /// <para>
        /// The original EBS volume type of the volume.
        /// </para>
        /// </summary>
        public VolumeType OriginalVolumeType { get; set; }

        /// <summary>
        /// Checks to see if the OriginalVolumeType property is set.
        /// </summary>
        internal bool IsSetOriginalVolumeType() => this.OriginalVolumeType != null;

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The modification progress, from 0 to 100 percent complete.
        /// </para>
        /// </summary>
        public long? Progress { get; set; }

        /// <summary>
        /// Checks to see if the Progress property is set.
        /// </summary>
        internal bool IsSetProgress() => this.Progress.HasValue;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The modification start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message about the modification progress or failure.
        /// </para>
        /// </summary>
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property TargetIops. 
        /// <para>
        /// The target IOPS rate of the volume.
        /// </para>
        /// </summary>
        public int? TargetIops { get; set; }

        /// <summary>
        /// Checks to see if the TargetIops property is set.
        /// </summary>
        internal bool IsSetTargetIops() => this.TargetIops.HasValue;

        /// <summary>
        /// Gets and sets the property TargetMultiAttachEnabled. 
        /// <para>
        /// The target setting for Amazon EBS Multi-Attach.
        /// </para>
        /// </summary>
        public bool? TargetMultiAttachEnabled { get; set; }

        /// <summary>
        /// Checks to see if the TargetMultiAttachEnabled property is set.
        /// </summary>
        internal bool IsSetTargetMultiAttachEnabled() => this.TargetMultiAttachEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property TargetSize. 
        /// <para>
        /// The target size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? TargetSize { get; set; }

        /// <summary>
        /// Checks to see if the TargetSize property is set.
        /// </summary>
        internal bool IsSetTargetSize() => this.TargetSize.HasValue;

        /// <summary>
        /// Gets and sets the property TargetThroughput. 
        /// <para>
        /// The target throughput of the volume, in MiB/s.
        /// </para>
        /// </summary>
        public int? TargetThroughput { get; set; }

        /// <summary>
        /// Checks to see if the TargetThroughput property is set.
        /// </summary>
        internal bool IsSetTargetThroughput() => this.TargetThroughput.HasValue;

        /// <summary>
        /// Gets and sets the property TargetVolumeType. 
        /// <para>
        /// The target EBS volume type of the volume.
        /// </para>
        /// </summary>
        public VolumeType TargetVolumeType { get; set; }

        /// <summary>
        /// Checks to see if the TargetVolumeType property is set.
        /// </summary>
        internal bool IsSetTargetVolumeType() => this.TargetVolumeType != null;

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId { get; set; }

        /// <summary>
        /// Checks to see if the VolumeId property is set.
        /// </summary>
        internal bool IsSetVolumeId() => this.VolumeId != null;
    }
}
