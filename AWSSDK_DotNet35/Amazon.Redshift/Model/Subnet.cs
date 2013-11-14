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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// <para> Describes a subnet. </para>
    /// </summary>
    public class Subnet
    {
        
        private string subnetIdentifier;
        private AvailabilityZone subnetAvailabilityZone;
        private string subnetStatus;


        /// <summary>
        /// The identifier of the subnet.
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
        /// Describes an availability zone.
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

        /// <summary>
        /// The status of the subnet.
        ///  
        /// </summary>
        public string SubnetStatus
        {
            get { return this.subnetStatus; }
            set { this.subnetStatus = value; }
        }

        // Check to see if SubnetStatus property is set
        internal bool IsSetSubnetStatus()
        {
            return this.subnetStatus != null;
        }
    }
}
