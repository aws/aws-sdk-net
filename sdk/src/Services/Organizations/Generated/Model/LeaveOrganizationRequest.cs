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
    /// Container for the parameters to the LeaveOrganization operation.
    /// Removes a member account from its parent organization. This version of the operation
    /// is performed by the account that wants to leave. To remove a member account as a user
    /// in the master account, use <a>RemoveAccountFromOrganization</a> instead.
    /// 
    ///  
    /// <para>
    /// This operation can be called only from a member account in the organization.
    /// </para>
    ///  <important> <ul> <li> 
    /// <para>
    /// The master account in an organization with all features enabled can set service control
    /// policies (SCPs) that can restrict what administrators of member accounts can do, including
    /// preventing them from successfully calling <code>LeaveOrganization</code> and leaving
    /// the organization. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can leave an organization as a member account only if the account is configured
    /// with the information required to operate as a standalone account. When you create
    /// an account in an organization using the AWS Organizations console, API, or CLI commands,
    /// the information required of standalone accounts is <i>not</i> automatically collected.
    /// For each account that you want to make standalone, you must accept the End User License
    /// Agreement (EULA), choose a support plan, provide and verify the required contact information,
    /// and provide a current payment method. AWS uses the payment method to charge for any
    /// billable (not free tier) AWS activity that occurs while the account is not attached
    /// to an organization. Follow the steps at <a href="http://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts_remove.html#leave-without-all-info">
    /// To leave an organization when all required account information has not yet been provided</a>
    /// in the <i>AWS Organizations User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You can leave an organization only after you enable IAM user access to billing in
    /// your account. For more information, see <a href="http://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/grantaccess.html#ControllingAccessWebsite-Activate">Activating
    /// Access to the Billing and Cost Management Console</a> in the <i>AWS Billing and Cost
    /// Management User Guide</i>.
    /// </para>
    ///  </li> </ul> </important>
    /// </summary>
    public partial class LeaveOrganizationRequest : AmazonOrganizationsRequest
    {

    }
}