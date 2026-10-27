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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WorkDocs.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeUsers operation. Describes the specified
    /// users. You can describe all users or filter the results (for example, by status or
    /// organization). <para> By default, Amazon WorkDocs returns the first 24 active or pending
    /// users. If there are more results, the response includes a marker that you can use
    /// to request the next set of results. </para>
    /// </summary>
    public partial class DescribeUsersRequest : AmazonWorkDocsRequest
    {
        /// <summary>
        /// Gets and sets the property AuthenticationToken. 
        /// <para>
        /// Amazon WorkDocs authentication token. Not required when using Amazon Web Services
        /// administrator credentials to access the API.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 8199)]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationToken property is set.
        /// </summary>
        internal bool IsSetAuthenticationToken() => this.AuthenticationToken != null;

        /// <summary>
        /// Gets and sets the property Fields. 
        /// <para>
        /// A comma-separated list of values. Specify "STORAGE_METADATA" to include the user storage
        /// quota and utilization information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Fields { get; set; }

        /// <summary>
        /// Checks to see if the Fields property is set.
        /// </summary>
        internal bool IsSetFields() => this.Fields != null;

        /// <summary>
        /// Gets and sets the property Include. 
        /// <para>
        /// The state of the users. Specify "ALL" to include inactive users.
        /// </para>
        /// </summary>
        public UserFilterType Include { get; set; }

        /// <summary>
        /// Checks to see if the Include property is set.
        /// </summary>
        internal bool IsSetInclude() => this.Include != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of items to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 999)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// The marker for the next set of results. (You received this marker from a previous
        /// call.)
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Marker { get; set; }

        /// <summary>
        /// Checks to see if the Marker property is set.
        /// </summary>
        internal bool IsSetMarker() => this.Marker != null;

        /// <summary>
        /// Gets and sets the property Order. 
        /// <para>
        /// The order for the results.
        /// </para>
        /// </summary>
        public OrderType Order { get; set; }

        /// <summary>
        /// Checks to see if the Order property is set.
        /// </summary>
        internal bool IsSetOrder() => this.Order != null;

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        /// The ID of the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// Checks to see if the OrganizationId property is set.
        /// </summary>
        internal bool IsSetOrganizationId() => this.OrganizationId != null;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// A query to filter users by user name. Remember the following about the <c>Userids</c>
        /// and <c>Query</c> parameters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you don't use either parameter, the API returns a paginated list of all users on
        /// the site.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you use both parameters, the API ignores the <c>Query</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Userid</c> parameter only returns user names that match a corresponding user
        /// ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>Query</c> parameter runs a "prefix" search for users by the <c>GivenName</c>,
        /// <c>SurName</c>, or <c>UserName</c> fields included in a <a href="https://docs.aws.amazon.com/workdocs/latest/APIReference/API_CreateUser.html">CreateUser</a>
        /// API call. For example, querying on <c>Ma</c> returns Márcia Oliveira, María García,
        /// and Mateo Jackson. If you use multiple characters, the API only returns data that
        /// matches all characters. For example, querying on <c>Ma J</c> only returns Mateo Jackson.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 512)]
        public string Query { get; set; }

        /// <summary>
        /// Checks to see if the Query property is set.
        /// </summary>
        internal bool IsSetQuery() => this.Query != null;

        /// <summary>
        /// Gets and sets the property Sort. 
        /// <para>
        /// The sorting criteria.
        /// </para>
        /// </summary>
        public UserSortType Sort { get; set; }

        /// <summary>
        /// Checks to see if the Sort property is set.
        /// </summary>
        internal bool IsSetSort() => this.Sort != null;

        /// <summary>
        /// Gets and sets the property UserIds. 
        /// <para>
        /// The IDs of the users.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2000)]
        public string UserIds { get; set; }

        /// <summary>
        /// Checks to see if the UserIds property is set.
        /// </summary>
        internal bool IsSetUserIds() => this.UserIds != null;
    }
}
