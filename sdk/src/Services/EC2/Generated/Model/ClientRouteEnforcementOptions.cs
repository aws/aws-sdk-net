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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Client Route Enforcement is a feature of Client VPN that helps enforce administrator
    /// defined routes on devices connected through the VPN. This feature helps improve your
    /// security posture by ensuring that network traffic originating from a connected client
    /// is not inadvertently sent outside the VPN tunnel.
    /// 
    ///  
    /// <para>
    /// Client Route Enforcement works by monitoring the route table of a connected device
    /// for routing policy changes to the VPN connection. If the feature detects any VPN routing
    /// policy modifications, it will automatically force an update to the route table, reverting
    /// it back to the expected route configurations.
    /// </para>
    /// </summary>
    public partial class ClientRouteEnforcementOptions
    {
        private bool? _enforced;

        /// <summary>
        /// Gets and sets the property Enforced. 
        /// <para>
        /// Enable or disable Client Route Enforcement. The state can either be <c>true</c> (enabled)
        /// or <c>false</c> (disabled). The default is <c>false</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>true | false</c> 
        /// </para>
        ///  
        /// <para>
        /// Default value: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? Enforced
        {
            get { return this._enforced; }
            set { this._enforced = value; }
        }

        // Check to see if Enforced property is set
        internal bool IsSetEnforced()
        {
            return this._enforced.HasValue; 
        }

    }
}