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
    /// Container for the parameters to the DeregisterDefaultHostManagementConfiguration operation.
    /// Removes the Default Host Management Configuration (DHMC) for an Amazon Web Services
    /// account and Amazon Web Services Region. After you deregister DHMC, Amazon EC2 instances
    /// are no longer automatically managed as managed nodes by Amazon Web Services Systems
    /// Manager. <para> To use this operation, you must have the following permissions: </para>
    /// <ul> <li> <para> You need the <c>ssm:GetServiceSetting</c> and <c>ssm:ResetServiceSetting</c>
    /// permissions for the <c>/ssm/managed-instance/default-ec2-instance-management-role</c>
    /// service setting. </para> </li> </ul> <para> If the registered role is service-managed,
    /// you also need the <c>iam:DeleteRole</c> permission so that Amazon Web Services Systems
    /// Manager can remove the role it created. </para>
    /// </summary>
    public partial class DeregisterDefaultHostManagementConfigurationRequest : AmazonSimpleSystemsManagementRequest
    {
    }
}
