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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Stateful inspection criteria for a domain list rule group. 
    /// 
    ///  
    /// <para>
    /// For HTTPS traffic, domain filtering is SNI-based. It uses the server name indicator
    /// extension of the TLS handshake.
    /// </para>
    ///  
    /// <para>
    /// By default, Network Firewall domain list inspection only includes traffic coming from
    /// the VPC where you deploy the firewall. To inspect traffic from IP addresses outside
    /// of the deployment VPC, you set the <c>HOME_NET</c> rule variable to include the CIDR
    /// range of the deployment VPC plus the other CIDR ranges. For more information, see
    /// <a>RuleVariables</a> in this guide and <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/stateful-rule-groups-domain-names.html">Stateful
    /// domain list rule groups in Network Firewall</a> in the <i>Network Firewall Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class RulesSourceList
    {
        private GeneratedRulesType _generatedRulesType;
        private List<string> _targets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _targetTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property GeneratedRulesType. 
        /// <para>
        /// Whether you want to apply allow, reject, alert, or drop behavior to the domains in
        /// your target list.
        /// </para>
        ///  <note> 
        /// <para>
        /// When logging is enabled and you choose Alert, traffic that matches the domain specifications
        /// generates an alert in the firewall's logs. Then, traffic either passes, is rejected,
        /// or drops based on other rules in the firewall policy.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public GeneratedRulesType GeneratedRulesType
        {
            get { return this._generatedRulesType; }
            set { this._generatedRulesType = value; }
        }

        // Check to see if GeneratedRulesType property is set
        internal bool IsSetGeneratedRulesType()
        {
            return this._generatedRulesType != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The domains that you want to inspect for in your traffic flows. Valid domain specifications
        /// are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Explicit names. For example, <c>abc.example.com</c> matches only the domain <c>abc.example.com</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Names that use a domain wildcard, which you indicate with an initial '<c>.</c>'. For
        /// example,<c>.example.com</c> matches <c>example.com</c> and matches all subdomains
        /// of <c>example.com</c>, such as <c>abc.example.com</c> and <c>www.example.com</c>.
        /// 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TargetTypes. 
        /// <para>
        /// The protocols you want to inspect. Specify <c>TLS_SNI</c> for <c>HTTPS</c>. Specify
        /// <c>HTTP_HOST</c> for <c>HTTP</c>. You can specify either or both. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> TargetTypes
        {
            get { return this._targetTypes; }
            set { this._targetTypes = value; }
        }

        // Check to see if TargetTypes property is set
        internal bool IsSetTargetTypes()
        {
            return this._targetTypes != null && (this._targetTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}