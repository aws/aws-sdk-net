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
    /// Container for the parameters to the ListAccountsForParent operation.
    /// Lists the accounts in an organization that are contained by the specified target root
    /// or organizational unit (OU). If you specify the root, you get a list of all the accounts
    /// that aren't in any OU. If you specify an OU, you get a list of all the accounts in
    /// only that OU and not in any child OUs. To get a list of all accounts in the organization,
    /// use the <a>ListAccounts</a> operation.
    /// 
    ///  <note> 
    /// <para>
    /// Always check the <c>NextToken</c> response parameter for a <c>null</c> value when
    /// calling a <c>List*</c> operation. These operations can occasionally return an empty
    /// set of results even when there are more results available. The <c>NextToken</c> response
    /// parameter value is <c>null</c> <i>only</i> when there are no more results to display.
    /// </para>
    ///  </note> 
    /// <para>
    /// This operation can be called only from the organization's management account or by
    /// a member account that is a delegated administrator.
    /// </para>
    /// </summary>
    public partial class ListAccountsForParentRequest : AmazonOrganizationsRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _parentId;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The total number of results that you want included on each page of the response. If
        /// you do not include this parameter, it defaults to a value that is specific to the
        /// operation. If additional items exist beyond the maximum you specify, the <c>NextToken</c>
        /// response element is present and has a value (is not null). Include that value as the
        /// <c>NextToken</c> request parameter in the next call to the operation to get the next
        /// part of the results. Note that Organizations might return fewer results than the maximum
        /// even when there are more results available. You should check <c>NextToken</c> after
        /// every operation to ensure that you receive all of the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int? MaxResults
        {
            get { return this._maxResults; }
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
        /// The parameter for receiving additional results if you receive a <c>NextToken</c> response
        /// in a previous request. A <c>NextToken</c> response indicates that more output is available.
        /// Set this parameter to the value of the previous call's <c>NextToken</c> response to
        /// indicate where the output should continue from.
        /// </para>
        /// </summary>
        [AWSProperty(Max=100000)]
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

        /// <summary>
        /// Gets and sets the property ParentId. 
        /// <para>
        /// The unique identifier (ID) for the parent root or organization unit (OU) whose accounts
        /// you want to list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=100)]
        public string ParentId
        {
            get { return this._parentId; }
            set { this._parentId = value; }
        }

        // Check to see if ParentId property is set
        internal bool IsSetParentId()
        {
            return this._parentId != null;
        }

    }
}