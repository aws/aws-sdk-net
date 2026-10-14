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
    /// Describes the Amazon FSx for NetApp ONTAP storage virtual machine (SVM) configuration.
    /// </summary>
    public partial class StorageVirtualMachine
    {
        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfiguration. 
        /// <para>
        /// Describes the Microsoft Active Directory configuration to which the SVM is joined,
        /// if applicable.
        /// </para>
        /// </summary>
        public SvmActiveDirectoryConfiguration ActiveDirectoryConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryConfiguration property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryConfiguration() => this.ActiveDirectoryConfiguration != null;

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The endpoints that are used to access data or to manage the SVM using the NetApp ONTAP
        /// CLI, REST API, or NetApp CloudManager. They are the <c>Iscsi</c>, <c>Management</c>,
        /// <c>Nfs</c>, and <c>Smb</c> endpoints.
        /// </para>
        /// </summary>
        public SvmEndpoints Endpoints { get; set; }

        /// <summary>
        /// Checks to see if the Endpoints property is set.
        /// </summary>
        internal bool IsSetEndpoints() => this.Endpoints != null;

        /// <summary>
        /// Gets and sets the property FileSystemId.
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
        /// Describes the SVM's lifecycle status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATED</c> - The SVM is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATING</c> - Amazon FSx is creating the new SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETING</c> - Amazon FSx is deleting an existing SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - Amazon FSx was unable to create the SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MISCONFIGURED</c> - The SVM is in a failed but recoverable state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PENDING</c> - Amazon FSx has not started creating the SVM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageVirtualMachineLifecycle Lifecycle { get; set; }

        /// <summary>
        /// Checks to see if the Lifecycle property is set.
        /// </summary>
        internal bool IsSetLifecycle() => this.Lifecycle != null;

        /// <summary>
        /// Gets and sets the property LifecycleTransitionReason. 
        /// <para>
        /// Describes why the SVM lifecycle state changed.
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
        /// The name of the SVM, if provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 47)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

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
        /// Gets and sets the property RootVolumeSecurityStyle. 
        /// <para>
        /// The security style of the root volume of the SVM.
        /// </para>
        /// </summary>
        public StorageVirtualMachineRootVolumeSecurityStyle RootVolumeSecurityStyle { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeSecurityStyle property is set.
        /// </summary>
        internal bool IsSetRootVolumeSecurityStyle() => this.RootVolumeSecurityStyle != null;

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// The SVM's system generated unique ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 21, Max = 21)]
        public string StorageVirtualMachineId { get; set; }

        /// <summary>
        /// Checks to see if the StorageVirtualMachineId property is set.
        /// </summary>
        internal bool IsSetStorageVirtualMachineId() => this.StorageVirtualMachineId != null;

        /// <summary>
        /// Gets and sets the property Subtype. 
        /// <para>
        /// Describes the SVM's subtype.
        /// </para>
        /// </summary>
        public StorageVirtualMachineSubtype Subtype { get; set; }

        /// <summary>
        /// Checks to see if the Subtype property is set.
        /// </summary>
        internal bool IsSetSubtype() => this.Subtype != null;

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
        /// The SVM's UUID (universally unique identifier).
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
