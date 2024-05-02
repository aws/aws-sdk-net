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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
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
namespace Amazon.RDS.Model
{
    /// <summary>
    /// This data type is used as a response element for the <c>DescribeDBSubnetGroups</c>
    /// operation.
    /// </summary>
    public partial class Subnet
    {
        private AvailabilityZone _subnetAvailabilityZone;
        private string _subnetIdentifier;
        private Outpost _subnetOutpost;
        private string _subnetStatus;

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone.
        /// </summary>
        public AvailabilityZone SubnetAvailabilityZone
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
        /// The identifier of the subnet.
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

        /// <summary>
        /// Gets and sets the property SubnetOutpost. 
        /// <para>
        /// If the subnet is associated with an Outpost, this value specifies the Outpost.
        /// </para>
        ///  
        /// <para>
        /// For more information about RDS on Outposts, see <a href="https://docs.aws.amazon.com/AmazonRDS/latest/UserGuide/rds-on-outposts.html">Amazon
        /// RDS on Amazon Web Services Outposts</a> in the <i>Amazon RDS User Guide.</i> 
        /// </para>
        /// </summary>
        public Outpost SubnetOutpost
        {
            get { return this._subnetOutpost; }
            set { this._subnetOutpost = value; }
        }

        // Check to see if SubnetOutpost property is set
        internal bool IsSetSubnetOutpost()
        {
            return this._subnetOutpost != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetStatus. 
        /// <para>
        /// The status of the subnet.
        /// </para>
        /// </summary>
        public string SubnetStatus
        {
            get { return this._subnetStatus; }
            set { this._subnetStatus = value; }
        }

        // Check to see if SubnetStatus property is set
        internal bool IsSetSubnetStatus()
        {
            return this._subnetStatus != null;
        }

    }
}