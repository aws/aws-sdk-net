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
    /// Container for the parameters to the RegisterWorkspaceDirectory operation. Registers
    /// the specified directory. This operation is asynchronous and returns before the WorkSpace
    /// directory is registered. If this is the first time you are registering a directory,
    /// you will need to create the workspaces_DefaultRole role before you can register a
    /// directory. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-access-control.html#create-default-role">
    /// Creating the workspaces_DefaultRole Role</a>.
    /// </summary>
    public partial class RegisterWorkspaceDirectoryRequest : AmazonWorkSpacesRequest
    {
        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfig. 
        /// <para>
        /// The active directory config of the directory.
        /// </para>
        /// </summary>
        public ActiveDirectoryConfig ActiveDirectoryConfig { get; set; }

        /// <summary>
        /// Checks to see if the ActiveDirectoryConfig property is set.
        /// </summary>
        internal bool IsSetActiveDirectoryConfig() => this.ActiveDirectoryConfig != null;

        /// <summary>
        /// Gets and sets the property DirectoryId. 
        /// <para>
        /// The identifier of the directory. You cannot register a directory if it does not have
        /// a status of Active. If the directory does not have a status of Active, you will receive
        /// an InvalidResourceStateException error. If you have already registered the maximum
        /// number of directories that you can register with Amazon WorkSpaces, you will receive
        /// a ResourceLimitExceededException error. Deregister directories that you are not using
        /// for WorkSpaces, and try again.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 65)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// Checks to see if the DirectoryId property is set.
        /// </summary>
        internal bool IsSetDirectoryId() => this.DirectoryId != null;

        /// <summary>
        /// Gets and sets the property EnableSelfService. 
        /// <para>
        /// Indicates whether self-service capabilities are enabled or disabled.
        /// </para>
        /// </summary>
        public bool? EnableSelfService { get; set; }

        /// <summary>
        /// Checks to see if the EnableSelfService property is set.
        /// </summary>
        internal bool IsSetEnableSelfService() => this.EnableSelfService.HasValue;

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity center instance.
        /// </para>
        /// </summary>
        public string IdcInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdcInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdcInstanceArn() => this.IdcInstanceArn != null;

        /// <summary>
        /// Gets and sets the property MicrosoftEntraConfig. 
        /// <para>
        /// The details about Microsoft Entra config.
        /// </para>
        /// </summary>
        public MicrosoftEntraConfig MicrosoftEntraConfig { get; set; }

        /// <summary>
        /// Checks to see if the MicrosoftEntraConfig property is set.
        /// </summary>
        internal bool IsSetMicrosoftEntraConfig() => this.MicrosoftEntraConfig != null;

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers of the subnets for your virtual private cloud (VPC). Make sure that
        /// the subnets are in supported Availability Zones. The subnets must also be in separate
        /// Availability Zones. If these conditions are not met, you will receive an OperationNotSupportedException
        /// error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<string> SubnetIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SubnetIds property is set.
        /// </summary>
        internal bool IsSetSubnetIds() => this.SubnetIds != null && (this.SubnetIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the directory.
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
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates whether your WorkSpace directory is dedicated or shared. To use Bring Your
        /// Own License (BYOL) images, this value must be set to <c>DEDICATED</c> and your Amazon
        /// Web Services account must be enabled for BYOL. If your account has not been enabled
        /// for BYOL, you will receive an InvalidParameterValuesException error. For more information
        /// about BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">Bring
        /// Your Own Windows Desktop Images</a>.
        /// </para>
        /// </summary>
        public Tenancy Tenancy { get; set; }

        /// <summary>
        /// Checks to see if the Tenancy property is set.
        /// </summary>
        internal bool IsSetTenancy() => this.Tenancy != null;

        /// <summary>
        /// Gets and sets the property UserIdentityType. 
        /// <para>
        /// The type of identity management the user is using.
        /// </para>
        /// </summary>
        public UserIdentityType UserIdentityType { get; set; }

        /// <summary>
        /// Checks to see if the UserIdentityType property is set.
        /// </summary>
        internal bool IsSetUserIdentityType() => this.UserIdentityType != null;

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryDescription. 
        /// <para>
        /// Description of the directory to register.
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryDescription { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceDirectoryDescription property is set.
        /// </summary>
        internal bool IsSetWorkspaceDirectoryDescription() => this.WorkspaceDirectoryDescription != null;

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryName. 
        /// <para>
        /// The name of the directory to register.
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryName { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceDirectoryName property is set.
        /// </summary>
        internal bool IsSetWorkspaceDirectoryName() => this.WorkspaceDirectoryName != null;

        /// <summary>
        /// Gets and sets the property WorkspaceType. 
        /// <para>
        /// Indicates whether the directory's WorkSpace type is personal or pools.
        /// </para>
        /// </summary>
        public WorkspaceType WorkspaceType { get; set; }

        /// <summary>
        /// Checks to see if the WorkspaceType property is set.
        /// </summary>
        internal bool IsSetWorkspaceType() => this.WorkspaceType != null;
    }
}
