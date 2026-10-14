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

namespace Amazon.IdentityStore.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsers operation. Lists all users in the identity
    /// store. Returns a paginated list of complete <c>User</c> objects. Filtering for a <c>User</c>
    /// by the <c>UserName</c> attribute is deprecated. Instead, use the <c>GetUserId</c>
    /// API action. <note> <para> If you have access to a member account, you can use this
    /// API operation from the member account. For more information, see <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/manage-your-accounts.html#limiting-access-from-member-accounts">Limiting
    /// access to the identity store from member accounts</a> in the <i> IAM Identity Center
    /// User Guide</i>. </para> </note>
    /// </summary>
    public partial class ListUsersRequest : AmazonIdentityStoreRequest
    {
        /// <summary>
        /// Gets and sets the property Extensions. 
        /// <para>
        /// A collection of extension names indicating what extensions the service should retrieve
        /// alongside other user attributes. <c>aws:identitystore:enterprise</c> is the only supported
        /// extension name.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 10)]
        public List<string> Extensions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Extensions property is set.
        /// </summary>
        internal bool IsSetExtensions() => this.Extensions != null && (this.Extensions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of <c>Filter</c> objects, which is used in the <c>ListUsers</c> and <c> ListGroups</c>
        /// requests. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Using filters with ListUsers API is deprecated, please use GetUserId API instead.")]
        [AWSProperty(Min = 0, Max = 1)]
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IdentityStoreId. 
        /// <para>
        /// The globally unique identifier for the identity store, such as <c>d-1234567890</c>.
        /// In this example, <c>d-</c> is a fixed prefix, and <c>1234567890</c> is a randomly
        /// generated string that contains numbers and lower case letters. This value is generated
        /// at the time that a new identity store is created.
        /// </para>
        ///  
        /// <para>
        /// You can specify the identity store by ID or by Amazon Resource Name (ARN). For example,
        /// identity store ID <c>d-1234567890</c> or identity store ARN <c>arn:aws:identitystore::111122223333:identitystore/d-1234567890</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 93)]
        public string IdentityStoreId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityStoreId property is set.
        /// </summary>
        internal bool IsSetIdentityStoreId() => this.IdentityStoreId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be returned per request. This parameter is used in
        /// all <c>List</c> requests to specify how many results to return in one page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The pagination token used for the <c>ListUsers</c> and <c>ListGroups</c> API operations.
        /// This value is generated by the identity store service. It is returned in the API response
        /// if the total results are more than the size of one page. This token is also returned
        /// when it is used in the API request to retrieve the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
