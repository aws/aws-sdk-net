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
    /// This is the response object from the GetAdminAccount operation.
    /// </summary>
    public partial class GetAdminAccountResponse : AmazonWebServiceResponse
    {
        private string _adminAccount;
        private AccountRoleStatus _roleStatus;

        /// <summary>
        /// Gets and sets the property AdminAccount. 
        /// <para>
        /// The account that is set as the Firewall Manager default administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property RoleStatus. 
        /// <para>
        /// The status of the account that you set as the Firewall Manager default administrator.
        /// </para>
        /// </summary>
        public AccountRoleStatus RoleStatus
        {
            get { return this._roleStatus; }
            set { this._roleStatus = value; }
        }

        // Check to see if RoleStatus property is set
        internal bool IsSetRoleStatus()
        {
            return this._roleStatus != null;
        }

    }
}