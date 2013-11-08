/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para>Represents the subnet associated with a cache cluster. This parameter refers to subnets defined in Amazon Virtual Private Cloud
    /// (Amazon VPC) and used with ElastiCache.</para>
    /// </summary>
    public class Subnet
    {
        
        private string subnetIdentifier;
        private AvailabilityZone subnetAvailabilityZone;


        /// <summary>
        /// The unique identifier for the subnet
        ///  
        /// </summary>
        public string SubnetIdentifier
        {
            get { return this.subnetIdentifier; }
            set { this.subnetIdentifier = value; }
        }

        // Check to see if SubnetIdentifier property is set
        internal bool IsSetSubnetIdentifier()
        {
            return this.subnetIdentifier != null;
        }

        /// <summary>
        /// The Availability Zone associated with the subnet
        ///  
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone
        {
            get { return this.subnetAvailabilityZone; }
            set { this.subnetAvailabilityZone = value; }
        }

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this.subnetAvailabilityZone != null;
        }
    }
}
