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
 * Do not modify this file. This file is generated from the dax-2017-04-19.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DAX.Model
{
    /// <summary>
    /// Represents the subnet associated with a DAX cluster. This parameter refers to subnets
    /// defined in Amazon Virtual Private Cloud (Amazon VPC) and used with DAX.
    /// </summary>
    public partial class Subnet
    {
        private string _subnetAvailabilityZone;
        private string _subnetIdentifier;

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The Availability Zone (AZ) for the subnet.
        /// </para>
        /// </summary>
        public string SubnetAvailabilityZone
        {
            get { return this._subnetAvailabilityZone; }
            set { this._subnetAvailabilityZone = value; }
        }

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this._subnetAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetIdentifier. 
        /// <para>
        /// The system-assigned identifier for the subnet.
        /// </para>
        /// </summary>
        public string SubnetIdentifier
        {
            get { return this._subnetIdentifier; }
            set { this._subnetIdentifier = value; }
        }

        // Check to see if SubnetIdentifier property is set
        internal bool IsSetSubnetIdentifier()
        {
            return this._subnetIdentifier != null;
        }

    }
}