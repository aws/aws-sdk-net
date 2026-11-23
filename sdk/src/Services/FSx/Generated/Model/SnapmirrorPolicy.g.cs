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
    /// Describes an Amazon FSx for NetApp ONTAP SnapMirror policy.
    /// </summary>
    public partial class SnapmirrorPolicy
    {
        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// The globally unique ID of the file system, assigned by Amazon FSx.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// The lifecycle status of the SnapMirror policy can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> – The SnapMirror policy is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> – Amazon FSx is creating the SnapMirror policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – Amazon FSx is deleting the SnapMirror policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Amazon FSx was unable to create the SnapMirror policy.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapmirrorPolicyLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason. 
        /// <para>
        /// The reason why the SnapMirror policy lifecycle status changed.
        /// </para>
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransitionReason property is set.
        /// </summary>
        internal bool IsSetLifecycleTransitionReason() => this.LifecycleTransitionReason != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SnapMirror policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property NetworkCompressionEnabled. 
        /// <para>
        /// Specifies whether SnapMirror compresses data when it transfers the data over the network.
        /// This value defaults to <c>false</c>.
        /// </para>
        /// </summary>
        public bool? NetworkCompressionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the NetworkCompressionEnabled property is set.
        /// </summary>
        internal bool IsSetNetworkCompressionEnabled() => this.NetworkCompressionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceARN.
        /// </summary>
        [AWSProperty(Min = 8, Max = 512)]
        public string ResourceARN { get; set; }

        /// <summary>
        /// Checks to see if the ResourceARN property is set.
        /// </summary>
        internal bool IsSetResourceARN() => this.ResourceARN != null;

        /// <summary>
        /// Gets and sets the property RetentionRules. 
        /// <para>
        /// The rules that determine which snapshots SnapMirror retains on the destination volume.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<SnapmirrorPolicyRetentionRule> RetentionRules { get; set; } = AWSConfigs.InitializeCollections ? new List<SnapmirrorPolicyRetentionRule>() : null;

        /// <summary>
        /// Checks to see if the RetentionRules property is set.
        /// </summary>
        internal bool IsSetRetentionRules() => this.RetentionRules != null && (this.RetentionRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope of the SnapMirror policy can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>FILESYSTEM</c> – The SnapMirror policy was created on the file system.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SVM</c> – The SnapMirror policy was created on an SVM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SnapmirrorPolicyScope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SnapmirrorPolicyId. 
        /// <para>
        /// The system-generated, unique ID of the SnapMirror policy.
        /// </para>
        /// </summary>
        public string SnapmirrorPolicyId { get; set; }

        /// <summary>
        /// Checks to see if the SnapmirrorPolicyId property is set.
        /// </summary>
        internal bool IsSetSnapmirrorPolicyId() => this.SnapmirrorPolicyId != null;

        /// <summary>
        /// Gets and sets the property SnapshotCopyMode. 
        /// <para>
        /// The snapshot copy mode of the SnapMirror policy, which determines which snapshots
        /// SnapMirror transfers to the destination volume.
        /// </para>
        /// </summary>
        public SnapmirrorPolicySnapshotCopyMode SnapshotCopyMode { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCopyMode property is set.
        /// </summary>
        internal bool IsSetSnapshotCopyMode() => this.SnapshotCopyMode != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// The ID of the SnapMirror policy's storage virtual machine, if you created the SnapMirror
        /// policy on a storage virtual machine.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string StorageVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineId() => this.StorageVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property Tags.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ThrottleInKbps. 
        /// <para>
        /// The maximum bandwidth, in kilobytes per second (KBps), that SnapMirror uses to transfer
        /// data. A value of <c>0</c> means that the bandwidth is unlimited.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ThrottleInKbps { get; set; }

        /// <summary>
        /// Checks to see if the ThrottleInKbps property is set.
        /// </summary>
        internal bool IsSetThrottleInKbps() => this.ThrottleInKbps.HasValue;

        /// <summary>
        /// Gets and sets the property TransferSchedule. 
        /// <para>
        /// The name of the ONTAP schedule that determines when SnapMirror transfers data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TransferSchedule { get; set; }

        /// <summary>
        /// Checks to see if the TransferSchedule property is set.
        /// </summary>
        internal bool IsSetTransferSchedule() => this.TransferSchedule != null;

        /// <summary>
        /// Gets and sets the property UUID. 
        /// <para>
        /// The SnapMirror policy's universally unique identifier (UUID).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 36)]
        public string UUID { get; set; }

        /// <summary>
        /// Checks to see if the UUID property is set.
        /// </summary>
        internal bool IsSetUUID() => this.UUID != null;
    }
}
