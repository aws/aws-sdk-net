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
    /// Specifies key usage.
    /// </summary>
    public partial class KeyUsagePropertyFlags
    {
        /// <summary>
        /// Gets and sets the property Decrypt. 
        /// <para>
        /// Allows key for encryption and decryption.
        /// </para>
        /// </summary>
        public bool? Decrypt { get; set; }

        /// <summary>
        /// Checks to see if the Decrypt property is set.
        /// </summary>
        internal bool IsSetDecrypt() => this.Decrypt.HasValue;

        /// <summary>
        /// Gets and sets the property KeyAgreement. 
        /// <para>
        /// Allows key exchange without encryption.
        /// </para>
        /// </summary>
        public bool? KeyAgreement { get; set; }

        /// <summary>
        /// Checks to see if the KeyAgreement property is set.
        /// </summary>
        internal bool IsSetKeyAgreement() => this.KeyAgreement.HasValue;

        /// <summary>
        /// Gets and sets the property Sign. 
        /// <para>
        /// Allow key use for digital signature.
        /// </para>
        /// </summary>
        public bool? Sign { get; set; }

        /// <summary>
        /// Checks to see if the Sign property is set.
        /// </summary>
        internal bool IsSetSign() => this.Sign.HasValue;
    }
}
