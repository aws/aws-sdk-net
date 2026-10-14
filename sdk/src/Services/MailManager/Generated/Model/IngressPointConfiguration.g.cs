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

namespace Amazon.MailManager.Model
{
    /// <summary>
    /// The configuration of the ingress endpoint resource.
    /// </summary>
    public partial class IngressPointConfiguration
    {
        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The SecretsManager::Secret ARN of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;

        /// <summary>
        /// Gets and sets the property SmtpPassword. 
        /// <para>
        /// The password of the ingress endpoint resource.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 8, Max = 64)]
        public string SmtpPassword { get; set; }

        /// <summary>
        /// Checks to see if the SmtpPassword property is set.
        /// </summary>
        internal bool IsSetSmtpPassword() => this.SmtpPassword != null;

        /// <summary>
        /// Gets and sets the property TlsAuthConfiguration. 
        /// <para>
        /// The mutual TLS authentication configuration of the ingress endpoint resource.
        /// </para>
        /// </summary>
        public TlsAuthConfiguration TlsAuthConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the TlsAuthConfiguration property is set.
        /// </summary>
        internal bool IsSetTlsAuthConfiguration() => this.TlsAuthConfiguration != null;
    }
}
