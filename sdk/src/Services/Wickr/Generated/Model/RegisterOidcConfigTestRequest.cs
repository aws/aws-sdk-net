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
 * Do not modify this file. This file is generated from the wickr-2024-02-01.normal.json service model.
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
namespace Amazon.Wickr.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterOidcConfigTest operation.
    /// Tests an OpenID Connect (OIDC) configuration for a Wickr network by validating the
    /// connection to the identity provider and retrieving its supported capabilities.
    /// </summary>
    public partial class RegisterOidcConfigTestRequest : AmazonWickrRequest
    {
        private string _certificate;
        private string _extraAuthParams;
        private string _issuer;
        private string _networkId;
        private string _scopes;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The CA certificate for secure communication with the OIDC provider (optional).
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraAuthParams. 
        /// <para>
        /// Additional authentication parameters to include in the test (optional).
        /// </para>
        /// </summary>
        public string ExtraAuthParams
        {
            get { return this._extraAuthParams; }
            set { this._extraAuthParams = value; }
        }

        // Check to see if ExtraAuthParams property is set
        internal bool IsSetExtraAuthParams()
        {
            return this._extraAuthParams != null;
        }

        /// <summary>
        /// Gets and sets the property Issuer. 
        /// <para>
        /// The issuer URL of the OIDC provider to test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Issuer
        {
            get { return this._issuer; }
            set { this._issuer = value; }
        }

        // Check to see if Issuer property is set
        internal bool IsSetIssuer()
        {
            return this._issuer != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkId. 
        /// <para>
        /// The ID of the Wickr network for which the OIDC configuration will be tested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=8, Max=8)]
        public string NetworkId
        {
            get { return this._networkId; }
            set { this._networkId = value; }
        }

        // Check to see if NetworkId property is set
        internal bool IsSetNetworkId()
        {
            return this._networkId != null;
        }

        /// <summary>
        /// Gets and sets the property Scopes. 
        /// <para>
        /// The OAuth scopes to test with the OIDC provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Scopes
        {
            get { return this._scopes; }
            set { this._scopes = value; }
        }

        // Check to see if Scopes property is set
        internal bool IsSetScopes()
        {
            return this._scopes != null;
        }

    }
}