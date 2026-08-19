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

namespace Amazon.SSO.Model
{
    /// <summary>
    /// Provides information about the role credentials that are assigned to the user.
    /// </summary>
    public partial class RoleCredentials
    {
        /// <summary>
        /// Gets and sets the property AccessKeyId. 
        /// <para>
        /// The identifier used for the temporary security credentials. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_use-resources.html">Using
        /// Temporary Security Credentials to Request Access to AWS Resources</a> in the <i>AWS
        /// IAM User Guide</i>.
        /// </para>
        /// </summary>
        public string AccessKeyId { get; set; }

        /// <summary>
        /// Checks to see if the AccessKeyId property is set.
        /// </summary>
        internal bool IsSetAccessKeyId() => this.AccessKeyId != null;

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// The date on which temporary security credentials expire.
        /// </para>
        /// </summary>
        public long? Expiration { get; set; }

        /// <summary>
        /// Checks to see if the Expiration property is set.
        /// </summary>
        internal bool IsSetExpiration() => this.Expiration.HasValue;

        /// <summary>
        /// Gets and sets the property SecretAccessKey. 
        /// <para>
        /// The key that is used to sign the request. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_use-resources.html">Using
        /// Temporary Security Credentials to Request Access to AWS Resources</a> in the <i>AWS
        /// IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SecretAccessKey { get; set; }

        /// <summary>
        /// Checks to see if the SecretAccessKey property is set.
        /// </summary>
        internal bool IsSetSecretAccessKey() => this.SecretAccessKey != null;

        /// <summary>
        /// Gets and sets the property SessionToken. 
        /// <para>
        /// The token used for temporary credentials. For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_temp_use-resources.html">Using
        /// Temporary Security Credentials to Request Access to AWS Resources</a> in the <i>AWS
        /// IAM User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SessionToken { get; set; }

        /// <summary>
        /// Checks to see if the SessionToken property is set.
        /// </summary>
        internal bool IsSetSessionToken() => this.SessionToken != null;
    }
}
