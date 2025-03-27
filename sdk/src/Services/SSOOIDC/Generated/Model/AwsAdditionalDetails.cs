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
 * Do not modify this file. This file is generated from the sso-oidc-2019-06-10.normal.json service model.
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
namespace Amazon.SSOOIDC.Model
{
    /// <summary>
    /// This structure contains Amazon Web Services-specific parameter extensions for the
    /// token endpoint responses and includes the identity context.
    /// </summary>
    public partial class AwsAdditionalDetails
    {
        private string _identityContext;

        /// <summary>
        /// Gets and sets the property IdentityContext. 
        /// <para>
        /// STS context assertion that carries a user identifier to the Amazon Web Services service
        /// that it calls and can be used to obtain an identity-enhanced IAM role session. This
        /// value corresponds to the <c>sts:identity_context</c> claim in the ID token.
        /// </para>
        /// </summary>
        public string IdentityContext
        {
            get { return this._identityContext; }
            set { this._identityContext = value; }
        }

        // Check to see if IdentityContext property is set
        internal bool IsSetIdentityContext()
        {
            return this._identityContext != null;
        }

    }
}