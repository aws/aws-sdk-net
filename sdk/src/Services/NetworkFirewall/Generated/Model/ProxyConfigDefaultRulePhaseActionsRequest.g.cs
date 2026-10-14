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
    /// This data type is used specifically for the <a>CreateProxyConfiguration</a> and <a>UpdateProxyConfiguration</a>
    /// APIs.
    /// </para>
    /// </summary>
    public partial class ProxyConfigDefaultRulePhaseActionsRequest
    {
        /// <summary>
        /// Gets and sets the property PostRESPONSE. 
        /// <para>
        /// After receiving response.
        /// </para>
        /// </summary>
        public ProxyRulePhaseAction PostRESPONSE { get; set; }

        /// <summary>
        /// Checks to see if the PostRESPONSE property is set.
        /// </summary>
        internal bool IsSetPostRESPONSE() => this.PostRESPONSE != null;

        /// <summary>
        /// Gets and sets the property PreDNS. 
        /// <para>
        /// Before domain resolution. 
        /// </para>
        /// </summary>
        public ProxyRulePhaseAction PreDNS { get; set; }

        /// <summary>
        /// Checks to see if the PreDNS property is set.
        /// </summary>
        internal bool IsSetPreDNS() => this.PreDNS != null;

        /// <summary>
        /// Gets and sets the property PreREQUEST. 
        /// <para>
        /// After DNS, before request.
        /// </para>
        /// </summary>
        public ProxyRulePhaseAction PreREQUEST { get; set; }

        /// <summary>
        /// Checks to see if the PreREQUEST property is set.
        /// </summary>
        internal bool IsSetPreREQUEST() => this.PreREQUEST != null;
    }
}
