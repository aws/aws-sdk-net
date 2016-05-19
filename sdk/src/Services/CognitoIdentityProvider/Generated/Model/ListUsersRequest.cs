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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Container for the parameters to the ListUsers operation.
    /// Lists the users in the Amazon Cognito user pool.
    /// </summary>
    public partial class ListUsersRequest : AmazonCognitoIdentityProviderRequest
    {
        private List<string> _attributesToGet = new List<string>();
        private int? _limit;
        private string _paginationToken;
        private string _userPoolId;
        private UserStatusType _userStatus;

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// The attributes to get from the request to list users.
        /// </para>
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && this._attributesToGet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The limit of the request to list users.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PaginationToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
        /// </para>
        /// </summary>
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
        /// The user pool ID for which you want to list users.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property UserStatus. 
        /// <para>
        /// The user status. Can be one of the following:
        /// </para>
        ///  <ul> <li>UNCONFIRMED - User has been created but not confirmed.</li> <li>CONFIRMED
        /// - User has been confirmed.</li> <li>ARCHIVED - User is no longer active.</li> <li>COMPROMISED
        /// - User is disabled due to a potential security threat.</li> <li>UNKNOWN - User status
        /// is not known.</li> </ul>
        /// </summary>
        public UserStatusType UserStatus
        {
            get { return this._userStatus; }
            set { this._userStatus = value; }
        }

        // Check to see if UserStatus property is set
        internal bool IsSetUserStatus()
        {
            return this._userStatus != null;
        }

    }
}