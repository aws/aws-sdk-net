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
 * Do not modify this file. This file is generated from the migrationhubstrategy-2020-02-19.normal.json service model.
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
        private string _interfaceName;
        private string _ipAddress;
        private string _macAddress;
        private string _netMask;

        /// <summary>
        /// Gets and sets the property InterfaceName. 
        /// <para>
        ///  Information about the name of the interface of the server for which the assessment
        /// was run. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string InterfaceName
        {
            get { return this._interfaceName; }
            set { this._interfaceName = value; }
        }

        // Check to see if InterfaceName property is set
        internal bool IsSetInterfaceName()
        {
            return this._interfaceName != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        ///  Information about the IP address of the server for which the assessment was run.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=15)]
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
        /// Gets and sets the property MacAddress. 
        /// <para>
        ///  Information about the MAC address of the server for which the assessment was run.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=17)]
        public string MacAddress
        {
            get { return this._macAddress; }
            set { this._macAddress = value; }
        }

        // Check to see if MacAddress property is set
        internal bool IsSetMacAddress()
        {
            return this._macAddress != null;
        }

        /// <summary>
        /// Gets and sets the property NetMask. 
        /// <para>
        ///  Information about the subnet mask of the server for which the assessment was run.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string NetMask
        {
            get { return this._netMask; }
            set { this._netMask = value; }
        }

        // Check to see if NetMask property is set
        internal bool IsSetNetMask()
        {
            return this._netMask != null;
        }

    }
}