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
    /// Container for the parameters to the CreateStorageVirtualMachine operation.
    /// Creates a storage virtual machine (SVM) for an Amazon FSx for ONTAP file system.
    /// </summary>
    public partial class CreateStorageVirtualMachineRequest : AmazonFSxRequest
    {
        private CreateSvmActiveDirectoryConfiguration _activeDirectoryConfiguration;
        private string _clientRequestToken;
        private string _fileSystemId;
        private string _name;
        private StorageVirtualMachineRootVolumeSecurityStyle _rootVolumeSecurityStyle;
        private string _svmAdminPassword;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfiguration. 
        /// <para>
        /// Describes the self-managed Microsoft Active Directory to which you want to join the
        /// SVM. Joining an Active Directory provides user authentication and access control for
        /// SMB clients, including Microsoft Windows and macOS client accessing the file system.
        /// </para>
        /// </summary>
        public CreateSvmActiveDirectoryConfiguration ActiveDirectoryConfiguration
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
        /// Gets and sets the property ClientRequestToken.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property FileSystemId.
        /// </summary>
        [AWSProperty(Required=true, Min=11, Max=21)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=47)]
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
        /// Gets and sets the property RootVolumeSecurityStyle. 
        /// <para>
        /// The security style of the root volume of the SVM. Specify one of the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>UNIX</code> if the file system is managed by a UNIX administrator, the majority
        /// of users are NFS clients, and an application accessing the data uses a UNIX user as
        /// the service account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NTFS</code> if the file system is managed by a Windows administrator, the majority
        /// of users are SMB clients, and an application accessing the data uses a Windows user
        /// as the service account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>MIXED</code> if the file system is managed by both UNIX and Windows administrators
        /// and users consist of both NFS and SMB clients.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property SvmAdminPassword. 
        /// <para>
        /// The password to use when managing the SVM using the NetApp ONTAP CLI or REST API.
        /// If you do not specify a password, you can still use the file system's <code>fsxadmin</code>
        /// user to manage the SVM.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=50)]
        public string SvmAdminPassword
        {
            get { return this._svmAdminPassword; }
            set { this._svmAdminPassword = value; }
        }

        // Check to see if SvmAdminPassword property is set
        internal bool IsSetSvmAdminPassword()
        {
            return this._svmAdminPassword != null;
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

    }
}