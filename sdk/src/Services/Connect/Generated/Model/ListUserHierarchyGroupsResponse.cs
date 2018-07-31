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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the ListUserHierarchyGroups operation.
    /// </summary>
    public partial class ListUserHierarchyGroupsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<HierarchyGroupSummary> _userHierarchyGroupSummaryList = new List<HierarchyGroupSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A string returned in the response. Use the value returned in the response as the value
        /// of the NextToken in a subsequent request to retrieve the next set of results.
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

        /// <summary>
        /// Gets and sets the property UserHierarchyGroupSummaryList. 
        /// <para>
        /// An array of <code>HierarchyGroupSummary</code> objects.
        /// </para>
        /// </summary>
        public List<HierarchyGroupSummary> UserHierarchyGroupSummaryList
        {
            get { return this._userHierarchyGroupSummaryList; }
            set { this._userHierarchyGroupSummaryList = value; }
        }

        // Check to see if UserHierarchyGroupSummaryList property is set
        internal bool IsSetUserHierarchyGroupSummaryList()
        {
            return this._userHierarchyGroupSummaryList != null && this._userHierarchyGroupSummaryList.Count > 0; 
        }

    }
}