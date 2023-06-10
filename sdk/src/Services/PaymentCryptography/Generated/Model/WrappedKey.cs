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

namespace Amazon.PaymentCryptography.Model
{
    /// <summary>
    /// Parameter information for generating a wrapped key using TR-31 or TR-34 standard.
    /// </summary>
    public partial class WrappedKey
    {
        private string _keyMaterial;
        private WrappedKeyMaterialFormat _wrappedKeyMaterialFormat;
        private string _wrappingKeyArn;

        /// <summary>
        /// Gets and sets the property KeyMaterial. 
        /// <para>
        /// Parameter information for generating a wrapped key using TR-31 or TR-34 standard.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=48, Max=16384)]
        public string KeyMaterial
        {
            get { return this._keyMaterial; }
            set { this._keyMaterial = value; }
        }

        // Check to see if KeyMaterial property is set
        internal bool IsSetKeyMaterial()
        {
            return this._keyMaterial != null;
        }

        /// <summary>
        /// Gets and sets the property WrappedKeyMaterialFormat. 
        /// <para>
        /// The key block format of a wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public WrappedKeyMaterialFormat WrappedKeyMaterialFormat
        {
            get { return this._wrappedKeyMaterialFormat; }
            set { this._wrappedKeyMaterialFormat = value; }
        }

        // Check to see if WrappedKeyMaterialFormat property is set
        internal bool IsSetWrappedKeyMaterialFormat()
        {
            return this._wrappedKeyMaterialFormat != null;
        }

        /// <summary>
        /// Gets and sets the property WrappingKeyArn. 
        /// <para>
        /// The <code>KeyARN</code> of the wrapped key.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string WrappingKeyArn
        {
            get { return this._wrappingKeyArn; }
            set { this._wrappingKeyArn = value; }
        }

        // Check to see if WrappingKeyArn property is set
        internal bool IsSetWrappingKeyArn()
        {
            return this._wrappingKeyArn != null;
        }

    }
}