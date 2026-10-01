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

namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// An object that contains information needed to create a data source connection that
    /// uses OAuth client credentials. This option is available for data source connections
    /// that are made with Snowflake, Starburst, and Databricks.
    /// </summary>
    public partial class OAuthParameters
    {
        /// <summary>
        /// Gets and sets the property IdentityProviderCACertificatesBundleS3Uri. 
        /// <para>
        /// The S3 URI of the identity provider's CA certificates bundle in PEM format. Use this
        /// parameter to provide a custom CA certificate bundle for the identity provider when
        /// the default trust store does not include the required certificates.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string IdentityProviderCACertificatesBundleS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderCACertificatesBundleS3Uri property is set.
        /// </summary>
        internal bool IsSetIdentityProviderCACertificatesBundleS3Uri() => this.IdentityProviderCACertificatesBundleS3Uri != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderResourceUri. 
        /// <para>
        /// The resource uri of the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string IdentityProviderResourceUri { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderResourceUri property is set.
        /// </summary>
        internal bool IsSetIdentityProviderResourceUri() => this.IdentityProviderResourceUri != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderVpcConnectionProperties.
        /// </summary>
        public VpcConnectionProperties IdentityProviderVpcConnectionProperties { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderVpcConnectionProperties property is set.
        /// </summary>
        internal bool IsSetIdentityProviderVpcConnectionProperties() => this.IdentityProviderVpcConnectionProperties != null;

        /// <summary>
        /// Gets and sets the property OAuthScope. 
        /// <para>
        /// The OAuth scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string OAuthScope { get; set; }

        /// <summary>
        /// Checks to see if the OAuthScope property is set.
        /// </summary>
        internal bool IsSetOAuthScope() => this.OAuthScope != null;

        /// <summary>
        /// Gets and sets the property TokenProviderUrl. 
        /// <para>
        /// The token endpoint URL of the identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string TokenProviderUrl { get; set; }

        /// <summary>
        /// Checks to see if the TokenProviderUrl property is set.
        /// </summary>
        internal bool IsSetTokenProviderUrl() => this.TokenProviderUrl != null;
    }
}
