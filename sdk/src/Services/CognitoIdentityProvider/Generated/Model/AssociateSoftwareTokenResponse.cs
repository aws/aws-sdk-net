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

namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// This is the response object from the AssociateSoftwareToken operation.
    /// </summary>
    public partial class AssociateSoftwareTokenResponse : AmazonWebServiceResponse
    {
        private string _secretCode;
        private string _session;

        /// <summary>
        /// Gets and sets the property SecretCode. 
        /// <para>
        /// A unique generated shared secret code that is used in the TOTP algorithm to generate
        /// a one-time code.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=16)]
        public string SecretCode
        {
            get { return this._secretCode; }
            set { this._secretCode = value; }
        }

        // Check to see if SecretCode property is set
        internal bool IsSetSecretCode()
        {
            return this._secretCode != null;
        }

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session that should be passed both ways in challenge-response calls to the service.
        /// This allows authentication of the user as part of the MFA setup process.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Session
        {
            get { return this._session; }
            set { this._session = value; }
        }

        // Check to see if Session property is set
        internal bool IsSetSession()
        {
            return this._session != null;
        }

    }
}