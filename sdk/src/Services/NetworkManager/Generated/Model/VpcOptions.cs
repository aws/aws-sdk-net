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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes the VPC options.
    /// </summary>
    public partial class VpcOptions
    {
        private bool? _applianceModeSupport;
        private bool? _ipv6Support;

        /// <summary>
        /// Gets and sets the property ApplianceModeSupport. 
        /// <para>
        /// Indicates whether appliance mode is supported. If enabled, traffic flow between a
        /// source and destination use the same Availability Zone for the VPC attachment for the
        /// lifetime of that flow. The default value is <code>false</code>.
        /// </para>
        /// </summary>
        public bool ApplianceModeSupport
        {
            get { return this._applianceModeSupport.GetValueOrDefault(); }
            set { this._applianceModeSupport = value; }
        }

        // Check to see if ApplianceModeSupport property is set
        internal bool IsSetApplianceModeSupport()
        {
            return this._applianceModeSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Support. 
        /// <para>
        /// Indicates whether IPv6 is supported.
        /// </para>
        /// </summary>
        public bool Ipv6Support
        {
            get { return this._ipv6Support.GetValueOrDefault(); }
            set { this._ipv6Support = value; }
        }

        // Check to see if Ipv6Support property is set
        internal bool IsSetIpv6Support()
        {
            return this._ipv6Support.HasValue; 
        }

    }
}