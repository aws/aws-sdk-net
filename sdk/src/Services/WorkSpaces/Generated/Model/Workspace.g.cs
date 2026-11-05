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

namespace Amazon.WorkSpaces.Model
{
    /// <summary>
    /// Describes a WorkSpace.
    /// </summary>
    public partial class Workspace
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle used to create the WorkSpace.
        /// </para>
        /// </summary>
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property ComputerName. 
        /// <para>
        /// The name of the WorkSpace, as seen by the operating system. The format of this name
        /// varies. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/launch-workspaces-tutorials.html">
        /// Launch a WorkSpace</a>. 
        /// </para>
        /// </summary>
        public string ComputerName { get; set; }

        /// <summary>
        /// Checks to see if the ComputerName property is set.
        /// </summary>
        internal bool IsSetComputerName() => this.ComputerName != null;

        /// <summary>
        /// Gets and sets the property DataReplicationSettings. 
        /// <para>
        /// Indicates the settings of the data replication.
        /// </para>
        /// </summary>
        public DataReplicationSettings DataReplicationSettings { get; set; }

        /// <summary>
        /// Checks to see if the DataReplicationSettings property is set.
        /// </summary>
        internal bool IsSetDataReplicationSettings() => this.DataReplicationSettings != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Directory Service directory for the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// The error code that is returned if the WorkSpace cannot be created.
        /// </para>
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// Checks to see if the ErrorCode property is set.
        /// </summary>
        internal bool IsSetErrorCode() => this.ErrorCode != null;

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The text of the error message that is returned if the WorkSpace cannot be created.
        /// </para>
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Checks to see if the ErrorMessage property is set.
        /// </summary>
        internal bool IsSetErrorMessage() => this.ErrorMessage != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the WorkSpace.
        /// </para>
        /// </summary>
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address of the WorkSpace.
        /// </para>
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

        /// <summary>
        /// Gets and sets the property ModificationStates. 
        /// <para>
        /// The modification states of the WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ModificationState> ModificationStates { get; set; } = AWSConfigs.InitializeCollections ? new List<ModificationState>() : null;

        /// <summary>
        /// Checks to see if the ModificationStates property is set.
        /// </summary>
        internal bool IsSetModificationStates() => this.ModificationStates != null && (this.ModificationStates.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RelatedWorkspaces. 
        /// <para>
        /// The standby WorkSpace or primary WorkSpace related to the specified WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RelatedWorkspaceProperties> RelatedWorkspaces { get; set; } = AWSConfigs.InitializeCollections ? new List<RelatedWorkspaceProperties>() : null;

        /// <summary>
        /// Checks to see if the RelatedWorkspaces property is set.
        /// </summary>
        internal bool IsSetRelatedWorkspaces() => this.RelatedWorkspaces != null && (this.RelatedWorkspaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RootVolumeEncryptionEnabled. 
        /// <para>
        /// Indicates whether the data stored on the root volume is encrypted.
        /// </para>
        /// </summary>
        public bool? RootVolumeEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RootVolumeEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetRootVolumeEncryptionEnabled() => this.RootVolumeEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property StandbyWorkspacesProperties. 
        /// <para>
        /// The properties of the standby WorkSpace
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<StandbyWorkspacesProperties> StandbyWorkspacesProperties { get; set; } = AWSConfigs.InitializeCollections ? new List<StandbyWorkspacesProperties>() : null;

        /// <summary>
        /// Checks to see if the StandbyWorkspacesProperties property is set.
        /// </summary>
        internal bool IsSetStandbyWorkspacesProperties() => this.StandbyWorkspacesProperties != null && (this.StandbyWorkspacesProperties.Count > 0 || !AWSConfigs.InitializeCollections);

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
        public WorkspaceState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet for the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 15, Max = 24)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// The user for the WorkSpace.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string UserName { get; set; }

        /// <summary>
        /// Checks to see if the UserName property is set.
        /// </summary>
        internal bool IsSetUserName() => this.UserName != null;

        /// <summary>
        /// Gets and sets the property UserVolumeEncryptionEnabled. 
        /// <para>
        /// Indicates whether the data stored on the user volume is encrypted.
        /// </para>
        /// </summary>
        public bool? UserVolumeEncryptionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the UserVolumeEncryptionEnabled property is set.
        /// </summary>
        internal bool IsSetUserVolumeEncryptionEnabled() => this.UserVolumeEncryptionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property VolumeEncryptionKey. 
        /// <para>
        /// The ARN of the symmetric KMS key used to encrypt data stored on your WorkSpace. Amazon
        /// WorkSpaces does not support asymmetric KMS keys.
        /// </para>
        /// </summary>
        public string VolumeEncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the VolumeEncryptionKey property is set.
        /// </summary>
        internal bool IsSetVolumeEncryptionKey() => this.VolumeEncryptionKey != null;

        /// <summary>
        /// Gets and sets the property WorkspaceId. 
        /// <para>
        /// The identifier of the WorkSpace.
        /// </para>
        /// </summary>
        public string WorkspaceId { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceId property is set.
        /// </summary>
        internal bool IsSetWorkspaceId() => this.WorkspaceId != null;

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the user-decoupled WorkSpace.
        /// </para>
        /// </summary>
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceProperties. 
        /// <para>
        /// The properties of the WorkSpace.
        /// </para>
        /// </summary>
        public WorkspaceProperties WorkspaceProperties { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceProperties property is set.
        /// </summary>
        internal bool IsSetWorkspaceProperties() => this.WorkspaceProperties != null;
    }
}
