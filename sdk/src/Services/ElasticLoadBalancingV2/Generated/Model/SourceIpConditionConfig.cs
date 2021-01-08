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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancingV2.Model
{
    /// <summary>
    /// Information about a source IP condition.
    /// 
    ///  
    /// <para>
    /// You can use this condition to route based on the IP address of the source that connects
    /// to the load balancer. If a client is behind a proxy, this is the IP address of the
    /// proxy not the IP address of the client.
    /// </para>
    /// </summary>
    public partial class SourceIpConditionConfig
    {
        private List<string> _values = new List<string>();

        /// <summary>
        /// Gets and sets the property Values. 
        /// <para>
        /// One or more source IP addresses, in CIDR format. You can use both IPv4 and IPv6 addresses.
        /// Wildcards are not supported.
        /// </para>
        ///  
        /// <para>
        /// If you specify multiple addresses, the condition is satisfied if the source IP address
        /// of the request matches one of the CIDR blocks. This condition is not satisfied by
        /// the addresses in the X-Forwarded-For header. To search for addresses in the X-Forwarded-For
        /// header, use <a>HttpHeaderConditionConfig</a>.
        /// </para>
        /// </summary>
        public List<string> Values
        {
            get { return this._values; }
            set { this._values = value; }
        }

        // Check to see if Values property is set
        internal bool IsSetValues()
        {
            return this._values != null && this._values.Count > 0; 
        }

    }
}