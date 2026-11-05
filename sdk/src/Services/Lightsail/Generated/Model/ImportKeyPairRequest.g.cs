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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the ImportKeyPair operation. Imports a public SSH
    /// key from a specific key pair.
    /// </summary>
    public partial class ImportKeyPairRequest : AmazonLightsailRequest
    {
        /// <summary>
        /// Gets and sets the property KeyPairName. 
        /// <para>
        /// The name of the key pair for which you want to import the public key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string KeyPairName { get; set; }

        /// <summary>
        /// Checks to see if the KeyPairName property is set.
        /// </summary>
        internal bool IsSetKeyPairName() => this.KeyPairName != null;

        /// <summary>
        /// Gets and sets the property PublicKeyBase64. 
        /// <para>
        /// A base64-encoded public key of the <c>ssh-rsa</c> type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PublicKeyBase64 { get; set; }

        /// <summary>
        /// Checks to see if the PublicKeyBase64 property is set.
        /// </summary>
        internal bool IsSetPublicKeyBase64() => this.PublicKeyBase64 != null;
    }
}
