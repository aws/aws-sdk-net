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
    /// This is the response object from the GenerateAs2805KekValidation operation.
    /// </summary>
    public partial class GenerateAs2805KekValidationResponse : AmazonWebServiceResponse
    {
        private string _keyArn;
        private string _keyCheckValue;
        private string _randomKeyReceive;
        private string _randomKeySend;

        /// <summary>
        /// Gets and sets the property KeyArn. 
        /// <para>
        /// The <c>keyARN</c> of sending KEK that Amazon Web Services Payment Cryptography validates
        /// for node-to-node initialization
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=70, Max=150)]
        public string KeyArn
        {
            get { return this._keyArn; }
            set { this._keyArn = value; }
        }

        // Check to see if KeyArn property is set
        internal bool IsSetKeyArn()
        {
            return this._keyArn != null;
        }

        /// <summary>
        /// Gets and sets the property KeyCheckValue. 
        /// <para>
        /// The key check value (KCV) of the sending KEK that Amazon Web Services Payment Cryptography
        /// validates for node-to-node initialization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=16)]
        public string KeyCheckValue
        {
            get { return this._keyCheckValue; }
            set { this._keyCheckValue = value; }
        }

        // Check to see if KeyCheckValue property is set
        internal bool IsSetKeyCheckValue()
        {
            return this._keyCheckValue != null;
        }

        /// <summary>
        /// Gets and sets the property RandomKeyReceive. 
        /// <para>
        /// The random key generated for receiving KEK validation. The initiating node sends this
        /// key to its partner node for validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=32, Max=48)]
        public string RandomKeyReceive
        {
            get { return this._randomKeyReceive; }
            set { this._randomKeyReceive = value; }
        }

        // Check to see if RandomKeyReceive property is set
        internal bool IsSetRandomKeyReceive()
        {
            return this._randomKeyReceive != null;
        }

        /// <summary>
        /// Gets and sets the property RandomKeySend. 
        /// <para>
        /// The random key generated for sending KEK validation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=32, Max=48)]
        public string RandomKeySend
        {
            get { return this._randomKeySend; }
            set { this._randomKeySend = value; }
        }

        // Check to see if RandomKeySend property is set
        internal bool IsSetRandomKeySend()
        {
            return this._randomKeySend != null;
        }

    }
}