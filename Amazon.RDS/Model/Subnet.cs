/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> This data type is used as a response element in the DescribeDBSubnetGroups action. </para>
    /// </summary>
    public class Subnet  
    {
        
        private string subnetIdentifier;
        private AvailabilityZone subnetAvailabilityZone;
        private string subnetStatus;

        /// <summary>
        /// Specifies the identifier of the subnet.
        ///  
        /// </summary>
        public string SubnetIdentifier
        {
            get { return this.subnetIdentifier; }
            set { this.subnetIdentifier = value; }
        }

        /// <summary>
        /// Sets the SubnetIdentifier property
        /// </summary>
        /// <param name="subnetIdentifier">The value to set for the SubnetIdentifier property </param>
        /// <returns>this instance</returns>
        public Subnet WithSubnetIdentifier(string subnetIdentifier)
        {
            this.subnetIdentifier = subnetIdentifier;
            return this;
        }
            

        // Check to see if SubnetIdentifier property is set
        internal bool IsSetSubnetIdentifier()
        {
            return this.subnetIdentifier != null;       
        }

        /// <summary>
        /// Contains Availability Zone information. This data type is used as an element in the following data type: <ul>
        /// <li><a>OrderableDBInstanceOption</a></li> </ul>
        ///  
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone
        {
            get { return this.subnetAvailabilityZone; }
            set { this.subnetAvailabilityZone = value; }
        }

        /// <summary>
        /// Sets the SubnetAvailabilityZone property
        /// </summary>
        /// <param name="subnetAvailabilityZone">The value to set for the SubnetAvailabilityZone property </param>
        /// <returns>this instance</returns>
        public Subnet WithSubnetAvailabilityZone(AvailabilityZone subnetAvailabilityZone)
        {
            this.subnetAvailabilityZone = subnetAvailabilityZone;
            return this;
        }
            

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this.subnetAvailabilityZone != null;       
        }

        /// <summary>
        /// Specifies the status of the subnet.
        ///  
        /// </summary>
        public string SubnetStatus
        {
            get { return this.subnetStatus; }
            set { this.subnetStatus = value; }
        }

        /// <summary>
        /// Sets the SubnetStatus property
        /// </summary>
        /// <param name="subnetStatus">The value to set for the SubnetStatus property </param>
        /// <returns>this instance</returns>
        public Subnet WithSubnetStatus(string subnetStatus)
        {
            this.subnetStatus = subnetStatus;
            return this;
        }
            

        // Check to see if SubnetStatus property is set
        internal bool IsSetSubnetStatus()
        {
            return this.subnetStatus != null;       
        }
    }
}
