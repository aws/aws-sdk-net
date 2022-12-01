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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterCompute operation.
    /// Registers your compute resources in a fleet you previously created. After you register
    /// a compute to your fleet, you can monitor and manage your compute using GameLift. The
    /// operation returns the compute resource containing SDK endpoint you can use to connect
    /// your game server to GameLift.
    /// 
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-creating-anywhere.html">Create
    /// an Anywhere fleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/integration-testing.html">Test
    /// your integration</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RegisterComputeRequest : AmazonGameLiftRequest
    {
        private string _certificatePath;
        private string _computeName;
        private string _dnsName;
        private string _fleetId;
        private string _ipAddress;
        private string _location;

        /// <summary>
        /// Gets and sets the property CertificatePath. 
        /// <para>
        /// The path to the TLS certificate on your compute resource. The path and certificate
        /// are not validated by GameLift.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CertificatePath
        {
            get { return this._certificatePath; }
            set { this._certificatePath = value; }
        }

        // Check to see if CertificatePath property is set
        internal bool IsSetCertificatePath()
        {
            return this._certificatePath != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeName. 
        /// <para>
        /// A descriptive label that is associated with the compute resource registered to your
        /// fleet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string ComputeName
        {
            get { return this._computeName; }
            set { this._computeName = value; }
        }

        // Check to see if ComputeName property is set
        internal bool IsSetComputeName()
        {
            return this._computeName != null;
        }

        /// <summary>
        /// Gets and sets the property DnsName. 
        /// <para>
        /// The DNS name of the compute resource. GameLift requires the DNS name or IP address
        /// to manage your compute resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string DnsName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DnsName property is set
        internal bool IsSetDnsName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet to register the compute to. You can use either the
        /// fleet ID or ARN value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The IP address of the compute resource. GameLift requires the DNS name or IP address
        /// to manage your compute resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The name of the custom location you added to the fleet you are registering this compute
        /// resource to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

    }
}