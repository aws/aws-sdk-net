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
    /// This is the response object from the ListMemberAccounts operation.
    /// </summary>
    public partial class ListMemberAccountsResponse : AmazonWebServiceResponse
    {
        private List<string> _memberAccounts = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MemberAccounts. 
        /// <para>
        /// An array of account IDs.
        /// </para>
        /// </summary>
        public List<string> MemberAccounts
        {
            get { return this._memberAccounts; }
            set { this._memberAccounts = value; }
        }

        // Check to see if MemberAccounts property is set
        internal bool IsSetMemberAccounts()
        {
            return this._memberAccounts != null && this._memberAccounts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you have more member account IDs than the number that you specified for <code>MaxResults</code>
        /// in the request, the response includes a <code>NextToken</code> value. To list more
        /// IDs, submit another <code>ListMemberAccounts</code> request, and specify the <code>NextToken</code>
        /// value from the response in the <code>NextToken</code> value in the next request.
        /// </para>
        /// </summary>
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