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

namespace Amazon.Signin.Model
{
    /// <summary>
    /// Container for the parameters to the CreateOAuth2TokenWithTokenExchange operation.
    /// Exchanges a supported token for an OAuth 2.0 access token scoped to a resource, which
    /// you can use to access AWS services from applications.
    /// </summary>
    public partial class CreateOAuth2TokenWithTokenExchangeRequest : AmazonSigninRequest
    {
        /// <summary>
        /// Gets and sets the property GrantType. The OAuth 2.0 grant type. Currently only supports
        /// "urn:ietf:params:oauth:grant-type:token-exchange".
        /// </summary>
        [AWSProperty(Required = true)]
        public string GrantType { get; set; }

        /// <summary>
        /// Checks to see if the GrantType property is set.
        /// </summary>
        internal bool IsSetGrantType() => this.GrantType != null;

        /// <summary>
        /// Gets and sets the property Resource. The OAuth resource for which the access token
        /// is requested. Required when "grant_type=urn:ietf:params:oauth:grant-type:token-exchange".
        /// Example: "glue.amazonaws.com".
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string Resource { get; set; }

        /// <summary>
        /// Checks to see if the Resource property is set.
        /// </summary>
        internal bool IsSetResource() => this.Resource != null;

        /// <summary>
        /// Gets and sets the property Scope. IAM managed policy Amazon Resource Names (ARNs)
        /// to apply as session policies that further scope down the permissions of the issued
        /// access token, provided as a space-delimited list. Example: "arn:aws:iam::444455556666:policy/MyPolicy".
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property SubjectToken. The subject token that represents the identity
        /// of the party on whose behalf the request is made. Required when "grant_type=urn:ietf:params:oauth:grant-type:token-exchange".
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 4, Max = 20000)]
        public string SubjectToken { get; set; }

        /// <summary>
        /// Checks to see if the SubjectToken property is set.
        /// </summary>
        internal bool IsSetSubjectToken() => this.SubjectToken != null;

        /// <summary>
        /// Gets and sets the property SubjectTokenType. The token type of the subject token.
        /// Currently only supports "urn:ietf:params:oauth:token-type:jwt". Required when "grant_type=urn:ietf:params:oauth:grant-type:token-exchange".
        /// </summary>
        public string SubjectTokenType { get; set; }

        /// <summary>
        /// Checks to see if the SubjectTokenType property is set.
        /// </summary>
        internal bool IsSetSubjectTokenType() => this.SubjectTokenType != null;
    }
}
