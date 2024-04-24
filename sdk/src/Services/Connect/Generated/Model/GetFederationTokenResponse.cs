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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the GetFederationToken operation.
    /// </summary>
    public partial class GetFederationTokenResponse : AmazonWebServiceResponse
    {
        private Credentials _credentials;
        private string _signInUrl;
        private string _userArn;
        private string _userId;

        /// <summary>
        /// Gets and sets the property Credentials. 
        /// <para>
        /// The credentials to use for federation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Credentials Credentials
        {
            get { return this._credentials; }
            set { this._credentials = value; }
        }

        // Check to see if Credentials property is set
        internal bool IsSetCredentials()
        {
            return this._credentials != null;
        }

        /// <summary>
        /// Gets and sets the property SignInUrl. 
        /// <para>
        /// The URL to sign into the user's instance. 
        /// </para>
        /// </summary>
        public string SignInUrl
        {
            get { return this._signInUrl; }
            set { this._signInUrl = value; }
        }

        // Check to see if SignInUrl property is set
        internal bool IsSetSignInUrl()
        {
            return this._signInUrl != null;
        }

        /// <summary>
        /// Gets and sets the property UserArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the user.
        /// </para>
        /// </summary>
        public string UserArn
        {
            get { return this._userArn; }
            set { this._userArn = value; }
        }

        // Check to see if UserArn property is set
        internal bool IsSetUserArn()
        {
            return this._userArn != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The identifier for the user. This can be the ID or the ARN of the user.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

    }
}