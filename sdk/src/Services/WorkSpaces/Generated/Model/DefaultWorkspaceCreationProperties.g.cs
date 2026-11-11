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
    /// Describes the default values that are used to create WorkSpaces. For more information,
    /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/update-directory-details.html">Update
    /// Directory Details for Your WorkSpaces</a>.
    /// </summary>
    public partial class DefaultWorkspaceCreationProperties
    {
        /// <summary>
        /// Gets and sets the property CustomSecurityGroupId. 
        /// <para>
        /// The identifier of the default security group to apply to WorkSpaces when they are
        /// created. For more information, see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/amazon-workspaces-security-groups.html">
        /// Security Groups for Your WorkSpaces</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 11, Max = 20)]
        public string CustomSecurityGroupId { get; set; }

        /// <summary>
        /// Checks to see if the CustomSecurityGroupId property is set.
        /// </summary>
        internal bool IsSetCustomSecurityGroupId() => this.CustomSecurityGroupId != null;

        /// <summary>
        /// Gets and sets the property DefaultOu. 
        /// <para>
        /// The organizational unit (OU) in the directory for the WorkSpace machine accounts.
        /// </para>
        /// </summary>
        public string DefaultOu { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOu property is set.
        /// </summary>
        internal bool IsSetDefaultOu() => this.DefaultOu != null;

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
        public bool? EnableInternetAccess { get; set; }

        /// <summary>
        /// Checks to see if the EnableInternetAccess property is set.
        /// </summary>
        internal bool IsSetEnableInternetAccess() => this.EnableInternetAccess.HasValue;

        /// <summary>
        /// Gets and sets the property EnableMaintenanceMode. 
        /// <para>
        /// Specifies whether maintenance mode is enabled for WorkSpaces. For more information,
        /// see <a href="https://docs.aws.amazon.com/workspaces/latest/adminguide/workspace-maintenance.html">WorkSpace
        /// Maintenance</a>.
        /// </para>
        /// </summary>
        public bool? EnableMaintenanceMode { get; set; }

        /// <summary>
        /// Checks to see if the EnableMaintenanceMode property is set.
        /// </summary>
        internal bool IsSetEnableMaintenanceMode() => this.EnableMaintenanceMode.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceIamRoleArn. 
        /// <para>
        /// Indicates the IAM role ARN of the instance.
        /// </para>
        /// </summary>
        public string InstanceIamRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the InstanceIamRoleArn property is set.
        /// </summary>
        internal bool IsSetInstanceIamRoleArn() => this.InstanceIamRoleArn != null;

        /// <summary>
        /// Gets and sets the property UserEnabledAsLocalAdministrator. 
        /// <para>
        /// Specifies whether WorkSpace users are local administrators on their WorkSpaces.
        /// </para>
        /// </summary>
        public bool? UserEnabledAsLocalAdministrator { get; set; }

        /// <summary>
        /// Checks to see if the UserEnabledAsLocalAdministrator property is set.
        /// </summary>
        internal bool IsSetUserEnabledAsLocalAdministrator() => this.UserEnabledAsLocalAdministrator.HasValue;
    }
}
