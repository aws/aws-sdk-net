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
    /// This is the response object from the VerifySoftwareToken operation.
    /// </summary>
    public partial class VerifySoftwareTokenResponse : AmazonWebServiceResponse
    {
        private string _session;
        private VerifySoftwareTokenResponseType _status;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// This session ID satisfies an <c>MFA_SETUP</c> challenge. Supply the session ID in
        /// your challenge response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=20, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Amazon Cognito can accept or reject the code that you provide. This response parameter
        /// indicates the success of TOTP verification. Some reasons that this operation might
        /// return an error are clock skew on the user's device and excessive retries.
        /// </para>
        /// </summary>
        public VerifySoftwareTokenResponseType Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}