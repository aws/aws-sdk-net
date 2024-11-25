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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An object that contains information needed to create a data source connection that
    /// uses OAuth client credentials. This option is available for data source connections
    /// that are made with Snowflake and Starburst.
    /// </summary>
    public partial class OAuthParameters
    {
        private string _identityProviderResourceUri;
        private VpcConnectionProperties _identityProviderVpcConnectionProperties;
        private string _oAuthScope;
        private string _tokenProviderUrl;

        /// <summary>
        /// Gets and sets the property IdentityProviderResourceUri. 
        /// <para>
        /// The resource uri of the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string IdentityProviderResourceUri
        {
            get { return this._identityProviderResourceUri; }
            set { this._identityProviderResourceUri = value; }
        }

        // Check to see if IdentityProviderResourceUri property is set
        internal bool IsSetIdentityProviderResourceUri()
        {
            return this._identityProviderResourceUri != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderVpcConnectionProperties.
        /// </summary>
        public VpcConnectionProperties IdentityProviderVpcConnectionProperties
        {
            get { return this._identityProviderVpcConnectionProperties; }
            set { this._identityProviderVpcConnectionProperties = value; }
        }

        // Check to see if IdentityProviderVpcConnectionProperties property is set
        internal bool IsSetIdentityProviderVpcConnectionProperties()
        {
            return this._identityProviderVpcConnectionProperties != null;
        }

        /// <summary>
        /// Gets and sets the property OAuthScope. 
        /// <para>
        /// The OAuth scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string OAuthScope
        {
            get { return this._oAuthScope; }
            set { this._oAuthScope = value; }
        }

        // Check to see if OAuthScope property is set
        internal bool IsSetOAuthScope()
        {
            return this._oAuthScope != null;
        }

        /// <summary>
        /// Gets and sets the property TokenProviderUrl. 
        /// <para>
        /// The token endpoint URL of the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string TokenProviderUrl
        {
            get { return this._tokenProviderUrl; }
            set { this._tokenProviderUrl = value; }
        }

        // Check to see if TokenProviderUrl property is set
        internal bool IsSetTokenProviderUrl()
        {
            return this._tokenProviderUrl != null;
        }

    }
}