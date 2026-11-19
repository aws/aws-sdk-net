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
    /// Information about a root volume replacement task.
    /// </summary>
    public partial class ReplaceRootVolumeTask
    {
        /// <summary>
        /// Gets and sets the property CompleteTime. 
        /// <para>
        /// The time the task completed.
        /// </para>
        /// </summary>
        public string CompleteTime { get; set; }

        /// <summary>
        /// Checks to see if the CompleteTime property is set.
        /// </summary>
        internal bool IsSetCompleteTime() => this.CompleteTime != null;

        /// <summary>
        /// Gets and sets the property DeleteReplacedRootVolume. 
        /// <para>
        /// Indicates whether the original root volume is to be deleted after the root volume
        /// replacement task completes.
        /// </para>
        /// </summary>
        public bool? DeleteReplacedRootVolume { get; set; }

        /// <summary>
        /// Checks to see if the DeleteReplacedRootVolume property is set.
        /// </summary>
        internal bool IsSetDeleteReplacedRootVolume() => this.DeleteReplacedRootVolume.HasValue;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI used to create the replacement root volume.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance for which the root volume replacement task was created.
        /// </para>
        /// </summary>
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ReplaceRootVolumeTaskId. 
        /// <para>
        /// The ID of the root volume replacement task.
        /// </para>
        /// </summary>
        public string ReplaceRootVolumeTaskId { get; set; }

        /// <summary>
        /// Checks to see if the ReplaceRootVolumeTaskId property is set.
        /// </summary>
        internal bool IsSetReplaceRootVolumeTaskId() => this.ReplaceRootVolumeTaskId != null;

        /// <summary>
        /// Gets and sets the property SnapshotId. 
        /// <para>
        /// The ID of the snapshot used to create the replacement root volume.
        /// </para>
        /// </summary>
        public string SnapshotId { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotId property is set.
        /// </summary>
        internal bool IsSetSnapshotId() => this.SnapshotId != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The time the task was started.
        /// </para>
        /// </summary>
        public string StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public ReplaceRootVolumeTaskState TaskState { get; set; }

        /// <summary>
        /// Checks to see if the TaskState property is set.
        /// </summary>
        internal bool IsSetTaskState() => this.TaskState != null;
    }
}
