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
 * Do not modify this file. This file is generated from the workspaces-2015-04-08.normal.json service model.
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
namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes the information used to create a WorkSpace.
    /// </summary>
    public partial class WorkspaceRequest
    {
        private string _bundleId;
        private string _directoryId;
        private bool? _rootVolumeEncryptionEnabled;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _userName;
        private bool? _userVolumeEncryptionEnabled;
        private string _volumeEncryptionKey;
        private string _workspaceName;
        private WorkspaceProperties _workspaceProperties;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle for the WorkSpace. You can use <a>DescribeWorkspaceBundles</a>
        /// to list the available bundles.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Directory Service directory for the WorkSpace. You can use <a>DescribeWorkspaceDirectories</a>
        /// to list the available directories.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=65)]
        public string DirectoryId
        {
            get { return this._directoryId; }
            set { this._directoryId = value; }
        }

        // Check to see if DirectoryId property is set
        internal bool IsSetDirectoryId()
        {
            return this._directoryId != null;
        }

        /// <summary>
        /// Gets and sets the property RootVolumeEncryptionEnabled. 
        /// <para>
        /// Indicates whether the data stored on the root volume is encrypted.
        /// </para>
        /// </summary>
        public bool? RootVolumeEncryptionEnabled
        {
            get { return this._rootVolumeEncryptionEnabled; }
            set { this._rootVolumeEncryptionEnabled = value; }
        }

        // Check to see if RootVolumeEncryptionEnabled property is set
        internal bool IsSetRootVolumeEncryptionEnabled()
        {
            return this._rootVolumeEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the WorkSpace.
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user name of the user for the WorkSpace. This user name must exist in the Directory
        /// Service directory for the WorkSpace.
        /// </para>
        ///  
        /// <para>
        /// The username is not case-sensitive, but we recommend matching the case in the Directory
        /// Service directory to avoid potential incompatibilities.
        /// </para>
        ///  
        /// <para>
        /// The reserved keyword, <c>[UNDEFINED]</c>, is used when creating user-decoupled WorkSpaces.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

        /// <summary>
        /// Gets and sets the property UserVolumeEncryptionEnabled. 
        /// <para>
        /// Indicates whether the data stored on the user volume is encrypted.
        /// </para>
        /// </summary>
        public bool? UserVolumeEncryptionEnabled
        {
            get { return this._userVolumeEncryptionEnabled; }
            set { this._userVolumeEncryptionEnabled = value; }
        }

        // Check to see if UserVolumeEncryptionEnabled property is set
        internal bool IsSetUserVolumeEncryptionEnabled()
        {
            return this._userVolumeEncryptionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VolumeEncryptionKey. 
        /// <para>
        /// The ARN of the symmetric KMS key used to encrypt data stored on your WorkSpace. Amazon
        /// WorkSpaces does not support asymmetric KMS keys.
        /// </para>
        /// </summary>
        public string VolumeEncryptionKey
        {
            get { return this._volumeEncryptionKey; }
            set { this._volumeEncryptionKey = value; }
        }

        // Check to see if VolumeEncryptionKey property is set
        internal bool IsSetVolumeEncryptionKey()
        {
            return this._volumeEncryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the user-decoupled WorkSpace.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>WorkspaceName</c> is required if <c>UserName</c> is <c>[UNDEFINED]</c> for user-decoupled
        /// WorkSpaces. <c>WorkspaceName</c> is not applicable if <c>UserName</c> is specified
        /// for user-assigned WorkSpaces.
        /// </para>
        ///  </note>
        /// </summary>
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceProperties. 
        /// <para>
        /// The WorkSpace properties.
        /// </para>
        /// </summary>
        public WorkspaceProperties WorkspaceProperties
        {
            get { return this._workspaceProperties; }
            set { this._workspaceProperties = value; }
        }

        // Check to see if WorkspaceProperties property is set
        internal bool IsSetWorkspaceProperties()
        {
            return this._workspaceProperties != null;
        }

    }
}