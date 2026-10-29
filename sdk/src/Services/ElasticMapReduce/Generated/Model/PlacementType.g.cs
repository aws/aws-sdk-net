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

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The Amazon EC2 Availability Zone configuration of the cluster (job flow).
    /// </summary>
    public partial class PlacementType
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public PlacementType() { }

        /// <summary>
        /// Instantiates PlacementType with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Amazon EC2 Availability Zone for the cluster. <c>AvailabilityZone</c>   is used for uniform instance groups, while <c>AvailabilityZones</c> (plural) is used   for instance fleets.</param>
        public PlacementType(string availabilityZone)
        {
            this.AvailabilityZone = availabilityZone;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon EC2 Availability Zone for the cluster. <c>AvailabilityZone</c> is used
        /// for uniform instance groups, while <c>AvailabilityZones</c> (plural) is used for instance
        /// fleets.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10280)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// When multiple Availability Zones are specified, Amazon EMR evaluates them and launches
        /// instances in the optimal Availability Zone. <c>AvailabilityZones</c> is used for instance
        /// fleets, while <c>AvailabilityZone</c> (singular) is used for uniform instance groups.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR releases 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AvailabilityZones { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AvailabilityZones property is set.
        /// </summary>
        internal bool IsSetAvailabilityZones() => this.AvailabilityZones != null && (this.AvailabilityZones.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
