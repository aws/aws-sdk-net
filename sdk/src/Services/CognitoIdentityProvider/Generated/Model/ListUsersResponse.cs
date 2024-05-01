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
    /// The response from the request to list users.
    /// </summary>
    public partial class ListUsersResponse : AmazonWebServiceResponse
    {
        private string _paginationToken;
        private List<UserType> _users = AWSConfigs.InitializeCollections ? new List<UserType>() : null;

        /// <summary>
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// The identifier that Amazon Cognito returned with the previous request to this operation.
        /// When you include a pagination token in your request, Amazon Cognito returns the next
        /// set of items in the list. By use of this token, you can paginate through the full
        /// list of items.
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
        /// Gets and sets the property Users. 
        /// <para>
        /// A list of the user pool users, and their attributes, that match your query.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Cognito creates a profile in your user pool for each native user in your user
        /// pool, and each unique user ID from your third-party identity providers (IdPs). When
        /// you link users with the <a href="https://docs.aws.amazon.com/cognito-user-identity-pools/latest/APIReference/API_AdminLinkProviderForUser.html">AdminLinkProviderForUser</a>
        /// API operation, the output of <c>ListUsers</c> displays both the IdP user and the native
        /// user that you linked. You can identify IdP users in the <c>Users</c> object of this
        /// API response by the IdP prefix that Amazon Cognito appends to <c>Username</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public List<UserType> Users
        {
            get { return this._users; }
            set { this._users = value; }
        }

        // Check to see if Users property is set
        internal bool IsSetUsers()
        {
            return this._users != null && (this._users.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}