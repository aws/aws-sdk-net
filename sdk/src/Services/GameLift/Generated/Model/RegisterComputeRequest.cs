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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterCompute operation.
    /// Registers a compute resource in an Amazon GameLift Servers Anywhere fleet. 
    /// 
    ///  
    /// <para>
    /// For an Anywhere fleet that's running the Amazon GameLift Servers Agent, the Agent
    /// handles all compute registry tasks for you. For an Anywhere fleet that doesn't use
    /// the Agent, call this operation to register fleet computes.
    /// </para>
    ///  
    /// <para>
    /// To register a compute, give the compute a name (must be unique within the fleet) and
    /// specify the compute resource's DNS name or IP address. Provide a fleet ID and a fleet
    /// location to associate with the compute being registered. You can optionally include
    /// the path to a TLS certificate on the compute resource.
    /// </para>
    ///  
    /// <para>
    /// If successful, this operation returns compute details, including an Amazon GameLift
    /// Servers SDK endpoint or Agent endpoint. Game server processes running on the compute
    /// can use this endpoint to communicate with the Amazon GameLift Servers service. Each
    /// server process includes the SDK endpoint in its call to the Amazon GameLift Servers
    /// server SDK action <c>InitSDK()</c>. 
    /// </para>
    ///  
    /// <para>
    /// To view compute details, call <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeCompute.html">DescribeCompute</a>
    /// with the compute name. 
    /// </para>
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
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk.html">Server
    /// SDK reference guides</a> (for version 5.x)
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
        /// The path to a TLS certificate on your compute resource. Amazon GameLift Servers doesn't
        /// validate the path and certificate.
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
        /// A descriptive label for the compute resource.
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
        /// The DNS name of the compute resource. Amazon GameLift Servers requires either a DNS
        /// name or IP address.
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
        [AWSProperty(Required=true, Min=1, Max=512)]
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
        /// The IP address of the compute resource. Amazon GameLift Servers requires either a
        /// DNS name or IP address. When registering an Anywhere fleet, an IP address is required.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// The name of a custom location to associate with the compute resource being registered.
        /// This parameter is required when registering a compute for an Anywhere fleet.
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