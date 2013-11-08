/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> Represents a snapshot of an Amazon EC2 EBS volume. </para>
    /// </summary>
    public class Snapshot
    {
        
        private string snapshotId;
        private string volumeId;
        private SnapshotState state;
        private DateTime? startTime;
        private string progress;
        private string ownerId;
        private string description;
        private int? volumeSize;
        private string ownerAlias;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The unique ID of this snapshot.
        ///  
        /// </summary>
        public string SnapshotId
        {
            get { return this.snapshotId; }
            set { this.snapshotId = value; }
        }

        // Check to see if SnapshotId property is set
        internal bool IsSetSnapshotId()
        {
            return this.snapshotId != null;
        }

        /// <summary>
        /// The ID of the volume from which this snapshot was created.
        ///  
        /// </summary>
        public string VolumeId
        {
            get { return this.volumeId; }
            set { this.volumeId = value; }
        }

        // Check to see if VolumeId property is set
        internal bool IsSetVolumeId()
        {
            return this.volumeId != null;
        }

        /// <summary>
        /// Snapshot state (e.g., pending, completed, or error).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, completed, error</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public SnapshotState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// Time stamp when the snapshot was initiated.
        ///  
        /// </summary>
        public DateTime StartTime
        {
            get { return this.startTime ?? default(DateTime); }
            set { this.startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this.startTime.HasValue;
        }

        /// <summary>
        /// The progress of the snapshot, in percentage.
        ///  
        /// </summary>
        public string Progress
        {
            get { return this.progress; }
            set { this.progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this.progress != null;
        }

        /// <summary>
        /// AWS Access Key ID of the user who owns the snapshot.
        ///  
        /// </summary>
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }

        /// <summary>
        /// Description of the snapshot.
        ///  
        /// </summary>
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }

        /// <summary>
        /// The size of the volume, in gigabytes.
        ///  
        /// </summary>
        public int VolumeSize
        {
            get { return this.volumeSize ?? default(int); }
            set { this.volumeSize = value; }
        }

        // Check to see if VolumeSize property is set
        internal bool IsSetVolumeSize()
        {
            return this.volumeSize.HasValue;
        }

        /// <summary>
        /// The AWS account alias (e.g., "amazon", "redhat", "self", etc.) or AWS account ID that owns the AMI.
        ///  
        /// </summary>
        public string OwnerAlias
        {
            get { return this.ownerAlias; }
            set { this.ownerAlias = value; }
        }

        // Check to see if OwnerAlias property is set
        internal bool IsSetOwnerAlias()
        {
            return this.ownerAlias != null;
        }

        /// <summary>
        /// A list of tags for the Snapshot.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }
    }
}
