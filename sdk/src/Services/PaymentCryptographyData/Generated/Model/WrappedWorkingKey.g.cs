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
    /// The parameter information of the outgoing wrapped key block.
    /// </summary>
    public partial class WrappedWorkingKey
    {
        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the key contained within the outgoing TR31WrappedKeyBlock.
        /// </para>
        ///  
        /// <para>
        ///  The KCV is used to check if all parties holding a given key have the same key or
        /// to detect that a key has changed. For more information on KCV, see <a href="https://docs.aws.amazon.com/payment-cryptography/latest/userguide/terminology.html#terms.kcv">KCV</a>
        /// in the <i>Amazon Web Services Payment Cryptography User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 4, Max = 16)]
        public string KeyCheckValue { get; set; }

        /// <summary>
        /// Checks to see if the KeyCheckValue property is set.
        /// </summary>
        internal bool IsSetKeyCheckValue() => this.KeyCheckValue != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterial. 
        /// <para>
        /// The wrapped key block of the outgoing transaction key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 32, Max = 16384)]
        public string WrappedKeyMaterial { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyMaterial property is set.
        /// </summary>
        internal bool IsSetWrappedKeyMaterial() => this.WrappedKeyMaterial != null;

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterialFormat. 
        /// <para>
        /// The key block format of the wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public WrappedKeyMaterialFormat WrappedKeyMaterialFormat { get; set; }

        /// <summary>
        /// Checks to see if the WrappedKeyMaterialFormat property is set.
        /// </summary>
        internal bool IsSetWrappedKeyMaterialFormat() => this.WrappedKeyMaterialFormat != null;
    }
}
