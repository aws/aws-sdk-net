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
    /// Describes the Amazon FSx for NetApp ONTAP storage virtual machine (SVM) configuration.
    /// </summary>
    public partial class StorageVirtualMachine
    {
        private SvmActiveDirectoryConfiguration _activeDirectoryConfiguration;
        private DateTime? _creationTime;
        private SvmEndpoints _endpoints;
        private string _fileSystemId;
        private StorageVirtualMachineLifecycle _lifecycle;
        private LifecycleTransitionReason _lifecycleTransitionReason;
        private string _name;
        private string _resourceARN;
        private StorageVirtualMachineRootVolumeSecurityStyle _rootVolumeSecurityStyle;
        private string _storageVirtualMachineId;
        private List<Tag> _tags = new List<Tag>();
        private string _uuid;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfiguration. 
        /// <para>
        /// Describes the Microsoft Active Directory configuration to which the SVM is joined,
        /// if applicable.
        /// </para>
        /// </summary>
        public SvmActiveDirectoryConfiguration ActiveDirectoryConfiguration
        {
            get { return this._activeDirectoryConfiguration; }
            set { this._activeDirectoryConfiguration = value; }
        }

        // Check to see if ActiveDirectoryConfiguration property is set
        internal bool IsSetActiveDirectoryConfiguration()
        {
            return this._activeDirectoryConfiguration != null;
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
        /// Gets and sets the property Endpoints. 
        /// <para>
        /// The endpoints that are used to access data or to manage the SVM using the NetApp ONTAP
        /// CLI, REST API, or NetApp CloudManager. They are the <code>Iscsi</code>, <code>Management</code>,
        /// <code>Nfs</code>, and <code>Smb</code> endpoints.
        /// </para>
        /// </summary>
        public SvmEndpoints Endpoints
        {
            get { return this._endpoints; }
            set { this._endpoints = value; }
        }

        // Check to see if Endpoints property is set
        internal bool IsSetEndpoints()
        {
            return this._endpoints != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId.
        /// </summary>
        [AWSProperty(Min=11, Max=21)]
        public string FileSystemId
        {
            get { return this._fileSystemId; }
            set { this._fileSystemId = value; }
        }

        // Check to see if FileSystemId property is set
        internal bool IsSetFileSystemId()
        {
            return this._fileSystemId != null;
        }

        /// <summary>
        /// Gets and sets the property Lifecycle. 
        /// <para>
        /// Describes the SVM's lifecycle status.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATED</code> - The SVM is fully available for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATING</code> - Amazon FSx is creating the new SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETING</code> - Amazon FSx is deleting an existing SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code> - Amazon FSx was unable to create the SVM.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MISCONFIGURED</code> - The SVM is in a failed but recoverable state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code> - Amazon FSx has not started creating the SVM.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StorageVirtualMachineLifecycle Lifecycle
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
        /// <para>
        /// Describes why the SVM lifecycle state changed.
        /// </para>
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
        /// The name of the SVM, if provisioned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=47)]
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
        /// Gets and sets the property RootVolumeSecurityStyle. 
        /// <para>
        /// The security style of the root volume of the SVM.
        /// </para>
        /// </summary>
        public StorageVirtualMachineRootVolumeSecurityStyle RootVolumeSecurityStyle
        {
            get { return this._rootVolumeSecurityStyle; }
            set { this._rootVolumeSecurityStyle = value; }
        }

        // Check to see if RootVolumeSecurityStyle property is set
        internal bool IsSetRootVolumeSecurityStyle()
        {
            return this._rootVolumeSecurityStyle != null;
        }

        /// <summary>
        /// Gets and sets the property StorageVirtualMachineId. 
        /// <para>
        /// The SVM's system generated unique ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=21)]
        public string StorageVirtualMachineId
        {
            get { return this._storageVirtualMachineId; }
            set { this._storageVirtualMachineId = value; }
        }

        // Check to see if StorageVirtualMachineId property is set
        internal bool IsSetStorageVirtualMachineId()
        {
            return this._storageVirtualMachineId != null;
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
        /// Gets and sets the property UUID. 
        /// <para>
        /// The SVM's UUID (universally unique identifier).
        /// </para>
        /// </summary>
        [AWSProperty(Max=36)]
        public string UUID
        {
            get { return this._uuid; }
            set { this._uuid = value; }
        }

        // Check to see if UUID property is set
        internal bool IsSetUUID()
        {
            return this._uuid != null;
        }

    }
}