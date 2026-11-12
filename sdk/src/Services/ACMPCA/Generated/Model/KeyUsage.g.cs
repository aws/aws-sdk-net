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

namespace Amazon.ACMPCA.Model
{
    /// <summary>
    /// Defines one or more purposes for which the key contained in the certificate can be
    /// used. Default value for each option is false.
    /// </summary>
    public partial class KeyUsage
    {
        /// <summary>
        /// Gets and sets the property CRLSign. 
        /// <para>
        /// Key can be used to sign CRLs.
        /// </para>
        /// </summary>
        public bool? CRLSign { get; set; }

        /// <summary>
        /// Checks to see if the CRLSign property is set.
        /// </summary>
        internal bool IsSetCRLSign() => this.CRLSign.HasValue;

        /// <summary>
        /// Gets and sets the property DataEncipherment. 
        /// <para>
        /// Key can be used to decipher data.
        /// </para>
        /// </summary>
        public bool? DataEncipherment { get; set; }

        /// <summary>
        /// Checks to see if the DataEncipherment property is set.
        /// </summary>
        internal bool IsSetDataEncipherment() => this.DataEncipherment.HasValue;

        /// <summary>
        /// Gets and sets the property DecipherOnly. 
        /// <para>
        /// Key can be used only to decipher data.
        /// </para>
        /// </summary>
        public bool? DecipherOnly { get; set; }

        /// <summary>
        /// Checks to see if the DecipherOnly property is set.
        /// </summary>
        internal bool IsSetDecipherOnly() => this.DecipherOnly.HasValue;

        /// <summary>
        /// Gets and sets the property DigitalSignature. 
        /// <para>
        ///  Key can be used for digital signing.
        /// </para>
        /// </summary>
        public bool? DigitalSignature { get; set; }

        /// <summary>
        /// Checks to see if the DigitalSignature property is set.
        /// </summary>
        internal bool IsSetDigitalSignature() => this.DigitalSignature.HasValue;

        /// <summary>
        /// Gets and sets the property EncipherOnly. 
        /// <para>
        /// Key can be used only to encipher data.
        /// </para>
        /// </summary>
        public bool? EncipherOnly { get; set; }

        /// <summary>
        /// Checks to see if the EncipherOnly property is set.
        /// </summary>
        internal bool IsSetEncipherOnly() => this.EncipherOnly.HasValue;

        /// <summary>
        /// Gets and sets the property KeyAgreement. 
        /// <para>
        /// Key can be used in a key-agreement protocol.
        /// </para>
        /// </summary>
        public bool? KeyAgreement { get; set; }

        /// <summary>
        /// Checks to see if the KeyAgreement property is set.
        /// </summary>
        internal bool IsSetKeyAgreement() => this.KeyAgreement.HasValue;

        /// <summary>
        /// Gets and sets the property KeyCertSign. 
        /// <para>
        /// Key can be used to sign certificates.
        /// </para>
        /// </summary>
        public bool? KeyCertSign { get; set; }

        /// <summary>
        /// Checks to see if the KeyCertSign property is set.
        /// </summary>
        internal bool IsSetKeyCertSign() => this.KeyCertSign.HasValue;

        /// <summary>
        /// Gets and sets the property KeyEncipherment. 
        /// <para>
        /// Key can be used to encipher data.
        /// </para>
        /// </summary>
        public bool? KeyEncipherment { get; set; }

        /// <summary>
        /// Checks to see if the KeyEncipherment property is set.
        /// </summary>
        internal bool IsSetKeyEncipherment() => this.KeyEncipherment.HasValue;

        /// <summary>
        /// Gets and sets the property NonRepudiation. 
        /// <para>
        /// Key can be used for non-repudiation.
        /// </para>
        /// </summary>
        public bool? NonRepudiation { get; set; }

        /// <summary>
        /// Checks to see if the NonRepudiation property is set.
        /// </summary>
        internal bool IsSetNonRepudiation() => this.NonRepudiation.HasValue;
    }
}
