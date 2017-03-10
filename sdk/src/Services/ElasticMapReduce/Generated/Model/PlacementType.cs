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

/*
 * Do not modify this file. This file is generated from the elasticmapreduce-2009-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticMapReduce.Model
{
    /// <summary>
    /// The Amazon EC2 Availability Zone configuration of the cluster (job flow).
    /// </summary>
    public partial class PlacementType
    {
        private string _availabilityZone;
        private List<string> _availabilityZones = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PlacementType() { }

        /// <summary>
        /// Instantiates PlacementType with the parameterized properties
        /// </summary>
        /// <param name="availabilityZone">The Amazon EC2 Availability Zone for the cluster. <code>AvailabilityZone</code> is used for uniform instance groups, while <code>AvailabilityZones</code> (plural) is used for instance fleets.</param>
        public PlacementType(string availabilityZone)
        {
            _availabilityZone = availabilityZone;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon EC2 Availability Zone for the cluster. <code>AvailabilityZone</code> is
        /// used for uniform instance groups, while <code>AvailabilityZones</code> (plural) is
        /// used for instance fleets.
        /// </para>
        /// </summary>
        public string AvailabilityZone
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
        /// Gets and sets the property AvailabilityZones. 
        /// <para>
        /// When multiple Availability Zones are specified, Amazon EMR evaluates them and launches
        /// instances in the optimal Availability Zone. <code>AvailabilityZones</code> is used
        /// for instance fleets, while <code>AvailabilityZone</code> (singular) is used for uniform
        /// instance groups.
        /// </para>
        ///  <note> 
        /// <para>
        /// The instance fleet configuration is available only in Amazon EMR versions 4.8.0 and
        /// later, excluding 5.0.x versions.
        /// </para>
        ///  </note>
        /// </summary>
        public List<string> AvailabilityZones
        {
            get { return this._availabilityZones; }
            set { this._availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this._availabilityZones != null && this._availabilityZones.Count > 0; 
        }

    }
}