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
 * Do not modify this file. This file is generated from the workdocs-2016-05-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeUsers operation.
    /// Describes the specified users. You can describe all users or filter the results (for
    /// example, by status or organization).
    /// 
    ///  
    /// <para>
    /// By default, Amazon WorkDocs returns the first 24 active or pending users. If there
    /// are more results, the response includes a marker that you can use to request the next
    /// set of results.
    /// </para>
    /// </summary>
    public partial class DescribeUsersRequest : AmazonWorkDocsRequest
    {
        private string _authenticationToken;
        private string _fields;
        private UserFilterType _include;
        private int? _limit;
        private string _marker;
        private OrderType _order;
        private string _organizationId;
        private string _query;
        private UserSortType _sort;
        private string _userIds;

        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using AWS administrator credentials
        /// to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=8199)]
        public string AuthenticationToken
        {
            get { return this._authenticationToken; }
            set { this._authenticationToken = value; }
        }

        // Check to see if AuthenticationToken property is set
        internal bool IsSetAuthenticationToken()
        {
            return this._authenticationToken != null;
        }

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A comma-separated list of values. Specify "STORAGE_METADATA" to include the user storage
        /// quota and utilization information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Fields
        {
            get { return this._fields; }
            set { this._fields = value; }
        }

        // Check to see if Fields property is set
        internal bool IsSetFields()
        {
            return this._fields != null;
        }

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// The state of the users. Specify "ALL" to include inactive users.
        /// </para>
        /// </summary>
        public UserFilterType Include
        {
            get { return this._include; }
            set { this._include = value; }
        }

        // Check to see if Include property is set
        internal bool IsSetInclude()
        {
            return this._include != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=999)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results. (You received this marker from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order for the results.
        /// </para>
        /// </summary>
        public OrderType Order
        {
            get { return this._order; }
            set { this._order = value; }
        }

        // Check to see if Order property is set
        internal bool IsSetOrder()
        {
            return this._order != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// A query to filter users by user name. Remember the following about the <code>Userids</code>
        /// and <code>Query</code> parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't use either parameter, the API returns a paginated list of all users on
        /// the site.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use both parameters, the API ignores the <code>Query</code> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Userid</code> parameter only returns user names that match a corresponding
        /// user ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>Query</code> parameter runs a "prefix" search for users by the <code>GivenName</code>,
        /// <code>SurName</code>, or <code>UserName</code> fields included in a <a href="https://docs.aws.amazon.com/workdocs/latest/APIReference/API_CreateUser.html">CreateUser</a>
        /// API call. For example, querying on <code>Ma</code> returns Márcia Oliveira, María
        /// García, and Mateo Jackson. If you use multiple characters, the API only returns data
        /// that matches all characters. For example, querying on <code>Ma J</code> only returns
        /// Mateo Jackson.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=512)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sorting criteria.
        /// </para>
        /// </summary>
        public UserSortType Sort
        {
            get { return this._sort; }
            set { this._sort = value; }
        }

        // Check to see if Sort property is set
        internal bool IsSetSort()
        {
            return this._sort != null;
        }

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The IDs of the users.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2000)]
        public string UserIds
        {
            get { return this._userIds; }
            set { this._userIds = value; }
        }

        // Check to see if UserIds property is set
        internal bool IsSetUserIds()
        {
            return this._userIds != null;
        }

    }
}