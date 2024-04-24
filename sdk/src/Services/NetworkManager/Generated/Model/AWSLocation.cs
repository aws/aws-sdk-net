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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Specifies a location in Amazon Web Services.
    /// </summary>
    public partial class AWSLocation
    {
        private string _subnetArn;
        private string _zone;

        /// <summary>
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the subnet that the device is located in.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string SubnetArn
        {
            get { return this._subnetArn; }
            set { this._subnetArn = value; }
        }

        // Check to see if SubnetArn property is set
        internal bool IsSetSubnetArn()
        {
            return this._subnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Zone. 
        /// <para>
        /// The Zone that the device is located in. Specify the ID of an Availability Zone, Local
        /// Zone, Wavelength Zone, or an Outpost.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string Zone
        {
            get { return this._zone; }
            set { this._zone = value; }
        }

        // Check to see if Zone property is set
        internal bool IsSetZone()
        {
            return this._zone != null;
        }

    }
}