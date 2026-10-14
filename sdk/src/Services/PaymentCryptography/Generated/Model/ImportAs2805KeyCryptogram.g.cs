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
    /// Parameter information for key material import using AS2805 key cryptogram format.
    /// </summary>
    public partial class ImportAs2805KeyCryptogram
    {
        /// <summary>
        /// Gets and sets the property As2805KeyVariant. 
        /// <para>
        /// The cryptographic usage of the key under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public As2805KeyVariant As2805KeyVariant { get; set; }

        /// <summary>
        /// Checks to see if the As2805KeyVariant property is set.
        /// </summary>
        internal bool IsSetAs2805KeyVariant() => this.As2805KeyVariant != null;

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specified whether the key is exportable. This data is immutable after the key is imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? Exportable { get; set; }

        /// <summary>
        /// Checks to see if the Exportable property is set.
        /// </summary>
        internal bool IsSetExportable() => this.Exportable.HasValue;

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The key algorithm of the key under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyAlgorithm KeyAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the KeyAlgorithm property is set.
        /// </summary>
        internal bool IsSetKeyAlgorithm() => this.KeyAlgorithm != null;

        /// <summary>
        /// Gets and sets the property KeyModesOfUse.
        /// </summary>
        [AWSProperty(Required = true)]
        public KeyModesOfUse KeyModesOfUse { get; set; }

        /// <summary>
        /// Checks to see if the KeyModesOfUse property is set.
        /// </summary>
        internal bool IsSetKeyModesOfUse() => this.KeyModesOfUse != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyCryptogram. 
        /// <para>
        /// The wrapped key cryptogram under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 16, Max = 4096)]
        public string WrappedKeyCryptogram { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyCryptogram property is set.
        /// </summary>
        internal bool IsSetWrappedKeyCryptogram() => this.WrappedKeyCryptogram != null;

        /// <summary>
        /// Gets and sets the property WrappingKeyIdentifier.
        /// </summary>
        [AWSProperty(Required = true, Min = 7, Max = 322)]
        public string WrappingKeyIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the WrappingKeyIdentifier property is set.
        /// </summary>
        internal bool IsSetWrappingKeyIdentifier() => this.WrappingKeyIdentifier != null;
    }
}
