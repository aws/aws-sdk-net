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
 * Do not modify this file. This file is generated from the macie2-2020-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// This is the response object from the CreateInvitations operation.
    /// </summary>
    public partial class CreateInvitationsResponse : AmazonWebServiceResponse
    {
        private List<UnprocessedAccount> _unprocessedAccounts = new List<UnprocessedAccount>();

        /// <summary>
        /// Gets and sets the property UnprocessedAccounts. 
        /// <para>
        /// An array of objects, one for each account whose invitation hasn't been processed.
        /// Each object identifies the account and explains why the invitation hasn't been processed
        /// for the account.
        /// </para>
        /// </summary>
        public List<UnprocessedAccount> UnprocessedAccounts
        {
            get { return this._unprocessedAccounts; }
            set { this._unprocessedAccounts = value; }
        }

        // Check to see if UnprocessedAccounts property is set
        internal bool IsSetUnprocessedAccounts()
        {
            return this._unprocessedAccounts != null && this._unprocessedAccounts.Count > 0; 
        }

    }
}