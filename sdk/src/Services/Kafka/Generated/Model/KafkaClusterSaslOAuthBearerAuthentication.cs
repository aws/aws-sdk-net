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
 * Do not modify this file. This file is generated from the kafka-2018-11-14.normal.json service model.
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
namespace Amazon.Kafka.Model
{
    /// <summary>
    /// Details for SASL/OAUTHBEARER client authentication.
    /// </summary>
    public partial class KafkaClusterSaslOAuthBearerAuthentication
    {
        private KafkaClusterOAuthClientCredentials _clientCredentials;
        private KafkaClusterOAuthClientCredentialsAssertion _clientCredentialsAssertion;
        private KafkaClusterOAuthIamJwtBearer _iamJwtBearer;
        private string _scope;
        private TokenEndpointAuthenticationMethod _tokenEndpointAuthenticationMethod;
        private string _tokenEndpointTlsCertificateArn;
        private string _tokenEndpointUrl;

        /// <summary>
        /// Gets and sets the property ClientCredentials. 
        /// <para>
        /// Details for SASL/OAUTHBEARER using standard client_credentials grant.
        /// </para>
        /// </summary>
        public KafkaClusterOAuthClientCredentials ClientCredentials
        {
            get { return this._clientCredentials; }
            set { this._clientCredentials = value; }
        }

        // Check to see if ClientCredentials property is set
        internal bool IsSetClientCredentials()
        {
            return this._clientCredentials != null;
        }

        /// <summary>
        /// Gets and sets the property ClientCredentialsAssertion. 
        /// <para>
        /// Details for SASL/OAUTHBEARER using client credentials grant with JWT client assertion.
        /// </para>
        /// </summary>
        public KafkaClusterOAuthClientCredentialsAssertion ClientCredentialsAssertion
        {
            get { return this._clientCredentialsAssertion; }
            set { this._clientCredentialsAssertion = value; }
        }

        // Check to see if ClientCredentialsAssertion property is set
        internal bool IsSetClientCredentialsAssertion()
        {
            return this._clientCredentialsAssertion != null;
        }

        /// <summary>
        /// Gets and sets the property IamJwtBearer. 
        /// <para>
        /// Details for SASL/OAUTHBEARER using JWT Bearer assertion grant (RFC 7523).
        /// </para>
        /// </summary>
        public KafkaClusterOAuthIamJwtBearer IamJwtBearer
        {
            get { return this._iamJwtBearer; }
            set { this._iamJwtBearer = value; }
        }

        // Check to see if IamJwtBearer property is set
        internal bool IsSetIamJwtBearer()
        {
            return this._iamJwtBearer != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// OAuth scope to request.
        /// </para>
        /// </summary>
        public string Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

        /// <summary>
        /// Gets and sets the property TokenEndpointAuthenticationMethod. 
        /// <para>
        /// How client credentials are sent to the identity provider. Valid values are POST, BASIC,
        /// or NONE.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TokenEndpointAuthenticationMethod TokenEndpointAuthenticationMethod
        {
            get { return this._tokenEndpointAuthenticationMethod; }
            set { this._tokenEndpointAuthenticationMethod = value; }
        }

        // Check to see if TokenEndpointAuthenticationMethod property is set
        internal bool IsSetTokenEndpointAuthenticationMethod()
        {
            return this._tokenEndpointAuthenticationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property TokenEndpointTlsCertificateArn. 
        /// <para>
        /// Secrets Manager ARN containing a custom CA certificate for the identity provider.
        /// </para>
        /// </summary>
        public string TokenEndpointTlsCertificateArn
        {
            get { return this._tokenEndpointTlsCertificateArn; }
            set { this._tokenEndpointTlsCertificateArn = value; }
        }

        // Check to see if TokenEndpointTlsCertificateArn property is set
        internal bool IsSetTokenEndpointTlsCertificateArn()
        {
            return this._tokenEndpointTlsCertificateArn != null;
        }

        /// <summary>
        /// Gets and sets the property TokenEndpointUrl. 
        /// <para>
        /// The HTTPS URL of the OAuth token endpoint that vends OAuth Bearer tokens per RFC 6749.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TokenEndpointUrl
        {
            get { return this._tokenEndpointUrl; }
            set { this._tokenEndpointUrl = value; }
        }

        // Check to see if TokenEndpointUrl property is set
        internal bool IsSetTokenEndpointUrl()
        {
            return this._tokenEndpointUrl != null;
        }

    }
}