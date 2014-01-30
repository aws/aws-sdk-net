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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an Availability Zone.</para>
    /// </summary>
    public class AvailabilityZone
    {
        
        private string zoneName;
        private AvailabilityZoneState state;
        private string regionName;
        private List<AvailabilityZoneMessage> messages = new List<AvailabilityZoneMessage>();


        /// <summary>
        /// The name of the Availability Zone.
        ///  
        /// </summary>
        public string ZoneName
        {
            get { return this.zoneName; }
            set { this.zoneName = value; }
        }

        // Check to see if ZoneName property is set
        internal bool IsSetZoneName()
        {
            return this.zoneName != null;
        }

        /// <summary>
        /// The state of the Availability Zone.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>available</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public AvailabilityZoneState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The name of the region.
        ///  
        /// </summary>
        public string RegionName
        {
            get { return this.regionName; }
            set { this.regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this.regionName != null;
        }

        /// <summary>
        /// Any messages about the Availability Zone.
        ///  
        /// </summary>
        public List<AvailabilityZoneMessage> Messages
        {
            get { return this.messages; }
            set { this.messages = value; }
        }

        // Check to see if Messages property is set
        internal bool IsSetMessages()
        {
            return this.messages.Count > 0;
        }
    }
}
