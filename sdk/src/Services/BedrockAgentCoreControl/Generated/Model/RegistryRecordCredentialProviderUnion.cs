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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Union of supported credential provider types for registry record synchronization.
    /// </summary>
    public partial class RegistryRecordCredentialProviderUnion
    {
        private RegistryRecordIamCredentialProvider _iamCredentialProvider;
        private RegistryRecordOAuthCredentialProvider _oauthCredentialProvider;

        /// <summary>
        /// Gets and sets the property IamCredentialProvider. 
        /// <para>
        /// The IAM credential provider configuration for authenticating with the external source
        /// using SigV4 signing.
        /// </para>
        /// </summary>
        public RegistryRecordIamCredentialProvider IamCredentialProvider
        {
            get { return this._iamCredentialProvider; }
            set { this._iamCredentialProvider = value; }
        }

        // Check to see if IamCredentialProvider property is set
        internal bool IsSetIamCredentialProvider()
        {
            return this._iamCredentialProvider != null;
        }

        /// <summary>
        /// Gets and sets the property OauthCredentialProvider. 
        /// <para>
        /// The OAuth credential provider configuration for authenticating with the external source.
        /// </para>
        /// </summary>
        public RegistryRecordOAuthCredentialProvider OauthCredentialProvider
        {
            get { return this._oauthCredentialProvider; }
            set { this._oauthCredentialProvider = value; }
        }

        // Check to see if OauthCredentialProvider property is set
        internal bool IsSetOauthCredentialProvider()
        {
            return this._oauthCredentialProvider != null;
        }

    }
}