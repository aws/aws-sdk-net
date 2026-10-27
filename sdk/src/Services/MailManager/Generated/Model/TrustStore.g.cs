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
    /// The trust store used for mutual TLS authentication. It contains the certificate authority
    /// (CA) certificates and optional certificate revocation list (CRL).
    /// </summary>
    public partial class TrustStore
    {
        /// <summary>
        /// Gets and sets the property CAContent. 
        /// <para>
        /// The PEM-encoded certificate authority (CA) certificates bundle for the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 500000)]
        public string CAContent { get; set; }

        /// <summary>
        /// Checks to see if the CAContent property is set.
        /// </summary>
        internal bool IsSetCAContent() => this.CAContent != null;

        /// <summary>
        /// Gets and sets the property CrlContent. 
        /// <para>
        /// The PEM-encoded certificate revocation lists (CRLs) for the trust store. There can
        /// be one CRL per certificate authority (CA) in the trust store.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 500000)]
        public string CrlContent { get; set; }

        /// <summary>
        /// Checks to see if the CrlContent property is set.
        /// </summary>
        internal bool IsSetCrlContent() => this.CrlContent != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used to encrypt the trust store contents.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
