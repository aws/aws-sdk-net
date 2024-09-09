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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
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
namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// Information about the OIDC-compliant identity provider (IdP) used to authenticate
    /// end users of an Amazon Q Business web experience.
    /// </summary>
    public partial class OpenIDConnectProviderConfiguration
    {
        private string _secretsArn;
        private string _secretsRole;

        /// <summary>
        /// Gets and sets the property SecretsArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a Secrets Manager secret containing the OIDC client
        /// secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string SecretsArn
        {
            get { return this._secretsArn; }
            set { this._secretsArn = value; }
        }

        // Check to see if SecretsArn property is set
        internal bool IsSetSecretsArn()
        {
            return this._secretsArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecretsRole. 
        /// <para>
        /// An IAM role with permissions to access KMS to decrypt the Secrets Manager secret containing
        /// your OIDC client secret.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1284)]
        public string SecretsRole
        {
            get { return this._secretsRole; }
            set { this._secretsRole = value; }
        }

        // Check to see if SecretsRole property is set
        internal bool IsSetSecretsRole()
        {
            return this._secretsRole != null;
        }

    }
}