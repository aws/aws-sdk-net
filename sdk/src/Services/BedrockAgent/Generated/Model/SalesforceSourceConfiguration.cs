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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// The endpoint information to connect to your Salesforce data source.
    /// </summary>
    public partial class SalesforceSourceConfiguration
    {
        private SalesforceAuthType _authType;
        private string _credentialsSecretArn;
        private string _hostUrl;

        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The supported authentication type to authenticate and connect to your Salesforce instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SalesforceAuthType AuthType
        {
            get { return this._authType; }
            set { this._authType = value; }
        }

        // Check to see if AuthType property is set
        internal bool IsSetAuthType()
        {
            return this._authType != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialsSecretArn. 
        /// <para>
        /// The Amazon Resource Name of an Secrets Manager secret that stores your authentication
        /// credentials for your Salesforce instance URL. For more information on the key-value
        /// pairs that must be included in your secret, depending on your authentication type,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/salesforce-data-source-connector.html#configuration-salesforce-connector">Salesforce
        /// connection configuration</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CredentialsSecretArn
        {
            get { return this._credentialsSecretArn; }
            set { this._credentialsSecretArn = value; }
        }

        // Check to see if CredentialsSecretArn property is set
        internal bool IsSetCredentialsSecretArn()
        {
            return this._credentialsSecretArn != null;
        }

        /// <summary>
        /// Gets and sets the property HostUrl. 
        /// <para>
        /// The Salesforce host URL or instance URL.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string HostUrl
        {
            get { return this._hostUrl; }
            set { this._hostUrl = value; }
        }

        // Check to see if HostUrl property is set
        internal bool IsSetHostUrl()
        {
            return this._hostUrl != null;
        }

    }
}