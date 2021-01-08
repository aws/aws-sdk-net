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
    /// This is the response object from the GetMembers operation.
    /// </summary>
    public partial class GetMembersResponse : AmazonWebServiceResponse
    {
        private List<MemberDetail> _memberDetails = new List<MemberDetail>();
        private List<UnprocessedAccount> _unprocessedAccounts = new List<UnprocessedAccount>();

        /// <summary>
        /// Gets and sets the property MemberDetails. 
        /// <para>
        /// The member account details that Detective is returning in response to the request.
        /// </para>
        /// </summary>
        public List<MemberDetail> MemberDetails
        {
            get { return this._memberDetails; }
            set { this._memberDetails = value; }
        }

        // Check to see if MemberDetails property is set
        internal bool IsSetMemberDetails()
        {
            return this._memberDetails != null && this._memberDetails.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedAccounts. 
        /// <para>
        /// The requested member accounts for which Detective was unable to return member details.
        /// </para>
        ///  
        /// <para>
        /// For each account, provides the reason why the request could not be processed.
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