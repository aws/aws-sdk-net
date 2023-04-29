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
    /// Container for the parameters to the CreateSecurityConfig operation.
    /// Specifies a security configuration for OpenSearch Serverless. For more information,
    /// see <a href="https://docs.aws.amazon.com/opensearch-service/latest/developerguide/serverless-saml.html">SAML
    /// authentication for Amazon OpenSearch Serverless</a>.
    /// </summary>
    public partial class CreateSecurityConfigRequest : AmazonOpenSearchServerlessRequest
    {
        private string _clientToken;
        private string _description;
        private string _name;
        private SamlConfigOptions _samlOptions;
        private SecurityConfigType _type;

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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=32)]
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
        /// Gets and sets the property SamlOptions. 
        /// <para>
        /// Describes SAML options in in the form of a key-value map. This field is required if
        /// you specify <code>saml</code> for the <code>type</code> parameter.
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

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of security configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SecurityConfigType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}