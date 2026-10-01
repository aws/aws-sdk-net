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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property ClientCredentials. 
        /// <para>
        /// Details for SASL/OAUTHBEARER using standard client_credentials grant.
        /// </para>
        /// </summary>
        public KafkaClusterOAuthClientCredentials ClientCredentials { get; set; }

        /// <summary>
        /// Checks to see if the ClientCredentials property is set.
        /// </summary>
        internal bool IsSetClientCredentials() => this.ClientCredentials != null;

        /// <summary>
        /// Gets and sets the property ClientCredentialsAssertion. 
        /// <para>
        /// Details for SASL/OAUTHBEARER using client credentials grant with JWT client assertion.
        /// </para>
        /// </summary>
        public KafkaClusterOAuthClientCredentialsAssertion ClientCredentialsAssertion { get; set; }

        /// <summary>
        /// Checks to see if the ClientCredentialsAssertion property is set.
        /// </summary>
        internal bool IsSetClientCredentialsAssertion() => this.ClientCredentialsAssertion != null;

        /// <summary>
        /// Gets and sets the property IamJwtBearer. 
        /// <para>
        /// Details for SASL/OAUTHBEARER using JWT Bearer assertion grant (RFC 7523).
        /// </para>
        /// </summary>
        public KafkaClusterOAuthIamJwtBearer IamJwtBearer { get; set; }

        /// <summary>
        /// Checks to see if the IamJwtBearer property is set.
        /// </summary>
        internal bool IsSetIamJwtBearer() => this.IamJwtBearer != null;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// OAuth scope to request.
        /// </para>
        /// </summary>
        public string Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TokenEndpointAuthenticationMethod. 
        /// <para>
        /// How client credentials are sent to the identity provider. Valid values are POST, BASIC,
        /// or NONE.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TokenEndpointAuthenticationMethod TokenEndpointAuthenticationMethod { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpointAuthenticationMethod property is set.
        /// </summary>
        internal bool IsSetTokenEndpointAuthenticationMethod() => this.TokenEndpointAuthenticationMethod != null;

        /// <summary>
        /// Gets and sets the property TokenEndpointTlsCertificateArn. 
        /// <para>
        /// Secrets Manager ARN containing a custom CA certificate for the identity provider.
        /// </para>
        /// </summary>
        public string TokenEndpointTlsCertificateArn { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpointTlsCertificateArn property is set.
        /// </summary>
        internal bool IsSetTokenEndpointTlsCertificateArn() => this.TokenEndpointTlsCertificateArn != null;

        /// <summary>
        /// Gets and sets the property TokenEndpointUrl. 
        /// <para>
        /// The HTTPS URL of the OAuth token endpoint that vends OAuth Bearer tokens per RFC 6749.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TokenEndpointUrl { get; set; }

        /// <summary>
        /// Checks to see if the TokenEndpointUrl property is set.
        /// </summary>
        internal bool IsSetTokenEndpointUrl() => this.TokenEndpointUrl != null;
    }
}
