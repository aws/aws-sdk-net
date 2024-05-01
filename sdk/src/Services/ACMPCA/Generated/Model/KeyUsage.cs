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
 * Do not modify this file. This file is generated from the acm-pca-2017-08-22.normal.json service model.
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
namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Defines one or more purposes for which the key contained in the certificate can be
    /// used. Default value for each option is false.
    /// </summary>
    public partial class KeyUsage
    {
        private bool? _crlSign;
        private bool? _dataEncipherment;
        private bool? _decipherOnly;
        private bool? _digitalSignature;
        private bool? _encipherOnly;
        private bool? _keyAgreement;
        private bool? _keyCertSign;
        private bool? _keyEncipherment;
        private bool? _nonRepudiation;

        /// <summary>
        /// Gets and sets the property CRLSign. 
        /// <para>
        /// Key can be used to sign CRLs.
        /// </para>
        /// </summary>
        public bool? CRLSign
        {
            get { return this._crlSign; }
            set { this._crlSign = value; }
        }

        // Check to see if CRLSign property is set
        internal bool IsSetCRLSign()
        {
            return this._crlSign.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataEncipherment. 
        /// <para>
        /// Key can be used to decipher data.
        /// </para>
        /// </summary>
        public bool? DataEncipherment
        {
            get { return this._dataEncipherment; }
            set { this._dataEncipherment = value; }
        }

        // Check to see if DataEncipherment property is set
        internal bool IsSetDataEncipherment()
        {
            return this._dataEncipherment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DecipherOnly. 
        /// <para>
        /// Key can be used only to decipher data.
        /// </para>
        /// </summary>
        public bool? DecipherOnly
        {
            get { return this._decipherOnly; }
            set { this._decipherOnly = value; }
        }

        // Check to see if DecipherOnly property is set
        internal bool IsSetDecipherOnly()
        {
            return this._decipherOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DigitalSignature. 
        /// <para>
        ///  Key can be used for digital signing.
        /// </para>
        /// </summary>
        public bool? DigitalSignature
        {
            get { return this._digitalSignature; }
            set { this._digitalSignature = value; }
        }

        // Check to see if DigitalSignature property is set
        internal bool IsSetDigitalSignature()
        {
            return this._digitalSignature.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EncipherOnly. 
        /// <para>
        /// Key can be used only to encipher data.
        /// </para>
        /// </summary>
        public bool? EncipherOnly
        {
            get { return this._encipherOnly; }
            set { this._encipherOnly = value; }
        }

        // Check to see if EncipherOnly property is set
        internal bool IsSetEncipherOnly()
        {
            return this._encipherOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyAgreement. 
        /// <para>
        /// Key can be used in a key-agreement protocol.
        /// </para>
        /// </summary>
        public bool? KeyAgreement
        {
            get { return this._keyAgreement; }
            set { this._keyAgreement = value; }
        }

        // Check to see if KeyAgreement property is set
        internal bool IsSetKeyAgreement()
        {
            return this._keyAgreement.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyCertSign. 
        /// <para>
        /// Key can be used to sign certificates.
        /// </para>
        /// </summary>
        public bool? KeyCertSign
        {
            get { return this._keyCertSign; }
            set { this._keyCertSign = value; }
        }

        // Check to see if KeyCertSign property is set
        internal bool IsSetKeyCertSign()
        {
            return this._keyCertSign.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KeyEncipherment. 
        /// <para>
        /// Key can be used to encipher data.
        /// </para>
        /// </summary>
        public bool? KeyEncipherment
        {
            get { return this._keyEncipherment; }
            set { this._keyEncipherment = value; }
        }

        // Check to see if KeyEncipherment property is set
        internal bool IsSetKeyEncipherment()
        {
            return this._keyEncipherment.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NonRepudiation. 
        /// <para>
        /// Key can be used for non-repudiation.
        /// </para>
        /// </summary>
        public bool? NonRepudiation
        {
            get { return this._nonRepudiation; }
            set { this._nonRepudiation = value; }
        }

        // Check to see if NonRepudiation property is set
        internal bool IsSetNonRepudiation()
        {
            return this._nonRepudiation.HasValue; 
        }

    }
}