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
    /// Details for SASL/OAUTHBEARER using client credentials grant with JWT client assertion.
    /// </summary>
    public partial class KafkaClusterOAuthClientCredentialsAssertion
    {
        private string _audience;
        private JwtSigningAlgorithm _signingAlgorithm;
        private string _tokenRequestSecretArn;

        /// <summary>
        /// Gets and sets the property Audience. 
        /// <para>
        /// The audience for the JWT client assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Audience
        {
            get { return this._audience; }
            set { this._audience = value; }
        }

        // Check to see if Audience property is set
        internal bool IsSetAudience()
        {
            return this._audience != null;
        }

        /// <summary>
        /// Gets and sets the property SigningAlgorithm. 
        /// <para>
        /// The signing algorithm for the JWT client assertion.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JwtSigningAlgorithm SigningAlgorithm
        {
            get { return this._signingAlgorithm; }
            set { this._signingAlgorithm = value; }
        }

        // Check to see if SigningAlgorithm property is set
        internal bool IsSetSigningAlgorithm()
        {
            return this._signingAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property TokenRequestSecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Secrets Manager secret containing the signing
        /// key.
        /// </para>
        /// </summary>
        public string TokenRequestSecretArn
        {
            get { return this._tokenRequestSecretArn; }
            set { this._tokenRequestSecretArn = value; }
        }

        // Check to see if TokenRequestSecretArn property is set
        internal bool IsSetTokenRequestSecretArn()
        {
            return this._tokenRequestSecretArn != null;
        }

    }
}