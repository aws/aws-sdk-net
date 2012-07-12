/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2012-06-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Modifies a volume attribute.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2012-06-15/", IsNullable = false)]
    public class ModifyVolumeAttributeRequest
    {
        private string volumeIdField;
        private bool? autoEnableIOField;

        /// <summary>
        /// The volume against which to make the modify call.
        /// </summary>
        [XmlElementAttribute(ElementName = "VolumeId")]
        public string VolumeId
        {
            get { return this.volumeIdField; }
            set { this.volumeIdField = value; }
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
        /// Sets the VolumeId property.
        /// </summary>
        /// <param name="volumeId">The new volume id</param>
        /// <returns>this instance</returns>
        public ModifyVolumeAttributeRequest WithVolumeId(string volumeId)
        {
            this.volumeIdField = volumeId;
            return this;
        }

        /// <summary>
        /// The value of AutoEnableIO attribute to set.
        /// </summary>
        public bool AutoEnableIO
        {
            get { return this.autoEnableIOField.GetValueOrDefault(); }
            set { this.autoEnableIOField = value; }
        }
        /// <summary>
        /// Checks if AutoEnableIO property is set
        /// </summary>
        /// <returns>true if AutoEnableIO property is set</returns>
        public bool IsSetAutoEnableIO()
        {
            return this.autoEnableIOField.HasValue;
        }
        /// <summary>
        /// Sets the AutoEnableIO property.
        /// </summary>
        /// <param name="autoEnableIO">The new AutoEnableIO value</param>
        /// <returns>this instance</returns>
        public ModifyVolumeAttributeRequest WithAutoEnableIO(bool autoEnableIO)
        {
            this.autoEnableIOField = autoEnableIO;
            return this;
        }
    }
}
