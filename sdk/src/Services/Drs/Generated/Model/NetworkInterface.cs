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
 * Do not modify this file. This file is generated from the drs-2020-02-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Network interface.
    /// </summary>
    public partial class NetworkInterface
    {
        private List<string> _ips = new List<string>();
        private bool? _isPrimary;
        private string _macAddress;

        /// <summary>
        /// Gets and sets the property Ips. 
        /// <para>
        /// Network interface IPs.
        /// </para>
        /// </summary>
        public List<string> Ips
        {
            get { return this._ips; }
            set { this._ips = value; }
        }

        // Check to see if Ips property is set
        internal bool IsSetIps()
        {
            return this._ips != null && this._ips.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IsPrimary. 
        /// <para>
        /// Whether this is the primary network interface.
        /// </para>
        /// </summary>
        public bool IsPrimary
        {
            get { return this._isPrimary.GetValueOrDefault(); }
            set { this._isPrimary = value; }
        }

        // Check to see if IsPrimary property is set
        internal bool IsSetIsPrimary()
        {
            return this._isPrimary.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MacAddress. 
        /// <para>
        /// The MAC address of the network interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
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

    }
}