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

/*
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes the modification status of an EBS volume.
    /// 
    ///  
    /// <para>
    /// If the volume has never been modified, some element values will be null.
    /// </para>
    /// </summary>
    public partial class VolumeModification
    {
        private DateTime? _endTime;
        private VolumeModificationState _modificationState;
        private int? _originalIops;
        private int? _originalSize;
        private VolumeType _originalVolumeType;
        private long? _progress;
        private DateTime? _startTime;
        private string _statusMessage;
        private int? _targetIops;
        private int? _targetSize;
        private VolumeType _targetVolumeType;
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Modification completion or failure time.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// Current state of modification. Possible values are <code>modifying</code> | <code>optimizing</code>
        /// | <code>complete</code> | <code>failed</code>. Modification state is null for unmodified
        /// volumes. 
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
        /// Original IOPS rate of the volume being modified.
        /// </para>
        /// </summary>
        public int OriginalIops
        {
            get { return this._originalIops.GetValueOrDefault(); }
            set { this._originalIops = value; }
        }

        // Check to see if OriginalIops property is set
        internal bool IsSetOriginalIops()
        {
            return this._originalIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalSize. 
        /// <para>
        /// Original size of the volume being modified.
        /// </para>
        /// </summary>
        public int OriginalSize
        {
            get { return this._originalSize.GetValueOrDefault(); }
            set { this._originalSize = value; }
        }

        // Check to see if OriginalSize property is set
        internal bool IsSetOriginalSize()
        {
            return this._originalSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OriginalVolumeType. 
        /// <para>
        /// Original EBS volume type of the volume being modified.
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
        /// Modification progress from 0 to 100%.
        /// </para>
        /// </summary>
        public long Progress
        {
            get { return this._progress.GetValueOrDefault(); }
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
        /// Modification start time 
        /// </para>
        /// </summary>
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
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
        /// Generic status message on modification progress or failure.
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
        /// Target IOPS rate of the volume being modified.
        /// </para>
        /// </summary>
        public int TargetIops
        {
            get { return this._targetIops.GetValueOrDefault(); }
            set { this._targetIops = value; }
        }

        // Check to see if TargetIops property is set
        internal bool IsSetTargetIops()
        {
            return this._targetIops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetSize. 
        /// <para>
        /// Target size of the volume being modified.
        /// </para>
        /// </summary>
        public int TargetSize
        {
            get { return this._targetSize.GetValueOrDefault(); }
            set { this._targetSize = value; }
        }

        // Check to see if TargetSize property is set
        internal bool IsSetTargetSize()
        {
            return this._targetSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TargetVolumeType. 
        /// <para>
        /// Target EBS volume type of the volume being modified.
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
        /// ID of the volume being modified.
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