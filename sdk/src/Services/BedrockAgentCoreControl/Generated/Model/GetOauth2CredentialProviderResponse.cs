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
    /// This is the response object from the GetOauth2CredentialProvider operation.
    /// </summary>
    public partial class GetOauth2CredentialProviderResponse : AmazonWebServiceResponse
    {
        private Secret _clientSecretArn;
        private DateTime? _createdTime;
        private string _credentialProviderArn;
        private CredentialProviderVendorType _credentialProviderVendor;
        private DateTime? _lastUpdatedTime;
        private string _name;
        private Oauth2ProviderConfigOutput _oauth2ProviderConfigOutput;

        /// <summary>
        /// Gets and sets the property ClientSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the client secret in AWS Secrets Manager.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Secret ClientSecretArn
        {
            get { return this._clientSecretArn; }
            set { this._clientSecretArn = value; }
        }

        // Check to see if ClientSecretArn property is set
        internal bool IsSetClientSecretArn()
        {
            return this._clientSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The timestamp when the OAuth2 credential provider was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CredentialProviderArn. 
        /// <para>
        /// ARN of the credential provider requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialProviderArn
        {
            get { return this._credentialProviderArn; }
            set { this._credentialProviderArn = value; }
        }

        // Check to see if CredentialProviderArn property is set
        internal bool IsSetCredentialProviderArn()
        {
            return this._credentialProviderArn != null;
        }

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
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// The timestamp when the OAuth2 credential provider was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the OAuth2 credential provider.
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
        /// Gets and sets the property Oauth2ProviderConfigOutput. 
        /// <para>
        /// The configuration output for the OAuth2 provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Oauth2ProviderConfigOutput Oauth2ProviderConfigOutput
        {
            get { return this._oauth2ProviderConfigOutput; }
            set { this._oauth2ProviderConfigOutput = value; }
        }

        // Check to see if Oauth2ProviderConfigOutput property is set
        internal bool IsSetOauth2ProviderConfigOutput()
        {
            return this._oauth2ProviderConfigOutput != null;
        }

    }
}