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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the EnableOrganizationsRootCredentialsManagement operation.
    /// Enables the management of privileged root user credentials across member accounts
    /// in your organization. When you enable root credentials management for <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_root-user.html#id_root-user-access-management">centralized
    /// root access</a>, the management account and the delegated administrator for IAM can
    /// manage root user credentials for member accounts in your organization.
    /// 
    ///  
    /// <para>
    /// Before you enable centralized root access, you must have an account configured with
    /// the following settings:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You must manage your Amazon Web Services accounts in <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_introduction.html">Organizations</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Enable trusted access for Identity and Access Management in Organizations. For details,
    /// see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/services-that-can-integrate-iam.html">IAM
    /// and Organizations</a> in the <i>Organizations User Guide</i>.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class EnableOrganizationsRootCredentialsManagementRequest : AmazonIdentityManagementServiceRequest
    {

    }
}