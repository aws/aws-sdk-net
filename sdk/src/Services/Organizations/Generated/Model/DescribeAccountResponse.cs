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
 * Do not modify this file. This file is generated from the organizations-2016-11-28.normal.json service model.
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
namespace Amazon.Organizations.Model
{
    /// <summary>
    /// This is the response object from the DescribeAccount operation.
    /// </summary>
    public partial class DescribeAccountResponse : AmazonWebServiceResponse
    {
        private Account _account;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// A structure that contains information about the requested account.
        /// </para>
        ///  <important> 
        /// <para>
        /// The <c>Status</c> parameter in the API response will be retired on September 9, 2026.
        /// Although both the account <c>State</c> and account <c>Status</c> parameters are currently
        /// available in the Organizations APIs (<c>DescribeAccount</c>, <c>ListAccounts</c>,
        /// <c>ListAccountsForParent</c>), we recommend that you update your scripts or other
        /// code to use the <c>State</c> parameter instead of <c>Status</c> before September 9,
        /// 2026.
        /// </para>
        ///  </important>
        /// </summary>
        public Account Account
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