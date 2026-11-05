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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Amazon Web Services credentials for API authentication.
    /// </summary>
    public partial class Credentials
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public Credentials() { }

        /// <summary>
        /// Instantiates Credentials with the parameterized properties
        /// </summary>
        /// <param name="accessKeyId">The access key ID that identifies the temporary security credentials.</param>
        /// <param name="secretAccessKey">The secret access key that can be used to sign requests.</param>
        /// <param name="sessionToken">The token that users must pass to the service API to use the temporary   credentials.</param>
        /// <param name="expiration">The date on which the current credentials expire.</param>
        public Credentials(string accessKeyId, string secretAccessKey, string sessionToken, DateTime? expiration)
        {
            this.AccessKeyId = accessKeyId;
            this.SecretAccessKey = secretAccessKey;
            this.SessionToken = sessionToken;
            this.Expiration = expiration;
        }

        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The access key ID that identifies the temporary security credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 16, Max = 128)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date on which the current credentials expire.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public override DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The secret access key that can be used to sign requests.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretAccessKey property is set.
        /// </summary>
        internal bool IsSetSecretAccessKey() => this.SecretAccessKey != null;

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// The token that users must pass to the service API to use the temporary credentials.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SessionToken { get; set; }

        /// <summary>
        /// Checks to see if the SessionToken property is set.
        /// </summary>
        internal bool IsSetSessionToken() => this.SessionToken != null;
    }
}
