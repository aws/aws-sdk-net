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
    /// Represents the response from the server to the request to update the user pool client.
    /// </summary>
    public partial class UpdateUserPoolClientResponse : AmazonWebServiceResponse
    {
        private UserPoolClientType _userPoolClient;

        /// <summary>
        /// Gets and sets the property UserPoolClient. 
        /// <para>
        /// The updated details of your app client.
        /// </para>
        /// </summary>
        public UserPoolClientType UserPoolClient
        {
            get { return this._userPoolClient; }
            set { this._userPoolClient = value; }
        }

        // Check to see if UserPoolClient property is set
        internal bool IsSetUserPoolClient()
        {
            return this._userPoolClient != null;
        }

    }
}