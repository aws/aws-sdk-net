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
    /// Parameter information for key material export using AS2805 key cryptogram format.
    /// </summary>
    public partial class ExportAs2805KeyCryptogram
    {
        private As2805KeyVariant _as2805KeyVariant;
        private string _wrappingKeyIdentifier;

        /// <summary>
        /// Gets and sets the property As2805KeyVariant. 
        /// <para>
        /// The cryptographic usage of the key under export.
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