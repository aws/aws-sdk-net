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
    /// Details for SASL/OAUTHBEARER using client credentials grant with JWT client assertion.
    /// </summary>
    public partial class KafkaClusterOAuthClientCredentialsAssertion
    {
        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The audience for the JWT client assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Audience { get; set; }

        /// <summary>
        /// Checks to see if the Audience property is set.
        /// </summary>
        internal bool IsSetAudience() => this.Audience != null;

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm for the JWT client assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public JwtSigningAlgorithm SigningAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SigningAlgorithm property is set.
        /// </summary>
        internal bool IsSetSigningAlgorithm() => this.SigningAlgorithm != null;

        /// <summary>
        /// Gets and sets the property TokenRequestSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret containing the signing
        /// key.
        /// </para>
        /// </summary>
        public string TokenRequestSecretArn { get; set; }

        /// <summary>
        /// Checks to see if the TokenRequestSecretArn property is set.
        /// </summary>
        internal bool IsSetTokenRequestSecretArn() => this.TokenRequestSecretArn != null;
    }
}
