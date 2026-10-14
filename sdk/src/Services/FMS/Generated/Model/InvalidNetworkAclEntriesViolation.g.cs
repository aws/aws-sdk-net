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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail for the entries in a network ACL resource.
    /// </summary>
    public partial class InvalidNetworkAclEntriesViolation
    {
        /// <summary>
        /// Gets and sets the property CurrentAssociatedNetworkAcl. 
        /// <para>
        /// The network ACL containing the entry violations. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CurrentAssociatedNetworkAcl { get; set; }

        /// <summary>
        /// Checks to see if the CurrentAssociatedNetworkAcl property is set.
        /// </summary>
        internal bool IsSetCurrentAssociatedNetworkAcl() => this.CurrentAssociatedNetworkAcl != null;

        /// <summary>
        /// Gets and sets the property EntryViolations. 
        /// <para>
        /// Detailed information about the entry violations in the network ACL. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EntryViolation> EntryViolations { get; set; } = AWSConfigs.InitializeCollections ? new List<EntryViolation>() : null;

        /// <summary>
        /// Checks to see if the EntryViolations property is set.
        /// </summary>
        internal bool IsSetEntryViolations() => this.EntryViolations != null && (this.EntryViolations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Subnet. 
        /// <para>
        /// The subnet that's associated with the network ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Subnet { get; set; }

        /// <summary>
        /// Checks to see if the Subnet property is set.
        /// </summary>
        internal bool IsSetSubnet() => this.Subnet != null;

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The Availability Zone where the network ACL is in use. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SubnetAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SubnetAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSubnetAvailabilityZone() => this.SubnetAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Vpc. 
        /// <para>
        /// The VPC where the violation was found. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string Vpc { get; set; }

        /// <summary>
        /// Checks to see if the Vpc property is set.
        /// </summary>
        internal bool IsSetVpc() => this.Vpc != null;
    }
}
