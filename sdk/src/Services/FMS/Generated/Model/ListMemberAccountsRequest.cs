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
    /// Container for the parameters to the ListMemberAccounts operation.
    /// Returns a <code>MemberAccounts</code> object that lists the member accounts in the
    /// administrator's AWS organization.
    /// 
    ///  
    /// <para>
    /// The <code>ListMemberAccounts</code> must be submitted by the account that is set as
    /// the AWS Firewall Manager administrator.
    /// </para>
    /// </summary>
    public partial class ListMemberAccountsRequest : AmazonFMSRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies the number of member account IDs that you want AWS Firewall Manager to return
        /// for this request. If you have more IDs than the number that you specify for <code>MaxResults</code>,
        /// the response includes a <code>NextToken</code> value that you can use to get another
        /// batch of member account IDs.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If you specify a value for <code>MaxResults</code> and you have more account IDs than
        /// the number that you specify for <code>MaxResults</code>, AWS Firewall Manager returns
        /// a <code>NextToken</code> value in the response that allows you to list another group
        /// of IDs. For the second and subsequent <code>ListMemberAccountsRequest</code> requests,
        /// specify the value of <code>NextToken</code> from the previous response to get information
        /// about another batch of member account IDs.
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