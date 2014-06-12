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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Describes a subnet.
    /// </summary>
    public partial class Subnet
    {
        private AvailabilityZone _subnetAvailabilityZone;
        private string _subnetIdentifier;
        private string _subnetStatus;


        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone.
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone
        {
            get { return this._subnetAvailabilityZone; }
            set { this._subnetAvailabilityZone = value; }
        }


        /// <summary>
        /// Sets the SubnetAvailabilityZone property
        /// </summary>
        /// <param name="subnetAvailabilityZone">The value to set for the SubnetAvailabilityZone property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Subnet WithSubnetAvailabilityZone(AvailabilityZone subnetAvailabilityZone)
        {
            this._subnetAvailabilityZone = subnetAvailabilityZone;
            return this;
        }

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this._subnetAvailabilityZone != null;
        }


        /// <summary>
        /// Gets and sets the property SubnetIdentifier. 
        /// <para>
        ///         The identifier of the subnet.        
        /// </para>
        /// </summary>
        public string SubnetIdentifier
        {
            get { return this._subnetIdentifier; }
            set { this._subnetIdentifier = value; }
        }


        /// <summary>
        /// Sets the SubnetIdentifier property
        /// </summary>
        /// <param name="subnetIdentifier">The value to set for the SubnetIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Subnet WithSubnetIdentifier(string subnetIdentifier)
        {
            this._subnetIdentifier = subnetIdentifier;
            return this;
        }

        // Check to see if SubnetIdentifier property is set
        internal bool IsSetSubnetIdentifier()
        {
            return this._subnetIdentifier != null;
        }


        /// <summary>
        /// Gets and sets the property SubnetStatus. 
        /// <para>
        ///         The status of the subnet.        
        /// </para>
        /// </summary>
        public string SubnetStatus
        {
            get { return this._subnetStatus; }
            set { this._subnetStatus = value; }
        }


        /// <summary>
        /// Sets the SubnetStatus property
        /// </summary>
        /// <param name="subnetStatus">The value to set for the SubnetStatus property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Subnet WithSubnetStatus(string subnetStatus)
        {
            this._subnetStatus = subnetStatus;
            return this;
        }

        // Check to see if SubnetStatus property is set
        internal bool IsSetSubnetStatus()
        {
            return this._subnetStatus != null;
        }

    }
}