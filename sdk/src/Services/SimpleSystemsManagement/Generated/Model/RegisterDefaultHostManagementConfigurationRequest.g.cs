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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterDefaultHostManagementConfiguration operation.
    /// Enables Default Host Management Configuration (DHMC) for the current Amazon Web Services
    /// account and Amazon Web Services Region. With DHMC enabled, you don't need to configure
    /// additional resources, such as an instance profile, to use your Amazon EC2 instances
    /// as managed nodes in Amazon Web Services Systems Manager. <para> To use this operation,
    /// you must have the following permissions: </para> <ul> <li> <para> You need the <c>ssm:GetServiceSetting</c>
    /// and <c>ssm:UpdateServiceSetting</c> permissions for the <c>/ssm/managed-instance/default-ec2-instance-management-role</c>
    /// service setting. </para> </li> <li> <para> You need the <c>iam:GetRole</c> and <c>iam:PassRole</c>
    /// permissions for the role used for Default Host Management Configuration. </para> </li>
    /// </ul> <para> If <c>PermissionModel</c> is <c>SERVICE_MANAGED</c>, you also need the
    /// <c>iam:CreateRole</c> and <c>iam:AttachRolePolicy</c> permissions so that Amazon Web
    /// Services Systems Manager can create and configure the role on your behalf. </para>
    /// </summary>
    public partial class RegisterDefaultHostManagementConfigurationRequest : AmazonSimpleSystemsManagementRequest
    {
        /// <summary>
        /// Gets and sets the property Overwrite. 
        /// <para>
        /// Specifies whether to override the role that is currently registered for Default Host
        /// Management Configuration. The default is <c>false</c>, which acts as a guardrail against
        /// accidentally replacing an existing configuration. Set this to <c>true</c> to replace
        /// the currently registered role.
        /// </para>
        /// </summary>
        public bool? Overwrite { get; set; }

        /// <summary>
        /// Checks to see if the Overwrite property is set.
        /// </summary>
        internal bool IsSetOverwrite() => this.Overwrite.HasValue;

        /// <summary>
        /// Gets and sets the property PermissionModel. 
        /// <para>
        /// The permission model that determines how the IAM role for Default Host Management
        /// Configuration is provided.
        /// </para>
        ///  
        /// <para>
        /// The permission model can be one of the following values:
        /// </para>
        ///  <dl> <dt>SERVICE_MANAGED</dt> <dd> 
        /// <para>
        /// Amazon Web Services Systems Manager creates and manages the role on your behalf.
        /// </para>
        ///  </dd> <dt>SELF_MANAGED</dt> <dd> 
        /// <para>
        /// You provide the role to register in <c>RoleArn</c>.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        [AWSProperty(Required = true)]
        public DHMCPermissionModel PermissionModel { get; set; }

        /// <summary>
        /// Checks to see if the PermissionModel property is set.
        /// </summary>
        internal bool IsSetPermissionModel() => this.PermissionModel != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the self-managed IAM role that you register for
        /// Default Host Management Configuration. The requirement for this value depends on the
        /// permission model:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>PermissionModel</c> is <c>SELF_MANAGED</c>, this value is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>PermissionModel</c> is <c>SERVICE_MANAGED</c>, this value must not be set.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;
    }
}
