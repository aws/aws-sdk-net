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
    /// Evaluation points in the traffic flow where rules are applied. There are three phases
    /// in a traffic where the rule match is applied. 
    /// 
    ///  
    /// <para>
    /// This data type is used specifically for the <a>CreateProxyRules</a> API.
    /// </para>
    ///  
    /// <para>
    /// Pre-DNS - before domain resolution.
    /// </para>
    ///  
    /// <para>
    /// Pre-Request - after DNS, before request.
    /// </para>
    ///  
    /// <para>
    /// Post-Response - after receiving response.
    /// </para>
    /// </summary>
    public partial class CreateProxyRulesByRequestPhase
    {
        private List<CreateProxyRule> _postRESPONSE = AWSConfigs.InitializeCollections ? new List<CreateProxyRule>() : null;
        private List<CreateProxyRule> _preDNS = AWSConfigs.InitializeCollections ? new List<CreateProxyRule>() : null;
        private List<CreateProxyRule> _preREQUEST = AWSConfigs.InitializeCollections ? new List<CreateProxyRule>() : null;

        /// <summary>
        /// Gets and sets the property PostRESPONSE. 
        /// <para>
        /// After receiving response.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<CreateProxyRule> PostRESPONSE
        {
            get { return this._postRESPONSE; }
            set { this._postRESPONSE = value; }
        }

        // Check to see if PostRESPONSE property is set
        internal bool IsSetPostRESPONSE()
        {
            return this._postRESPONSE != null && (this._postRESPONSE.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreDNS. 
        /// <para>
        /// Before domain resolution. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<CreateProxyRule> PreDNS
        {
            get { return this._preDNS; }
            set { this._preDNS = value; }
        }

        // Check to see if PreDNS property is set
        internal bool IsSetPreDNS()
        {
            return this._preDNS != null && (this._preDNS.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PreREQUEST. 
        /// <para>
        /// After DNS, before request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<CreateProxyRule> PreREQUEST
        {
            get { return this._preREQUEST; }
            set { this._preREQUEST = value; }
        }

        // Check to see if PreREQUEST property is set
        internal bool IsSetPreREQUEST()
        {
            return this._preREQUEST != null && (this._preREQUEST.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}