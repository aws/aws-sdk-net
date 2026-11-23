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
    /// Container for the parameters to the CreateSnapmirrorPolicy operation. Creates a SnapMirror
    /// policy for an Amazon FSx for NetApp ONTAP file system or storage virtual machine (SVM).
    /// A SnapMirror policy defines how the SnapMirror relationships that use the policy replicate
    /// data, including which snapshots to transfer, the maximum number of snapshots to retain
    /// on the destination volume, and when to transfer data. <para> The <c>CreateSnapmirrorPolicy</c>
    /// operation returns while the SnapMirror policy's lifecycle state is still <c>CREATING</c>.
    /// You can check the SnapMirror policy creation status by calling the DescribeSnapmirrorPolicies
    /// operation. </para>
    /// </summary>
    public partial class CreateSnapmirrorPolicyRequest : AmazonFSxRequest
    {
        /// <summary>
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property FileSystemId. 
        /// <para>
        /// Specifies the ID of the Amazon FSx for NetApp ONTAP file system on which to create
        /// the SnapMirror policy. You must specify either a <c>FileSystemId</c> or a <c>StorageVirtualMachineId</c>,
        /// but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 21)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// Checks to see if the FileSystemId property is set.
        /// </summary>
        internal bool IsSetFileSystemId() => this.FileSystemId != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Specifies the name of the SnapMirror policy.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
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
        /// Gets and sets the property RetentionRules. 
        /// <para>
        /// Specifies the rules that determine which snapshots SnapMirror retains on the destination
        /// volume, based on their SnapMirror labels.
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
        /// Gets and sets the property SnapshotCopyMode. 
        /// <para>
        /// Specifies which snapshots SnapMirror transfers to the destination volume:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COPY_ALL_SOURCE_SNAPSHOTS</c> – SnapMirror copies all snapshots of the source
        /// volume to the destination volume on a transfer. You can't specify <c>RetentionRules</c>
        /// along with this property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COPY_LATEST_SOURCE_SNAPSHOT</c> – SnapMirror copies the latest snapshot of the
        /// source volume to the destination volume on a transfer. You can't specify <c>RetentionRules</c>
        /// along with this property.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_CREATE_SNAPSHOT_ON_SOURCE</c> – SnapMirror doesn't create a snapshot on the
        /// source volume at beginning of an update or resync operation. You must specify <c>RetentionRules</c>
        /// along with this property.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you don't specify a <c>SnapshotCopyMode</c>, SnapMirror creates a new snapshot
        /// of the source volume and copies it, along with any snapshots that match <c>RetentionRules</c>,
        /// to the destination volume on a transfer. <c>RetentionRules</c> is optional.
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
        /// Specifies the ID of the SVM on which to create the SnapMirror policy. You must specify
        /// either a <c>FileSystemId</c> or a <c>StorageVirtualMachineId</c>, but not both.
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
        /// Specifies the maximum bandwidth, in kilobytes per second (KBps), that SnapMirror uses
        /// to transfer data. A value of <c>0</c> means that the bandwidth is unlimited.
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
        /// Specifies the name of the ONTAP schedule that determines when SnapMirror transfers
        /// data.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TransferSchedule { get; set; }

        /// <summary>
        /// Checks to see if the TransferSchedule property is set.
        /// </summary>
        internal bool IsSetTransferSchedule() => this.TransferSchedule != null;
    }
}
