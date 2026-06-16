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
    /// The monetization configuration for a web ACL or rule group. Specifies the cryptocurrency
    /// payment networks and currency mode for AI bot monetization. You must provide this
    /// configuration when any rule in the web ACL or rule group uses the <c>Monetize</c>
    /// action.
    /// </summary>
    public partial class MonetizationConfig
    {
        private CryptoConfig _cryptoConfig;
        private CurrencyMode _currencyMode;

        /// <summary>
        /// Gets and sets the property CryptoConfig. 
        /// <para>
        /// The cryptocurrency payment configuration, including the blockchain networks and wallet
        /// addresses where you receive payments.
        /// </para>
        /// </summary>
        public CryptoConfig CryptoConfig
        {
            get { return this._cryptoConfig; }
            set { this._cryptoConfig = value; }
        }

        // Check to see if CryptoConfig property is set
        internal bool IsSetCryptoConfig()
        {
            return this._cryptoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CurrencyMode. 
        /// <para>
        /// Specifies whether the configuration uses real or test currency. Set to <c>REAL</c>
        /// to settle payments in USDC on production blockchain networks (Base, Solana). Set to
        /// <c>TEST</c> to settle on testnet networks (Base Sepolia, Solana Devnet) with tokens
        /// that have no monetary value. If not specified, defaults to <c>REAL</c>.
        /// </para>
        /// </summary>
        public CurrencyMode CurrencyMode
        {
            get { return this._currencyMode; }
            set { this._currencyMode = value; }
        }

        // Check to see if CurrencyMode property is set
        internal bool IsSetCurrencyMode()
        {
            return this._currencyMode != null;
        }

    }
}