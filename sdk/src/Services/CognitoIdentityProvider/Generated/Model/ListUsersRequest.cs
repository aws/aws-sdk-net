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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsers operation.
    /// Given a user pool ID, returns a list of users and their basic details in a user pool.
    /// 
    ///  <note> 
    /// <para>
    /// Amazon Cognito evaluates Identity and Access Management (IAM) policies in requests
    /// for this API operation. For this operation, you must use IAM credentials to authorize
    /// requests, and you must grant yourself the corresponding IAM permission in a policy.
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_aws-signing.html">Signing
    /// Amazon Web Services API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/user-pools-API-operations.html">Using
    /// the Amazon Cognito user pools API and user pool endpoints</a> 
    /// </para>
    ///  </li> </ul> </note>
    /// </summary>
    public partial class ListUsersRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<string> _attributesToGet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _filter;
        private int? _limit;
        private string _paginationToken;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// A JSON array of user attribute names, for example <c>given_name</c>, that you want
        /// Amazon Cognito to include in the response for each user. When you don't provide an
        /// <c>AttributesToGet</c> parameter, Amazon Cognito returns all attributes for each user.
        /// </para>
        ///  
        /// <para>
        /// Use <c>AttributesToGet</c> with required attributes in your user pool, or in conjunction
        /// with <c>Filter</c>. Amazon Cognito returns an error if not all users in the results
        /// have set a value for the attribute you request. Attributes that you can't filter on,
        /// including custom attributes, must have a value set in every user profile before an
        /// <c>AttributesToGet</c> parameter returns results.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && (this._attributesToGet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A filter string of the form <c>"AttributeName Filter-Type "AttributeValue"</c>. Quotation
        /// marks within the filter string must be escaped using the backslash (<c>\</c>) character.
        /// For example, <c>"family_name = \"Reddy\""</c>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>AttributeName</i>: The name of the attribute to search for. You can only search
        /// for one attribute at a time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Filter-Type</i>: For an exact match, use <c>=</c>, for example, "<c>given_name
        /// = \"Jon\"</c>". For a prefix ("starts with") match, use <c>^=</c>, for example, "<c>given_name
        /// ^= \"Jon\"</c>". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>AttributeValue</i>: The attribute value that must be matched for each user.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the filter string is empty, <c>ListUsers</c> returns all users in the user pool.
        /// </para>
        ///  
        /// <para>
        /// You can only search for the following standard attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>username</c> (case-sensitive)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>email</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>phone_number</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>given_name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>family_name</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>preferred_username</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>cognito:user_status</c> (called <b>Status</b> in the Console) (case-insensitive)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>status (called <b>Enabled</b> in the Console) (case-sensitive)</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sub</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Custom attributes aren't searchable.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can also list users with a client-side filter. The server-side filter matches
        /// no more than one attribute. For an advanced search, use a client-side filter with
        /// the <c>--query</c> parameter of the <c>list-users</c> action in the CLI. When you
        /// use a client-side filter, ListUsers returns a paginated list of zero or more users.
        /// You can receive multiple pages in a row with zero results. Repeat the query with each
        /// pagination token that is returned until you receive a null pagination token value,
        /// and then review the combined result. 
        /// </para>
        ///  
        /// <para>
        /// For more information about server-side and client-side filtering, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-filter.html">FilteringCLI
        /// output</a> in the <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-filter.html">Command
        /// Line Interface User Guide</a>. 
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/how-to-manage-user-accounts.html#cognito-user-pools-searching-for-users-using-listusers-api">Searching
        /// for Users Using the ListUsers API</a> and <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/how-to-manage-user-accounts.html#cognito-user-pools-searching-for-users-listusers-api-examples">Examples
        /// of Using the ListUsers API</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of users that you want Amazon Cognito to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=60)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// This API operation returns a limited number of results. The pagination token is an
        /// identifier that you can present in an additional API request with the same parameters.
        /// When you include the pagination token, Amazon Cognito returns the next set of items
        /// after the current list. Subsequent requests return a new pagination token. By use
        /// of this token, you can paginate through the full list of items.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string PaginationToken
        {
            get { return this._paginationToken; }
            set { this._paginationToken = value; }
        }

        // Check to see if PaginationToken property is set
        internal bool IsSetPaginationToken()
        {
            return this._paginationToken != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool where you want to display or search for users.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string UserPoolId
        {
            get { return this._userPoolId; }
            set { this._userPoolId = value; }
        }

        // Check to see if UserPoolId property is set
        internal bool IsSetUserPoolId()
        {
            return this._userPoolId != null;
        }

    }
}