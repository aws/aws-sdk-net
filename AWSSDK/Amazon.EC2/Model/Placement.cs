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
    /// <summary>
    /// Placement constraints.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Placement
    {    
        private string availabilityZoneField;
        private string groupNameField;
        private string tenancyField;

        /// <summary>
        /// The Availability Zone of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the Availability Zone of the instance.
        /// </summary>
        /// <param name="availabilityZone">Availability Zones for launching the instances.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Placement WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// The name of the placement group the instance is in.
        /// </summary>
        [XmlElementAttribute(ElementName = "GroupName")]
        public string GroupName
        {
            get { return this.groupNameField; }
            set { this.groupNameField = value; }
        }

        /// <summary>
        /// Sets the name of the placement group the instance is in.
        /// </summary>
        /// <param name="groupName">The name of a PlacementGroup.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Placement WithGroupName(string groupName)
        {
            this.groupNameField = groupName;
            return this;
        }

        /// <summary>
        /// Checks if GroupName property is set
        /// </summary>
        /// <returns>true if GroupName property is set</returns>
        public bool IsSetGroupName()
        {
            return this.groupNameField != null;
        }

        /// <summary>
        /// The tenancy of the instance.
        /// 
        /// Valid Values: default | dedicated
        /// </summary>
        [XmlElementAttribute(ElementName = "Tenancy")]
        public string Tenancy
        {
            get { return this.tenancyField; }
            set { this.tenancyField = value; }
        }

        /// <summary>
        /// Checks if Tenancy property is set
        /// </summary>
        /// <returns>true if Tenancy property is set</returns>
        public bool IsSetTenancy()
        {
            return this.tenancyField != null;
        }

        /// <summary>
        /// Sets the tenancy of the instance.
        /// 
        /// Valid Values: default | dedicated
        /// </summary>
        /// <param name="tenancy">The tenancy of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Placement WithTenancy(string tenancy)
        {
            this.tenancyField = tenancy;
            return this;
        }
    }
}
