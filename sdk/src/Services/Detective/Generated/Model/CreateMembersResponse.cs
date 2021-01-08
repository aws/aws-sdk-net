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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// This is the response object from the CreateMembers operation.
    /// </summary>
    public partial class CreateMembersResponse : AmazonWebServiceResponse
    {
        private List<MemberDetail> _members = new List<MemberDetail>();
        private List<UnprocessedAccount> _unprocessedAccounts = new List<UnprocessedAccount>();

        /// <summary>
        /// Gets and sets the property Members. 
        /// <para>
        /// The set of member account invitation requests that Detective was able to process.
        /// This includes accounts that are being verified, that failed verification, and that
        /// passed verification and are being sent an invitation.
        /// </para>
        /// </summary>
        public List<MemberDetail> Members
        {
            get { return this._members; }
            set { this._members = value; }
        }

        // Check to see if Members property is set
        internal bool IsSetMembers()
        {
            return this._members != null && this._members.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedAccounts. 
        /// <para>
        /// The list of accounts for which Detective was unable to process the invitation request.
        /// For each account, the list provides the reason why the request could not be processed.
        /// The list includes accounts that are already member accounts in the behavior graph.
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