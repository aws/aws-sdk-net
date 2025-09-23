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
    /// This structure contains Amazon Web Services-specific parameter extensions and the
    /// <a href="https://docs.aws.amazon.com/singlesignon/latest/userguide/trustedidentitypropagation-overview.html">identity
    /// context</a>.
    /// </summary>
    public partial class AwsAdditionalDetails
    {
        private string _identityContext;

        /// <summary>
        /// Gets and sets the property IdentityContext. 
        /// <para>
        /// The trusted context assertion is signed and encrypted by STS. It provides access to
        /// <c>sts:identity_context</c> claim in the <c>idToken</c> without JWT parsing
        /// </para>
        ///  
        /// <para>
        /// Identity context comprises information that Amazon Web Services services use to make
        /// authorization decisions when they receive requests.
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