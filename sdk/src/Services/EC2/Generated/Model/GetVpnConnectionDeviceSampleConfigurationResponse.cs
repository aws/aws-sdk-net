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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetVpnConnectionDeviceSampleConfiguration operation.
    /// </summary>
    public partial class GetVpnConnectionDeviceSampleConfigurationResponse : AmazonWebServiceResponse
    {
        private string _vpnConnectionDeviceSampleConfiguration;

        /// <summary>
        /// Gets and sets the property VpnConnectionDeviceSampleConfiguration. 
        /// <para>
        /// Sample configuration file for the specified customer gateway device.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string VpnConnectionDeviceSampleConfiguration
        {
            get { return this._vpnConnectionDeviceSampleConfiguration; }
            set { this._vpnConnectionDeviceSampleConfiguration = value; }
        }

        // Check to see if VpnConnectionDeviceSampleConfiguration property is set
        internal bool IsSetVpnConnectionDeviceSampleConfiguration()
        {
            return this._vpnConnectionDeviceSampleConfiguration != null;
        }

    }
}