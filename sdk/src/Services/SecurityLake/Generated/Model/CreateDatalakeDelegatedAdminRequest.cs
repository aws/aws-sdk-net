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
 * Do not modify this file. This file is generated from the securitylake-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityLake.Model
{
    /// <summary>
    /// Container for the parameters to the CreateDatalakeDelegatedAdmin operation.
    /// Designates the Security Lake administrator account for the organization. This API
    /// can only be called by the organization management account. The organization management
    /// account cannot be the delegated administrator account.
    /// </summary>
    public partial class CreateDatalakeDelegatedAdminRequest : AmazonSecurityLakeRequest
    {
        private string _account;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// Account ID of the Security Lake delegated administrator.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

    }
}