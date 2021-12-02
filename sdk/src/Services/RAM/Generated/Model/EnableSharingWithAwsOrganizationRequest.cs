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
 * Do not modify this file. This file is generated from the ram-2018-01-04.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RAM.Model
{
    /// <summary>
    /// Container for the parameters to the EnableSharingWithAwsOrganization operation.
    /// Enables resource sharing within your organization in Organizations. Calling this operation
    /// enables RAM to retrieve information about the organization and its structure. This
    /// lets you share resources with all of the accounts in an organization by specifying
    /// the organization's ID, or all of the accounts in an organizational unit (OU) by specifying
    /// the OU's ID. Until you enable sharing within the organization, you can specify only
    /// individual Amazon Web Services accounts, or for supported resource types, IAM users
    /// and roles.
    /// 
    ///  
    /// <para>
    /// You must call this operation from an IAM user or role in the organization's management
    /// account.
    /// </para>
    /// </summary>
    public partial class EnableSharingWithAwsOrganizationRequest : AmazonRAMRequest
    {

    }
}