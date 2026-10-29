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
    /// Describes the information used to create a WorkSpace.
    /// </summary>
    public partial class WorkspaceRequest
    {
        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The identifier of the bundle for the WorkSpace. You can use <a>DescribeWorkspaceBundles</a>
        /// to list the available bundles.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BundleId { get; set; }

        /// <summary>
        /// Checks to see if the BundleId property is set.
        /// </summary>
        internal bool IsSetBundleId() => this.BundleId != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the Directory Service directory for the WorkSpace. You can use <a>DescribeWorkspaceDirectories</a>
        /// to list the available directories.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address for the WorkSpace.
        /// </para>
        /// </summary>
        public string Ipv6Address { get; set; }

        /// <summary>
        /// Checks to see if the Ipv6Address property is set.
        /// </summary>
        internal bool IsSetIpv6Address() => this.Ipv6Address != null;

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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags for the WorkSpace.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

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
        [AWSProperty(Required = true, Min = 1, Max = 63)]
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
        public string WorkspaceName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceName property is set.
        /// </summary>
        internal bool IsSetWorkspaceName() => this.WorkspaceName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceProperties. 
        /// <para>
        /// The WorkSpace properties.
        /// </para>
        /// </summary>
        public WorkspaceProperties WorkspaceProperties { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceProperties property is set.
        /// </summary>
        internal bool IsSetWorkspaceProperties() => this.WorkspaceProperties != null;
    }
}
