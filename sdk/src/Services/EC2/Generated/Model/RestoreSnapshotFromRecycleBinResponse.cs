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
    /// This is the response object from the RestoreSnapshotFromRecycleBin operation.
    /// </summary>
    public partial class RestoreSnapshotFromRecycleBinResponse : AmazonWebServiceResponse
    {
        private string _description;
        private bool? _encrypted;
        private string _outpostArn;
        private string _ownerId;
        private string _progress;
        private string _snapshotId;
        private SSEType _sseType;
        private DateTime? _startTime;
        private SnapshotState _state;
        private string _volumeId;
        private int? _volumeSize;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description for the snapshot.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Indicates whether the snapshot is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted
        {
            get { return this._encrypted; }
            set { this._encrypted = value; }
        }

        // Check to see if Encrypted property is set
        internal bool IsSetEncrypted()
        {
            return this._encrypted.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The ARN of the Outpost on which the snapshot is stored. For more information, see
        /// <a href="https://docs.aws.amazon.com/ebs/latest/userguide/snapshots-outposts.html">Amazon
        /// EBS local snapshots on Outposts</a> in the <i>Amazon EBS User Guide</i>.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the EBS snapshot.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The progress of the snapshot, as a percentage.
        /// </para>
        /// </summary>
        public string Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        public string SnapshotId
        {
            get { return this._snapshotId; }
            set { this._snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this._snapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property SseType. 
        /// <para>
        /// Reserved for future use.
        /// </para>
        /// </summary>
        public SSEType SseType
        {
            get { return this._sseType; }
            set { this._sseType = value; }
        }

        // Check to see if SseType property is set
        internal bool IsSetSseType()
        {
            return this._sseType != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time stamp when the snapshot was initiated.
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the snapshot.
        /// </para>
        /// </summary>
        public SnapshotState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that was used to create the snapshot.
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

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        public int? VolumeSize
        {
            get { return this._volumeSize; }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

    }
}