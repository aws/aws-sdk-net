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
    /// Parameter information for generating a random key for KEK validation to perform node-to-node
    /// initialization.
    /// </summary>
    public partial class As2805KekValidationType
    {
        private KekValidationRequest _kekValidationRequest;
        private KekValidationResponse _kekValidationResponse;

        /// <summary>
        /// Gets and sets the property KekValidationRequest. 
        /// <para>
        /// Parameter information for generating a KEK validation request during node-to-node
        /// initialization.
        /// </para>
        /// </summary>
        public KekValidationRequest KekValidationRequest
        {
            get { return this._kekValidationRequest; }
            set { this._kekValidationRequest = value; }
        }

        // Check to see if KekValidationRequest property is set
        internal bool IsSetKekValidationRequest()
        {
            return this._kekValidationRequest != null;
        }

        /// <summary>
        /// Gets and sets the property KekValidationResponse. 
        /// <para>
        /// Parameter information for generating a KEK validation response during node-to-node
        /// initialization.
        /// </para>
        /// </summary>
        public KekValidationResponse KekValidationResponse
        {
            get { return this._kekValidationResponse; }
            set { this._kekValidationResponse = value; }
        }

        // Check to see if KekValidationResponse property is set
        internal bool IsSetKekValidationResponse()
        {
            return this._kekValidationResponse != null;
        }

    }
}