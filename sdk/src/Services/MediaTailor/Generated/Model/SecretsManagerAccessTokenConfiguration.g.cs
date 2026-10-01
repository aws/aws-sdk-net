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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// AWS Secrets Manager access token configuration parameters. For information about Secrets
    /// Manager access token authentication, see <a href="https://docs.aws.amazon.com/mediatailor/latest/ug/channel-assembly-access-configuration-access-token.html">Working
    /// with AWS Secrets Manager access token authentication</a>.
    /// </summary>
    public partial class SecretsManagerAccessTokenConfiguration
    {
        /// <summary>
        /// Gets and sets the property HeaderName. 
        /// <para>
        /// The name of the HTTP header used to supply the access token in requests to the source
        /// location.
        /// </para>
        /// </summary>
        public string HeaderName { get; set; }

        /// <summary>
        /// Checks to see if the HeaderName property is set.
        /// </summary>
        internal bool IsSetHeaderName() => this.HeaderName != null;

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AWS Secrets Manager secret that contains the
        /// access token.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SecretStringKey. 
        /// <para>
        /// The AWS Secrets Manager <a href="https://docs.aws.amazon.com/secretsmanager/latest/apireference/API_CreateSecret.html#SecretsManager-CreateSecret-request-SecretString.html">SecretString</a>
        /// key associated with the access token. MediaTailor uses the key to look up SecretString
        /// key and value pair containing the access token.
        /// </para>
        /// </summary>
        public string SecretStringKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretStringKey property is set.
        /// </summary>
        internal bool IsSetSecretStringKey() => this.SecretStringKey != null;
    }
}
