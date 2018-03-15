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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Organizations.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeOrganization operation.
    /// Retrieves information about the organization that the user's account belongs to.
    /// 
    ///  
    /// <para>
    /// This operation can be called from any account in the organization.
    /// </para>
    ///  <note> 
    /// <para>
    /// Even if a policy type is shown as available in the organization, it can be disabled
    /// separately at the root level with <a>DisablePolicyType</a>. Use <a>ListRoots</a> to
    /// see the status of policy types for a specified root.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class DescribeOrganizationRequest : AmazonOrganizationsRequest
    {

    }
}