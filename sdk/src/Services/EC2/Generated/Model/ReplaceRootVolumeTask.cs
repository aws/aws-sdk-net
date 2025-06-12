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
    /// Information about a root volume replacement task.
    /// </summary>
    public partial class ReplaceRootVolumeTask
    {
        private string _completeTime;
        private bool? _deleteReplacedRootVolume;
        private string _imageId;
        private string _instanceId;
        private string _replaceRootVolumeTaskId;
        private string _snapshotId;
        private string _startTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private ReplaceRootVolumeTaskState _taskState;

        /// <summary>
        /// Gets and sets the property CompleteTime. 
        /// <para>
        /// The time the task completed.
        /// </para>
        /// </summary>
        public string CompleteTime
        {
            get { return this._completeTime; }
            set { this._completeTime = value; }
        }

        // Check to see if CompleteTime property is set
        internal bool IsSetCompleteTime()
        {
            return this._completeTime != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteReplacedRootVolume. 
        /// <para>
        /// Indicates whether the original root volume is to be deleted after the root volume
        /// replacement task completes.
        /// </para>
        /// </summary>
        public bool? DeleteReplacedRootVolume
        {
            get { return this._deleteReplacedRootVolume; }
            set { this._deleteReplacedRootVolume = value; }
        }

        // Check to see if DeleteReplacedRootVolume property is set
        internal bool IsSetDeleteReplacedRootVolume()
        {
            return this._deleteReplacedRootVolume.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI used to create the replacement root volume.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance for which the root volume replacement task was created.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property ReplaceRootVolumeTaskId. 
        /// <para>
        /// The ID of the root volume replacement task.
        /// </para>
        /// </summary>
        public string ReplaceRootVolumeTaskId
        {
            get { return this._replaceRootVolumeTaskId; }
            set { this._replaceRootVolumeTaskId = value; }
        }

        // Check to see if ReplaceRootVolumeTaskId property is set
        internal bool IsSetReplaceRootVolumeTaskId()
        {
            return this._replaceRootVolumeTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot used to create the replacement root volume.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the task was started.
        /// </para>
        /// </summary>
        public string StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskState. 
        /// <para>
        /// The state of the task. The task can be in one of the following states:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>pending</c> - the replacement volume is being created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>in-progress</c> - the original volume is being detached and the replacement volume
        /// is being attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>succeeded</c> - the replacement volume has been successfully attached to the instance
        /// and the instance is available.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failing</c> - the replacement task is in the process of failing.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed</c> - the replacement task has failed but the original root volume is still
        /// attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failing-detached</c> - the replacement task is in the process of failing. The
        /// instance might have no root volume attached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>failed-detached</c> - the replacement task has failed and the instance has no
        /// root volume attached.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ReplaceRootVolumeTaskState TaskState
        {
            get { return this._taskState; }
            set { this._taskState = value; }
        }

        // Check to see if TaskState property is set
        internal bool IsSetTaskState()
        {
            return this._taskState != null;
        }

    }
}