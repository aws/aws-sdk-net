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
    /// Describes an Amazon FSx for NetApp ONTAP storage virtual machine (SVM) peer relationship.
    /// </summary>
    public partial class StorageVirtualMachinePeer
    {
        /// <summary>
        /// Gets and sets the property Applications. 
        /// <para>
        /// The applications that the SVM peer relationship authorizes. The applications can be
        /// one or more of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SNAPMIRROR</c> – SnapMirror replication.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FILE_COPY</c> – File copy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>LUN_COPY</c> – LUN copy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FLEXCACHE</c> – FlexCache.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 4)]
        public List<string> Applications { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Applications property is set.
        /// </summary>
        internal bool IsSetApplications() => this.Applications != null && (this.Applications.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// The lifecycle status of the SVM peer can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> – The SVM peer is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> – Amazon FSx is creating the SVM peer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> – Amazon FSx is deleting the SVM peer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> – Amazon FSx was unable to create the SVM peer.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageVirtualMachinePeerLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason. 
        /// <para>
        /// The reason why the SVM peer lifecycle status changed.
        /// </para>
        /// </summary>
        public LifecycleTransitionReason LifecycleTransitionReason { get; set; }

        /// <summary>
        /// Checks to see if the LifecycleTransitionReason property is set.
        /// </summary>
        internal bool IsSetLifecycleTransitionReason() => this.LifecycleTransitionReason != null;

        /// <summary>
        /// Gets and sets the property PeerClusterName. 
        /// <para>
        /// The name of the peer cluster that the peer SVM is on.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 44)]
        public string PeerClusterName { get; set; }

        /// <summary>
        /// Checks to see if the PeerClusterName property is set.
        /// </summary>
        internal bool IsSetPeerClusterName() => this.PeerClusterName != null;

        /// <summary>
        /// Gets and sets the property PeerSvmAlias. 
        /// <para>
        /// The name that the local cluster uses to identify the peer SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 41)]
        public string PeerSvmAlias { get; set; }

        /// <summary>
        /// Checks to see if the PeerSvmAlias property is set.
        /// </summary>
        internal bool IsSetPeerSvmAlias() => this.PeerSvmAlias != null;

        /// <summary>
        /// Gets and sets the property PeerSvmName. 
        /// <para>
        /// The name of the SVM on the peer cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string PeerSvmName { get; set; }

        /// <summary>
        /// Checks to see if the PeerSvmName property is set.
        /// </summary>
        internal bool IsSetPeerSvmName() => this.PeerSvmName != null;

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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the SVM peer relationship in ONTAP can be one of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PEERED</c> – The SVM peer relationship is established.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INITIATED</c> – The local cluster sent a peering request to the peer SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> – A peering request from the peer SVM is waiting for acceptance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INITIALIZING</c> – ONTAP is setting up the SVM peer relationship.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c> – The SVM peer relationship is suspended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REJECTED</c> – The peering request was rejected.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageVirtualMachinePeerState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// The ID of the SVM on the file system that the SVM peer relationship belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string StorageVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineId() => this.StorageVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachinePeerId. 
        /// <para>
        /// The system-generated, unique ID of the SVM peer.
        /// </para>
        /// </summary>
        public string StorageVirtualMachinePeerId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachinePeerId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachinePeerId() => this.StorageVirtualMachinePeerId != null;

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
        /// Gets and sets the property UUID. 
        /// <para>
        /// The SVM peer's universally unique identifier (UUID).
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
