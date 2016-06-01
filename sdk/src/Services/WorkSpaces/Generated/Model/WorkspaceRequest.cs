/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Contains information about a WorkSpace creation request.
    /// </summary>
    public partial class WorkspaceRequest
    {
        private string _bundleId;
        private string _directoryId;
        private bool? _rootVolumeEncryptionEnabled;
        private List<Tag> _tags = new List<Tag>();
        private string _userName;
        private bool? _userVolumeEncryptionEnabled;
        private string _volumeEncryptionKey;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle to create the WorkSpace from. You can use the <a>DescribeWorkspaceBundles</a>
        /// operation to obtain a list of the bundles that are available.
        /// </para>
        /// </summary>
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
        /// The identifier of the AWS Directory Service directory to create the WorkSpace in.
        /// You can use the <a>DescribeWorkspaceDirectories</a> operation to obtain a list of
        /// the directories that are available.
        /// </para>
        /// </summary>
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
        /// Specifies whether the data stored on the root volume, or C: drive, is encrypted.
        /// </para>
        /// </summary>
        public bool RootVolumeEncryptionEnabled
        {
            get { return this._rootVolumeEncryptionEnabled.GetValueOrDefault(); }
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
        /// The tags of the WorkSpace request.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The username that the WorkSpace is assigned to. This username must exist in the AWS
        /// Directory Service directory specified by the <code>DirectoryId</code> member.
        /// </para>
        /// </summary>
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
        /// Specifies whether the data stored on the user volume, or D: drive, is encrypted.
        /// </para>
        /// </summary>
        public bool UserVolumeEncryptionEnabled
        {
            get { return this._userVolumeEncryptionEnabled.GetValueOrDefault(); }
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
        /// The KMS key used to encrypt data stored on your WorkSpace.
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

    }
}