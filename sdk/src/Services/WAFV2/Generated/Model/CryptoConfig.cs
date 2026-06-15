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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
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
namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The cryptocurrency payment configuration for AI bot monetization. Contains the list
    /// of blockchain payment networks where you receive payments.
    /// </summary>
    public partial class CryptoConfig
    {
        private List<PaymentNetwork> _paymentNetworks = AWSConfigs.InitializeCollections ? new List<PaymentNetwork>() : null;

        /// <summary>
        /// Gets and sets the property PaymentNetworks. 
        /// <para>
        /// The blockchain payment networks configured to receive payments. You can specify 1
        /// to 2 networks. All networks must be in the same environment-either all production
        /// networks (Base, Solana) or all test networks (Base Sepolia, Solana Devnet).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<PaymentNetwork> PaymentNetworks
        {
            get { return this._paymentNetworks; }
            set { this._paymentNetworks = value; }
        }

        // Check to see if PaymentNetworks property is set
        internal bool IsSetPaymentNetworks()
        {
            return this._paymentNetworks != null && (this._paymentNetworks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}