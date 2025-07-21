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
    /// Container for the parameters to the UpdateOauth2CredentialProvider operation.
    /// Updates an existing OAuth2 credential provider.
    /// </summary>
    public partial class UpdateOauth2CredentialProviderRequest : AmazonBedrockAgentCoreControlRequest
    {
        private CredentialProviderVendorType _credentialProviderVendor;
        private string _name;
        private Oauth2ProviderConfigInput _oauth2ProviderConfigInput;

        /// <summary>
        /// Gets and sets the property CredentialProviderVendor. 
        /// <para>
        /// The vendor of the OAuth2 credential provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CredentialProviderVendorType CredentialProviderVendor
        {
            get { return this._credentialProviderVendor; }
            set { this._credentialProviderVendor = value; }
        }

        // Check to see if CredentialProviderVendor property is set
        internal bool IsSetCredentialProviderVendor()
        {
            return this._credentialProviderVendor != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the OAuth2 credential provider to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Oauth2ProviderConfigInput. 
        /// <para>
        /// The configuration input for the OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Oauth2ProviderConfigInput Oauth2ProviderConfigInput
        {
            get { return this._oauth2ProviderConfigInput; }
            set { this._oauth2ProviderConfigInput = value; }
        }

        // Check to see if Oauth2ProviderConfigInput property is set
        internal bool IsSetOauth2ProviderConfigInput()
        {
            return this._oauth2ProviderConfigInput != null;
        }

    }
}