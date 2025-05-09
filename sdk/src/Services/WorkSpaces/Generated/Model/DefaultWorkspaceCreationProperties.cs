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
    /// Describes the default values that are used to create WorkSpaces. For more information,
    /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-directory-details.html">Update
    /// Directory Details for Your WorkSpaces</a>.
    /// </summary>
    public partial class DefaultWorkspaceCreationProperties
    {
        private string _customSecurityGroupId;
        private string _defaultOu;
        private bool? _enableInternetAccess;
        private bool? _enableMaintenanceMode;
        private string _instanceIamRoleArn;
        private bool? _userEnabledAsLocalAdministrator;

        /// <summary>
        /// Gets and sets the property CustomSecurityGroupId. 
        /// <para>
        /// The identifier of the default security group to apply to WorkSpaces when they are
        /// created. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/amazon-workspaces-security-groups.html">
        /// Security Groups for Your WorkSpaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=11, Max=20)]
        public string CustomSecurityGroupId
        {
            get { return this._customSecurityGroupId; }
            set { this._customSecurityGroupId = value; }
        }

        // Check to see if CustomSecurityGroupId property is set
        internal bool IsSetCustomSecurityGroupId()
        {
            return this._customSecurityGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultOu. 
        /// <para>
        /// The organizational unit (OU) in the directory for the WorkSpace machine accounts.
        /// </para>
        /// </summary>
        public string DefaultOu
        {
            get { return this._defaultOu; }
            set { this._defaultOu = value; }
        }

        // Check to see if DefaultOu property is set
        internal bool IsSetDefaultOu()
        {
            return this._defaultOu != null;
        }

        /// <summary>
        /// Gets and sets the property EnableInternetAccess. 
        /// <para>
        /// Specifies whether to automatically assign an Elastic public IP address to WorkSpaces
        /// in this directory by default. If enabled, the Elastic public IP address allows outbound
        /// internet access from your WorkSpaces when you’re using an internet gateway in the
        /// Amazon VPC in which your WorkSpaces are located. If you're using a Network Address
        /// Translation (NAT) gateway for outbound internet access from your VPC, or if your WorkSpaces
        /// are in public subnets and you manually assign them Elastic IP addresses, you should
        /// disable this setting. This setting applies to new WorkSpaces that you launch or to
        /// existing WorkSpaces that you rebuild. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/amazon-workspaces-vpc.html">
        /// Configure a VPC for Amazon WorkSpaces</a>.
        /// </para>
        /// </summary>
        public bool? EnableInternetAccess
        {
            get { return this._enableInternetAccess; }
            set { this._enableInternetAccess = value; }
        }

        // Check to see if EnableInternetAccess property is set
        internal bool IsSetEnableInternetAccess()
        {
            return this._enableInternetAccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableMaintenanceMode. 
        /// <para>
        /// Specifies whether maintenance mode is enabled for WorkSpaces. For more information,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspace-maintenance.html">WorkSpace
        /// Maintenance</a>.
        /// </para>
        /// </summary>
        public bool? EnableMaintenanceMode
        {
            get { return this._enableMaintenanceMode; }
            set { this._enableMaintenanceMode = value; }
        }

        // Check to see if EnableMaintenanceMode property is set
        internal bool IsSetEnableMaintenanceMode()
        {
            return this._enableMaintenanceMode.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceIamRoleArn. 
        /// <para>
        /// Indicates the IAM role ARN of the instance.
        /// </para>
        /// </summary>
        public string InstanceIamRoleArn
        {
            get { return this._instanceIamRoleArn; }
            set { this._instanceIamRoleArn = value; }
        }

        // Check to see if InstanceIamRoleArn property is set
        internal bool IsSetInstanceIamRoleArn()
        {
            return this._instanceIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserEnabledAsLocalAdministrator. 
        /// <para>
        /// Specifies whether WorkSpace users are local administrators on their WorkSpaces.
        /// </para>
        /// </summary>
        public bool? UserEnabledAsLocalAdministrator
        {
            get { return this._userEnabledAsLocalAdministrator; }
            set { this._userEnabledAsLocalAdministrator = value; }
        }

        // Check to see if UserEnabledAsLocalAdministrator property is set
        internal bool IsSetUserEnabledAsLocalAdministrator()
        {
            return this._userEnabledAsLocalAdministrator.HasValue; 
        }

    }
}