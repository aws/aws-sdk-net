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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
        private DateTime? _endTime;
        private VolumeModificationState _modificationState;
        private int? _originalIops;
        private bool? _originalMultiAttachEnabled;
        private int? _originalSize;
        private int? _originalThroughput;
        private VolumeType _originalVolumeType;
        private long? _progress;
        private DateTime? _startTime;
        private string _statusMessage;
        private int? _targetIops;
        private bool? _targetMultiAttachEnabled;
        private int? _targetSize;
        private int? _targetThroughput;
        private VolumeType _targetVolumeType;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The modification completion or failure time.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModificationState. 
        /// <para>
        /// The current modification state.
        /// </para>
        /// </summary>
        public VolumeModificationState ModificationState
        {
            get { return this._modificationState; }
            set { this._modificationState = value; }
        }

        // Check to see if ModificationState property is set
        internal bool IsSetModificationState()
        {
            return this._modificationState != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalIops. 
        /// <para>
        /// The original IOPS rate of the volume.
        /// </para>
        /// </summary>
        public int? OriginalIops
        {
            get { return this._originalIops; }
            set { this._originalIops = value; }
        }

        // Check to see if OriginalIops property is set
        internal bool IsSetOriginalIops()
        {
            return this._originalIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalMultiAttachEnabled. 
        /// <para>
        /// The original setting for Amazon EBS Multi-Attach.
        /// </para>
        /// </summary>
        public bool? OriginalMultiAttachEnabled
        {
            get { return this._originalMultiAttachEnabled; }
            set { this._originalMultiAttachEnabled = value; }
        }

        // Check to see if OriginalMultiAttachEnabled property is set
        internal bool IsSetOriginalMultiAttachEnabled()
        {
            return this._originalMultiAttachEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalSize. 
        /// <para>
        /// The original size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? OriginalSize
        {
            get { return this._originalSize; }
            set { this._originalSize = value; }
        }

        // Check to see if OriginalSize property is set
        internal bool IsSetOriginalSize()
        {
            return this._originalSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalThroughput. 
        /// <para>
        /// The original throughput of the volume, in MiB/s.
        /// </para>
        /// </summary>
        public int? OriginalThroughput
        {
            get { return this._originalThroughput; }
            set { this._originalThroughput = value; }
        }

        // Check to see if OriginalThroughput property is set
        internal bool IsSetOriginalThroughput()
        {
            return this._originalThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalVolumeType. 
        /// <para>
        /// The original EBS volume type of the volume.
        /// </para>
        /// </summary>
        public VolumeType OriginalVolumeType
        {
            get { return this._originalVolumeType; }
            set { this._originalVolumeType = value; }
        }

        // Check to see if OriginalVolumeType property is set
        internal bool IsSetOriginalVolumeType()
        {
            return this._originalVolumeType != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The modification progress, from 0 to 100 percent complete.
        /// </para>
        /// </summary>
        public long? Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The modification start time.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A status message about the modification progress or failure.
        /// </para>
        /// </summary>
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property TargetIops. 
        /// <para>
        /// The target IOPS rate of the volume.
        /// </para>
        /// </summary>
        public int? TargetIops
        {
            get { return this._targetIops; }
            set { this._targetIops = value; }
        }

        // Check to see if TargetIops property is set
        internal bool IsSetTargetIops()
        {
            return this._targetIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetMultiAttachEnabled. 
        /// <para>
        /// The target setting for Amazon EBS Multi-Attach.
        /// </para>
        /// </summary>
        public bool? TargetMultiAttachEnabled
        {
            get { return this._targetMultiAttachEnabled; }
            set { this._targetMultiAttachEnabled = value; }
        }

        // Check to see if TargetMultiAttachEnabled property is set
        internal bool IsSetTargetMultiAttachEnabled()
        {
            return this._targetMultiAttachEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetSize. 
        /// <para>
        /// The target size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? TargetSize
        {
            get { return this._targetSize; }
            set { this._targetSize = value; }
        }

        // Check to see if TargetSize property is set
        internal bool IsSetTargetSize()
        {
            return this._targetSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetThroughput. 
        /// <para>
        /// The target throughput of the volume, in MiB/s.
        /// </para>
        /// </summary>
        public int? TargetThroughput
        {
            get { return this._targetThroughput; }
            set { this._targetThroughput = value; }
        }

        // Check to see if TargetThroughput property is set
        internal bool IsSetTargetThroughput()
        {
            return this._targetThroughput.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetVolumeType. 
        /// <para>
        /// The target EBS volume type of the volume.
        /// </para>
        /// </summary>
        public VolumeType TargetVolumeType
        {
            get { return this._targetVolumeType; }
            set { this._targetVolumeType = value; }
        }

        // Check to see if TargetVolumeType property is set
        internal bool IsSetTargetVolumeType()
        {
            return this._targetVolumeType != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume.
        /// </para>
        /// </summary>
        public string VolumeId
        {
            get { return this._volumeId; }
            set { this._volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this._volumeId != null;
        }

    }
}