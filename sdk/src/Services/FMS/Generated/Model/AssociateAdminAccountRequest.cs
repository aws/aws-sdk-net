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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateAdminAccount operation.
    /// Sets the AWS Firewall Manager administrator account. AWS Firewall Manager must be
    /// associated with a master account in AWS Organizations or associated with a member
    /// account that has the appropriate permissions. If the account ID that you submit is
    /// not an AWS Organizations master account, AWS Firewall Manager will set the appropriate
    /// permissions for the given member account.
    /// 
    ///  
    /// <para>
    /// The account that you associate with AWS Firewall Manager is called the AWS Firewall
    /// manager administrator account. 
    /// </para>
    /// </summary>
    public partial class AssociateAdminAccountRequest : AmazonFMSRequest
    {
        private string _adminAccount;

        /// <summary>
        /// Gets and sets the property AdminAccount. 
        /// <para>
        /// The AWS account ID to associate with AWS Firewall Manager as the AWS Firewall Manager
        /// administrator account. This can be an AWS Organizations master account or a member
        /// account. For more information about AWS Organizations and master accounts, see <a
        /// href="https://docs.aws.amazon.com/organizations/latest/userguide/orgs_manage_accounts.html">Managing
        /// the AWS Accounts in Your Organization</a>.
        /// </para>
        /// </summary>
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