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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListAssociations operation.
    /// Returns all State Manager associations in the current AWS account and Region. You
    /// can limit the results to a specific State Manager association document or instance
    /// by specifying a filter.
    /// </summary>
    public partial class ListAssociationsRequest : AmazonSimpleSystemsManagementRequest
    {
        private List<AssociationFilter> _associationFilterList = new List<AssociationFilter>();
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public ListAssociationsRequest() { }

        /// <summary>
        /// Instantiates ListAssociationsRequest with the parameterized properties
        /// </summary>
        /// <param name="associationFilterList">One or more filters. Use a filter to return a more specific list of results. <note> Filtering associations using the <code>InstanceID</code> attribute only returns legacy associations created using the <code>InstanceID</code> attribute. Associations targeting the instance that are part of the Target Attributes <code>ResourceGroup</code> or <code>Tags</code> are not returned. </note></param>
        public ListAssociationsRequest(List<AssociationFilter> associationFilterList)
        {
            _associationFilterList = associationFilterList;
        }

        /// <summary>
        /// Gets and sets the property AssociationFilterList. 
        /// <para>
        /// One or more filters. Use a filter to return a more specific list of results.
        /// </para>
        ///  <note> 
        /// <para>
        /// Filtering associations using the <code>InstanceID</code> attribute only returns legacy
        /// associations created using the <code>InstanceID</code> attribute. Associations targeting
        /// the instance that are part of the Target Attributes <code>ResourceGroup</code> or
        /// <code>Tags</code> are not returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1)]
        public List<AssociationFilter> AssociationFilterList
        {
            get { return this._associationFilterList; }
            set { this._associationFilterList = value; }
        }

        // Check to see if AssociationFilterList property is set
        internal bool IsSetAssociationFilterList()
        {
            return this._associationFilterList != null && this._associationFilterList.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of items to return for this call. The call also returns a token
        /// that you can specify in a subsequent call to get the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// The token for the next set of items to return. (You received this token from a previous
        /// call.)
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