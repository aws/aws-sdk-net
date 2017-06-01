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
        private string _filter;
        private int? _limit;
        private string _paginationToken;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        /// An array of strings, where each string is the name of a user attribute to be returned
        /// for each user in the search results. If the array is empty, all attributes are returned.
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
        /// Gets and sets the property Filter. 
        /// <para>
        /// A filter string of the form "<i>AttributeName</i> <i>Filter-Type</i> "<i>AttributeValue</i>"".
        /// Quotation marks within the filter string must be escaped using the backslash (\) character.
        /// For example, "<code>family_name</code> = \"Reddy\"".
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>AttributeName</i>: The name of the attribute to search for. You can only search
        /// for one attribute at a time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Filter-Type</i>: For an exact match, use =, for example, "<code>given_name</code>
        /// = \"Jon\"". For a prefix ("starts with") match, use ^=, for example, "<code>given_name</code>
        /// ^= \"Jon\"". 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>AttributeValue</i>: The attribute value that must be matched for each user.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the filter string is empty, <code>ListUsers</code> returns all users in the user
        /// pool.
        /// </para>
        ///  
        /// <para>
        /// You can only search for the following standard attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>username</code> (case-sensitive)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>email</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>phone_number</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>given_name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>family_name</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>preferred_username</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>cognito:user_status</code> (called <b>Enabled</b> in the Console) (case-sensitive)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>status</code> (case-insensitive)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Custom attributes are not searchable.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/cognito/latest/developerguide/how-to-manage-user-accounts.html#cognito-user-pools-searching-for-users-using-listusers-api">Searching
        /// for Users Using the ListUsers API</a> and <a href="http://docs.aws.amazon.com/cognito/latest/developerguide/how-to-manage-user-accounts.html#cognito-user-pools-searching-for-users-listusers-api-examples">Examples
        /// of Using the ListUsers API</a> in the <i>Amazon Cognito Developer Guide</i>.
        /// </para>
        /// </summary>
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
        /// Maximum number of users to be returned.
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
        /// The user pool ID for the user pool on which the search should be performed.
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

    }
}