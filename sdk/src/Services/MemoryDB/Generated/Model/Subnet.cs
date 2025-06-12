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
 * Do not modify this file. This file is generated from the memorydb-2021-01-01.normal.json service model.
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
namespace Amazon.MemoryDB.Model
{
    /// <summary>
    /// Represents the subnet associated with a cluster. This parameter refers to subnets
    /// defined in Amazon Virtual Private Cloud (Amazon VPC) and used with MemoryDB.
    /// </summary>
    public partial class Subnet
    {
        private AvailabilityZone _availabilityZone;
        private string _identifier;
        private List<string> _supportedNetworkTypes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the subnet resides
        /// </para>
        /// </summary>
        public AvailabilityZone AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property Identifier. 
        /// <para>
        /// The unique identifier for the subnet.
        /// </para>
        /// </summary>
        public string Identifier
        {
            get { return this._identifier; }
            set { this._identifier = value; }
        }

        // Check to see if Identifier property is set
        internal bool IsSetIdentifier()
        {
            return this._identifier != null;
        }

        /// <summary>
        /// Gets and sets the property SupportedNetworkTypes. 
        /// <para>
        /// The network types supported by this subnet. Returns an array of strings that can include
        /// 'ipv4', 'ipv6', or both, indicating whether the subnet supports IPv4 only, IPv6 only,
        /// or dual-stack deployments.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SupportedNetworkTypes
        {
            get { return this._supportedNetworkTypes; }
            set { this._supportedNetworkTypes = value; }
        }

        // Check to see if SupportedNetworkTypes property is set
        internal bool IsSetSupportedNetworkTypes()
        {
            return this._supportedNetworkTypes != null && (this._supportedNetworkTypes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}