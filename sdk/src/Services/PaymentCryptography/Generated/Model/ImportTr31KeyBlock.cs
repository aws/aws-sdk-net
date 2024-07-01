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
    /// Parameter information for key material import using symmetric TR-31 key exchange method.
    /// </summary>
    public partial class ImportTr31KeyBlock
    {
        private string _wrappedKeyBlock;
        private string _wrappingKeyIdentifier;

        /// <summary>
        /// Gets and sets the property WrappedKeyBlock. 
        /// <para>
        /// The TR-31 wrapped key block to import.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=56, Max=9984)]
        public string WrappedKeyBlock
        {
            get { return this._wrappedKeyBlock; }
            set { this._wrappedKeyBlock = value; }
        }

        // Check to see if WrappedKeyBlock property is set
        internal bool IsSetWrappedKeyBlock()
        {
            return this._wrappedKeyBlock != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyIdentifier. 
        /// <para>
        /// The <c>KeyARN</c> of the key that will decrypt or unwrap a TR-31 key block during
        /// import.
        /// </para>
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