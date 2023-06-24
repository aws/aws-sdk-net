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
 * Do not modify this file. This file is generated from the fsx-2018-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FSx.Model
{
    /// <summary>
    /// A snapshot of an Amazon FSx for OpenZFS volume.
    /// </summary>
    public partial class Snapshot
    {
        private List<AdministrativeAction> _administrativeActions = new List<AdministrativeAction>();
        private DateTime? _creationTime;
        private SnapshotLifecycle _lifecycle;
        private LifecycleTransitionReason _lifecycleTransitionReason;
        private string _name;
        private string _resourceARN;
        private string _snapshotId;
        private List<Tag> _tags = new List<Tag>();
        private string _volumeId;

        /// <summary>
        /// Gets and sets the property AdministrativeActions. 
        /// <para>
        /// A list of administrative actions for the file system that are in process or waiting
        /// to be processed. Administrative actions describe changes to the Amazon FSx system.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<AdministrativeAction> AdministrativeActions
        {
            get { return this._administrativeActions; }
            set { this._administrativeActions = value; }
        }

        // Check to see if AdministrativeActions property is set
        internal bool IsSetAdministrativeActions()
        {
            return this._administrativeActions != null && this._administrativeActions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the snapshot.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>PENDING</code> - Amazon FSx hasn't started creating the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATING</code> - Amazon FSx is creating the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - Amazon FSx is deleting the snapshot.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>AVAILABLE</code> - The snapshot is fully available.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapshotLifecycle Lifecycle
        {
            get { return this._lifecycle; }
            set { this._lifecycle = value; }
        }

        // Check to see if Lifecycle property is set
        internal bool IsSetLifecycle()
        {
            return this._lifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason.
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason
        {
            get { return this._lifecycleTransitionReason; }
            set { this._lifecycleTransitionReason = value; }
        }

        // Check to see if LifecycleTransitionReason property is set
        internal bool IsSetLifecycleTransitionReason()
        {
            return this._lifecycleTransitionReason != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=203)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min=8, Max=512)]
        public string ResourceARN
        {
            get { return this._resourceARN; }
            set { this._resourceARN = value; }
        }

        // Check to see if ResourceARN property is set
        internal bool IsSetResourceARN()
        {
            return this._resourceARN != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=28)]
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
        /// Gets and sets the property Tags.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property VolumeId. 
        /// <para>
        /// The ID of the volume that the snapshot is of.
        /// </para>
        /// </summary>
        [AWSProperty(Min=23, Max=23)]
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