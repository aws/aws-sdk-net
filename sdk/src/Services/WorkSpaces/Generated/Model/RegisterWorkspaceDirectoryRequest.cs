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
    /// Container for the parameters to the RegisterWorkspaceDirectory operation.
    /// Registers the specified directory. This operation is asynchronous and returns before
    /// the WorkSpace directory is registered. If this is the first time you are registering
    /// a directory, you will need to create the workspaces_DefaultRole role before you can
    /// register a directory. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspaces-access-control.html#create-default-role">
    /// Creating the workspaces_DefaultRole Role</a>.
    /// </summary>
    public partial class RegisterWorkspaceDirectoryRequest : AmazonWorkSpacesRequest
    {
        private ActiveDirectoryConfig _activeDirectoryConfig;
        private string _directoryId;
        private bool? _enableSelfService;
        private string _idcInstanceArn;
        private MicrosoftEntraConfig _microsoftEntraConfig;
        private List<string> _subnetIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private Tenancy _tenancy;
        private UserIdentityType _userIdentityType;
        private string _workspaceDirectoryDescription;
        private string _workspaceDirectoryName;
        private WorkspaceType _workspaceType;

        /// <summary>
        /// Gets and sets the property ActiveDirectoryConfig. 
        /// <para>
        /// The active directory config of the directory.
        /// </para>
        /// </summary>
        public ActiveDirectoryConfig ActiveDirectoryConfig
        {
            get { return this._activeDirectoryConfig; }
            set { this._activeDirectoryConfig = value; }
        }

        // Check to see if ActiveDirectoryConfig property is set
        internal bool IsSetActiveDirectoryConfig()
        {
            return this._activeDirectoryConfig != null;
        }

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
        /// Gets and sets the property EnableSelfService. 
        /// <para>
        /// Indicates whether self-service capabilities are enabled or disabled.
        /// </para>
        /// </summary>
        public bool? EnableSelfService
        {
            get { return this._enableSelfService; }
            set { this._enableSelfService = value; }
        }

        // Check to see if EnableSelfService property is set
        internal bool IsSetEnableSelfService()
        {
            return this._enableSelfService.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IdcInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the identity center instance.
        /// </para>
        /// </summary>
        public string IdcInstanceArn
        {
            get { return this._idcInstanceArn; }
            set { this._idcInstanceArn = value; }
        }

        // Check to see if IdcInstanceArn property is set
        internal bool IsSetIdcInstanceArn()
        {
            return this._idcInstanceArn != null;
        }

        /// <summary>
        /// Gets and sets the property MicrosoftEntraConfig. 
        /// <para>
        /// The details about Microsoft Entra config.
        /// </para>
        /// </summary>
        public MicrosoftEntraConfig MicrosoftEntraConfig
        {
            get { return this._microsoftEntraConfig; }
            set { this._microsoftEntraConfig = value; }
        }

        // Check to see if MicrosoftEntraConfig property is set
        internal bool IsSetMicrosoftEntraConfig()
        {
            return this._microsoftEntraConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers of the subnets for your virtual private cloud (VPC). Make sure that
        /// the subnets are in supported Availability Zones. The subnets must also be in separate
        /// Availability Zones. If these conditions are not met, you will receive an OperationNotSupportedException
        /// error.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<string> SubnetIds
        {
            get { return this._subnetIds; }
            set { this._subnetIds = value; }
        }

        // Check to see if SubnetIds property is set
        internal bool IsSetSubnetIds()
        {
            return this._subnetIds != null && (this._subnetIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the directory.
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
        public Tenancy Tenancy
        {
            get { return this._tenancy; }
            set { this._tenancy = value; }
        }

        // Check to see if Tenancy property is set
        internal bool IsSetTenancy()
        {
            return this._tenancy != null;
        }

        /// <summary>
        /// Gets and sets the property UserIdentityType. 
        /// <para>
        /// The type of identity management the user is using.
        /// </para>
        /// </summary>
        public UserIdentityType UserIdentityType
        {
            get { return this._userIdentityType; }
            set { this._userIdentityType = value; }
        }

        // Check to see if UserIdentityType property is set
        internal bool IsSetUserIdentityType()
        {
            return this._userIdentityType != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryDescription. 
        /// <para>
        /// Description of the directory to register.
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryDescription
        {
            get { return this._workspaceDirectoryDescription; }
            set { this._workspaceDirectoryDescription = value; }
        }

        // Check to see if WorkspaceDirectoryDescription property is set
        internal bool IsSetWorkspaceDirectoryDescription()
        {
            return this._workspaceDirectoryDescription != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceDirectoryName. 
        /// <para>
        /// The name of the directory to register.
        /// </para>
        /// </summary>
        public string WorkspaceDirectoryName
        {
            get { return this._workspaceDirectoryName; }
            set { this._workspaceDirectoryName = value; }
        }

        // Check to see if WorkspaceDirectoryName property is set
        internal bool IsSetWorkspaceDirectoryName()
        {
            return this._workspaceDirectoryName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceType. 
        /// <para>
        /// Indicates whether the directory's WorkSpace type is personal or pools.
        /// </para>
        /// </summary>
        public WorkspaceType WorkspaceType
        {
            get { return this._workspaceType; }
            set { this._workspaceType = value; }
        }

        // Check to see if WorkspaceType property is set
        internal bool IsSetWorkspaceType()
        {
            return this._workspaceType != null;
        }

    }
}