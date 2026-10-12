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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// The role of the key, the algorithm it supports, and the cryptographic operations allowed
    /// with the key. This data is immutable after the key is created.
    /// </summary>
    public partial class KeyAttributes
    {
        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The key algorithm to be use during creation of an Amazon Web Services Payment Cryptography
        /// key.
        /// </para>
        ///  
        /// <para>
        /// For symmetric keys, Amazon Web Services Payment Cryptography supports <c>AES</c> and
        /// <c>TDES</c> algorithms. For asymmetric keys, Amazon Web Services Payment Cryptography
        /// supports <c>RSA</c> and <c>ECC_NIST</c> algorithms.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyClass. 
        /// <para>
        /// The type of Amazon Web Services Payment Cryptography key to create, which determines
        /// the classiﬁcation of the cryptographic method and whether Amazon Web Services Payment
        /// Cryptography key contains a symmetric key or an asymmetric key pair.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyClass KeyClass { get; set; }

        /// <summary>
        /// Checks to see if the KeyClass property is set.
        /// </summary>
        internal bool IsSetKeyClass() => this.KeyClass != null;

        /// <summary>
        /// Gets and sets the property KeyModesOfUse. 
        /// <para>
        /// The list of cryptographic operations that you can perform using the key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyModesOfUse KeyModesOfUse { get; set; }

        /// <summary>
        /// Checks to see if the KeyModesOfUse property is set.
        /// </summary>
        internal bool IsSetKeyModesOfUse() => this.KeyModesOfUse != null;

        /// <summary>
        /// Gets and sets the property KeyUsage. 
        /// <para>
        /// The cryptographic usage of an Amazon Web Services Payment Cryptography key as deﬁned
        /// in section A.5.2 of the TR-31 spec.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyUsage KeyUsage { get; set; }

        /// <summary>
        /// Checks to see if the KeyUsage property is set.
        /// </summary>
        internal bool IsSetKeyUsage() => this.KeyUsage != null;
    }
}
