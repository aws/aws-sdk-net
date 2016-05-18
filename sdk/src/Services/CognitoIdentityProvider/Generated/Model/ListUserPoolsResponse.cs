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
    /// Represents the response to list user pools.
    /// </summary>
    public partial class ListUserPoolsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UserPoolDescriptionType> _userPools = new List<UserPoolDescriptionType>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An identifier that was returned from the previous call to this operation, which can
        /// be used to return the next set of items in the list.
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
        /// Gets and sets the property UserPools. 
        /// <para>
        /// The user pools from the response to list users.
        /// </para>
        /// </summary>
        public List<UserPoolDescriptionType> UserPools
        {
            get { return this._userPools; }
            set { this._userPools = value; }
        }

        // Check to see if UserPools property is set
        internal bool IsSetUserPools()
        {
            return this._userPools != null && this._userPools.Count > 0; 
        }

    }
}