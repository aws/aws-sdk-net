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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes an additional key exchange round negotiated for an active VPN tunnel.
    /// </summary>
    public partial class ActiveVpnTunnelAdditionalKeyExchange
    {
        /// <summary>
        /// Gets and sets the property AdditionalKeyExchangeRound. 
        /// <para>
        /// The additional key exchange round number.
        /// </para>
        /// </summary>
        public int? AdditionalKeyExchangeRound { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalKeyExchangeRound property is set.
        /// </summary>
        internal bool IsSetAdditionalKeyExchangeRound() => this.AdditionalKeyExchangeRound.HasValue;

        /// <summary>
        /// Gets and sets the property KeyExchangeMethod. 
        /// <para>
        /// The key exchange method number negotiated for this round.
        /// </para>
        /// </summary>
        public int? KeyExchangeMethod { get; set; }

        /// <summary>
        /// Checks to see if the KeyExchangeMethod property is set.
        /// </summary>
        internal bool IsSetKeyExchangeMethod() => this.KeyExchangeMethod.HasValue;
    }
}
