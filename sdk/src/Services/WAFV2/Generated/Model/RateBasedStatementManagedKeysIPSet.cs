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
    /// The set of IP addresses that are currently blocked for a <a>RateBasedStatement</a>.
    /// This is only available for rate-based rules that aggregate on just the IP address,
    /// with the <c>AggregateKeyType</c> set to <c>IP</c> or <c>FORWARDED_IP</c>.
    /// 
    ///  
    /// <para>
    /// A rate-based rule applies its rule action to requests from IP addresses that are in
    /// the rule's managed keys list and that match the rule's scope-down statement. When
    /// a rule has no scope-down statement, it applies the action to all requests from the
    /// IP addresses that are in the list. The rule applies its rule action to rate limit
    /// the matching requests. The action is usually Block but it can be any valid rule action
    /// except for Allow. 
    /// </para>
    ///  
    /// <para>
    /// The maximum number of IP addresses that can be rate limited by a single rate-based
    /// rule instance is 10,000. If more than 10,000 addresses exceed the rate limit, WAF
    /// limits those with the highest rates. 
    /// </para>
    /// </summary>
    public partial class RateBasedStatementManagedKeysIPSet
    {
        private List<string> _addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private IPAddressVersion _ipAddressVersion;

        /// <summary>
        /// Gets and sets the property Addresses. 
        /// <para>
        /// The IP addresses that are currently blocked.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Addresses
        {
            get { return this._addresses; }
            set { this._addresses = value; }
        }

        // Check to see if Addresses property is set
        internal bool IsSetAddresses()
        {
            return this._addresses != null && (this._addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IPAddressVersion. 
        /// <para>
        /// The version of the IP addresses, either <c>IPV4</c> or <c>IPV6</c>. 
        /// </para>
        /// </summary>
        public IPAddressVersion IPAddressVersion
        {
            get { return this._ipAddressVersion; }
            set { this._ipAddressVersion = value; }
        }

        // Check to see if IPAddressVersion property is set
        internal bool IsSetIPAddressVersion()
        {
            return this._ipAddressVersion != null;
        }

    }
}