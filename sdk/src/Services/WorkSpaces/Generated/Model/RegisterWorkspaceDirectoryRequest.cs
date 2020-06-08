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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

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
        private string _directoryId;
        private bool? _enableSelfService;
        private bool? _enableWorkDocs;
        private List<string> _subnetIds = new List<string>();
        private List<Tag> _tags = new List<Tag>();
        private Tenancy _tenancy;

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
        /// Gets and sets the property EnableSelfService. 
        /// <para>
        /// Indicates whether self-service capabilities are enabled or disabled.
        /// </para>
        /// </summary>
        public bool EnableSelfService
        {
            get { return this._enableSelfService.GetValueOrDefault(); }
            set { this._enableSelfService = value; }
        }

        // Check to see if EnableSelfService property is set
        internal bool IsSetEnableSelfService()
        {
            return this._enableSelfService.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableWorkDocs. 
        /// <para>
        /// Indicates whether Amazon WorkDocs is enabled or disabled. If you have enabled this
        /// parameter and WorkDocs is not available in the Region, you will receive an OperationNotSupportedException
        /// error. Set <code>EnableWorkDocs</code> to disabled, and try again.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableWorkDocs
        {
            get { return this._enableWorkDocs.GetValueOrDefault(); }
            set { this._enableWorkDocs = value; }
        }

        // Check to see if EnableWorkDocs property is set
        internal bool IsSetEnableWorkDocs()
        {
            return this._enableWorkDocs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetIds. 
        /// <para>
        /// The identifiers of the subnets for your virtual private cloud (VPC). Make sure that
        /// the subnets are in supported Availability Zones. The subnets must also be in separate
        /// Availability Zones. If these conditions are not met, you will receive an OperationNotSupportedException
        /// error.
        /// </para>
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
            return this._subnetIds != null && this._subnetIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the directory.
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
        /// Gets and sets the property Tenancy. 
        /// <para>
        /// Indicates whether your WorkSpace directory is dedicated or shared. To use Bring Your
        /// Own License (BYOL) images, this value must be set to <code>DEDICATED</code> and your
        /// AWS account must be enabled for BYOL. If your account has not been enabled for BYOL,
        /// you will receive an InvalidParameterValuesException error. For more information about
        /// BYOL images, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/byol-windows-images.html">Bring
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

    }
}