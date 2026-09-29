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

namespace Amazon.MigrationHubStrategyRecommendations.Model
{
    /// <summary>
    /// IP address based configurations.
    /// </summary>
    public partial class IPAddressBasedRemoteInfo
    {
        /// <summary>
        /// Gets and sets the property AuthType. 
        /// <para>
        /// The type of authorization.
        /// </para>
        /// </summary>
        public AuthType AuthType { get; set; }

        /// <summary>
        /// Checks to see if the AuthType property is set.
        /// </summary>
        internal bool IsSetAuthType() => this.AuthType != null;

        /// <summary>
        /// Gets and sets the property IpAddressConfigurationTimeStamp. 
        /// <para>
        /// The time stamp of the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string IpAddressConfigurationTimeStamp { get; set; }

        /// <summary>
        /// Checks to see if the IpAddressConfigurationTimeStamp property is set.
        /// </summary>
        internal bool IsSetIpAddressConfigurationTimeStamp() => this.IpAddressConfigurationTimeStamp != null;

        /// <summary>
        /// Gets and sets the property OsType. 
        /// <para>
        /// The type of the operating system.
        /// </para>
        /// </summary>
        public OSType OsType { get; set; }

        /// <summary>
        /// Checks to see if the OsType property is set.
        /// </summary>
        internal bool IsSetOsType() => this.OsType != null;
    }
}
