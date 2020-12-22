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
    /// A custom Availability Zone (AZ) is an on-premises AZ that is integrated with a VMware
    /// vSphere cluster.
    /// 
    ///  
    /// <para>
    /// For more information about RDS on VMware, see the <a href="https://docs.aws.amazon.com/AmazonRDS/latest/RDSonVMwareUserGuide/rds-on-vmware.html">
    /// RDS on VMware User Guide.</a> 
    /// </para>
    /// </summary>
    public partial class CustomAvailabilityZone
    {
        private string _customAvailabilityZoneId;
        private string _customAvailabilityZoneName;
        private string _customAvailabilityZoneStatus;
        private VpnDetails _vpnDetails;

        /// <summary>
        /// Gets and sets the property CustomAvailabilityZoneId. 
        /// <para>
        /// The identifier of the custom AZ.
        /// </para>
        ///  
        /// <para>
        /// Amazon RDS generates a unique identifier when a custom AZ is created.
        /// </para>
        /// </summary>
        public string CustomAvailabilityZoneId
        {
            get { return this._customAvailabilityZoneId; }
            set { this._customAvailabilityZoneId = value; }
        }

        // Check to see if CustomAvailabilityZoneId property is set
        internal bool IsSetCustomAvailabilityZoneId()
        {
            return this._customAvailabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomAvailabilityZoneName. 
        /// <para>
        /// The name of the custom AZ.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property CustomAvailabilityZoneStatus. 
        /// <para>
        /// The status of the custom AZ.
        /// </para>
        /// </summary>
        public string CustomAvailabilityZoneStatus
        {
            get { return this._customAvailabilityZoneStatus; }
            set { this._customAvailabilityZoneStatus = value; }
        }

        // Check to see if CustomAvailabilityZoneStatus property is set
        internal bool IsSetCustomAvailabilityZoneStatus()
        {
            return this._customAvailabilityZoneStatus != null;
        }

        /// <summary>
        /// Gets and sets the property VpnDetails. 
        /// <para>
        /// Information about the virtual private network (VPN) between the VMware vSphere cluster
        /// and the AWS website.
        /// </para>
        /// </summary>
        public VpnDetails VpnDetails
        {
            get { return this._vpnDetails; }
            set { this._vpnDetails = value; }
        }

        // Check to see if VpnDetails property is set
        internal bool IsSetVpnDetails()
        {
            return this._vpnDetails != null;
        }

    }
}