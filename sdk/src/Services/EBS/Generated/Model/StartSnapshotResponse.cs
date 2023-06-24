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
 * Do not modify this file. This file is generated from the ebs-2019-11-02.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EBS.Model
{
    /// <summary>
    /// This is the response object from the StartSnapshot operation.
    /// </summary>
    public partial class StartSnapshotResponse : AmazonWebServiceResponse
    {
        private int? _blockSize;
        private string _description;
        private string _kmsKeyArn;
        private string _ownerId;
        private string _parentSnapshotId;
        private string _snapshotId;
        private DateTime? _startTime;
        private Status _status;
        private List<Tag> _tags = new List<Tag>();
        private long? _volumeSize;

        /// <summary>
        /// Gets and sets the property BlockSize. 
        /// <para>
        /// The size of the blocks in the snapshot, in bytes.
        /// </para>
        /// </summary>
        public int BlockSize
        {
            get { return this._blockSize.GetValueOrDefault(); }
            set { this._blockSize = value; }
        }

        // Check to see if BlockSize property is set
        internal bool IsSetBlockSize()
        {
            return this._blockSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Key Management Service (KMS) key used to encrypt
        /// the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the snapshot owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=24)]
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
        /// Gets and sets the property ParentSnapshotId. 
        /// <para>
        /// The ID of the parent snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ParentSnapshotId
        {
            get { return this._parentSnapshotId; }
            set { this._parentSnapshotId = value; }
        }

        // Check to see if ParentSnapshotId property is set
        internal bool IsSetParentSnapshotId()
        {
            return this._parentSnapshotId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The timestamp when the snapshot was created.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Max=32)]
        public Status Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags applied to the snapshot. You can specify up to 50 tags per snapshot. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">
        /// Tagging your Amazon EC2 resources</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VolumeSize. 
        /// <para>
        /// The size of the volume, in GiB.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long VolumeSize
        {
            get { return this._volumeSize.GetValueOrDefault(); }
            set { this._volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this._volumeSize.HasValue; 
        }

    }
}