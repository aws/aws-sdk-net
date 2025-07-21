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
    /// The configuration for a credential provider. This structure defines how the gateway
    /// authenticates with the target endpoint.
    /// </summary>
    public partial class CredentialProviderConfiguration
    {
        private CredentialProvider _credentialProvider;
        private CredentialProviderType _credentialProviderType;

        /// <summary>
        /// Gets and sets the property CredentialProvider. 
        /// <para>
        /// The credential provider. This field contains the specific configuration for the credential
        /// provider type.
        /// </para>
        /// </summary>
        public CredentialProvider CredentialProvider
        {
            get { return this._credentialProvider; }
            set { this._credentialProvider = value; }
        }

        // Check to see if CredentialProvider property is set
        internal bool IsSetCredentialProvider()
        {
            return this._credentialProvider != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialProviderType. 
        /// <para>
        /// The type of credential provider. This field specifies which authentication method
        /// the gateway uses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CredentialProviderType CredentialProviderType
        {
            get { return this._credentialProviderType; }
            set { this._credentialProviderType = value; }
        }

        // Check to see if CredentialProviderType property is set
        internal bool IsSetCredentialProviderType()
        {
            return this._credentialProviderType != null;
        }

    }
}