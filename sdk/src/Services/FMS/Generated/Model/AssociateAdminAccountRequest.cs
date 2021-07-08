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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAdminAccount operation.
    /// Sets the Firewall Manager administrator account. The account must be a member of the
    /// organization in Organizations whose resources you want to protect. Firewall Manager
    /// sets the permissions that allow the account to administer your Firewall Manager policies.
    /// 
    ///  
    /// <para>
    /// The account that you associate with Firewall Manager is called the Firewall Manager
    /// administrator account. 
    /// </para>
    /// </summary>
    public partial class AssociateAdminAccountRequest : AmazonFMSRequest
    {
        private string _adminAccount;

        /// <summary>
        /// Gets and sets the property AdminAccount. 
        /// <para>
        /// The Amazon Web Services account ID to associate with Firewall Manager as the Firewall
        /// Manager administrator account. This must be an Organizations member account. For more
        /// information about Organizations, see <a href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
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

    }
}