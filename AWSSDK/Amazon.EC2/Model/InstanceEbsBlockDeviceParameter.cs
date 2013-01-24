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
    /// Instance EBS block device parameter.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class InstanceEbsBlockDeviceParameter
    {    
        private string volumeIdField;
        private bool? deleteOnTerminationField;

        /// <summary>
        /// The ID of the Amazon EBS volume.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Amazon EBS volume.
        /// </summary>
        /// <param name="volumeId">The ID of the Amazon EBS volume.</param>
        /// <returns>this instance</returns>
        public InstanceEbsBlockDeviceParameter WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }

        /// <summary>
        /// Checks if VolumeId property is set
        /// </summary>
        /// <returns>true if VolumeId property is set</returns>
        public bool IsSetVolumeId()
        {
            return this.volumeIdField != null;
        }

        /// <summary>
        /// Whether the Amazon EBS volume is deleted on instance termination.
        /// </summary>
        [XmlElementAttribute(ElementName = "DeleteOnTermination")]
        public bool DeleteOnTermination
        {
            get { return this.deleteOnTerminationField.GetValueOrDefault(); }
            set { this.deleteOnTerminationField = value; }
        }

        /// <summary>
        /// Sets whether the Amazon EBS volume is deleted on instance termination.
        /// </summary>
        /// <param name="deleteOnTermination">Specifies whether the Amazon EBS volume is
        /// deleted on instance termination.</param>
        /// <returns>this instance</returns>
        public InstanceEbsBlockDeviceParameter WithDeleteOnTermination(bool deleteOnTermination)
        {
            this.deleteOnTerminationField = deleteOnTermination;
            return this;
        }

        /// <summary>
        /// Checks if DeleteOnTermination property is set
        /// </summary>
        /// <returns>true if DeleteOnTermination property is set</returns>
        public bool IsSetDeleteOnTermination()
        {
            return this.deleteOnTerminationField.HasValue;
        }

    }
}
