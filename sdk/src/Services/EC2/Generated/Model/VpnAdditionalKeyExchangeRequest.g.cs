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
    /// Specifies an additional key exchange round for the VPN tunnel, as defined in RFC 9370.
    /// </summary>
    public partial class VpnAdditionalKeyExchangeRequest
    {
        /// <summary>
        /// Gets and sets the property AdditionalKeyExchangeRound. 
        /// <para>
        /// The additional key exchange round number.
        /// </para>
        ///  
        /// <para>
        /// Valid range: Minimum value of 1. Maximum value of 7.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 7)]
        public int? AdditionalKeyExchangeRound { get; set; }

        /// <summary>
        /// Checks to see if the AdditionalKeyExchangeRound property is set.
        /// </summary>
        internal bool IsSetAdditionalKeyExchangeRound() => this.AdditionalKeyExchangeRound.HasValue;

        /// <summary>
        /// Gets and sets the property KeyExchangeMethods. 
        /// <para>
        /// The key exchange method numbers that are permitted for this round. The method numbers
        /// are the IANA IKEv2 key exchange method transform IDs.
        /// </para>
        ///  
        /// <para>
        /// A <c>required</c> round must specify at least one method. An <c>optional</c> round
        /// can omit this parameter or specify an empty list. If omitted or empty for an optional
        /// round, the round is disabled.
        /// </para>
        ///  
        /// <para>
        /// IKEv2 requires that the initial Diffie-Hellman exchange and each required round use
        /// a different key exchange method. The permitted methods must allow a distinct method
        /// to be selected for each of them.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>2</c> | <c>5</c> | <c>14</c> | <c>15</c> | <c>16</c> | <c>17</c>
        /// | <c>18</c> | <c>19</c> | <c>20</c> | <c>21</c> | <c>22</c> | <c>23</c> | <c>24</c>
        /// | <c>35</c> | <c>36</c> | <c>37</c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AdditionalKeyExchangeMethodsRequestListValue> KeyExchangeMethods { get; set; } = AWSConfigs.InitializeCollections ? new List<AdditionalKeyExchangeMethodsRequestListValue>() : null;

        /// <summary>
        /// Checks to see if the KeyExchangeMethods property is set.
        /// </summary>
        internal bool IsSetKeyExchangeMethods() => this.KeyExchangeMethods != null && (this.KeyExchangeMethods.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Requirement. 
        /// <para>
        /// Indicates whether this round is mandatory. If <c>required</c>, the tunnel isn't established
        /// unless the customer gateway device negotiates this round. If <c>optional</c>, the
        /// round is negotiated only if the customer gateway device supports it.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>required</c> | <c>optional</c> 
        /// </para>
        ///  
        /// <para>
        /// Default: <c>required</c> 
        /// </para>
        /// </summary>
        public AdditionalKeyExchangeRequirement Requirement { get; set; }

        /// <summary>
        /// Checks to see if the Requirement property is set.
        /// </summary>
        internal bool IsSetRequirement() => this.Requirement != null;
    }
}
