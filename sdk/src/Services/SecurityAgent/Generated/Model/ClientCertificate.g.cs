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

namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// A client certificate for mutual TLS (mTLS) authentication to target hosts.
    /// </summary>
    public partial class ClientCertificate
    {
        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A customer-chosen name for this client certificate, used in error messages and console
        /// display.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Origins. 
        /// <para>
        /// The origins (scheme://host[:port]) this certificate applies to. Paths are not supported.
        /// Each hostname can have at most one client certificate.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public List<string> Origins { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Origins property is set.
        /// </summary>
        internal bool IsSetOrigins() => this.Origins != null && (this.Origins.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecretArn. 
        /// <para>
        /// The ARN of the Secrets Manager secret containing the certificate and private key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SecretArn { get; set; }

        /// <summary>
        /// Checks to see if the SecretArn property is set.
        /// </summary>
        internal bool IsSetSecretArn() => this.SecretArn != null;
    }
}
