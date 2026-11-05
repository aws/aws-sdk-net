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

namespace Amazon.Continuum.Model
{
    /// <summary>
    /// This is the response object from the StartIntegrationAuthorization operation.
    /// </summary>
    public partial class StartIntegrationAuthorizationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CodeChallenge. The PKCE code challenge to send as the OAuth
        /// `code_challenge` parameter.
        /// </summary>
        [AWSProperty(Required = true, Min = 43, Max = 128)]
        public string CodeChallenge { get; set; }

        /// <summary>
        /// Checks to see if the CodeChallenge property is set.
        /// </summary>
        internal bool IsSetCodeChallenge() => this.CodeChallenge != null;

        /// <summary>
        /// Gets and sets the property CodeChallengeMethod. The PKCE challenge method to send
        /// as the OAuth `code_challenge_method` parameter.
        /// </summary>
        [AWSProperty(Required = true)]
        public OAuthCodeChallengeMethod CodeChallengeMethod { get; set; }

        /// <summary>
        /// Checks to see if the CodeChallengeMethod property is set.
        /// </summary>
        internal bool IsSetCodeChallengeMethod() => this.CodeChallengeMethod != null;

        /// <summary>
        /// Gets and sets the property ExpiresAt. The time after which CreateIntegration no longer
        /// accepts this authorization.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Checks to see if the ExpiresAt property is set.
        /// </summary>
        internal bool IsSetExpiresAt() => this.ExpiresAt.HasValue;

        /// <summary>
        /// Gets and sets the property State. An opaque value to send as the OAuth `state` parameter.
        /// Pass the value the provider returns in its callback to CreateIntegration as `authorization.state`.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 1024)]
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;
    }
}
