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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// A set of temporary AWS credentials.
    /// </summary>
    public partial class AwsCredentials
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. The AWS access key ID.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property Expiration. The timestamp when the credentials expire.
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property SecretAccessKey. The AWS secret access key.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretAccessKey property is set.
        /// </summary>
        internal bool IsSetSecretAccessKey() => this.SecretAccessKey != null;

        /// <summary>
        /// Gets and sets the property SessionToken. The AWS session token.
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public string SessionToken { get; set; }

        /// <summary>
        /// Checks to see if the SessionToken property is set.
        /// </summary>
        internal bool IsSetSessionToken() => this.SessionToken != null;
    }
}
