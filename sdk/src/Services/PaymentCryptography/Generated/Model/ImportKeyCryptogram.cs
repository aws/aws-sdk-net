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
    /// Parameter information for key material import using asymmetric RSA wrap and unwrap
    /// key exchange method.
    /// </summary>
    public partial class ImportKeyCryptogram
    {
        private bool? _exportable;
        private string _importToken;
        private KeyAttributes _keyAttributes;
        private string _wrappedKeyCryptogram;
        private WrappingKeySpec _wrappingSpec;

        /// <summary>
        /// Gets and sets the property Exportable. 
        /// <para>
        /// Specifies whether the key is exportable from the service.
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
        /// Gets and sets the property ImportToken. 
        /// <para>
        /// The import token that initiates key import using the asymmetric RSA wrap and unwrap
        /// key exchange method into AWS Payment Cryptography. It expires after 30 days. You can
        /// use the same import token to import multiple keys to the same service account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ImportToken
        {
            get { return this._importToken; }
            set { this._importToken = value; }
        }

        // Check to see if ImportToken property is set
        internal bool IsSetImportToken()
        {
            return this._importToken != null;
        }

        /// <summary>
        /// Gets and sets the property KeyAttributes.
        /// </summary>
        [AWSProperty(Required=true)]
        public KeyAttributes KeyAttributes
        {
            get { return this._keyAttributes; }
            set { this._keyAttributes = value; }
        }

        // Check to see if KeyAttributes property is set
        internal bool IsSetKeyAttributes()
        {
            return this._keyAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKeyCryptogram. 
        /// <para>
        /// The RSA wrapped key cryptogram under import.
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
        /// Gets and sets the property WrappingSpec. 
        /// <para>
        /// The wrapping spec for the wrapped key cryptogram.
        /// </para>
        /// </summary>
        public WrappingKeySpec WrappingSpec
        {
            get { return this._wrappingSpec; }
            set { this._wrappingSpec = value; }
        }

        // Check to see if WrappingSpec property is set
        internal bool IsSetWrappingSpec()
        {
            return this._wrappingSpec != null;
        }

    }
}