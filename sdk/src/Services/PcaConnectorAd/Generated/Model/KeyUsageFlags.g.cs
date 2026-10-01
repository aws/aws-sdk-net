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

namespace Amazon.PcaConnectorAd.Model
{
    /// <summary>
    /// The key usage flags represent the purpose (e.g., encipherment, signature) of the key
    /// contained in the certificate.
    /// </summary>
    public partial class KeyUsageFlags
    {
        /// <summary>
        /// Gets and sets the property DataEncipherment. 
        /// <para>
        /// DataEncipherment is asserted when the subject public key is used for directly enciphering
        /// raw user data without the use of an intermediate symmetric cipher.
        /// </para>
        /// </summary>
        public bool? DataEncipherment { get; set; }

        /// <summary>
        /// Checks to see if the DataEncipherment property is set.
        /// </summary>
        internal bool IsSetDataEncipherment() => this.DataEncipherment.HasValue;

        /// <summary>
        /// Gets and sets the property DigitalSignature. 
        /// <para>
        /// The digitalSignature is asserted when the subject public key is used for verifying
        /// digital signatures.
        /// </para>
        /// </summary>
        public bool? DigitalSignature { get; set; }

        /// <summary>
        /// Checks to see if the DigitalSignature property is set.
        /// </summary>
        internal bool IsSetDigitalSignature() => this.DigitalSignature.HasValue;

        /// <summary>
        /// Gets and sets the property KeyAgreement. 
        /// <para>
        /// KeyAgreement is asserted when the subject public key is used for key agreement.
        /// </para>
        /// </summary>
        public bool? KeyAgreement { get; set; }

        /// <summary>
        /// Checks to see if the KeyAgreement property is set.
        /// </summary>
        internal bool IsSetKeyAgreement() => this.KeyAgreement.HasValue;

        /// <summary>
        /// Gets and sets the property KeyEncipherment. 
        /// <para>
        /// KeyEncipherment is asserted when the subject public key is used for enciphering private
        /// or secret keys, i.e., for key transport.
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
        /// NonRepudiation is asserted when the subject public key is used to verify digital signatures.
        /// </para>
        /// </summary>
        public bool? NonRepudiation { get; set; }

        /// <summary>
        /// Checks to see if the NonRepudiation property is set.
        /// </summary>
        internal bool IsSetNonRepudiation() => this.NonRepudiation.HasValue;
    }
}
