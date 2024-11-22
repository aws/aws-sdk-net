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
    /// This is the response object from the StartWebAuthnRegistration operation.
    /// </summary>
    public partial class StartWebAuthnRegistrationResponse : AmazonWebServiceResponse
    {
        private Amazon.Runtime.Documents.Document _credentialCreationOptions;

        /// <summary>
        /// Gets and sets the property CredentialCreationOptions. 
        /// <para>
        /// The information that a user can provide in their request to register with their passkey
        /// provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Amazon.Runtime.Documents.Document CredentialCreationOptions
        {
            get { return this._credentialCreationOptions; }
            set { this._credentialCreationOptions = value; }
        }

        // Check to see if CredentialCreationOptions property is set
        internal bool IsSetCredentialCreationOptions()
        {
            return !this._credentialCreationOptions.IsNull();
        }

    }
}