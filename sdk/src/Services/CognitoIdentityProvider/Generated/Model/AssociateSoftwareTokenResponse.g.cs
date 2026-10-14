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
    /// This is the response object from the AssociateSoftwareToken operation.
    /// </summary>
    public partial class AssociateSoftwareTokenResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property SecretCode. 
        /// <para>
        /// A unique generated shared secret code that is used by the TOTP algorithm to generate
        /// a one-time code.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 16)]
        public string SecretCode { get; set; }

        /// <summary>
        /// Checks to see if the SecretCode property is set.
        /// </summary>
        internal bool IsSetSecretCode() => this.SecretCode != null;

        /// <summary>
        /// Gets and sets the property Session. 
        /// <para>
        /// The session identifier that maintains the state of authentication requests and challenge
        /// responses.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 20, Max = 4096)]
        public string Session { get; set; }

        /// <summary>
        /// Checks to see if the Session property is set.
        /// </summary>
        internal bool IsSetSession() => this.Session != null;
    }
}
