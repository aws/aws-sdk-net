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
    /// Parameter information for generating a KEK validation response during node-to-node
    /// initialization.
    /// </summary>
    public partial class KekValidationResponse
    {
        private string _randomKeySend;

        /// <summary>
        /// Gets and sets the property RandomKeySend. 
        /// <para>
        /// The random key for generating a KEK validation response.
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