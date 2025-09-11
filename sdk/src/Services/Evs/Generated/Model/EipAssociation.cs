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
 * Do not modify this file. This file is generated from the evs-2023-07-27.normal.json service model.
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
namespace Amazon.Evs.Model
{
    /// <summary>
    /// An Elastic IP address association with the elastic network interface in the VLAN subnet.
    /// </summary>
    public partial class EipAssociation
    {
        private string _allocationId;
        private string _associationId;
        private string _ipAddress;

        /// <summary>
        /// Gets and sets the property AllocationId. 
        /// <para>
        /// The Elastic IP address allocation ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=26)]
        public string AllocationId
        {
            get { return this._allocationId; }
            set { this._allocationId = value; }
        }

        // Check to see if AllocationId property is set
        internal bool IsSetAllocationId()
        {
            return this._allocationId != null;
        }

        /// <summary>
        /// Gets and sets the property AssociationId. 
        /// <para>
        /// A unique ID for the elastic IP address association with the VLAN subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=9, Max=26)]
        public string AssociationId
        {
            get { return this._associationId; }
            set { this._associationId = value; }
        }

        // Check to see if AssociationId property is set
        internal bool IsSetAssociationId()
        {
            return this._associationId != null;
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The Elastic IP address.
        /// </para>
        /// </summary>
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

    }
}