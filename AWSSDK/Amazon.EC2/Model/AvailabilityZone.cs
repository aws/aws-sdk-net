/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    ///<summary>
    ///Availability Zone
    ///</summary>
    [XmlRootAttribute(IsNullable = false)]
    public class AvailabilityZone
    {    
        private string zoneNameField;
        private string zoneStateField;
        private string regionNameField;
        private List<string> messageField;

        /// <summary>
        /// Name of the Availability Zone.
        /// </summary>
        [XmlElementAttribute(ElementName = "ZoneName")]
        public string ZoneName
        {
            get { return this.zoneNameField; }
            set { this.zoneNameField = value; }
        }

        /// <summary>
        /// Sets the name of the Availability Zone.
        /// </summary>
        /// <param name="zoneName">Name of the Availability Zone.</param>
        /// <returns>this instance</returns>
        public AvailabilityZone WithZoneName(string zoneName)
        {
            this.zoneNameField = zoneName;
            return this;
        }

        /// <summary>
        /// Checks if ZoneName property is set
        /// </summary>
        /// <returns>true if ZoneName property is set</returns>
        public bool IsSetZoneName()
        {
            return this.zoneNameField != null;
        }

        /// <summary>
        /// State of the Availability Zone.
        /// </summary>
        [XmlElementAttribute(ElementName = "ZoneState")]
        public string ZoneState
        {
            get { return this.zoneStateField; }
            set { this.zoneStateField = value; }
        }

        /// <summary>
        /// Sets the state of the Availability Zone.
        /// </summary>
        /// <param name="zoneState">State of the Availability Zone.</param>
        /// <returns>this instance</returns>
        public AvailabilityZone WithZoneState(string zoneState)
        {
            this.zoneStateField = zoneState;
            return this;
        }

        /// <summary>
        /// Checks if ZoneState property is set
        /// </summary>
        /// <returns>true if ZoneState property is set</returns>
        public bool IsSetZoneState()
        {
            return this.zoneStateField != null;
        }

        /// <summary>
        /// The Region the Availablity Zone is in
        /// </summary>
        [XmlElementAttribute(ElementName = "RegionName")]
        public string RegionName
        {
            get { return this.regionNameField; }
            set { this.regionNameField = value; }
        }

        /// <summary>
        /// Sets the Region the Availablity Zone is in
        /// </summary>
        /// <param name="regionName">Name of the region.</param>
        /// <returns>this instance</returns>
        public AvailabilityZone WithRegionName(string regionName)
        {
            this.regionNameField = regionName;
            return this;
        }

        /// <summary>
        /// Checks if RegionName property is set
        /// </summary>
        /// <returns>true if RegionName property is set</returns>
        public bool IsSetRegionName()
        {
            return this.regionNameField != null;
        }

        /// <summary>
        /// Information about the Availability Zone.
        /// </summary>
        [XmlElementAttribute(ElementName = "Message")]
        public List<string> Message
        {
            get
            {
                if (this.messageField == null)
                {
                    this.messageField = new List<string>();
                }
                return this.messageField;
            }
            set { this.messageField = value; }
        }

        /// <summary>
        /// Sets information about the Availability Zone.
        /// </summary>
        /// <param name="list">The Availability Zone messages.</param>
        /// <returns>this instance</returns>
        public AvailabilityZone WithMessage(params string[] list)
        {
            foreach (string item in list)
            {
                Message.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Message property is set
        /// </summary>
        /// <returns>true if Message property is set</returns>
        public bool IsSetMessage()
        {
            return (Message.Count > 0);
        }

    }
}
