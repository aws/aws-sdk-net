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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the GetId operation.
    /// Generates (or retrieves) a Cognito ID. Supplying multiple logins will create an implicit
    /// linked account.
    /// 
    ///  
    /// <para>
    /// This is a public API. You do not need any credentials to call this API.
    /// </para>
    /// </summary>
    public partial class GetIdRequest : AmazonCognitoIdentityRequest
    {
        private string _accountId;
        private string _identityPoolId;
        private Dictionary<string, string> _logins = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// A standard AWS account ID (9+ digits).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=15)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// An identity pool ID in the format REGION:GUID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property Logins. 
        /// <para>
        /// A set of optional name-value pairs that map provider names to provider tokens. The
        /// available provider names for <code>Logins</code> are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Facebook: <code>graph.facebook.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon Cognito user pool: <code>cognito-idp.&lt;region&gt;.amazonaws.com/&lt;YOUR_USER_POOL_ID&gt;</code>,
        /// for example, <code>cognito-idp.us-east-1.amazonaws.com/us-east-1_123456789</code>.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Google: <code>accounts.google.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon: <code>www.amazon.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Twitter: <code>api.twitter.com</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Digits: <code>www.digits.com</code> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Max=10)]
        public Dictionary<string, string> Logins
        {
            get { return this._logins; }
            set { this._logins = value; }
        }

        // Check to see if Logins property is set
        internal bool IsSetLogins()
        {
            return this._logins != null && this._logins.Count > 0; 
        }

        /// <summary>
        /// Get the signer to use for this request.
        /// </summary>
        /// <returns>A signer for this request.</returns>
        override protected AbstractAWSSigner CreateSigner()
        {
            return new NullSigner();
        }
    }
}