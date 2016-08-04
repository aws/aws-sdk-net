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
    /// The device verifier against which it will be authenticated.
    /// </summary>
    public partial class DeviceSecretVerifierConfigType
    {
        private string _passwordVerifier;
        private string _salt;

        /// <summary>
        /// Gets and sets the property PasswordVerifier. 
        /// <para>
        /// The password verifier.
        /// </para>
        /// </summary>
        public string PasswordVerifier
        {
            get { return this._passwordVerifier; }
            set { this._passwordVerifier = value; }
        }

        // Check to see if PasswordVerifier property is set
        internal bool IsSetPasswordVerifier()
        {
            return this._passwordVerifier != null;
        }

        /// <summary>
        /// Gets and sets the property Salt. 
        /// <para>
        /// The salt.
        /// </para>
        /// </summary>
        public string Salt
        {
            get { return this._salt; }
            set { this._salt = value; }
        }

        // Check to see if Salt property is set
        internal bool IsSetSalt()
        {
            return this._salt != null;
        }

    }
}