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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomAvailabilityZone operation.
    /// Creates a custom Availability Zone (AZ).
    /// 
    ///  
    /// <para>
    /// A custom AZ is an on-premises AZ that is integrated with a VMware vSphere cluster.
    /// </para>
    ///  
    /// <para>
    /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
    /// RDS on VMware User Guide.</a> 
    /// </para>
    /// </summary>
    public partial class CreateCustomAvailabilityZoneRequest : AmazonRDSRequest
    {
        private string _customAvailabilityZoneName;
        private string _existingVpnId;
        private string _newVpnTunnelName;
        private string _vpnTunnelOriginatorIP;

        /// <summary>
        /// Gets and sets the property CustomAvailabilityZoneName. 
        /// <para>
        /// The name of the custom Availability Zone (AZ).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CustomAvailabilityZoneName
        {
            get { return this._customAvailabilityZoneName; }
            set { this._customAvailabilityZoneName = value; }
        }

        // Check to see if CustomAvailabilityZoneName property is set
        internal bool IsSetCustomAvailabilityZoneName()
        {
            return this._customAvailabilityZoneName != null;
        }

        /// <summary>
        /// Gets and sets the property ExistingVpnId. 
        /// <para>
        /// The ID of an existing virtual private network (VPN) between the Amazon RDS website
        /// and the VMware vSphere cluster.
        /// </para>
        /// </summary>
        public string ExistingVpnId
        {
            get { return this._existingVpnId; }
            set { this._existingVpnId = value; }
        }

        // Check to see if ExistingVpnId property is set
        internal bool IsSetExistingVpnId()
        {
            return this._existingVpnId != null;
        }

        /// <summary>
        /// Gets and sets the property NewVpnTunnelName. 
        /// <para>
        /// The name of a new VPN tunnel between the Amazon RDS website and the VMware vSphere
        /// cluster.
        /// </para>
        ///  
        /// <para>
        /// Specify this parameter only if <code>ExistingVpnId</code> isn't specified.
        /// </para>
        /// </summary>
        public string NewVpnTunnelName
        {
            get { return this._newVpnTunnelName; }
            set { this._newVpnTunnelName = value; }
        }

        // Check to see if NewVpnTunnelName property is set
        internal bool IsSetNewVpnTunnelName()
        {
            return this._newVpnTunnelName != null;
        }

        /// <summary>
        /// Gets and sets the property VpnTunnelOriginatorIP. 
        /// <para>
        /// The IP address of network traffic from your on-premises data center. A custom AZ receives
        /// the network traffic.
        /// </para>
        ///  
        /// <para>
        /// Specify this parameter only if <code>ExistingVpnId</code> isn't specified.
        /// </para>
        /// </summary>
        public string VpnTunnelOriginatorIP
        {
            get { return this._vpnTunnelOriginatorIP; }
            set { this._vpnTunnelOriginatorIP = value; }
        }

        // Check to see if VpnTunnelOriginatorIP property is set
        internal bool IsSetVpnTunnelOriginatorIP()
        {
            return this._vpnTunnelOriginatorIP != null;
        }

    }
}