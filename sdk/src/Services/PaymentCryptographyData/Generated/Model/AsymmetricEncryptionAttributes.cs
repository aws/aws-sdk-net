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
 * Do not modify this file. This file is generated from the payment-cryptography-data-2022-02-03.normal.json service model.
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
    /// Parameters for plaintext encryption using asymmetric keys.
    /// </summary>
    public partial class AsymmetricEncryptionAttributes
    {
        private PaddingType _paddingType;

        /// <summary>
        /// Gets and sets the property PaddingType. 
        /// <para>
        /// The padding to be included with the data.
        /// </para>
        /// </summary>
        public PaddingType PaddingType
        {
            get { return this._paddingType; }
            set { this._paddingType = value; }
        }

        // Check to see if PaddingType property is set
        internal bool IsSetPaddingType()
        {
            return this._paddingType != null;
        }

    }
}