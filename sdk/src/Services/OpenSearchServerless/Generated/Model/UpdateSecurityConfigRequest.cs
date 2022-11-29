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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSecurityConfig operation.
    /// Updates a security configuration for OpenSearch Serverless. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
    /// authentication for Amazon OpenSearch Serverless</a>.
    /// </summary>
    public partial class UpdateSecurityConfigRequest : AmazonOpenSearchServerlessRequest
    {
        private string _clientToken;
        private string _configVersion;
        private string _description;
        private string _id;
        private SamlConfigOptions _samlOptions;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigVersion. 
        /// <para>
        /// The version of the security configuration to be updated. You can find the most recent
        /// version of a security configuration using the <code>GetSecurityPolicy</code> command.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=36)]
        public string ConfigVersion
        {
            get { return this._configVersion; }
            set { this._configVersion = value; }
        }

        // Check to see if ConfigVersion property is set
        internal bool IsSetConfigVersion()
        {
            return this._configVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The security configuration identifier. For SAML the ID will be <code>saml/&lt;accountId&gt;/&lt;idpProviderName&gt;</code>.
        /// For example, <code>saml/123456789123/OKTADev</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SamlOptions. 
        /// <para>
        /// SAML options in in the form of a key-value map.
        /// </para>
        /// </summary>
        public SamlConfigOptions SamlOptions
        {
            get { return this._samlOptions; }
            set { this._samlOptions = value; }
        }

        // Check to see if SamlOptions property is set
        internal bool IsSetSamlOptions()
        {
            return this._samlOptions != null;
        }

    }
}