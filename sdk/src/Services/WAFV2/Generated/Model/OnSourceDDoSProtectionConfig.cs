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
    /// Configures the level of DDoS protection that applies to web ACLs associated with Application
    /// Load Balancers.
    /// </summary>
    public partial class OnSourceDDoSProtectionConfig
    {
        private LowReputationMode _albLowReputationMode;

        /// <summary>
        /// Gets and sets the property ALBLowReputationMode. 
        /// <para>
        /// The level of DDoS protection that applies to web ACLs associated with Application
        /// Load Balancers. <c>ACTIVE_UNDER_DDOS</c> protection is enabled by default whenever
        /// a web ACL is associated with an Application Load Balancer. In the event that an Application
        /// Load Balancer experiences high-load conditions or suspected DDoS attacks, the <c>ACTIVE_UNDER_DDOS</c>
        /// protection automatically rate limits traffic from known low reputation sources without
        /// disrupting Application Load Balancer availability. <c>ALWAYS_ON</c> protection provides
        /// constant, always-on monitoring of known low reputation sources for suspected DDoS
        /// attacks. While this provides a higher level of protection, there may be potential
        /// impacts on legitimate traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public LowReputationMode ALBLowReputationMode
        {
            get { return this._albLowReputationMode; }
            set { this._albLowReputationMode = value; }
        }

        // Check to see if ALBLowReputationMode property is set
        internal bool IsSetALBLowReputationMode()
        {
            return this._albLowReputationMode != null;
        }

    }
}