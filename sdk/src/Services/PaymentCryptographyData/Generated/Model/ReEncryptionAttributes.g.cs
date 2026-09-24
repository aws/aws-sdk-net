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
    /// Parameters that are required to perform reencryption operation.
    /// </summary>
    public partial class ReEncryptionAttributes
    {
        /// <summary>
        /// Gets and sets the property Asymmetric. 
        /// <para>
        /// Specifies the parameters required to encrypt data using an asymmetric key pair. You
        /// must specify a <c>PaddingType</c>.
        /// </para>
        /// </summary>
        public AsymmetricEncryptionAttributes Asymmetric { get; set; }

        /// <summary>
        /// Checks to see if the Asymmetric property is set.
        /// </summary>
        internal bool IsSetAsymmetric() => this.Asymmetric != null;

        /// <summary>
        /// Gets and sets the property Dukpt. 
        /// <para>
        /// Specifies the parameters required to encrypt data using DUKPT.
        /// </para>
        /// </summary>
        public DukptEncryptionAttributes Dukpt { get; set; }

        /// <summary>
        /// Checks to see if the Dukpt property is set.
        /// </summary>
        internal bool IsSetDukpt() => this.Dukpt != null;

        /// <summary>
        /// Gets and sets the property Symmetric. 
        /// <para>
        /// Specifies the parameters required to encrypt data using symmetric keys.
        /// </para>
        /// </summary>
        public SymmetricEncryptionAttributes Symmetric { get; set; }

        /// <summary>
        /// Checks to see if the Symmetric property is set.
        /// </summary>
        internal bool IsSetSymmetric() => this.Symmetric != null;
    }
}
