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
    /// Describes a WorkSpace.
    /// </summary>
    public partial class Workspace
    {
        private string _bundleId;
        private string _computerName;
        private DataReplicationSettings _dataReplicationSettings;
        private string _directoryId;
        private string _errorCode;
        private string _errorMessage;
        private string _ipAddress;
        private List<ModificationState> _modificationStates = AWSConfigs.InitializeCollections ? new List<ModificationState>() : null;
        private List<RelatedWorkspaceProperties> _relatedWorkspaces = AWSConfigs.InitializeCollections ? new List<RelatedWorkspaceProperties>() : null;
        private bool? _rootVolumeEncryptionEnabled;
        private List<StandbyWorkspacesProperties> _standbyWorkspacesProperties = AWSConfigs.InitializeCollections ? new List<StandbyWorkspacesProperties>() : null;
        private WorkspaceState _state;
        private string _subnetId;
        private string _userName;
        private bool? _userVolumeEncryptionEnabled;
        private string _volumeEncryptionKey;
        private string _workspaceId;
        private string _workspaceName;
        private WorkspaceProperties _workspaceProperties;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle used to create the WorkSpace.
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
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The name of the WorkSpace, as seen by the operating system. The format of this name
        /// varies. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/launch-workspaces-tutorials.html">
        /// Launch a WorkSpace</a>. 
        /// </para>
        /// </summary>
        public string ComputerName
        {
            get { return this._computerName; }
            set { this._computerName = value; }
        }

        // Check to see if ComputerName property is set
        internal bool IsSetComputerName()
        {
            return this._computerName != null;
        }

        /// <summary>
        /// Gets and sets the property DataReplicationSettings. 
        /// <para>
        /// Indicates the settings of the data replication.
        /// </para>
        /// </summary>
        public DataReplicationSettings DataReplicationSettings
        {
            get { return this._dataReplicationSettings; }
            set { this._dataReplicationSettings = value; }
        }

        // Check to see if DataReplicationSettings property is set
        internal bool IsSetDataReplicationSettings()
        {
            return this._dataReplicationSettings != null;
        }

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Directory Service directory for the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=10, Max=65)]
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
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that is returned if the WorkSpace cannot be created.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The text of the error message that is returned if the WorkSpace cannot be created.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the WorkSpace.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ModificationStates. 
        /// <para>
        /// The modification states of the WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModificationState> ModificationStates
        {
            get { return this._modificationStates; }
            set { this._modificationStates = value; }
        }

        // Check to see if ModificationStates property is set
        internal bool IsSetModificationStates()
        {
            return this._modificationStates != null && (this._modificationStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RelatedWorkspaces. 
        /// <para>
        /// The standby WorkSpace or primary WorkSpace related to the specified WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedWorkspaceProperties> RelatedWorkspaces
        {
            get { return this._relatedWorkspaces; }
            set { this._relatedWorkspaces = value; }
        }

        // Check to see if RelatedWorkspaces property is set
        internal bool IsSetRelatedWorkspaces()
        {
            return this._relatedWorkspaces != null && (this._relatedWorkspaces.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// Gets and sets the property StandbyWorkspacesProperties. 
        /// <para>
        /// The properties of the standby WorkSpace
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StandbyWorkspacesProperties> StandbyWorkspacesProperties
        {
            get { return this._standbyWorkspacesProperties; }
            set { this._standbyWorkspacesProperties = value; }
        }

        // Check to see if StandbyWorkspacesProperties property is set
        internal bool IsSetStandbyWorkspacesProperties()
        {
            return this._standbyWorkspacesProperties != null && (this._standbyWorkspacesProperties.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The operational state of the WorkSpace.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PENDING</c> – The WorkSpace is in a waiting state (for example, the WorkSpace
        /// is being created).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>AVAILABLE</c> – The WorkSpace is running and has passed the health checks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>IMPAIRED</c> – Refer to <c>UNHEALTHY</c> state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNHEALTHY</c> – The WorkSpace is not responding to health checks.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REBOOTING</c> – The WorkSpace is being rebooted (restarted).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTING</c> – The WorkSpace is starting up and health checks are being run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REBUILDING</c> – The WorkSpace is being rebuilt.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RESTORING</c> – The WorkSpace is being restored.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAINTENANCE</c> – The WorkSpace is undergoing scheduled maintenance by Amazon
        /// Web Services.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADMIN_MAINTENANCE</c> – The WorkSpace is undergoing maintenance by the WorkSpaces
        /// administrator.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATING</c> – The WorkSpace is being deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TERMINATED</c> – The WorkSpace has been deleted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SUSPENDED</c> – The WorkSpace has been suspended for image creation.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UPDATING</c> – The WorkSpace is undergoing an update.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPING</c> – The WorkSpace is being stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STOPPED</c> – The WorkSpace has been stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ERROR </c> – The WorkSpace is an error state (for example, an error occurred during
        /// startup).
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// After a WorkSpace is terminated, the <c>TERMINATED</c> state is returned only briefly
        /// before the WorkSpace directory metadata is cleaned up, so this state is rarely returned.
        /// To confirm that a WorkSpace is terminated, check for the WorkSpace ID by using <a
        /// href="https://docs.aws.amazon.com/workspaces/latest/api/API_DescribeWorkspaces.html">
        /// DescribeWorkSpaces</a>. If the WorkSpace ID isn't returned, then the WorkSpace has
        /// been successfully terminated.
        /// </para>
        ///  </note>
        /// </summary>
        public WorkspaceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet for the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=15, Max=24)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user for the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the WorkSpace.
        /// </para>
        /// </summary>
        public string WorkspaceId
        {
            get { return this._workspaceId; }
            set { this._workspaceId = value; }
        }

        // Check to see if WorkspaceId property is set
        internal bool IsSetWorkspaceId()
        {
            return this._workspaceId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the user-decoupled WorkSpace.
        /// </para>
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
        /// The properties of the WorkSpace.
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