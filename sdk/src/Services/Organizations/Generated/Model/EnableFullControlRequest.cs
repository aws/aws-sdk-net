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
    /// Container for the parameters to the EnableFullControl operation.
    /// Enables full-control mode in an organization. Full-control mode enables the use of
    /// policies to restrict the services and actions that can be called in each account.
    /// Until you enable full-control mode, you have access only to shared billing, and you
    /// can't use any of the advanced account administration features that AWS Organizations
    /// supports. For more information about full-control mode, see <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_full-control-mode.html">Enabling
    /// Full-Control Mode in Your Organization</a> in the <i>AWS Organizations User Guide</i>.
    /// 
    ///  <important> 
    /// <para>
    /// This operation is required only for organizations that were created explicitly in
    /// billing mode, or that were migrated from a Consolidated Billing account family to
    /// Organizations. Calling this operation sends a handshake to every account in the organization.
    /// The migration can be finalized and the new features enabled only after all administrators
    /// approve the switch by accepting the handshake.
    /// </para>
    ///  </important> 
    /// <para>
    /// After all member accounts accept the handshake, you finalize the migration by accepting
    /// the handshake that contains <code>"Action": "ENABLE_FULL_CONTROL"</code>. This completes
    /// the switch.
    /// </para>
    ///  
    /// <para>
    /// After you enable full-control mode, the master account in the organization can apply
    /// policies on all member accounts. These policies can restrict what users and even administrators
    /// in those accounts can do. The master account can apply policies that prevent accounts
    /// from leaving the organization. Ensure that your account administrators are aware of
    /// this.
    /// </para>
    ///  
    /// <para>
    /// This operation can be called only from the organization's master account. 
    /// </para>
    /// </summary>
    public partial class EnableFullControlRequest : AmazonOrganizationsRequest
    {

    }
}