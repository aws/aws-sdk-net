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
 * Do not modify this file. This file is generated from the meteringmarketplace-2016-01-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AWSMarketplaceMetering.Model
{
    /// <summary>
    /// This is the response object from the RegisterUsage operation.
    /// </summary>
    public partial class RegisterUsageResponse : AmazonWebServiceResponse
    {
        private DateTime? _publicKeyRotationTimestamp;
        private string _signature;

        /// <summary>
        /// Gets and sets the property PublicKeyRotationTimestamp. 
        /// <para>
        /// (Optional) Only included when public key version has expired
        /// </para>
        /// </summary>
        public DateTime PublicKeyRotationTimestamp
        {
            get { return this._publicKeyRotationTimestamp.GetValueOrDefault(); }
            set { this._publicKeyRotationTimestamp = value; }
        }

        // Check to see if PublicKeyRotationTimestamp property is set
        internal bool IsSetPublicKeyRotationTimestamp()
        {
            return this._publicKeyRotationTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Signature. 
        /// <para>
        /// JWT Token
        /// </para>
        /// </summary>
        public string Signature
        {
            get { return this._signature; }
            set { this._signature = value; }
        }

        // Check to see if Signature property is set
        internal bool IsSetSignature()
        {
            return this._signature != null;
        }

    }
}