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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the origin resource of an Amazon Lightsail content delivery network (CDN)
    /// distribution.
    /// 
    ///  
    /// <para>
    /// An origin can be a Lightsail instance or load balancer. A distribution pulls content
    /// from an origin, caches it, and serves it to viewers via a worldwide network of edge
    /// servers.
    /// </para>
    /// </summary>
    public partial class InputOrigin
    {
        private string _name;
        private OriginProtocolPolicyEnum _protocolPolicy;
        private RegionName _regionName;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the origin resource.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ProtocolPolicy. 
        /// <para>
        /// The protocol that your Amazon Lightsail distribution uses when establishing a connection
        /// with your origin to pull content.
        /// </para>
        /// </summary>
        public OriginProtocolPolicyEnum ProtocolPolicy
        {
            get { return this._protocolPolicy; }
            set { this._protocolPolicy = value; }
        }

        // Check to see if ProtocolPolicy property is set
        internal bool IsSetProtocolPolicy()
        {
            return this._protocolPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// The AWS Region name of the origin resource.
        /// </para>
        /// </summary>
        public RegionName RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

    }
}