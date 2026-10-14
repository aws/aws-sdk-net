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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// This session ID satisfies an <c>MFA_SETUP</c> challenge. Supply the session ID in
        /// your challenge response.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 4096)]
        public string Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Amazon Cognito can accept or reject the code that you provide. This response parameter
        /// indicates the success of TOTP verification. Some reasons that this operation might
        /// return an error are clock skew on the user's device and excessive retries.
        /// </para>
        /// </summary>
        public VerifySoftwareTokenResponseType Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
