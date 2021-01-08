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
    /// This is the response object from the ListMembers operation.
    /// </summary>
    public partial class ListMembersResponse : AmazonWebServiceResponse
    {
        private List<MemberDetail> _memberDetails = new List<MemberDetail>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MemberDetails. 
        /// <para>
        /// The list of member accounts in the behavior graph.
        /// </para>
        ///  
        /// <para>
        /// The results include member accounts that did not pass verification and member accounts
        /// that have not yet accepted the invitation to the behavior graph. The results do not
        /// include member accounts that were removed from the behavior graph.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more member accounts remaining in the results, then this is the pagination
        /// token to use to request the next page of member accounts.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}