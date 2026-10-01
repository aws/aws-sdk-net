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

namespace Amazon.PaymentCryptographyData.Model
{
    /// <summary>
    /// Parameters requried to encrypt plaintext data using symmetric keys.
    /// </summary>
    public partial class SymmetricEncryptionAttributes
    {
        /// <summary>
        /// Gets and sets the property InitializationVector. 
        /// <para>
        /// An input used to provide the intial state. If no value is provided, Amazon Web Services
        /// Payment Cryptography defaults it to zero.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 16, Max = 32)]
        public string InitializationVector { get; set; }

        /// <summary>
        /// Checks to see if the InitializationVector property is set.
        /// </summary>
        internal bool IsSetInitializationVector() => this.InitializationVector != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The block cipher method to use for encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EncryptionMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property PaddingType. 
        /// <para>
        /// The padding to be included with the data.
        /// </para>
        /// </summary>
        public PaddingType PaddingType { get; set; }

        /// <summary>
        /// Checks to see if the PaddingType property is set.
        /// </summary>
        internal bool IsSetPaddingType() => this.PaddingType != null;
    }
}
