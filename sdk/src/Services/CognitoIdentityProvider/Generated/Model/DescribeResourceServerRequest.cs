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
    /// Container for the parameters to the DescribeResourceServer operation.
    /// Describes a resource server. For more information about resource servers, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pools-define-resource-servers.html">Access
    /// control with resource servers</a>.
    /// </summary>
    public partial class DescribeResourceServerRequest : AmazonCognitoIdentityProviderRequest
    {
        private string _identifier;
        private string _userPoolId;

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// A unique resource server identifier for the resource server. The identifier can be
        /// an API friendly name like <c>solar-system-data</c>. You can also set an API URL like
        /// <c>https://solar-system-data-api.example.com</c> as your identifier.
        /// </para>
        ///  
        /// <para>
        /// Amazon Cognito represents scopes in the access token in the format <c>$resource-server-identifier/$scope</c>.
        /// Longer scope-identifier strings increase the size of your access tokens.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property UserPoolId. 
        /// <para>
        /// The ID of the user pool that hosts the resource server.
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