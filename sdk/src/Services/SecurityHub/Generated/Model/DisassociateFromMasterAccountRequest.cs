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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the DisassociateFromMasterAccount operation.
    /// This method is deprecated. Instead, use <code>DisassociateFromAdministratorAccount</code>.
    /// 
    ///  
    /// <para>
    /// The Security Hub console continues to use <code>DisassociateFromMasterAccount</code>.
    /// It will eventually change to use <code>DisassociateFromAdministratorAccount</code>.
    /// Any IAM policies that specifically control access to this function must continue to
    /// use <code>DisassociateFromMasterAccount</code>. You should also add <code>DisassociateFromAdministratorAccount</code>
    /// to your policies to ensure that the correct permissions are in place after the console
    /// begins to use <code>DisassociateFromAdministratorAccount</code>.
    /// </para>
    ///  
    /// <para>
    /// Disassociates the current Security Hub member account from the associated administrator
    /// account.
    /// </para>
    ///  
    /// <para>
    /// This operation is only used by accounts that are not part of an organization. For
    /// organization accounts, only the administrator account can disassociate a member account.
    /// </para>
    /// </summary>
    public partial class DisassociateFromMasterAccountRequest : AmazonSecurityHubRequest
    {

    }
}