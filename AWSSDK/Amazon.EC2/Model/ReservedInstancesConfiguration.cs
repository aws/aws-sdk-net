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
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The configuration settings for the modified Reserved Instances. </para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class ReservedInstancesConfiguration
    {
        
        private string availabilityZoneField;
        private string platformField;
        private int? instanceCountField;
        private string instanceTypeField;

        /// <summary>
        /// The Availability Zone for the modified Reserved Instances.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

        /// <summary>
        /// The network platform of the modified Reserved Instances, which is either EC2-Classic or EC2-VPC.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "Platform")]
        public string Platform
        {
            get { return this.platformField; }
            set { this.platformField = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this.platformField != null;
        }

        /// <summary>
        /// The number of modified Reserved Instances.
        ///  
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public int InstanceCount
        {
            get { return this.instanceCountField.GetValueOrDefault(); }
            set { this.instanceCountField = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCountField.HasValue;
        }

        /// <summary>
        /// The instance type for the modified Reserved Instances.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceTypeField != null;
        }

    }
}
