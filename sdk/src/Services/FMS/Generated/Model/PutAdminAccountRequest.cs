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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the PutAdminAccount operation.
    /// Creates or updates an Firewall Manager administrator account. The account must be
    /// a member of the organization that was onboarded to Firewall Manager by <a>AssociateAdminAccount</a>.
    /// Only the organization's management account can create an Firewall Manager administrator
    /// account. When you create an Firewall Manager administrator account, the service checks
    /// to see if the account is already a delegated administrator within Organizations. If
    /// the account isn't a delegated administrator, Firewall Manager calls Organizations
    /// to delegate the account within Organizations. For more information about administrator
    /// accounts within Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
    /// the Amazon Web Services Accounts in Your Organization</a>.
    /// </summary>
    public partial class PutAdminAccountRequest : AmazonFMSRequest
    {
        private string _adminAccount;
        private AdminScope _adminScope;

        /// <summary>
        /// Gets and sets the property AdminAccount. 
        /// <para>
        /// The Amazon Web Services account ID to add as an Firewall Manager administrator account.
        /// The account must be a member of the organization that was onboarded to Firewall Manager
        /// by <a>AssociateAdminAccount</a>. For more information about Organizations, see <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
        /// the Amazon Web Services Accounts in Your Organization</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string AdminAccount
        {
            get { return this._adminAccount; }
            set { this._adminAccount = value; }
        }

        // Check to see if AdminAccount property is set
        internal bool IsSetAdminAccount()
        {
            return this._adminAccount != null;
        }

        /// <summary>
        /// Gets and sets the property AdminScope. 
        /// <para>
        /// Configures the resources that the specified Firewall Manager administrator can manage.
        /// As a best practice, set the administrative scope according to the principles of least
        /// privilege. Only grant the administrator the specific resources or permissions that
        /// they need to perform the duties of their role.
        /// </para>
        /// </summary>
        public AdminScope AdminScope
        {
            get { return this._adminScope; }
            set { this._adminScope = value; }
        }

        // Check to see if AdminScope property is set
        internal bool IsSetAdminScope()
        {
            return this._adminScope != null;
        }

    }
}