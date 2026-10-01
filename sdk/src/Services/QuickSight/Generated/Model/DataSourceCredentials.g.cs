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
    /// Data source credentials. This is a variant type structure. For this structure to be
    /// valid, only one of the attributes can be non-null.
    /// </summary>
    public partial class DataSourceCredentials
    {
        /// <summary>
        /// Gets and sets the property CopySourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a data source that has the credential pair that
        /// you want to use. When <c>CopySourceArn</c> is not null, the credential pair from the
        /// data source in the ARN is used as the credentials for the <c>DataSourceCredentials</c>
        /// structure.
        /// </para>
        /// </summary>
        public string CopySourceArn { get; set; }

        /// <summary>
        /// Checks to see if the CopySourceArn property is set.
        /// </summary>
        internal bool IsSetCopySourceArn() => this.CopySourceArn != null;

        /// <summary>
        /// Gets and sets the property CredentialPair. 
        /// <para>
        /// Credential pair. For more information, see <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_CredentialPair.html">CredentialPair</a>
        /// </c>.
        /// </para>
        /// </summary>
        public CredentialPair CredentialPair { get; set; }

        /// <summary>
        /// Checks to see if the CredentialPair property is set.
        /// </summary>
        internal bool IsSetCredentialPair() => this.CredentialPair != null;

        /// <summary>
        /// Gets and sets the property KeyPairCredentials. 
        /// <para>
        /// The credentials for connecting using key-pair.
        /// </para>
        /// </summary>
        public KeyPairCredentials KeyPairCredentials { get; set; }

        /// <summary>
        /// Checks to see if the KeyPairCredentials property is set.
        /// </summary>
        internal bool IsSetKeyPairCredentials() => this.KeyPairCredentials != null;

        /// <summary>
        /// Gets and sets the property OAuthClientCredentials. 
        /// <para>
        /// The OAuth client credentials for connecting to a data source using OAuth 2.0 client
        /// credentials (2LO) authentication. For more information, see <c> <a href="https://docs.aws.amazon.com/quicksight/latest/APIReference/API_OAuthClientCredentials.html">OAuthClientCredentials</a>
        /// </c>.
        /// </para>
        /// </summary>
        public OAuthClientCredentials OAuthClientCredentials { get; set; }

        /// <summary>
        /// Checks to see if the OAuthClientCredentials property is set.
        /// </summary>
        internal bool IsSetOAuthClientCredentials() => this.OAuthClientCredentials != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the secret associated with the data source in Amazon
        /// Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property WebProxyCredentials. 
        /// <para>
        /// The credentials for connecting through a web proxy server.
        /// </para>
        /// </summary>
        public WebProxyCredentials WebProxyCredentials { get; set; }

        /// <summary>
        /// Checks to see if the WebProxyCredentials property is set.
        /// </summary>
        internal bool IsSetWebProxyCredentials() => this.WebProxyCredentials != null;
    }
}
