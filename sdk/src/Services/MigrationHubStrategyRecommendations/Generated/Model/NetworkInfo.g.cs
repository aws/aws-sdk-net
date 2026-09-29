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
    /// Information about the server's network for which the assessment was run.
    /// </summary>
    public partial class NetworkInfo
    {
        /// <summary>
        /// Gets and sets the property InterfaceName. 
        /// <para>
        ///  Information about the name of the interface of the server for which the assessment
        /// was run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string InterfaceName { get; set; }

        /// <summary>
        /// Checks to see if the InterfaceName property is set.
        /// </summary>
        internal bool IsSetInterfaceName() => this.InterfaceName != null;

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  Information about the IP address of the server for which the assessment was run.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 15)]
        public string IpAddress { get; set; }

        /// <summary>
        /// Checks to see if the IpAddress property is set.
        /// </summary>
        internal bool IsSetIpAddress() => this.IpAddress != null;

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        ///  Information about the MAC address of the server for which the assessment was run.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 17)]
        public string MacAddress { get; set; }

        /// <summary>
        /// Checks to see if the MacAddress property is set.
        /// </summary>
        internal bool IsSetMacAddress() => this.MacAddress != null;

        /// <summary>
        /// Gets and sets the property NetMask. 
        /// <para>
        ///  Information about the subnet mask of the server for which the assessment was run.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string NetMask { get; set; }

        /// <summary>
        /// Checks to see if the NetMask property is set.
        /// </summary>
        internal bool IsSetNetMask() => this.NetMask != null;
    }
}
