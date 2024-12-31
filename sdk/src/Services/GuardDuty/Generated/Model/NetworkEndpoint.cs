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
 * Do not modify this file. This file is generated from the guardduty-2017-11-28.normal.json service model.
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
namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Contains information about network endpoints that were observed in the attack sequence.
    /// </summary>
    public partial class NetworkEndpoint
    {
        private AutonomousSystem _autonomousSystem;
        private NetworkConnection _connection;
        private string _domain;
        private string _id;
        private string _ip;
        private NetworkGeoLocation _location;
        private int? _port;

        /// <summary>
        /// Gets and sets the property AutonomousSystem. 
        /// <para>
        /// The Autonomous System (AS) of the network endpoint.
        /// </para>
        /// </summary>
        public AutonomousSystem AutonomousSystem
        {
            get { return this._autonomousSystem; }
            set { this._autonomousSystem = value; }
        }

        // Check to see if AutonomousSystem property is set
        internal bool IsSetAutonomousSystem()
        {
            return this._autonomousSystem != null;
        }

        /// <summary>
        /// Gets and sets the property Connection. 
        /// <para>
        /// Information about the network connection.
        /// </para>
        /// </summary>
        public NetworkConnection Connection
        {
            get { return this._connection; }
            set { this._connection = value; }
        }

        // Check to see if Connection property is set
        internal bool IsSetConnection()
        {
            return this._connection != null;
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The domain information for the network endpoint.
        /// </para>
        /// </summary>
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the network endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Ip. 
        /// <para>
        /// The IP address associated with the network endpoint.
        /// </para>
        /// </summary>
        public string Ip
        {
            get { return this._ip; }
            set { this._ip = value; }
        }

        // Check to see if Ip property is set
        internal bool IsSetIp()
        {
            return this._ip != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Information about the location of the network endpoint.
        /// </para>
        /// </summary>
        public NetworkGeoLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port number associated with the network endpoint.
        /// </para>
        /// </summary>
        public int? Port
        {
            get { return this._port; }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

    }
}