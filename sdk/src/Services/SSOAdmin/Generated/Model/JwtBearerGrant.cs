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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// A structure that defines configuration settings for an application that supports the
    /// JWT Bearer Token Authorization Grant.
    /// </summary>
    public partial class JwtBearerGrant
    {
        private List<AuthorizedTokenIssuer> _authorizedTokenIssuers = AWSConfigs.InitializeCollections ? new List<AuthorizedTokenIssuer>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizedTokenIssuers. 
        /// <para>
        /// A list of allowed token issuers trusted by the Identity Center instances for this
        /// application.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<AuthorizedTokenIssuer> AuthorizedTokenIssuers
        {
            get { return this._authorizedTokenIssuers; }
            set { this._authorizedTokenIssuers = value; }
        }

        // Check to see if AuthorizedTokenIssuers property is set
        internal bool IsSetAuthorizedTokenIssuers()
        {
            return this._authorizedTokenIssuers != null && (this._authorizedTokenIssuers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}