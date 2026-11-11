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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DirectoryService.Model
{
    /// <summary>
    /// Contains information about a Remote Authentication Dial In User Service (RADIUS) server.
    /// </summary>
    public partial class RadiusSettings
    {
        /// <summary>
        /// Gets and sets the property AuthenticationProtocol. 
        /// <para>
        /// The protocol specified for your RADIUS endpoints.
        /// </para>
        /// </summary>
        public RadiusAuthenticationProtocol AuthenticationProtocol { get; set; }

        /// <summary>
        /// Checks to see if the AuthenticationProtocol property is set.
        /// </summary>
        internal bool IsSetAuthenticationProtocol() => this.AuthenticationProtocol != null;

        /// <summary>
        /// Gets and sets the property DisplayLabel. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string DisplayLabel { get; set; }

        /// <summary>
        /// Checks to see if the DisplayLabel property is set.
        /// </summary>
        internal bool IsSetDisplayLabel() => this.DisplayLabel != null;

        /// <summary>
        /// Gets and sets the property RadiusPort. 
        /// <para>
        /// The port that your RADIUS server is using for communications. Your self-managed network
        /// must allow inbound traffic over this port from the Directory Service servers.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1025, Max = 65535)]
        public int? RadiusPort { get; set; }

        /// <summary>
        /// Checks to see if the RadiusPort property is set.
        /// </summary>
        internal bool IsSetRadiusPort() => this.RadiusPort.HasValue;

        /// <summary>
        /// Gets and sets the property RadiusRetries. 
        /// <para>
        /// The maximum number of times that communication with the RADIUS server is retried after
        /// the initial attempt.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public int? RadiusRetries { get; set; }

        /// <summary>
        /// Checks to see if the RadiusRetries property is set.
        /// </summary>
        internal bool IsSetRadiusRetries() => this.RadiusRetries.HasValue;

        /// <summary>
        /// Gets and sets the property RadiusServers. 
        /// <para>
        /// The fully qualified domain name (FQDN) or IP addresses of the RADIUS server endpoints,
        /// or the FQDN or IP addresses of your RADIUS server load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RadiusServers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RadiusServers property is set.
        /// </summary>
        internal bool IsSetRadiusServers() => this.RadiusServers != null && (this.RadiusServers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RadiusServersIpv6. 
        /// <para>
        /// The IPv6 addresses of the RADIUS server endpoints or RADIUS server load balancer.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> RadiusServersIpv6 { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the RadiusServersIpv6 property is set.
        /// </summary>
        internal bool IsSetRadiusServersIpv6() => this.RadiusServersIpv6 != null && (this.RadiusServersIpv6.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RadiusTimeout. 
        /// <para>
        /// The amount of time, in seconds, to wait for the RADIUS server to respond.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? RadiusTimeout { get; set; }

        /// <summary>
        /// Checks to see if the RadiusTimeout property is set.
        /// </summary>
        internal bool IsSetRadiusTimeout() => this.RadiusTimeout.HasValue;

        /// <summary>
        /// Gets and sets the property SharedSecret. 
        /// <para>
        /// Required for enabling RADIUS on the directory.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 8, Max = 512)]
        public string SharedSecret { get; set; }

        /// <summary>
        /// Checks to see if the SharedSecret property is set.
        /// </summary>
        internal bool IsSetSharedSecret() => this.SharedSecret != null;

        /// <summary>
        /// Gets and sets the property UseSameUsername. 
        /// <para>
        /// Not currently used.
        /// </para>
        /// </summary>
        public bool? UseSameUsername { get; set; }

        /// <summary>
        /// Checks to see if the UseSameUsername property is set.
        /// </summary>
        internal bool IsSetUseSameUsername() => this.UseSameUsername.HasValue;
    }
}
