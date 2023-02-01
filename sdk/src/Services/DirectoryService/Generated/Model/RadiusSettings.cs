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
 * Do not modify this file. This file is generated from the ds-2015-04-16.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about a Remote Authentication Dial In User Service (RADIUS) server.
    /// </summary>
    public partial class RadiusSettings
    {
        private RadiusAuthenticationProtocol _authenticationProtocol;
        private string _displayLabel;
        private int? _radiusPort;
        private int? _radiusRetries;
        private List<string> _radiusServers = new List<string>();
        private int? _radiusTimeout;
        private string _sharedSecret;
        private bool? _useSameUsername;

        /// <summary>
        /// Gets and sets the property AuthenticationProtocol. 
        /// <para>
        /// The protocol specified for your RADIUS endpoints.
        /// </para>
        /// </summary>
        public RadiusAuthenticationProtocol AuthenticationProtocol
        {
            get { return this._authenticationProtocol; }
            set { this._authenticationProtocol = value; }
        }

        // Check to see if AuthenticationProtocol property is set
        internal bool IsSetAuthenticationProtocol()
        {
            return this._authenticationProtocol != null;
        }

        /// <summary>
        /// Gets and sets the property DisplayLabel. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string DisplayLabel
        {
            get { return this._displayLabel; }
            set { this._displayLabel = value; }
        }

        // Check to see if DisplayLabel property is set
        internal bool IsSetDisplayLabel()
        {
            return this._displayLabel != null;
        }

        /// <summary>
        /// Gets and sets the property RadiusPort. 
        /// <para>
        /// The port that your RADIUS server is using for communications. Your self-managed network
        /// must allow inbound traffic over this port from the Directory Service servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1025, Max=65535)]
        public int RadiusPort
        {
            get { return this._radiusPort.GetValueOrDefault(); }
            set { this._radiusPort = value; }
        }

        // Check to see if RadiusPort property is set
        internal bool IsSetRadiusPort()
        {
            return this._radiusPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RadiusRetries. 
        /// <para>
        /// The maximum number of times that communication with the RADIUS server is attempted.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public int RadiusRetries
        {
            get { return this._radiusRetries.GetValueOrDefault(); }
            set { this._radiusRetries = value; }
        }

        // Check to see if RadiusRetries property is set
        internal bool IsSetRadiusRetries()
        {
            return this._radiusRetries.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RadiusServers. 
        /// <para>
        /// An array of strings that contains the fully qualified domain name (FQDN) or IP addresses
        /// of the RADIUS server endpoints, or the FQDN or IP addresses of your RADIUS server
        /// load balancer.
        /// </para>
        /// </summary>
        public List<string> RadiusServers
        {
            get { return this._radiusServers; }
            set { this._radiusServers = value; }
        }

        // Check to see if RadiusServers property is set
        internal bool IsSetRadiusServers()
        {
            return this._radiusServers != null && this._radiusServers.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RadiusTimeout. 
        /// <para>
        /// The amount of time, in seconds, to wait for the RADIUS server to respond.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public int RadiusTimeout
        {
            get { return this._radiusTimeout.GetValueOrDefault(); }
            set { this._radiusTimeout = value; }
        }

        // Check to see if RadiusTimeout property is set
        internal bool IsSetRadiusTimeout()
        {
            return this._radiusTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// Required for enabling RADIUS on the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=8, Max=512)]
        public string SharedSecret
        {
            get { return this._sharedSecret; }
            set { this._sharedSecret = value; }
        }

        // Check to see if SharedSecret property is set
        internal bool IsSetSharedSecret()
        {
            return this._sharedSecret != null;
        }

        /// <summary>
        /// Gets and sets the property UseSameUsername. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        public bool UseSameUsername
        {
            get { return this._useSameUsername.GetValueOrDefault(); }
            set { this._useSameUsername = value; }
        }

        // Check to see if UseSameUsername property is set
        internal bool IsSetUseSameUsername()
        {
            return this._useSameUsername.HasValue; 
        }

    }
}