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
 * Do not modify this file. This file is generated from the payment-cryptography-2021-09-14.normal.json service model.
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
        private As2805KeyVariant _as2805KeyVariant;
        private bool? _exportable;
        private KeyAlgorithm _keyAlgorithm;
        private KeyModesOfUse _keyModesOfUse;
        private string _wrappedKeyCryptogram;
        private string _wrappingKeyIdentifier;

        /// <summary>
        /// Gets and sets the property As2805KeyVariant. 
        /// <para>
        /// The cryptographic usage of the key under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public As2805KeyVariant As2805KeyVariant
        {
            get { return this._as2805KeyVariant; }
            set { this._as2805KeyVariant = value; }
        }

        // Check to see if As2805KeyVariant property is set
        internal bool IsSetAs2805KeyVariant()
        {
            return this._as2805KeyVariant != null;
        }

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specified whether the key is exportable. This data is immutable after the key is imported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? Exportable
        {
            get { return this._exportable; }
            set { this._exportable = value; }
        }

        // Check to see if Exportable property is set
        internal bool IsSetExportable()
        {
            return this._exportable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyAlgorithm. 
        /// <para>
        /// The key algorithm of the key under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAlgorithm KeyAlgorithm
        {
            get { return this._keyAlgorithm; }
            set { this._keyAlgorithm = value; }
        }

        // Check to see if KeyAlgorithm property is set
        internal bool IsSetKeyAlgorithm()
        {
            return this._keyAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property KeyModesOfUse.
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyModesOfUse KeyModesOfUse
        {
            get { return this._keyModesOfUse; }
            set { this._keyModesOfUse = value; }
        }

        // Check to see if KeyModesOfUse property is set
        internal bool IsSetKeyModesOfUse()
        {
            return this._keyModesOfUse != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKeyCryptogram. 
        /// <para>
        /// The wrapped key cryptogram under import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=16, Max=4096)]
        public string WrappedKeyCryptogram
        {
            get { return this._wrappedKeyCryptogram; }
            set { this._wrappedKeyCryptogram = value; }
        }

        // Check to see if WrappedKeyCryptogram property is set
        internal bool IsSetWrappedKeyCryptogram()
        {
            return this._wrappedKeyCryptogram != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyIdentifier.
        /// </summary>
        [AWSProperty(Required=true, Min=7, Max=322)]
        public string WrappingKeyIdentifier
        {
            get { return this._wrappingKeyIdentifier; }
            set { this._wrappingKeyIdentifier = value; }
        }

        // Check to see if WrappingKeyIdentifier property is set
        internal bool IsSetWrappingKeyIdentifier()
        {
            return this._wrappingKeyIdentifier != null;
        }

    }
}