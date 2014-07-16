/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the ModifySubnetAttribute operation.
    /// <para>Modifies a subnet attribute.</para>
    /// </summary>
    public partial class ModifySubnetAttributeRequest : AmazonEC2Request
    {
        private string subnetId;
        private bool? mapPublicIpOnLaunch;


        /// <summary>
        /// The ID of the subnet.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// Modifies the public IP addressing behavior for the subnet. Specify true to indicate that instances launched into the specified subnet should be assigned a public IP address. /// If set to true, the instance receives a public IP address only if the instance is launched with a single, new network interface with the device index of 0.
        /// </summary>
        public bool MapPublicIpOnLaunch
        {
            get { return this.mapPublicIpOnLaunch ?? default(bool); }
            set { this.mapPublicIpOnLaunch = value; }
        }

        // Check to see if MapPublicIpOnLaunch property is set
        internal bool IsSetMapPublicIpOnLaunch()
        {
            return this.mapPublicIpOnLaunch.HasValue;
        }

    }
}
    
