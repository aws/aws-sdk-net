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
 * Do not modify this file. This file is generated from the pca-connector-ad-2018-05-10.normal.json service model.
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
namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// The key usage flags represent the purpose (e.g., encipherment, signature) of the key
    /// contained in the certificate.
    /// </summary>
    public partial class KeyUsageFlags
    {
        private bool? _dataEncipherment;
        private bool? _digitalSignature;
        private bool? _keyAgreement;
        private bool? _keyEncipherment;
        private bool? _nonRepudiation;

        /// <summary>
        /// Gets and sets the property DataEncipherment. 
        /// <para>
        /// DataEncipherment is asserted when the subject public key is used for directly enciphering
        /// raw user data without the use of an intermediate symmetric cipher.
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
        /// Gets and sets the property DigitalSignature. 
        /// <para>
        /// The digitalSignature is asserted when the subject public key is used for verifying
        /// digital signatures.
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
        /// Gets and sets the property KeyAgreement. 
        /// <para>
        /// KeyAgreement is asserted when the subject public key is used for key agreement.
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
        /// Gets and sets the property KeyEncipherment. 
        /// <para>
        /// KeyEncipherment is asserted when the subject public key is used for enciphering private
        /// or secret keys, i.e., for key transport.
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
        /// NonRepudiation is asserted when the subject public key is used to verify digital signatures.
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