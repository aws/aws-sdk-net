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
        /// <summary>
        /// Gets and sets the property PostRESPONSE. 
        /// <para>
        /// After receiving response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<CreateProxyRule> PostRESPONSE { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateProxyRule>() : null;

        /// <summary>
        /// Checks to see if the PostRESPONSE property is set.
        /// </summary>
        internal bool IsSetPostRESPONSE() => this.PostRESPONSE != null && (this.PostRESPONSE.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreDNS. 
        /// <para>
        /// Before domain resolution. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<CreateProxyRule> PreDNS { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateProxyRule>() : null;

        /// <summary>
        /// Checks to see if the PreDNS property is set.
        /// </summary>
        internal bool IsSetPreDNS() => this.PreDNS != null && (this.PreDNS.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PreREQUEST. 
        /// <para>
        /// After DNS, before request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<CreateProxyRule> PreREQUEST { get; set; } = AWSConfigs.InitializeCollections ? new List<CreateProxyRule>() : null;

        /// <summary>
        /// Checks to see if the PreREQUEST property is set.
        /// </summary>
        internal bool IsSetPreREQUEST() => this.PreREQUEST != null && (this.PreREQUEST.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
