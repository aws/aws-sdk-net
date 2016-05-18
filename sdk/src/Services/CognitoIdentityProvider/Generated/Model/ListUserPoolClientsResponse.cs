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
    /// Represents the response from the server that lists user pool clients.
    /// </summary>
    public partial class ListUserPoolClientsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<UserPoolClientDescription> _userPoolClients = new List<UserPoolClientDescription>();

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
        /// Gets and sets the property UserPoolClients. 
        /// <para>
        /// The user pool clients in the response that lists user pool clients.
        /// </para>
        /// </summary>
        public List<UserPoolClientDescription> UserPoolClients
        {
            get { return this._userPoolClients; }
            set { this._userPoolClients = value; }
        }

        // Check to see if UserPoolClients property is set
        internal bool IsSetUserPoolClients()
        {
            return this._userPoolClients != null && this._userPoolClients.Count > 0; 
        }

    }
}